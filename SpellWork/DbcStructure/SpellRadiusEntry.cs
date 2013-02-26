using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

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
