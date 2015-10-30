using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellCastingRequirements.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCastingRequirementsEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint FacingCasterFlags;                            // 20       m_facingCasterFlags
        public uint MinFactionId;                                 // 159      m_minFactionID not used
        public uint MinReputation;                                // 160      m_minReputation not used
        public int AreaGroupId;                                   // 164      m_requiredAreaGroupId
        public uint RequiredAuraVision;                           // 161      m_requiredAuraVision not used
        public uint RequiresSpellFocus;                           // 19       m_requiresSpellFocus
    };

}
