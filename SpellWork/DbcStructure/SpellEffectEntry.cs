using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    // SpellEffect.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellEffectEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint Effect;                                       // 73-75    m_effect
        public float EffectMultipleValue;                         // 106-108  m_effectAmplitude
        public uint EffectApplyAuraName;                          // 100-102  m_effectAura
        public uint EffectAmplitude;                              // 103-105  m_effectAuraPeriod
        public int EffectBasePoints;                              // 82-84    m_effectBasePoints (don't must be used in spell/auras explicitly, must be used cached Spell::m_currentBasePoints)
        public float Unk_320_4;                                   // 169-171  3.2.0
        public float DmgMultiplier;                               // 156-158  m_effectChainAmplitude
        public uint EffectChainTarget;                            // 109-111  m_effectChainTargets
        public int EffectDieSides;                                // 76-78    m_effectDieSides
        public uint EffectItemType;                               // 112-114  m_effectItemType
        public uint EffectMechanic;                               // 85-87    m_effectMechanic
        public int EffectMiscValue;                               // 115-117  m_effectMiscValue
        public int EffectMiscValueB;                              // 118-120  m_effectMiscValueB
        public float EffectPointsPerComboPoint;                   // 124-126  m_effectPointsPerCombo
        public uint EffectRadiusIndex;                            // 94-96    m_effectRadiusIndex - spellradius.dbc
        public uint EffectRadiusMaxIndex;                         // 97-99    4.0.0
        public float EffectRealPointsPerLevel;                    // 79-81    m_effectRealPointsPerLevel
        [StoragePresence(StoragePresenceOption.Include, ArraySize = DBC.MAX_EFFECT_INDEX)]
        public uint[] EffectSpellClassMaskA;                      // 127-129  m_effectSpellClassMaskA, effect 0
        public uint EffectTriggerSpell;                           // 121-123  m_effectTriggerSpell
        public uint EffectImplicitTargetA;                        // 88-90    m_implicitTargetA
        public uint EffectImplicitTargetB;                        // 91-93    m_implicitTargetB
        public uint EffectSpellId;                                // new 4.0.0
        public uint EffectIndex;                                  // new 4.0.0
        public int unk;

        public SpellEffectEntry()
        {
            // for default value
            EffectSpellClassMaskA = new uint[DBC.MAX_EFFECT_INDEX];
        }
    };
}
