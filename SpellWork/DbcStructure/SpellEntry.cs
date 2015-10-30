using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // Spell.dbc
    [StructLayout(LayoutKind.Sequential)]
    public partial class SpellEntry
    {
        public uint   ID;                     // 0
        public string Name_lang;              // 1
        public string NameSubtext_lang;       // 2
        public string Description_lang;       // 3
        public string AuraDescription_lang;   // 4
        public uint   RuneCostID;             // 5
        public uint   SpellMissileID;         // 6
        public uint   DescriptionVariablesID; // 7
        public uint   ScalingID;              // 8
        public uint   AuraOptionsID;          // 9
        public uint   AuraRestrictionsID;     // 10
        public uint   CastingRequirementsID;  // 11
        public uint   CategoriesID;           // 12
        public uint   ClassOptionsID;         // 13
        public uint   CooldownsID;            // 14
        public uint   EquippedItemsID;        // 15
        public uint   InterruptsID;           // 16
        public uint   LevelsID;               // 17
        public uint   ReagentsID;             // 18
        public uint   ShapeshiftID;           // 19
        public uint   TargetRestrictionsID;   // 20
        public uint   TotemsID;               // 21
        public uint   RequiredProjectID;      // 22
        public uint   MiscID;                 // 23
    };
}
