using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // Spell.dbc
    [StructLayout(LayoutKind.Sequential)]
    public partial class SpellEntry
    {
        public uint   m_ID;                     // 0
        public string m_Name;                   // 1
        public string m_NameSubtext;            // 2
        public string m_Description;            // 3
        public string m_AuraDescription;        // 4
        public uint   m_RuneCostID;             // 5
        public uint   m_SpellMissileID;         // 6
        public uint   m_DescriptionVariablesID; // 7
        public uint   m_ScalingID;              // 8
        public uint   m_AuraOptionsID;          // 9
        public uint   m_AuraRestrictionsID;     // 10
        public uint   m_CastingRequirementsID;  // 11
        public uint   m_CategoriesID;           // 12
        public uint   m_ClassOptionsID;         // 13
        public uint   m_CooldownsID;            // 14
        public uint   m_EquippedItemsID;        // 15
        public uint   m_InterruptsID;           // 16
        public uint   m_LevelsID;               // 17
        public uint   m_ReagentsID;             // 18
        public uint   m_ShapeshiftID;           // 19
        public uint   m_TargetRestrictionsID;   // 20
        public uint   m_TotemsID;               // 21
        public uint   m_RequiredProjectID;      // 22
        public uint   m_MiscID;                 // 23
    };
}
