using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBFilesClient.NET;
using SpellWork.Dbc;
using SpellWork.Enums;

namespace SpellWork
{
    public static class DBC
    {
        public const string VERSION = "SpellWork 4.3.4 (15595)";
        public const string DBC_PATH = "dbc";

        public const int MAX_DBC_LOCALE = 16;
        public const int MAX_EFFECT_INDEX = 3;
        public const int SPELL_ENTRY_FOR_DETECT_LOCALE = 1;

        public static DBCStorage<CurrencyTypesEntry> CurrencyTypes { get; set; }
        public static DBCStorage<SpellEntry> Spell { get; set; }
        public static DBCStorage<SpellEffectEntry> SpellEffect { get; set; }
        public static DBCStorage<SpellTargetRestrictionsEntry> SpellTargetRestrictions { get; set; }
        public static DBCStorage<SpellAuraRestrictionsEntry> SpellAuraRestrictions { get; set; }
        public static DBCStorage<SpellCooldownsEntry> SpellCooldowns { get; set; }
        public static DBCStorage<SpellCategoriesEntry> SpellCategories { get; set; }
        public static DBCStorage<SpellShapeshiftEntry> SpellShapeshift { get; set; }
        public static DBCStorage<SpellAuraOptionsEntry> SpellAuraOptions { get; set; }
        public static DBCStorage<SpellLevelsEntry> SpellLevels { get; set; }
        public static DBCStorage<SpellClassOptionsEntry> SpellClassOptions { get; set; }
        public static DBCStorage<SpellCastingRequirementsEntry> SpellCastingRequirements { get; set; }
        public static DBCStorage<SpellPowerEntry> SpellPower { get; set; }
        public static DBCStorage<SpellInterruptsEntry> SpellInterrupts { get; set; }
        public static DBCStorage<SpellEquippedItemsEntry> SpellEquippedItems { get; set; }
        public static DBCStorage<SpellRadiusEntry> SpellRadius { get; set; }
        public static DBCStorage<SpellCastTimesEntry> SpellCastTimes { get; set; }
        public static DBCStorage<SpellDifficultyEntry> SpellDifficulty { get; set; }
        public static DBCStorage<SpellRangeEntry> SpellRange { get; set; }
        public static DBCStorage<SpellReagentsEntry> SpellReagents { get; set; }
        public static DBCStorage<SpellDurationEntry> SpellDuration { get; set; }
        public static DBCStorage<SkillLineAbilityEntry> SkillLineAbility { get; set; }
        public static DBCStorage<SkillLineEntry> SkillLine { get; set; }
        public static DBCStorage<ScreenEffectEntry> ScreenEffect { get; set; }
        public static DBCStorage<OverrideSpellDataEntry> OverrideSpellData { get; set; }

        public static Dictionary<uint, Dictionary<uint, SpellEffectEntry>> SpellEffects { get; set; }

        static DBC()
        {
            CurrencyTypes               = new DBCStorage<CurrencyTypesEntry>();
            Spell                       = new DBCStorage<SpellEntry>();
            SpellEffect                 = new DBCStorage<SpellEffectEntry>();
            SpellTargetRestrictions     = new DBCStorage<SpellTargetRestrictionsEntry>();
            SpellAuraRestrictions       = new DBCStorage<SpellAuraRestrictionsEntry>();
            SpellCooldowns              = new DBCStorage<SpellCooldownsEntry>();
            SpellCategories             = new DBCStorage<SpellCategoriesEntry>();
            SpellShapeshift             = new DBCStorage<SpellShapeshiftEntry>();
            SpellAuraOptions            = new DBCStorage<SpellAuraOptionsEntry>();
            SpellLevels                 = new DBCStorage<SpellLevelsEntry>();
            SpellClassOptions           = new DBCStorage<SpellClassOptionsEntry>();
            SpellCastingRequirements    = new DBCStorage<SpellCastingRequirementsEntry>();
            SpellPower                  = new DBCStorage<SpellPowerEntry>();
            SpellInterrupts             = new DBCStorage<SpellInterruptsEntry>();
            SpellEquippedItems          = new DBCStorage<SpellEquippedItemsEntry>();
            SpellRadius                 = new DBCStorage<SpellRadiusEntry>();
            SpellCastTimes              = new DBCStorage<SpellCastTimesEntry>();
            SpellDifficulty             = new DBCStorage<SpellDifficultyEntry>();
            SpellRange                  = new DBCStorage<SpellRangeEntry>();
            SpellReagents               = new DBCStorage<SpellReagentsEntry>();
            SpellDuration               = new DBCStorage<SpellDurationEntry>();
            SkillLineAbility            = new DBCStorage<SkillLineAbilityEntry>();
            SkillLine                   = new DBCStorage<SkillLineEntry>();
            ScreenEffect                = new DBCStorage<ScreenEffectEntry>();
            OverrideSpellData           = new DBCStorage<OverrideSpellDataEntry>();

            SpellEffects                = new Dictionary<uint, Dictionary<uint, SpellEffectEntry>>();
        }

        // DB 
       // public static List<Item> ItemTemplate = new List<Item>();

        // Locale
        public static LocalesDBC Locale { get; set; }
    }
}
