using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellTargetRestrictions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellTargetRestrictionsEntry
    {
        public uint ID;
        public uint SpellID;
        public uint DifficultyID;
        public float ConeAngle;
        public float Width;
        public uint MaxAffectedTargets;
        public uint MaxTargetLevel;
        public uint TargetCreatureType;
        public uint Targets;
    };
}