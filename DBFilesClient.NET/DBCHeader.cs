using System.Runtime.InteropServices;

namespace DBFilesClient.NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct DBCHeader
    {
        public static readonly int Size = Marshal.SizeOf(typeof(DBCHeader));

        public uint FourCC;
        public int Records;
        public int RecordFields;
        public int RecordSize;
        public int StringPoolSize;
    }
}
