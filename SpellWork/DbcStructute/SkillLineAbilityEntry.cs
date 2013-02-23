using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SkillLineAbilityEntry
    {
        public uint ID;                                             // 0        m_ID
        public uint SkillId;                                        // 1        m_skillLine
        public uint SpellId;                                        // 2        m_spell
        public uint Racemask;                                       // 3        m_raceMask
        public uint Classmask;                                      // 4        m_classMask
        public uint RacemaskNot;                                    // 5        m_excludeRace
        public uint ClassmaskNot;                                   // 6        m_excludeClass
        public uint Req_skill_value;                                // 7        m_minSkillLineRank
        public uint Forward_spellid;                                // 8        m_supercededBySpell
        public uint LearnOnGetSkill;                                // 9        m_acquireMethod
        public uint Max_value;                                      // 10       m_trivialSkillLineRankHigh
        public uint Min_value;                                      // 11       m_trivialSkillLineRankLow
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] CharacterPoints;                              // 12-13    m_characterPoints[2]
    };

}
