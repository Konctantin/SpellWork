using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellRadiusEntry
    {
        public uint ID;
        public float Radius;
        public int Zero;
        public float Radius2;
    };

}
