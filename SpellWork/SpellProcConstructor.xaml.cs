using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Логика взаимодействия для SpellProcConstructor.xaml
    /// </summary>
    public partial class SpellProcConstructor : UserControl
    {
        public SpellProcConstructor()
        {
            InitializeComponent();
        }

        private void cbFamilyName_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
                                // because underlying type int
            var spellFamilyName = (int)((KeyValuePair<object, object>)cbFamilyName.SelectedValue).Key;

            var spells = from Spell in DBC.Spell.Records
                         
                         join sk in DBC.SkillLineAbility.Records on Spell.ID equals sk.SpellId into temp1
                         from Skill in temp1.DefaultIfEmpty()
                                                              // stupid exception
                         join skl in DBC.SkillLine.Records on (Skill != null ? Skill : new SkillLineAbilityEntry()).SkillId equals skl.ID into temp2
                         from SkillLine in temp2.DefaultIfEmpty()
                         
                         where Spell.SpellFamilyName == spellFamilyName
                         select new
                         {
                             Spell,
                             // stupid exception
                             (Skill != null ? Skill : new SkillLineAbilityEntry()).SkillId,
                             SkillLine
                         };

            var treeRecord = new ObservableCollection<SpellFamilyRecord>();

            if (cbFamilyName.SelectedIndex > 1)
            {
                for (int i = 0; i < 96; i++)
                {
                    uint[] mask = new uint[3];

                    if (i < 32)
                        mask[0] = 1U << i;
                    else if (i < 64)
                        mask[1] = 1U << (i - 32);
                    else
                        mask[2] = 1U << (i - 64);

                    var rec = new SpellFamilyRecord(mask[0], mask[1], mask[2]);
                    treeRecord.Add(rec);
                    #warning need implement here
                }

                tree.ItemsSource = treeRecord;

                foreach (var elem in spells)
                {
                    var spell = elem.Spell;
                    var IsSkill = elem.SkillId != 0;

                    var name = new StringBuilder();
                    var toolTip = new StringBuilder();
                    name.Append(spell.SpellName);
                    if (IsSkill)
                    {
                        name.AppendFormat("(Skill: ({0}) {1}) ", elem.SkillId, elem.SkillLine.Name);
                        toolTip.AppendLine();
                    }

                    int index = 0;
                    foreach (var node in treeRecord)
                    {
                        var mask = new uint[3];

                        if (index < 32)
                            mask[0] = 1U << index;
                        else if (index < 64)
                            mask[1] = 1U << (index - 32);
                        else
                            mask[2] = 1U << (index - 64);

                        if (((spell.SpellClassOptions.SpellFamilyFlags[0] & mask[0]) != 0) ||
                            ((spell.SpellClassOptions.SpellFamilyFlags[1] & mask[1]) != 0) ||
                            ((spell.SpellClassOptions.SpellFamilyFlags[2] & mask[2]) != 0))
                        {
                            node.SetInfo(IsSkill, spell.ID, name.ToString());
                            //
                        }
                        ++index;
                    }
                }                
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }

    public class SpellFamilyRecord : INotifyPropertyChanged
    {
        public uint Mask1 { get; set; }
        public uint Mask2 { get; set; }
        public uint Mask3 { get; set; }

        public void SetInfo(bool isSkill, uint id, string name)
        {
            SpellList.Add(new SpellRecord(isSkill, id, name));
            PropChenged("SpellList");
        }

        public ObservableCollection<SpellRecord> SpellList { get; set; }

        public SpellFamilyRecord(uint mask1, uint mask2, uint mask3)
        {
            this.Mask1 = mask1;
            this.Mask2 = mask2;
            this.Mask3 = mask3;

            this.SpellList = new ObservableCollection<SpellRecord>();
        }

        private void PropChenged(string pname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(pname));
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class SpellRecord : INotifyPropertyChanged
    {
        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set 
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    PropChenged("IsChecked");
                }
            }
        }
        public bool IsSkill { get; set; }
        public uint SpellId { get; set; }
        public string SpellName { get; set; }

        public SpellRecord(bool isSkill, uint id, string name)
        {
            this.IsSkill   = isSkill;
            this.SpellId   = id;
            this.SpellName = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void PropChenged(string pname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(pname));
        }
    }
}
