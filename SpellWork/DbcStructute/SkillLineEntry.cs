using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SkillLineEntry
    {
        public uint ID;                                           // 0        m_ID
        public int CategoryId;                                    // 1        m_categoryID
        //public uint SkillCostID;                                  // 2        m_skillCostsID
        public string _Name;                                      // 3-18     m_displayName_lang
        public string _Description;                               // 20-35    m_description_lang
        public uint SpellIcon;                                    // 37       m_spellIconID
        public string _AlternateVerb;                             // 38-53    m_alternateVerb_lang
        public uint CanLink;                                      // 55       m_canLink (prof. with recipes

        public string Name
        {
            get { return _Name; }
        }

        public string Description
        {
            get { return _Description; }
        }

        public string AlternateVerb
        {
            get { return _AlternateVerb; }
        }
    };

}
