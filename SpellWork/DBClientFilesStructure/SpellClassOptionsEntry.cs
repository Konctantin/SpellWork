using System.Runtime.InteropServices;
using SpellWork.Enums;

namespace SpellWork.DBClientFilesStructure
{
    // SpellClassOptions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellClassOptionsEntry
    {
        public uint Id;
        public uint m_ModalNextSpell;
        public uint SpellFamilyFlags0 { get; private set; }
        public uint SpellFamilyFlags1 { get; private set; }
        public uint SpellFamilyFlags2 { get; private set; }
        public uint SpellFamilyFlags3 { get; private set; }
        public SpellFamilyNames SpellFamilyName { get; private set; }

        public SpellEntry ModalNextSpell => DBC.Spell.GetValueOrDefault(m_ModalNextSpell);
    };
}
