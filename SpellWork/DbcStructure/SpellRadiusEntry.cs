using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellRadiusEntry
    {
        public uint ID;
        public float Radius;
        public float RadiusPerLevel;
        public float RadiusMin;
        public float RadiusMax;
    };
}