using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    // SpellCategories.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCategoriesEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint Category;                                     // 1        m_category
        public uint DmgClass;                                     // 153      m_defenseType
        public uint Dispel;                                       // 2        m_dispelType
        public uint Mechanic;                                     // 3        m_mechanic
        public uint PreventionType;                               // 154      m_preventionType
        public uint StartRecoveryCategory;                        // 145      m_startRecoveryCategory
    };

}
