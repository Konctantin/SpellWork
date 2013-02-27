using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using SpellWork.Enums;

namespace SpellWork.Dbc
{
    // SpellCategories.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCategoriesEntry
    {
        public uint Id;                     // 0        m_ID
        public uint Category;               // 1        m_category
        public uint DmgClass;               // 153      m_defenseType
        public uint Dispel;                 // 2        m_dispelType
        public uint Mechanic;               // 3        m_mechanic
        public uint PreventionType;         // 154      m_preventionType
        public uint StartRecoveryCategory;  // 145      m_startRecoveryCategory

        public override string ToString()
        {
            return string.Format("Id: {0}, DamsgeClass: {1}, Dispel: {2}, Mechanic: {3}, PreventionType: {4}, StartRecoveryCategory: {5}",
                Category, DmgClass,
                DBC.SpellDispelType.GetValueOrDefault(Dispel), 
                (Mechanics)Mechanic, (SpellPreventionType)PreventionType, StartRecoveryCategory);
        }
    };
}
