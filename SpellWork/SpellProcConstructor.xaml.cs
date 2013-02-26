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
            var spells = from Spell in DBC.Spell.Records
                         where Spell.SpellFamilyName == (int)((KeyValuePair<object, object>)cbFamilyName.SelectedValue).Key
                         join sk in DBC.SkillLineAbility.Records on Spell.ID equals sk.SpellId into temp1
                         from Skill in temp1.DefaultIfEmpty()
                         join skl in DBC.SkillLine.Records on (Skill != null ? Skill : new SkillLineAbilityEntry()).SkillId equals skl.ID into temp2
                         from SkillLine in temp2.DefaultIfEmpty()
                         select new
                         {
                             Spell,
                             (Skill != null ? Skill : new SkillLineAbilityEntry()).SkillId,
                             SkillLine
                         };

            ObservableCollection<SpellFamilyRecord> treeRecord = new ObservableCollection<SpellFamilyRecord>();

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
                    //rec.SpellList.Add(new SpellRecord((i %2 )!=0, 1, "lololo"));

                    treeRecord.Add(rec);


                    
                    //TreeNode node = new TreeNode();
                    //node.Text = String.Format("0x{0:X8} {1:X8} {2:X8}", mask[2], mask[1], mask[0]);
                    //node.ImageKey = "family.ico";
                    //familyTree.Nodes.Add(node);
                }

                tree.ItemsSource = treeRecord;

                foreach (var elem in spells)
                {
                    SpellEntry spell = elem.Spell;
                    bool IsSkill = elem.SkillId != 0;

                    StringBuilder name = new StringBuilder();
                    StringBuilder toolTip = new StringBuilder();

                    //name.AppendFormat(/*"{0} - {1} ", spell.ID, spell.SpellNameRank);

                    //toolTip.AppendFormatLine("Spell Name: {0}", spell.SpellNameRank);
                    //toolTip.AppendFormatLine("Description: {0}", spell.Description);
                    //toolTip.AppendFormatLine("ToolTip: {0}", spell.ToolTip);

                    if (IsSkill)
                    {
                        name.AppendFormat("(Skill: ({0}) {1}) ", elem.SkillId, elem.SkillLine.Name);

                        toolTip.AppendLine();
                        //toolTip.AppendFormatLine("Skill Name: {0}", elem.SkillLine.Name);
                        //toolTip.AppendFormatLine("Description: {0}", elem.SkillLine.Description);
                    }

                    //name.AppendFormat("({0})", spell.School.ToString().NormaliseString("MASK_"));

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
                            node.SetInfo(false, spell.ID, name.ToString());
                            //TreeNode child = new TreeNode();
                            //child = node.Nodes.Add(name.ToString());
                            //child.Name = spell.ID.ToString();
                            //child.ImageKey = IsSkill ? "plus.ico" : "munus.ico";
                            //child.ForeColor = IsSkill ? Color.Blue : Color.Red;
                            //child.ToolTipText = toolTip.ToString();
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

        public void SetInfo(bool ch, uint id, string name)
        {
            SpellList.Add(new SpellRecord(ch, id, name));
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
        private bool isch;
        public bool IsCheked { get { return isch; }
            set 
            {
                if (isch != value)
                {
                    isch = value;
                    PropChenged("IsCheked");
                }
            }
        }
        public uint SpellId { get; set; }
        public string SpellName { get; set; }

        public SpellRecord(bool ch, uint id, string name)
        {
            this.IsCheked = ch;
            this.SpellId = id;
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
