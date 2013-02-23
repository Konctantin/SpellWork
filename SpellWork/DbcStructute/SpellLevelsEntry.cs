using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    // SpellLevels.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellLevelsEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint BaseLevel;                                    // 41       m_baseLevel
        public uint MaxLevel;                                     // 40       m_maxLevel
        public uint SpellLevel;                                   // 42       m_spellLevel
    };

}
