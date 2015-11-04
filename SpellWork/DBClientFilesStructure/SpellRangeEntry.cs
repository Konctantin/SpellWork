using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellRangeEntry
    {
        public uint ID;
        public float MinRangeHostile;
        public float MinRangeFriend;
        public float MaxRangeHostile;
        public float MaxRangeFriend;
        public uint Flags;
        public string DisplayName;
        public string DisplayNameShort;
    };
}