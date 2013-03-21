using System.ComponentModel;
using SpellWork.Enums;

namespace SpellWork.Controls.SpellProc
{
    public class SpellProcEntry : INotifyPropertyChanged
    {
        private int entry;
        public int Entry
        { 
            get { return entry; }
            set
            {
                if (entry != value)
                {
                    entry = value;
                    SendPropertyChange("Entry");
                }
            }
        }

        private SpellSchoolMask schoolMask;
        public SpellSchoolMask SchoolMask
        {
            get { return schoolMask; }
            set
            {
                if (schoolMask != value)
                {
                    schoolMask = value;
                    SendPropertyChange("SchoolMask");
                }
            }
        }

        private SpellFamilyNames spellFamilyName;
        public SpellFamilyNames SpellFamilyName
        {
            get { return spellFamilyName; }
            set
            {
                if (spellFamilyName != value)
                {
                    spellFamilyName = value;
                    SendPropertyChange("SpellFamilyName");
                }
            }
        }

        private uint[] spellFamilyMaskA;
        public uint[] SpellFamilyMaskA
        {
            get { return spellFamilyMaskA; }
            set
            {
                if (spellFamilyMaskA != value)
                {
                    spellFamilyMaskA = value;
                    SendPropertyChange("SpellFamilyMaskA");
                }
            }
        }

        private uint[] spellFamilyMaskB;
        public uint[] SpellFamilyMaskB
        {
            get { return spellFamilyMaskB; }
            set
            {
                if (spellFamilyMaskB != value)
                {
                    spellFamilyMaskB = value;
                    SendPropertyChange("SpellFamilyMaskB");
                }
            }
        }

        private uint[] spellFamilyMaskC;
        public uint[] SpellFamilyMaskC
        {
            get { return spellFamilyMaskC; }
            set
            {
                if (spellFamilyMaskC != value)
                {
                    spellFamilyMaskC = value;
                    SendPropertyChange("SpellFamilyMaskC");
                }
            }
        }

        private ProcFlags procFlags;
        public ProcFlags ProcFlags
        {
            get { return procFlags; }
            set
            {
                if (procFlags != value)
                {
                    procFlags = value;
                    SendPropertyChange("ProcFlags");
                }
            }
        }

        private ProcFlagsEx procEx;
        public ProcFlagsEx ProcEx
        {
            get { return procEx; }
            set
            {
                if (procEx != value)
                {
                    procEx = value;
                    SendPropertyChange("ProcEx");
                }
            }
        }

        private float ppmRate;
        public float PpmRate
        {
            get { return ppmRate; }
            set
            {
                if (ppmRate != value)
                {
                    ppmRate = value;
                    SendPropertyChange("PpmRate");
                }
            }
        }

        private float customChance;
        public float CustomChance
        {
            get { return customChance; }
            set
            {
                if (customChance != value)
                {
                    customChance = value;
                    SendPropertyChange("CustomChance");
                }
            }
        }

        private int cooldown;
        public int Cooldown
        {
            get { return cooldown; }
            set
            {
                if (cooldown != value)
                {
                    cooldown = value;
                    SendPropertyChange("Cooldown");
                }
            }
        }

        public SpellProcEntry()
        {
            this.SpellFamilyMaskA = new uint[3];
            this.SpellFamilyMaskB = new uint[3];
            this.SpellFamilyMaskC = new uint[3];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SendPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
