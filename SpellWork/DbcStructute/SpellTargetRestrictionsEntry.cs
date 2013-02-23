using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    // SpellTargetRestrictions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellTargetRestrictionsEntry
    {
        public uint Id;                                           // 0        m_ID
        public float MaxTargetRadius;
        public uint MaxAffectedTargets;                           // 152      m_maxTargets
        public uint MaxTargetLevel;                               // 147      m_maxTargetLevel
        public uint TargetCreatureType;                           // 18       m_targetCreatureType
        public uint Targets;                                      // 17       m_targets
    };

}
