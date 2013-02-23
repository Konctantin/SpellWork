using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    // SpellPower.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellPowerEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint ManaCost;                                     // 45       m_manaCost
        public uint ManaCostPerlevel;                             // 46       m_manaCostPerLevel
        public uint ManaCostPercentage;                           // 144      m_manaCostPct
        public uint ManaPerSecond;                                // 47       m_manaPerSecond
        public uint PowerDisplayId;                                 // 168      PowerDisplay.dbc, new in 3.1
        public uint Unk1;                                           // 6        4.0.0
        public uint Unk2;
    };

}
