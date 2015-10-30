using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellAuraRestrictions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellAuraRestrictionsEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint CasterAuraState;                              // 21       m_casterAuraState
        public uint TargetAuraState;                              // 22       m_targetAuraState
        public uint CasterAuraStateNot;                           // 23       m_excludeCasterAuraState
        public uint TargetAuraStateNot;                           // 24       m_excludeTargetAuraState
        public uint CasterAuraSpell;                              // 25       m_casterAuraSpell
        public uint TargetAuraSpell;                              // 26       m_targetAuraSpell
        public uint ExcludeCasterAuraSpell;                       // 27       m_excludeCasterAuraSpell
        public uint ExcludeTargetAuraSpell;                       // 28       m_excludeTargetAuraSpell
    };
}