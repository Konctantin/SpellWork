using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellAuraRestrictions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellAuraRestrictionsEntry
    {
        public uint Id;
        public uint CasterAuraState;
        public uint TargetAuraState;
        public uint CasterAuraStateNot;
        public uint TargetAuraStateNot;
        public uint CasterAuraSpell;
        public uint TargetAuraSpell;
        public uint ExcludeCasterAuraSpell;
        public uint ExcludeTargetAuraSpell;
    };
}