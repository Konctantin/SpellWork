using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    // SpellCooldowns.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCooldownsEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint CategoryRecoveryTime;                         // 31       m_categoryRecoveryTime
        public uint RecoveryTime;                                 // 30       m_recoveryTime
        public uint StartRecoveryTime;                            // 146      m_startRecoveryTime
    };

}
