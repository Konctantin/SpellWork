using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellPower.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellPowerEntry
    {
        public uint ID;
        public uint SpellID;
        public uint PowerIndex;
        public uint PowerType;
        public uint ManaCost;
        public uint ManaCostPerLevel;
        public uint ManaCostPerSecond;
        public uint ManaCostAdditional;
        public uint PowerDisplayID;
        public uint UnitPowerBarID;
        public float ManaCostPercentage;
        public float ManaCostPercentagePerSecond;
        public uint RequiredAura;
        public float HealthCostPercentage;
    };
}