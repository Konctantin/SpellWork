using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using SpellWork.Controls;
using SpellWork.Controls.SpellProc;
using SpellWork.DBClientFilesStructure;

namespace SpellWork
{
    /// <summary>
    /// Логика взаимодействия для SpellProcConstructor.xaml
    /// </summary>
    public partial class SpellProcConstructor : UserControl
    {
        #region Dependecy Property

        public static readonly DependencyProperty SpellProcProperty =
            DependencyProperty.Register("SpellProc", typeof(SpellProcEntry), typeof(SpellProcConstructor),
            new PropertyMetadata(new SpellProcEntry(), SpellProcPropertyChanged));

        public SpellProcEntry SpellProc
        {
            get { return (SpellProcEntry)GetValue(SpellProcProperty); }
            set { SetValue(SpellProcProperty, value); }
        }

        static void SpellProcPropertyChanged(DependencyObject dependecyObject, DependencyPropertyChangedEventArgs e)
        {
            var constructor = dependecyObject as SpellProcConstructor;
            if (constructor != null && e.NewValue != e.OldValue)
            {
                constructor.SpellProc = (SpellProcEntry)e.NewValue;
            }
        }

        #endregion

        public static ObservableCollection<SpellFamilyRecord> TreeRecords = new ObservableCollection<SpellFamilyRecord>();
        public static ObservableCollection<SpellEntry> ProcSpells = new ObservableCollection<SpellEntry>();

        public SpellProcConstructor()
        {
            InitializeComponent();
        }

        void cbFamilyName_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            // because underlying type int
            var spellFamilyName = (int)((KeyValuePair<object, object>)cbFamilyName.SelectedValue).Key;

//            var spells = from Spell in DBC.Spell.Records

//                         join sk in DBC.SkillLineAbility.Records on Spell.ID equals sk.SpellId into temp1
//                         from Skill in temp1.NewIfEmpty()

//                         join skl in DBC.SkillLine.Records on Skill.SkillId equals skl.ID into temp2
//                         from SkillLine in temp2.NewIfEmpty()

//                         where Spell.SpellFamilyName == spellFamilyName
//                         select new
//                         {
//                             Spell,
//                             // stupid exception
//                             Skill.SkillId,
//                             SkillLine
//                         };

//            TreeRecords.Clear();

//            if (cbFamilyName.SelectedIndex > 1)
//            {
//                for (int i = 0; i < 96; i++)
//                {
//                    uint[] mask = new uint[3];

//                    if (i < 32)
//                        mask[0] = 1U << i;
//                    else if (i < 64)
//                        mask[1] = 1U << (i - 32);
//                    else
//                        mask[2] = 1U << (i - 64);

//                    var rec = new SpellFamilyRecord(mask[2], mask[1], mask[0]);
//                    TreeRecords.Add(rec);
//#warning need implement here
//                }

//                foreach (var elem in spells)
//                {
//                    var spell = elem.Spell;
//                    var IsSkill = elem.SkillId != 0;

//                    var name = new StringBuilder();
//                    name.Append(spell.SpellName);
//                    if (IsSkill)
//                    {
//                        name.AppendFormat(" Skill: ({0}) {1} ", elem.SkillId, elem.SkillLine.Name);
//                    }

//                    int index = 0;
//                    foreach (var node in TreeRecords)
//                    {
//                        var mask = new uint[3];

//                        if (index < 32)
//                            mask[0] = 1U << index;
//                        else if (index < 64)
//                            mask[1] = 1U << (index - 32);
//                        else
//                            mask[2] = 1U << (index - 64);

//                        var flags = spell.SpellClassOptions.SpellFamilyFlags;

//                        int effindex = 0;
//                        foreach (var eff in spell.SpellEffectList)
//                        {
//                            for (int i = 0; i < 3; ++i)
//                            {
//                                if ((eff.EffectSpellClassMaskA[i] & mask[i]) != 0)
//                                {
//                                    node.AddSpellInfo(IsSkill, spell.ID, effindex++, name.ToString());
//                                }
//                            }
//                        }

//                        ++index;
//                    }
//                }
//            }
        }

        void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            var spellProc = SpellProc;
            var mask = new uint[3, 3];

            foreach (var record in TreeRecords)
            {
                if (record.IsCheckedA)
                {
                    mask[0, 0] |= record.Mask1;
                    mask[0, 1] |= record.Mask2;
                    mask[0, 2] |= record.Mask3;
                }
                if (record.IsCheckedB)
                {
                    mask[1, 0] |= record.Mask1;
                    mask[1, 1] |= record.Mask2;
                    mask[1, 2] |= record.Mask3;
                }
                if (record.IsCheckedC)
                {
                    mask[2, 0] |= record.Mask1;
                    mask[2, 1] |= record.Mask2;
                    mask[2, 2] |= record.Mask3;
                }
            }

            SpellProc.SpellFamilyMaskA = new uint[] { mask[0, 0], mask[0, 1], mask[0, 2] };
            SpellProc.SpellFamilyMaskB = new uint[] { mask[1, 0], mask[1, 1], mask[1, 2] };
            SpellProc.SpellFamilyMaskC = new uint[] { mask[2, 0], mask[2, 1], mask[2, 2] };

            SetValue(SpellProcProperty, spellProc);

            //if (spellViewer.SelectedSpell.SpellClassOptions == null)
            //    return;

            //var query = (from spell in DBC.Spell.Values
            //             join pco in DBC.SpellClassOptions.Records on spell.SpellClassOptionsId equals pco.Id into _pco
            //             from spellclassOption in _pco.NewIfEmpty()

            //             join sk in DBC.SkillLineAbility.Records on spell.ID equals sk.SpellId into temp1
            //             from Skill in temp1.NewIfEmpty()

            //             where spellclassOption.SpellFamilyName == spellViewer.SelectedSpell.SpellClassOptions.SpellFamilyName

            //             //join skl in DBC.SkillLine on Skill.Value.SkillId equals skl.Value.ID into temp2
            //             //from SkillLine in temp2.DefaultIfEmpty()
            //             orderby Skill.ID descending
            //             select spell).ToList();

            //ProcSpells.Clear();
            //foreach (var spell in query)
            //{
            //    int j = 0;
            //    foreach (var eff in spell.SpellEffectList)
            //    {
            //        for (int i = 0; i < 3; ++i)
            //        {
            //            if ((eff.EffectSpellClassMaskA[i] & mask[j, i]) != 0)
            //            {
            //                ProcSpells.Add(spell);
            //            }
            //        }
            //        ++j;
            //    }
            //}
        }
    }
}
