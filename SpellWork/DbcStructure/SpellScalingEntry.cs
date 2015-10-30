using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellScaling.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellScalingEntry
    {
        public uint ID;
        public int CastTimeMin;
        public int CastTimeMax;
        public uint CastTimeMaxLevel;
        public int ScalingClass;
        public float NerfFactor;
        public uint NerfMaxLevel;
        public uint MaxScalingLevel;
        public uint ScalesFromItemLevel;
    };
}