using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;
using SpellWork.Enums;

namespace SpellWork.Dbc
{
    // Spell.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellEntry
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

        
        public uint ID { get {return m_ID; } }
        public uint uAttributes { get { return m_Attributes; } } 			     // 1        m_attribute
        public uint uAttributesEx1 { get { return m_AttributesEx; } } 			 // 2        m_attributesEx
        public uint uAttributesEx2 { get { return m_AttributesEx2; } } 			 // 3        m_attributesExB
        public uint uAttributesEx3 { get { return m_AttributesEx3; } } 			 // 4        m_attributesExC
        public uint uAttributesEx4 { get { return m_AttributesEx4; } } 			 // 5        m_attributesExD
        public uint uAttributesEx5 { get { return m_AttributesEx5; } } 			 // 6        m_attributesExE
        public uint uAttributesEx6 { get { return m_AttributesEx6; } } 			 // 7        m_attributesExF
        public uint uAttributesEx7 { get { return m_AttributesEx7; } } 			 // 8        3.2.0 (0x20 - totems, 0x4 - paladin auras, etc...)
        public uint uAttributesEx8 { get { return m_AttributesEx8; } } 			 // 7        m_attributesExF
        public SpellAtribute    Attributes    { get { return (SpellAtribute)m_Attributes; } }
        public SpellAtributeEx  AttributesEx1 { get { return (SpellAtributeEx)m_AttributesEx; } }
        public SpellAtributeEx2 AttributesEx2 { get { return (SpellAtributeEx2)m_AttributesEx2; } }
        public SpellAtributeEx3 AttributesEx3 { get { return (SpellAtributeEx3)m_AttributesEx3; } }
        public SpellAtributeEx4 AttributesEx4 { get { return (SpellAtributeEx4)m_AttributesEx4; } }
        public SpellAtributeEx5 AttributesEx5 { get { return (SpellAtributeEx5)m_AttributesEx5; } }
        public SpellAtributeEx6 AttributesEx6 { get { return (SpellAtributeEx6)m_AttributesEx6; } }
        public SpellAtributeExG AttributesEx7 { get { return (SpellAtributeExG)m_AttributesEx7; } }
        //public SpellAtribute AttributesEx8 { get { return (SpellAtributeEx8)m_AttributesEx8; } } 
        public uint SomeFlags { get { return m_SomeFlags; } } 			         // 9        4.0.0
        public uint CastingTimeIndex { get { return m_CastingTimeIndex; } } 	 // 11       m_castingTimeIndex
        public uint DurationIndex { get { return m_DurationIndex; } } 			 // 12       m_durationIndex
        public uint PowerType { get { return m_PowerType; } } 			         // 13       m_powerType
        public uint RangeIndex { get { return m_RangeIndex; } } 			     // 14       m_rangeIndex
        public float Speed { get { return m_Speed; } } 			                 // 15       m_speed
        public uint SpellIconID { get { return m_SpellIconID; } } 			     // 18       m_spellIconID
        public uint ActiveIconID { get { return m_ActiveIconID; } } 			 // 19       m_activeIconID
        public uint SchoolMask { get { return m_SchoolMask; } }

        /// <summary>
        /// Return current Spell Name
        /// </summary>
        public string SpellName
        {
            get { return _SpellName; }
        }


        /// <summary>
        /// Return current Spell Rank
        /// </summary>
        public string Rank
        {
            get { return _Rank; }
        }

        public string SpellNameRank
        {
            get { return string.IsNullOrWhiteSpace(Rank) ? SpellName : String.Format("{0} ({1})", SpellName, Rank); }
        }

        /// <summary>
        /// Return current Spell Description
        /// </summary>
        public string Description
        {
            get { return _Description; }
        }

        /// <summary>
        /// Return current Spell ToolTip
        /// </summary>
        public string ToolTip
        {
            get { return _ToolTip; }
        }

        public ProcFlags ProcInfo
        {
            #warning need reimplement resource converter
            get { return (ProcFlags)SpellAuraOptions.ProcFlags; }                
        }

        public string Duration
        {
            get { return DBC.SpellDuration.ContainsKey(DurationIndex) ? DBC.SpellDuration[DurationIndex].ToString() : string.Empty; }
        }

