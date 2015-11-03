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
            IsEffect = new bool[3];
            IsEffect[effectIndex]  = true;
            IsSkill = isSkill;
            SpellId = id;
            EffectIndex = effectIndex;
            SpellName = name;
        }

        public void SetEffectIndexMask(int index)
        {
            IsEffect[index] = true;
        }
    }
}
