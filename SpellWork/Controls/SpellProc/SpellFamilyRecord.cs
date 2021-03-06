﻿using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SpellWork.Controls
{
    public class SpellFamilyRecord : INotifyPropertyChanged
    {
        bool isCheckedA;
        public bool IsCheckedA
        {
            get { return isCheckedA; }
            set
            {
                if (isCheckedA != value)
                {
                    isCheckedA = value;
                    PropChenged("IsCheckedA");
                }
            }
        }

        bool isCheckedB;
        public bool IsCheckedB
        {
            get { return isCheckedB; }
            set
            {
                if (isCheckedB != value)
                {
                    isCheckedB = value;
                    PropChenged("IsCheckedB");
                }
            }
        }

        bool isCheckedC;
        public bool IsCheckedC
        {
            get { return isCheckedC; }
            set
            {
                if (isCheckedC != value)
                {
                    isCheckedC = value;
                    PropChenged("IsCheckedC");
                }
            }
        }

        public uint Mask1 { get; set; }
        public uint Mask2 { get; set; }
        public uint Mask3 { get; set; }

        public void AddSpellInfo(bool isSkill, uint id, int effectIndex, string name)
        {
            bool found = false;
            for (int i = 0; i < SpellList.Count; ++i)
            {
                if (SpellList[i].SpellId == id)
                {
                    SpellList[i].SetEffectIndexMask(effectIndex);
                    found = true;
                }
            }

            if (!found)
                SpellList.Add(new SpellRecord(isSkill, id, effectIndex, name));

            PropChenged("SpellList");
        }

        public ObservableCollection<SpellRecord> SpellList { get; set; }

        public SpellFamilyRecord(uint mask1, uint mask2, uint mask3)
        {
            Mask1 = mask1;
            Mask2 = mask2;
            Mask3 = mask3;

            SpellList = new ObservableCollection<SpellRecord>();
        }

        void PropChenged(string pname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(pname));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
