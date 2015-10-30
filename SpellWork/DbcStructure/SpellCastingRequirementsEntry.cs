using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellCastingRequirements.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCastingRequirementsEntry
    {
        public uint Id;
        public uint FacingCasterFlags;
        public uint MinFactionId;
        public uint MinReputation;
        public uint AreaGroupId;
        public uint RequiredAuraVision;
        public uint RequiresSpellFocus;
    };

}
