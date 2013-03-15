using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Controls
{
    public class SpellRecord
    {
        public bool IsSkill     { get; set; }
        public uint SpellId     { get; set; }
        public int EffectIndex  { get; set; }
        public bool[] IsEffect  { get; set; }
        public string SpellName { get; set; }

        public SpellRecord(bool isSkill, uint id, int effectIndex, string name)
        {
            this.IsEffect               = new bool[3];
            this.IsEffect[effectIndex]  = true;
            this.IsSkill                = isSkill;
            this.SpellId                = id;
            this.EffectIndex            = effectIndex;
            this.SpellName              = name;
        }

        public void SetEffectIndexMask(int index)
        {
            this.IsEffect[index] = true;
        }
    }
}
