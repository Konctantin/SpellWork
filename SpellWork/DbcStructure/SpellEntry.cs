using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;
using SpellWork.Enums;

namespace SpellWork.Dbc
{
    // Spell.dbc
    [StructLayout(LayoutKind.Sequential)]
    public partial class SpellEntry
    {
        public uint m_ID;                                         // 0        m_ID
        public uint m_Attributes;                                 // 1        m_attribute
        public uint m_AttributesEx;                               // 2        m_attributesEx
        public uint m_AttributesEx2;                              // 3        m_attributesExB
        public uint m_AttributesEx3;                              // 4        m_attributesExC
        public uint m_AttributesEx4;                              // 5        m_attributesExD
        public uint m_AttributesEx5;                              // 6        m_attributesExE
        public uint m_AttributesEx6;                              // 7        m_attributesExF
        public uint m_AttributesEx7;                              // 8        3.2.0 (0x20 - totems, 0x4 - paladin auras, etc...)
        public uint m_AttributesEx8;
        public uint m_SomeFlags;                                  // 9        4.0.0
        public uint Unk_400_1;                                    // 10       4.0.0
        public uint m_CastingTimeIndex;                           // 11       m_castingTimeIndex
        public uint m_DurationIndex;                              // 12       m_durationIndex
        public uint m_PowerType;                                  // 13       m_powerType
        public uint m_RangeIndex;                                 // 14       m_rangeIndex
        public float m_Speed;                                     // 15       m_speed
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] m_SpellVisual;                              // 16-17    m_spellVisualID
        public uint m_SpellIconID;                                // 18       m_spellIconID
        public uint m_ActiveIconID;                               // 19       m_activeIconID
        public string _SpellName;                                 // 20       m_name_lang
        public string _Rank;                                      // 21       m_nameSubtext_lang
        public string _Description;                               // 22       m_description_lang not used
        public string _ToolTip;                                   // 23       m_auraDescription_lang not used
        public uint m_SchoolMask;                                 // 24       m_schoolMask
        public uint RuneCostID;                                   // 25       m_runeCostID
        public uint SpellMissileID;                               // 26       m_spellMissileID not used
        public uint SpellDescriptionVariableID;                   // 27       3.2.0
        public uint SpellDifficultyId;                            // 28       m_spellDifficultyID - id from SpellDifficulty.dbc
        public float Unk_f1;                                      // 29
        public uint SpellScalingId;                               // 30       SpellScaling.dbc
        public uint SpellAuraOptionsId;                           // 31       SpellAuraOptions.dbc
        public uint SpellAuraRestrictionsId;                      // 32       SpellAuraRestrictions.dbc
        public uint SpellCastingRequirementsId;                   // 33       SpellCastingRequirements.dbc
        public uint SpellCategoriesId;                            // 34       SpellCategories.dbc
        public uint SpellClassOptionsId;                          // 35       SpellClassOptions.dbc
        public uint SpellCooldownsId;                             // 36       SpellCooldowns.dbc
        public uint UnkIndex7;                                    // 37       all zeros...
        public uint SpellEquippedItemsId;                         // 38       SpellEquippedItems.dbc
        public uint SpellInterruptsId;                            // 39       SpellInterrupts.dbc
        public uint SpellLevelsId;                                // 40       SpellLevels.dbc
        public uint SpellPowerId;                                 // 41       SpellPower.dbc
        public uint SpellReagentsId;                              // 42       SpellReagents.dbc
        public uint SpellShapeshiftId;                            // 43       SpellShapeshift.dbc
        public uint SpellTargetRestrictionsId;                    // 44       SpellTargetRestrictions.dbc
        public uint SpellTotemsId;                                // 45       SpellTotems.dbc
        public uint ResearchProject;                              // 46       ResearchProject.dbc

        public string Range
        {
            get
            {
                if (RangeIndex == 0 || !DBC.SpellRange.ContainsKey(RangeIndex))
                    return String.Empty;

                var range = DBC.SpellRange[RangeIndex];
                var sb = new StringBuilder(128);
                sb.AppendFormat("SpellRange: (Id {0}) \"{1}\":\r\n", range.ID, range.Description1);
                sb.AppendFormat("    MinRange = {0}, MinRangeFriendly = {1}\r\n", range.MinRange, range.MinRangeFriendly);
                sb.AppendFormat("    MaxRange = {0}, MaxRangeFriendly = {1}\r\n", range.MaxRange, range.MaxRangeFriendly);

                return sb.ToString();
            }
        }

        public string GetRadius(uint index)
        {
            uint rIndex = GetEffect(index).EffectRadiusIndex;
            if (rIndex != 0)
            {
                if (DBC.SpellRadius.ContainsKey(rIndex))
                    return String.Format("Radius (Id {0}) {1:F}", rIndex, DBC.SpellRadius[rIndex].Radius);
                else
                    return String.Format("Radius (Id {0}) Not found", rIndex);
            }
            return String.Empty;
        }

        public SpellEffectEntry GetEffect(uint index)
        {
            if (DBC.SpellEffects.ContainsKey(ID))
                if (DBC.SpellEffects[ID].ContainsKey(index))
                    return DBC.SpellEffects[ID][index];

            return new SpellEffectEntry();
        }

        public string Reagents
        {
            get
            {
                if (SpellReagentsId == 0)
                    return string.Empty;

                SpellReagentsEntry reagents;
                if (!DBC.SpellReagents.TryGetValue(SpellReagentsId, out reagents))
                    return "Reagents: Not Found Id " + SpellReagentsId;

                StringBuilder builder = new StringBuilder();

                bool printedHeader = false;
                for (int i = 0; i < reagents.Reagent.Length; ++i)
                {
                    if (reagents.Reagent[i] == 0)
                        continue;

                    if (!printedHeader)
                    {
                        builder.AppendLine();
                        builder.Append("Reagents:");
                        printedHeader = true;
                    }

                    builder.AppendFormat("  {0}x{1}", reagents.Reagent[i], reagents.ReagentCount[i]);
                }

                if (printedHeader)
                {
                    builder.AppendLine();
                    builder.AppendLine();
                }

                return builder.ToString();
            }
        }
    };

}
