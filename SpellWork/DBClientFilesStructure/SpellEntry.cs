using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    // Spell.dbc
    [StructLayout(LayoutKind.Sequential)]
    public partial class SpellEntry
    {
        public uint   ID              { get; private set; }
        public string Name            { get; private set; }
        public string NameSubtext     { get; private set; }
        public string Description     { get; private set; }
        public string AuraDescription { get; private set; }
        public uint   m_RuneCostID;
        public uint   m_SpellMissileID;
        public uint   m_DescriptionVariablesID;
        public uint   m_ScalingID;
        public uint   m_AuraOptionsID;
        public uint   m_AuraRestrictionsID;
        public uint   m_CastingRequirementsID;
        public uint   m_CategoriesID;
        public uint   m_ClassOptionsID;
        public uint   m_CooldownsID;
        public uint   m_EquippedItemsID;
        public uint   m_InterruptsID;
        public uint   m_LevelsID;
        public uint   m_ReagentsID;
        public uint   m_ShapeshiftID;
        public uint   m_TargetRestrictionsID;
        public uint   m_TotemsID;
        public uint   m_RequiredProjectID;
        public uint   m_MiscID;
    };
}
