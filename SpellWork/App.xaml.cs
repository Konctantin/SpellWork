using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using DBFilesClient.NET;
using SpellWork.Dbc;

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
            SpellWork.DataBase.Sql.Dispose();
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

        DBCStorage<T> LoadDBC<T>() where T : class, new()
        {
            var name = typeof(T).Name;
            name = name.Substring(0, name.Length - "Entry".Length);
            var fileName = Path.Combine(DBC.DBC_PATH, name + ".dbc");

            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName);

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

        DB2Storage<T> LoadDB2<T>() where T : class, new()
        {
            var name = typeof(T).Name;
            name = name.Substring(0, name.Length - "Entry".Length);
            var fileName = Path.Combine(DBC.DBC_PATH, name + ".db2");

            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName);

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

        public void LoadSpells()
        {
            DBC.Spell                           = LoadDBC<SpellEntry>();
            DBC.SpellEffect                     = LoadDBC<SpellEffectEntry>();
            DBC.SpellTargetRestrictions         = LoadDBC<SpellTargetRestrictionsEntry>();
            DBC.SpellAuraRestrictions           = LoadDB2<SpellAuraRestrictionsEntry>();
            DBC.SpellCooldowns                  = LoadDBC<SpellCooldownsEntry>();
            DBC.SpellCategories                 = LoadDBC<SpellCategoriesEntry>();
            DBC.SpellShapeshift                 = LoadDBC<SpellShapeshiftEntry>();
            DBC.SpellAuraOptions                = LoadDBC<SpellAuraOptionsEntry>();
            DBC.SpellLevels                     = LoadDBC<SpellLevelsEntry>();
            DBC.SpellClassOptions               = LoadDB2<SpellClassOptionsEntry>();
            DBC.SpellCastingRequirements        = LoadDB2<SpellCastingRequirementsEntry>();
            DBC.SpellPower                      = LoadDB2<SpellPowerEntry>();
            DBC.SpellInterrupts                 = LoadDBC<SpellInterruptsEntry>();
           // DBC.SpellEquippedItems              = LoadDBC<SpellEquippedItemsEntry>();
           // DBC.SpellDuration                   = LoadDBC<SpellDurationEntry>();
            DBC.SkillLineAbility                = LoadDBC<SkillLineAbilityEntry>();
          //  DBC.SpellRadius                     = LoadDBC<SpellRadiusEntry>();
          //  DBC.SpellCastTimes                  = LoadDBC<SpellCastTimesEntry>();
          //  DBC.SpellDifficulty                 = LoadDBC<SpellDifficultyEntry>();
          //  DBC.CurrencyTypes                   = LoadDBC<CurrencyTypesEntry>();
          //  DBC.OverrideSpellData               = LoadDBC<OverrideSpellDataEntry>();
            DBC.SkillLine                       = LoadDBC<SkillLineEntry>();
         //   DBC.SpellRange                      = LoadDBC<SpellRangeEntry>();
            DBC.SpellReagents                   = LoadDB2<SpellReagentsEntry>();
         //   DBC.ScreenEffect                    = LoadDBC<ScreenEffectEntry>();
         //   DBC.ItemClass                       = LoadDBC<ItemClassEntry>();
            DBC.SpellShapeshiftForm             = LoadDBC<SpellShapeshiftFormEntry>();
            //   DBC.SpellDispelType                 = LoadDBC<SpellDispelTypeEntry>();
        }
    }
}
