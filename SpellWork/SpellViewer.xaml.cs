using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SpellWork.Dbc;

namespace SpellWork
{
    /// <summary>
    /// Логика взаимодействия для SpellViewer.xaml
    /// </summary>
    public partial class SpellViewer : UserControl
    {
        public SpellViewer()
        {
            InitializeComponent();
        }

        private void ApplyFilter(object sender, ExecutedRoutedEventArgs e)
        {
            var spellList = CollectionViewSource.GetDefaultView(lvSpellList.ItemsSource);

            int spellId = 0;
            int.TryParse(tbSpellName.Text, out spellId);

            Func<ComboBox, int> getValue = (comboBox) => { 
                return comboBox.SelectedIndex > 0 
                    ? (int)((KeyValuePair<object, object>)comboBox.SelectedValue).Value 
                    : -1; 
            };

            var auraType    = getValue(cbAuraType);
            var spellFamily = getValue(cbSpellFamilyName);
            var spellEffect = getValue(cbSpellEffect);
            var targetA     = getValue(cbTargetA);
            var targetB     = getValue(cbTargetB);

            // disable filter
            if (string.IsNullOrWhiteSpace(tbSpellName.Text) 
                && spellFamily == -1 
                && auraType == -1 
                && spellEffect == -1
                && targetA == -1
                && targetB == -1
                )
            {
                spellList.Filter = null;
                return;
            }

            var spellids = new List<uint>();

            // speedup variant
            if (spellFamily != -1 || spellEffect != -1 || auraType != -1 || targetA != -1 || targetB != -1)
            {
                spellids = (from spell in DBC.Spell.Values

                            join spe in DBC.SpellEffect.Records on spell.ID equals spe.EffectSpellId into _spe
                            from spellEffectEntry in _spe.DefaultIfEmpty()

                            join sco in DBC.SpellClassOptions.Records on spell.SpellClassOptionsId equals sco.Id into _sco
                            from spellClassOptionEntry in _sco.DefaultIfEmpty()

                            where (spellFamily == -1 || (spellClassOptionEntry != null && spellClassOptionEntry.SpellFamilyName == spellFamily))

                               && (spellEffect == -1 || (spellEffectEntry != null && spellEffectEntry.Effect == spellEffect))
                               && (auraType    == -1 || (spellEffectEntry != null && spellEffectEntry.EffectApplyAuraName == auraType))
                               && (targetA     == -1 || (spellEffectEntry != null && spellEffectEntry.EffectImplicitTargetA == targetA))
                               && (targetB     == -1 || (spellEffectEntry != null && spellEffectEntry.EffectImplicitTargetB == targetB))
                            #warning todo : implement additional filter
                               //&& (!use1val      || spell.CreateFilter(field1, advVal1, field1ct))
                               //&& (!use2val      || spell.CreateFilter(field2, advVal2, field2ct))
                           select spell.ID).ToList();
            }

            var hasAdditionalFilter = spellids.Count() > 0;

            if (spellList != null)
            {
                spellList.Filter = new Predicate<object>((spellRaw) =>
                {
                    if (!(spellRaw is SpellEntry))
                        return false;

                    var spell = spellRaw as SpellEntry;                    

                    // SpellName of Id
                    if (!string.IsNullOrWhiteSpace(tbSpellName.Text))
                    {
                        if (spellId > 0 && spell.ID == spellId)
                            return true;

                        if (spell.SpellName.IndexOf(tbSpellName.Text, StringComparison.CurrentCultureIgnoreCase) > -1)
                            return true;
                    }

                    if (hasAdditionalFilter && spellids.Contains(spell.ID))
                        return true;

                    return false;
                });
            }
        }

        private void filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilter(sender, null);
        }
    }
}
