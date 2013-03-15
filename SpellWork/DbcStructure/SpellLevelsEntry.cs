using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellLevels.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellLevelsEntry
    {
        public uint Id;
        public uint BaseLevel;
        public uint MaxLevel;
        public uint SpellLevel;
    };
}
