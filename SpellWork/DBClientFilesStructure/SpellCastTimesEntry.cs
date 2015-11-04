using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCastTimesEntry
    {
        public uint  ID;
        public int   CastTime;
        public float CastTimePerLevel;
        public int   MinCastTime;
    };
}
