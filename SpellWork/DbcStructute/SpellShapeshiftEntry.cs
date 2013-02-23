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
        public uint Id;                                               // 0        m_ID
        public uint StancesNot;                                       // 13       m_shapeshiftExclude
        public uint unk1;                                             // 3
        public uint Stances;                                          // 15       m_shapeshiftMask
        public uint unk2;                                             // 5
        public uint StanceBarOrder;                                   // 155      m_stanceBarOrder not used
    };

}
