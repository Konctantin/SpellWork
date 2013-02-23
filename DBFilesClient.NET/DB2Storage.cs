using System;
using System.IO;

namespace DBFilesClient.NET
{
    public sealed class DB2Storage<T> : DBCStorage<T> where T : class, new()
    {
        public uint Hash { get; set; }
        public uint Build { get; set; }
        public uint Locale { get; set; }

        public override unsafe void Load(Stream stream, LoadFlags flags)
        {
            GenerateLoadMethod();

            byte[] headerBytes;
            byte[] data;
            byte[] pool;

            fixed (byte* headerPtr = headerBytes = new byte[DB2Header.Size])
            {
                if (stream.Read(headerBytes, 0, DB2Header.Size) != DB2Header.Size)
                    throw new IOException("Failed to read the DB2 header.");

                var header = (DB2Header*)headerPtr;
                if (!flags.HasFlag(LoadFlags.IgnoreWrongFourCC) && header->FourCC != 0x32424457)
                    throw new ArgumentException("This is not a valid DB2 file.");

                if (header->RecordSize != m_entrySize)
                    throw new ArgumentException("This DB2 file has wrong record size ("
                        + header->RecordSize + ", expected is " + m_entrySize + ").");

                m_records = header->Records;
                this.Hash = header->Hash;
                this.Build = header->Build;

                if (header->Build > 12880)
                {
                    fixed (byte* extHeaderPtr = headerBytes = new byte[DB2ExtendedHeader.Size])
                    {
                        if (stream.Read(headerBytes, 0, DB2ExtendedHeader.Size) != DB2ExtendedHeader.Size)
                            throw new IOException("Failed to read the extended DB2 header.");

                        var extHeader = (DB2ExtendedHeader*)extHeaderPtr;
                        this.Locale = extHeader->Locale;

                        if (extHeader->MaxId != 0)
                        {
                            int diff;
                            checked
                            {
                                diff = (int)(extHeader->MaxId - extHeader->MinId + 1) * 6;
                            }

                            if (stream.CanSeek)
                            {
                                stream.Seek(diff, SeekOrigin.Current);
                            }
                            else
                            {
                                var dummy = new byte[4096];
                                while (diff > 0)
                                    diff -= stream.Read(dummy, 0, Math.Min(diff, 4096));
                            }
                        }
                    }
                }

                int index, size;

                index = 0;
                size = header->Records * header->RecordSize;
                data = new byte[size];
                while (index < size)
                    index += stream.Read(data, index, size - index);

                index = 0;
                size = header->StringPoolSize;
                pool = new byte[size];
                while (index < size)
                    index += stream.Read(pool, index, size - index);
            }

            fixed (byte* pdata_ = data)
            {
                byte* pdata = pdata_;

                if (m_records > 0)
                    this.Resize(*(uint*)pdata, *(uint*)(pdata + m_entrySize * (m_records - 1)));

                fixed (byte* ppool = m_haveString ? pool : null)
                {
                    sbyte* spool = (sbyte*)ppool;
                    int poolLen = pool.Length;
                    StringGetter strGetter = offset => LazyCString.LoadString(spool, poolLen, offset);

                    bool ignoreLazyCStrings = !flags.HasFlag(LoadFlags.LazyCStrings);

                    for (int i = 0; i < m_records; i++)
                    {
                        var entry = (T)m_ctor.Invoke(null);

                        m_loadMethod(pdata, pool, strGetter, entry, ignoreLazyCStrings);

                        uint id = *(uint*)pdata;
                        m_entries[id - m_minId] = entry;

                        pdata += m_entrySize;
                    }
                }
            }
        }
    }
}