        public string Range
        {
            get
            {
                if (RangeIndex == 0 || !DBC.SpellRange.ContainsKey(RangeIndex))
                    return String.Empty;

                SpellRangeEntry range = DBC.SpellRange[RangeIndex];
                StringBuilder sb = new StringBuilder(128);
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

        public bool HasEffectAtIndex(uint index)
        {
            try
            {
                var value = DBC.SpellEffects[ID][index];
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool HasSpellEffect(int effect)
        {
            try
            {
                var value = DBC.SpellEffects[ID];
                foreach (var eff in value)
                {
                    if (eff.Value.Effect == effect)
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool HasSpellAura(int aura)
        {
            try
            {
                var value = DBC.SpellEffects[ID];
                foreach (var eff in value)
                {
                    if (eff.Value.EffectApplyAuraName == aura)
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool HasSpellTargetA(int target)
        {
            try
            {
                var value = DBC.SpellEffects[ID];
                foreach (var eff in value)
                {
                    if (eff.Value.EffectImplicitTargetA == target)
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool HasSpellTargetB(int target)
        {
            try
            {
                var value = DBC.SpellEffects[ID];
                foreach (var eff in value)
                {
                    if (eff.Value.EffectImplicitTargetB == target)
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public SpellEffectEntry GetEffect(uint index)
        {
            if (DBC.SpellEffects.ContainsKey(ID))
                if (DBC.SpellEffects[ID].ContainsKey(index))
                    return DBC.SpellEffects[ID][index];

            return default(SpellEffectEntry);
        }

        public string CastTime
        {
            get
            {
                if (CastingTimeIndex == 0)
                    return String.Empty;

                if (!DBC.SpellCastTimes.ContainsKey(CastingTimeIndex))
                    return String.Format("CastingTime (Id {0}) = ????", CastingTimeIndex);
                else
                    return String.Format("CastingTime (Id {0}) = {1:F}",
                        CastingTimeIndex, DBC.SpellCastTimes[CastingTimeIndex].CastTime / 1000.0f);
            }
        }

        public string SpellDifficulty
        {
            get
            {
                if (SpellDifficultyId == 0)
                    return string.Empty;

                StringBuilder builder = new StringBuilder("Spell Difficulty Id: " + SpellDifficultyId);

                SpellDifficultyEntry entry;
                if (DBC.SpellDifficulty.TryGetValue(SpellDifficultyId, out entry))
                {
                    builder.AppendLine();

                    for (int i = 0; i < entry.Spells.Length; ++i)
                    {
                        int spellId = entry.Spells[i];

                        builder.AppendFormat("    {0}) {1} - ", i, spellId);

                        SpellEntry spell;
                        if (DBC.Spell.TryGetValue((uint)spellId, out spell))
                            builder.AppendLine(spell.SpellNameRank);
                        else
                            builder.AppendLine("(Not Found in Spell.dbc)");
                    }
                }
                else
                    builder.AppendLine(" (Not Found in SpellDifficulty.dbc)");

                return builder.ToString();
            }
        }

        public SpellSchoolMask School
        {
            get { return (SpellSchoolMask)m_SchoolMask; }
        }

        public SpellTargetRestrictionsEntry SpellTargetRestrictions
        {
            get { return DBC.SpellTargetRestrictions.GetValueOrDefault(SpellTargetRestrictionsId); }
        }

        public SpellAuraRestrictionsEntry SpellAuraRestrictions
        {
            get { return DBC.SpellAuraRestrictions.GetValueOrDefault(SpellAuraRestrictionsId); }
        }

        public SpellCooldownsEntry SpellCooldowns
        {
            get { return DBC.SpellCooldowns.GetValueOrDefault(SpellCooldownsId); }
        }

        public SpellCategoriesEntry SpellCategories
        {
            get { return DBC.SpellCategories.GetValueOrDefault(SpellCategoriesId); }
        }

        public SpellShapeshiftEntry SpellShapeshift
        {
            get { return DBC.SpellShapeshift.GetValueOrDefault(SpellShapeshiftId); }
        }

        public SpellAuraOptionsEntry SpellAuraOptions
        {
            get { return DBC.SpellAuraOptions.GetValueOrDefault(SpellAuraOptionsId); }
        }

        public SpellLevelsEntry SpellLevels
        {
            get { return DBC.SpellLevels.GetValueOrDefault(SpellLevelsId); }
        }

        public uint SpellFamilyName
        {
            get
            {
                SpellClassOptionsEntry r;
                if (DBC.SpellClassOptions.TryGetValue(SpellClassOptionsId, out r))
                    return r.SpellFamilyName;
                return 0xFFFFFFFF;
            }
        }

        public SpellClassOptionsEntry SpellClassOptions
        {
            get { return DBC.SpellClassOptions.GetValueOrDefault(SpellClassOptionsId); }
        }

        public SpellCastingRequirementsEntry SpellCastingRequirements
        {
            get { return DBC.SpellCastingRequirements.GetValueOrDefault(SpellCastingRequirementsId); }
        }

        public SpellPowerEntry SpellPower
        {
            get { return DBC.SpellPower.GetValueOrDefault(SpellPowerId);  }
        }

        public SpellInterruptsEntry SpellInterrupts
        {
            get { return DBC.SpellInterrupts.GetValueOrDefault(SpellInterruptsId); }
        }

        public SpellEquippedItemsEntry SpellEquippedItems
        {
            get { return DBC.SpellEquippedItems.GetValueOrDefault(SpellEquippedItemsId); }
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
