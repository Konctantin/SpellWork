using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using SpellWork.Dbc;

namespace SpellWork
{
    /// <summary>
    /// Логика взаимодействия для SpellViewer.xaml
    /// </summary>
    public partial class SpellViewer : UserControl
    {
        #region SelectedSpell

        public static readonly DependencyProperty SelectedSpellProperty = DependencyProperty.Register("SelectedSpell", typeof(SpellEntry), typeof(SpellViewer),
            new PropertyMetadata(default(SpellEntry), new PropertyChangedCallback(SelectedSpellPropertySelectedChanged)));

        private static void SelectedSpellPropertySelectedChanged(DependencyObject dependecyObject, DependencyPropertyChangedEventArgs e)
        {
            if (!(e.NewValue is SpellEntry))
                return;

            var spellViewer = dependecyObject as SpellViewer;
            if (spellViewer != null && e.NewValue != e.OldValue)
                spellViewer.lvSpellList.SelectedValue = e.NewValue;
        }

        public SpellEntry SelectedSpell
        {
            get { return (SpellEntry)GetValue(SelectedSpellProperty); }
            set { SetValue(SelectedSpellProperty, value); }
        }

        #endregion

        public SpellViewer()
        {
            InitializeComponent();
        }

        void ApplyFilter(object sender, ExecutedRoutedEventArgs e)
        {
            //Action applyFilter = () =>
            //    {
            //        var spellList = CollectionViewSource.GetDefaultView(lvSpellList.ItemsSource);

            //        // spell id or name
            //        bool hasSpellNameOrId = !string.IsNullOrWhiteSpace(tbSpellName.Text);
            //        int spellId = 0;
            //        int.TryParse(tbSpellName.Text, out spellId);

            //        // spell icon
            //        bool hasSpellIcon = !string.IsNullOrWhiteSpace(tbSpellIcon.Text);
            //        int iconId = 0;
            //        int.TryParse(tbSpellIcon.Text, out iconId);

            //        // spell attribute
            //        bool hasSpellAttribute = !string.IsNullOrWhiteSpace(tbSpellAttributes.Text);
            //        int attrib = 0;
            //        int.TryParse(tbSpellAttributes.Text, out attrib);

            //        Func<ComboBox, int> getValue = (comboBox) =>
            //        {
            //            return comboBox.SelectedIndex > 0
            //                ? (int)((KeyValuePair<object, object>)comboBox.SelectedValue).Value
            //                : -1;
            //        };

            //        var auraType = getValue(cbAuraType);
            //        var spellFamily = getValue(cbSpellFamilyName);
            //        var spellEffect = getValue(cbSpellEffect);
            //        var targetA = getValue(cbTargetA);
            //        var targetB = getValue(cbTargetB);

            //        // disable filter
            //        if (!hasSpellNameOrId && !hasSpellIcon && !hasSpellAttribute
            //            && spellFamily == -1
            //            && auraType == -1
            //            && spellEffect == -1
            //            && targetA == -1
            //            && targetB == -1
            //            )
            //        {
            //            spellList.Filter = null;
            //            return;
            //        }

//                    var spellids = (from spell in DBC.Spell.Values

//                                    join spe in DBC.SpellEffect.Records on spell.ID equals spe.EffectSpellId into _spe
//                                    from spellEffectEntry in _spe.DefaultIfEmpty()

//                                    join sco in DBC.SpellClassOptions.Records on spell.SpellClassOptionsId equals sco.Id into _sco
//                                    from spellClassOptionEntry in _sco.DefaultIfEmpty()

//                                    where (spellId == 0 || spell.ID == spellId)
//                                        && (!hasSpellNameOrId || spellId > 0 || spell.SpellName.IndexOf(tbSpellName.Text, StringComparison.CurrentCultureIgnoreCase) > -1)

//                                        && (!hasSpellIcon || spell.ActiveIconID == iconId)

//                                        && (!hasSpellAttribute || (
//                                            ((spell.m_Attributes & attrib) != 0) ||
//                                            ((spell.m_AttributesEx & attrib) != 0) ||
//                                            ((spell.m_AttributesEx2 & attrib) != 0) ||
//                                            ((spell.m_AttributesEx3 & attrib) != 0) ||
//                                            ((spell.m_AttributesEx4 & attrib) != 0) ||
//                                            ((spell.m_AttributesEx5 & attrib) != 0) ||
//                                            ((spell.m_AttributesEx6 & attrib) != 0) ||
//                                            ((spell.m_AttributesEx7 & attrib) != 0) ||
//                                            ((spell.m_AttributesEx8 & attrib) != 0)
//                                        ))

//                                        && (spellFamily == -1 || (spellClassOptionEntry != null && spellClassOptionEntry.SpellFamilyName == spellFamily))

//                                        && (spellEffect == -1 || (spellEffectEntry != null && spellEffectEntry.Effect == spellEffect))
//                                        && (auraType == -1 || (spellEffectEntry != null && spellEffectEntry.EffectApplyAuraName == auraType))
//                                        && (targetA == -1 || (spellEffectEntry != null && spellEffectEntry.EffectImplicitTargetA == targetA))
//                                        && (targetB == -1 || (spellEffectEntry != null && spellEffectEntry.EffectImplicitTargetB == targetB))

//#warning todo : implement additional filter
//                                    //&& (!use1val      || spell.CreateFilter(field1, advVal1, field1ct))
//                                    //&& (!use2val      || spell.CreateFilter(field2, advVal2, field2ct))
//                                    select spell.ID).ToList();

//                    if (spellList != null)
//                        spellList.Filter = new Predicate<object>((spellRaw) =>
//                        {
//                            return spellids.Contains((spellRaw as SpellEntry).ID);
//                        });
//                };
//            new Task(applyFilter).RunSynchronously();
        }

        void filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilter(sender, null);
        }

        void lvSpellList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var listView = sender as ListView;
            if (listView != null && listView.SelectedValue is SpellEntry)
                this.SelectedSpell = listView.SelectedValue as SpellEntry;
        }
    }
}
