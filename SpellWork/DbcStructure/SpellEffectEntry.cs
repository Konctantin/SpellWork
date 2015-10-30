using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    // SpellEffect.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellEffectEntry
    {
        public uint   ID;
        public uint   DifficultyID;
        public uint   Effect;
        public float  EffectAmplitude;
        public uint   EffectAura;
        public uint   EffectAuraPeriod;
        public uint   EffectBasePoints;
        public float  EffectBonusCoefficient;
        public float  EffectChainAmplitude;
        public uint   EffectChainTargets;
        public uint   EffectDieSides;
        public uint   EffectItemType;
        public uint   EffectMechanic;
        public int    EffectMiscValue;
        public int    EffectMiscValueB;
        public float  EffectPointsPerResource;
        public uint   EffectRadiusIndex;
        public uint   EffectRadiusMaxIndex;
        public float  EffectRealPointsPerLevel;
        public uint   EffectSpellClassMask0;
        public uint   EffectSpellClassMask1;
        public uint   EffectSpellClassMask2;
        public uint   EffectSpellClassMask3;
        public uint   EffectTriggerSpell;
        public float  EffectPosFacing;
        public uint   ImplicitTarget0;
        public uint   ImplicitTarget1;
        public uint   SpellID;
        public uint   EffectIndex;
        public uint   EffectAttributes;
        public float  BonusCoefficientFromAP;
    };
}
