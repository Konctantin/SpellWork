using System.Runtime.InteropServices;
using SpellWork.Enums;
using System.Linq;

namespace SpellWork.DBClientFilesStructure
{
    // SpellEffect.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellEffectEntry
    {
        public uint   ID;
        public uint   DifficultyID;
        public SpellEffects Effect          { get; private set; }
        public float  EffectAmplitude       { get; private set; }
        public AuraType EffectAura          { get; private set; }
        public uint EffectAuraPeriod        { get; private set; }
        public uint EffectBasePoints        { get; private set; }
        public float EffectBonusCoefficient { get; private set; }
        public float EffectChainAmplitude   { get; private set; }
        public uint   EffectChainTargets;
        public uint   EffectDieSides;
        public uint   EffectItemType;
        public Mechanics EffectMechanic { get; private set; }
        public int    EffectMiscValue { get; private set; }
        public int    EffectMiscValueB { get; private set; }
        public float  EffectPointsPerResource { get; private set; }
        public uint   EffectRadiusIndex;
        public uint   EffectRadiusMaxIndex;
        public float  EffectRealPointsPerLevel { get; private set; }
        public uint   EffectSpellClassMask0 { get; private set; }
        public uint   EffectSpellClassMask1 { get; private set; }
        public uint   EffectSpellClassMask2 { get; private set; }
        public uint   EffectSpellClassMask3 { get; private set; }
        public uint   EffectTriggerSpell;
        public float  EffectPosFacing { get; private set; }
        public Targets ImplicitTarget0 { get; private set; }
        public Targets ImplicitTarget1 { get; private set; }
        public uint   SpellID;
        public uint   EffectIndex { get; private set; }
        public uint   EffectAttributes;
        public float  BonusCoefficientFromAP { get; private set; }

        public SpellMiscDifficultyEntry Difficulty => DBC.SpellDifficulty.GetValueOrDefault(DifficultyID);

        public SpellEntry TriggerSpell => DBC.Spell.Values.FirstOrDefault(s => s.ID == EffectTriggerSpell);

        public SpellRadiusEntry Radius => DBC.SpellRadius.GetValueOrDefault(EffectRadiusIndex);

        public SpellRadiusEntry RadiusMax => DBC.SpellRadius.GetValueOrDefault(EffectRadiusMaxIndex);
    };
}
