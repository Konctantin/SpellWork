using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using DBFilesClient.NET;
using SpellWork.Dbc;
using SpellWork.Enums;

namespace SpellWork
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnExit(ExitEventArgs e)
        {
            SpellWork.Properties.Settings.Default.Save();

            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                //var sw = new Stopwatch();
                //sw.Start();
                LoadSpells();
                //sw.Stop();
                //MessageBox.Show(sw.ElapsedMilliseconds.ToString());
            }
            catch (Exception ex)
            {
                var innerMessage = ex.InnerException == null 
                    ? string.Empty : 
                    ex.InnerException.Message;

                MessageBox.Show(
                    ex.Message + Environment.NewLine + innerMessage,
                    "SpellWork Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
                Application.Current.Shutdown();
                return;
            }

            base.OnStartup(e);
        }

        private DBCStorage<T> LoadDBC<T>() where T : class, new()
        {
            var name = typeof(T).Name;
            name = name.Substring(0, name.Length - "Entry".Length);
            var fileName = Path.Combine(DBC.DBC_PATH, name + ".dbc");

            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName);

            var tmp = new DBCStorage<T>();
            var bytes = File.ReadAllBytes(fileName);
            using (var ms = new MemoryStream(bytes))
            {
                try
                {
                    tmp.Load(ms);
                }
                catch (Exception ex)
                {
                    throw new Exception("Can't load " + fileName, ex);
                }
            }
            return tmp;
        }

        public void LoadSpells()
        {
            DBC.Spell                           = LoadDBC<SpellEntry>();
            DBC.SpellEffect                     = LoadDBC<SpellEffectEntry>();
            DBC.SpellTargetRestrictions         = LoadDBC<SpellTargetRestrictionsEntry>();
            DBC.SpellAuraRestrictions           = LoadDBC<SpellAuraRestrictionsEntry>();
            DBC.SpellCooldowns                  = LoadDBC<SpellCooldownsEntry>();
            DBC.SpellCategories                 = LoadDBC<SpellCategoriesEntry>();
            DBC.SpellShapeshift                 = LoadDBC<SpellShapeshiftEntry>();
            DBC.SpellAuraOptions                = LoadDBC<SpellAuraOptionsEntry>();
            DBC.SpellLevels                     = LoadDBC<SpellLevelsEntry>();
            DBC.SpellClassOptions               = LoadDBC<SpellClassOptionsEntry>();
            DBC.SpellCastingRequirements        = LoadDBC<SpellCastingRequirementsEntry>();
            DBC.SpellPower                      = LoadDBC<SpellPowerEntry>();
            DBC.SpellInterrupts                 = LoadDBC<SpellInterruptsEntry>();
            DBC.SpellEquippedItems              = LoadDBC<SpellEquippedItemsEntry>();
            DBC.SpellDuration                   = LoadDBC<SpellDurationEntry>();
            DBC.SkillLineAbility                = LoadDBC<SkillLineAbilityEntry>();
            DBC.SpellRadius                     = LoadDBC<SpellRadiusEntry>();
            DBC.SpellCastTimes                  = LoadDBC<SpellCastTimesEntry>();
            DBC.SpellDifficulty                 = LoadDBC<SpellDifficultyEntry>();
            DBC.CurrencyTypes                   = LoadDBC<CurrencyTypesEntry>();
            DBC.OverrideSpellData               = LoadDBC<OverrideSpellDataEntry>();
            DBC.SkillLine                       = LoadDBC<SkillLineEntry>();
            DBC.SpellRange                      = LoadDBC<SpellRangeEntry>();
            DBC.SpellReagents                   = LoadDBC<SpellReagentsEntry>();
            DBC.ScreenEffect                    = LoadDBC<ScreenEffectEntry>();
            DBC.ItemClass                       = LoadDBC<ItemClassEntry>();
            DBC.SpellShapeshiftForm             = LoadDBC<SpellShapeshiftFormEntry>();
            DBC.SpellDispelType                 = LoadDBC<SpellDispelTypeEntry>();


            // this is to speedup spelleffect lookups
            foreach (SpellEffectEntry value in DBC.SpellEffect)
            {
                if (DBC.SpellEffects.ContainsKey(value.EffectSpellId))
                {
                    DBC.SpellEffects[value.EffectSpellId].Add(value.EffectIndex, value);
                }
                else
                {
                    Dictionary<uint, SpellEffectEntry> temp = new Dictionary<uint, SpellEffectEntry>(3);
                    DBC.SpellEffects.Add(value.EffectSpellId, temp);
                    DBC.SpellEffects[value.EffectSpellId].Add(value.EffectIndex, value);
                }
            }

            DBC.Locale = Enums.LocalesDBC.ruRU;
        }
    }
}
