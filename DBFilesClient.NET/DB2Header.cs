using System.Runtime.InteropServices;

namespace DBFilesClient.NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DB2Header
    {
        public static readonly int Size = Marshal.SizeOf(typeof(DB2Header));

        public uint FourCC;
        public int Records;
        public int RecordFields;
        public int RecordSize;
        public int StringPoolSize;
        public uint Hash;
        public uint Build;
        public uint Unk;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DB2ExtendedHeader
    {
        public static readonly int Size = Marshal.SizeOf(typeof(DB2ExtendedHeader));

        public uint MinId;
        public uint MaxId;
        public uint Locale;
        public uint Unk;
    }
}
