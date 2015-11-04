using System.Collections.Generic;
using DBFilesClient.NET;
using SpellWork.DBClientFilesStructure;
using System.IO;
using System;

namespace SpellWork
{
    public static class DBC
    {
        public const string VERSION = "SpellWork 6.2.2 (20574)";
        public const string DBC_PATH = "dbc";

        //public static DBCStorage<CurrencyTypesEntry>            CurrencyTypes          { get; private set; } = LoadDBC<CurrencyTypesEntry>();
        public static DBCStorage<SpellEntry> Spell                                       { get; private set; } = LoadDBC<SpellEntry>();
        public static DB2Storage<SpellMiscEntry> SpellMisc                               { get; private set; } = LoadDB2<SpellMiscEntry>();
        public static DBCStorage<SpellEffectEntry> SpellEffect                           { get; private set; } = LoadDBC<SpellEffectEntry>();
        public static DBCStorage<SpellTargetRestrictionsEntry> SpellTargetRestrictions   { get; private set; } = LoadDBC<SpellTargetRestrictionsEntry>();
        public static DB2Storage<SpellAuraRestrictionsEntry> SpellAuraRestrictions       { get; private set; } = LoadDB2<SpellAuraRestrictionsEntry>();
        public static DBCStorage<SpellCooldownsEntry> SpellCooldowns                     { get; private set; } = LoadDBC<SpellCooldownsEntry>();
        public static DBCStorage<SpellCategoriesEntry> SpellCategories                   { get; private set; } = LoadDBC<SpellCategoriesEntry>();
        public static DBCStorage<SpellShapeshiftEntry> SpellShapeshift                   { get; private set; } = LoadDBC<SpellShapeshiftEntry>();
        public static DBCStorage<SpellAuraOptionsEntry> SpellAuraOptions                 { get; private set; } = LoadDBC<SpellAuraOptionsEntry>();
        public static DBCStorage<SpellLevelsEntry> SpellLevels                           { get; private set; } = LoadDBC<SpellLevelsEntry>();
        public static DB2Storage<SpellClassOptionsEntry> SpellClassOptions               { get; private set; } = LoadDB2<SpellClassOptionsEntry>();
        public static DB2Storage<SpellCastingRequirementsEntry> SpellCastingRequirements { get; private set; } = LoadDB2<SpellCastingRequirementsEntry>();
        public static DB2Storage<SpellPowerEntry> SpellPower                             { get; private set; } = LoadDB2<SpellPowerEntry>();
        public static DBCStorage<SpellInterruptsEntry> SpellInterrupts                   { get; private set; } = LoadDBC<SpellInterruptsEntry>();
        //public static DBCStorage<SpellEquippedItemsEntry>       SpellEquippedItems     { get; private set; } = LoadDBC<SpellEquippedItemsEntry>();
        public static DB2Storage<SpellRadiusEntry> SpellRadius                           { get; private set; } = LoadDB2<SpellRadiusEntry>();
        public static DB2Storage<SpellCastTimesEntry> SpellCastTimes                     { get; private set; } = LoadDB2<SpellCastTimesEntry>();
        public static DB2Storage<SpellMiscDifficultyEntry> SpellDifficulty               { get; private set; } = LoadDB2<SpellMiscDifficultyEntry>();
        public static DB2Storage<SpellRangeEntry> SpellRange                             { get; private set; } = LoadDB2<SpellRangeEntry>();
        public static DB2Storage<SpellReagentsEntry> SpellReagents                       { get; private set; } = LoadDB2<SpellReagentsEntry>();
        public static DB2Storage<SpellDurationEntry> SpellDuration                       { get; private set; } = LoadDB2<SpellDurationEntry>();
        public static DBCStorage<SkillLineAbilityEntry> SkillLineAbility                 { get; private set; } = LoadDBC<SkillLineAbilityEntry>();
        public static DBCStorage<SkillLineEntry> SkillLine                               { get; private set; } = LoadDBC<SkillLineEntry>();
        //public static DBCStorage<ScreenEffectEntry>             ScreenEffect           { get; private set; } = LoadDBC<ScreenEffectEntry>();
        //public static DBCStorage<OverrideSpellDataEntry>        OverrideSpellData      { get; private set; } = LoadDBC<OverrideSpellDataEntry>();
        //public static DBCStorage<ItemClassEntry>                ItemClass              { get; private set; } = LoadDBC<ItemClassEntry>();
        public static DBCStorage<SpellShapeshiftFormEntry> SpellShapeshiftForm           { get; private set; } = LoadDBC<SpellShapeshiftFormEntry>();
        public static DB2Storage<SpellDispelTypeEntry> SpellDispelType                   { get; private set; } = LoadDB2<SpellDispelTypeEntry>();
        public static DB2Storage<ItemSparseEntry> ItemSparse                             { get; private set; } = LoadDB2<ItemSparseEntry>("Item-sparse.db2");

        public static void Load() { }

        static DBCStorage<T> LoadDBC<T>(string file = "") where T : class, new()
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                file = typeof(T).Name;
                file = file.Substring(0, file.Length - "Entry".Length) + ".dbc";
            }
            var fileName = Path.Combine(DBC_PATH, file);

            if (!File.Exists(fileName))
                throw new FileNotFoundException($"File '{fileName}' not found", fileName);

            var bytes = File.ReadAllBytes(fileName);
            using (var ms = new MemoryStream(bytes))
            {
                try
                {
                    var tmp = new DBCStorage<T>();
                    tmp.Load(ms);
                    return tmp;
                }
                catch (Exception ex)
                {
                    throw new Exception("Can't load " + fileName, ex);
                }
            }
        }

        static DB2Storage<T> LoadDB2<T>(string file  = "") where T : class, new()
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                file = typeof(T).Name;
                file = file.Substring(0, file.Length - "Entry".Length) + ".db2";
            }
            var fileName = Path.Combine(DBC_PATH, file);

            if (!File.Exists(fileName))
                throw new FileNotFoundException($"File '{fileName}' not found", fileName);

            var bytes = File.ReadAllBytes(fileName);
            using (var ms = new MemoryStream(bytes))
            {
                try
                {
                    var tmp = new DB2Storage<T>();
                    tmp.Load(ms);
                    return tmp;
                }
                catch (Exception ex)
                {
                    throw new Exception("Can't load " + fileName, ex);
                }
            }
        }
    }
}
