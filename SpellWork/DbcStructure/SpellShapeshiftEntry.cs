using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    // SpellShapeshift.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellShapeshiftEntry
    {
        public uint Id;
        public uint StancesNot;
        public uint unk1;
        public uint Stances;
        public uint unk2;
        public uint StanceBarOrder;
    };

}
