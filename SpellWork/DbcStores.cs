using System.Collections.Generic;
using DBFilesClient.NET;
using SpellWork.Dbc;

namespace SpellWork
{
    public static class DBC
    {
        public const string VERSION = "SpellWork 6.2.2 (20574)";
        public const string DBC_PATH = "dbc";

        //public static DBCStorage<CurrencyTypesEntry>            CurrencyTypes            { get; set; } = new DBCStorage<CurrencyTypesEntry>();
        public static DBCStorage<SpellEntry>                    Spell                    { get; set; } = new DBCStorage<SpellEntry>();
        public static DBCStorage<SpellEffectEntry>              SpellEffect              { get; set; } = new DBCStorage<SpellEffectEntry>();
        public static DBCStorage<SpellTargetRestrictionsEntry>  SpellTargetRestrictions  { get; set; } = new DBCStorage<SpellTargetRestrictionsEntry>();
        public static DB2Storage<SpellAuraRestrictionsEntry>    SpellAuraRestrictions    { get; set; } = new DB2Storage<SpellAuraRestrictionsEntry>();
        public static DBCStorage<SpellCooldownsEntry>           SpellCooldowns           { get; set; } = new DBCStorage<SpellCooldownsEntry>();
        public static DBCStorage<SpellCategoriesEntry>          SpellCategories          { get; set; } = new DBCStorage<SpellCategoriesEntry>();
        public static DBCStorage<SpellShapeshiftEntry>          SpellShapeshift          { get; set; } = new DBCStorage<SpellShapeshiftEntry>();
        public static DBCStorage<SpellAuraOptionsEntry>         SpellAuraOptions         { get; set; } = new DBCStorage<SpellAuraOptionsEntry>();
        public static DBCStorage<SpellLevelsEntry>              SpellLevels              { get; set; } = new DBCStorage<SpellLevelsEntry>();
        public static DB2Storage<SpellClassOptionsEntry>        SpellClassOptions        { get; set; } = new DB2Storage<SpellClassOptionsEntry>();
        public static DB2Storage<SpellCastingRequirementsEntry> SpellCastingRequirements { get; set; } = new DB2Storage<SpellCastingRequirementsEntry>();
        public static DB2Storage<SpellPowerEntry>               SpellPower               { get; set; } = new DB2Storage<SpellPowerEntry>();
        public static DBCStorage<SpellInterruptsEntry>          SpellInterrupts          { get; set; } = new DBCStorage<SpellInterruptsEntry>();
        //public static DBCStorage<SpellEquippedItemsEntry>       SpellEquippedItems       { get; set; } = new DBCStorage<SpellEquippedItemsEntry>();
        //public static DBCStorage<SpellRadiusEntry>              SpellRadius              { get; set; } = new DBCStorage<SpellRadiusEntry>();
        //public static DBCStorage<SpellCastTimesEntry>           SpellCastTimes           { get; set; } = new DBCStorage<SpellCastTimesEntry>();
        //public static DBCStorage<SpellDifficultyEntry>          SpellDifficulty          { get; set; } = new DBCStorage<SpellDifficultyEntry>();
        //public static DBCStorage<SpellRangeEntry>               SpellRange               { get; set; } = new DBCStorage<SpellRangeEntry>();
        public static DB2Storage<SpellReagentsEntry>            SpellReagents            { get; set; } = new DB2Storage<SpellReagentsEntry>();
        //public static DBCStorage<SpellDurationEntry>            SpellDuration            { get; set; } = new DBCStorage<SpellDurationEntry>();
        public static DBCStorage<SkillLineAbilityEntry>         SkillLineAbility         { get; set; } = new DBCStorage<SkillLineAbilityEntry>();
        public static DBCStorage<SkillLineEntry>                SkillLine                { get; set; } = new DBCStorage<SkillLineEntry>();
        //public static DBCStorage<ScreenEffectEntry>             ScreenEffect             { get; set; } = new DBCStorage<ScreenEffectEntry>();
        //public static DBCStorage<OverrideSpellDataEntry>        OverrideSpellData        { get; set; } = new DBCStorage<OverrideSpellDataEntry>();
        //public static DBCStorage<ItemClassEntry>                ItemClass                { get; set; } = new DBCStorage<ItemClassEntry>();
        public static DBCStorage<SpellShapeshiftFormEntry>      SpellShapeshiftForm      { get; set; } = new DBCStorage<SpellShapeshiftFormEntry>();
        //public static DBCStorage<SpellDispelTypeEntry>          SpellDispelType          { get; set; } = new DBCStorage<SpellDispelTypeEntry>();
    }
}
