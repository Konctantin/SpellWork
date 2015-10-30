using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellAuraOptions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellAuraOptionsEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint StackAmount;                                  // 51       m_cumulativeAura
        public uint ProcChance;                                   // 38       m_procChance
        public uint ProcCharges;                                  // 39       m_procCharges
        public uint ProcFlags;                                    // 37       m_procTypeMask
    };

}
