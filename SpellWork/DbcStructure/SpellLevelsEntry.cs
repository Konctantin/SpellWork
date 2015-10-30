using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellLevels.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellLevelsEntry
    {
        public uint ID;
        public uint SpellID;
        public uint DifficultyID;
        public uint BaseLevel;
        public uint MaxLevel;
        public uint SpellLevel;
    };
}