using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class ItemClassEntry
    {
        public uint Id;
        public uint unk1;
        public uint unk2;
        public uint unk3;
        public uint unk4;
        public string _Name;

        public string Name { get { return _Name; } }
    }
}

