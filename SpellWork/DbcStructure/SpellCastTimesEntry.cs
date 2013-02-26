using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCastTimesEntry
    {
        public uint ID;
        public int CastTime;
        public float CastTimePerLevel;
        public int MinCastTime;
    };
}
