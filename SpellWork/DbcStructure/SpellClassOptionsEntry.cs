using System.Runtime.InteropServices;
using SpellWork.Enums;

namespace SpellWork.Dbc
{
    // SpellClassOptions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellClassOptionsEntry
    {
        public uint Id;
        public uint ModalNextSpell;
        public uint SpellFamilyFlags0;
        public uint SpellFamilyFlags1;
        public uint SpellFamilyFlags2;
        public uint SpellFamilyFlags3;
        public SpellFamilyNames SpellFamilyName;
    };
}
