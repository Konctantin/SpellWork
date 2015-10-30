using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpellWork.Enums;

namespace SpellWork.Dbc
{
    public partial class SpellEntry
    {
        public uint ID                  { get { return m_ID; } }
        public uint SomeFlags           { get { return m_SomeFlags; } }
        public uint CastingTimeIndex    { get { return m_CastingTimeIndex; } }
        public uint DurationIndex       { get { return m_DurationIndex; } }
        public uint PowerType           { get { return m_PowerType; } }
        public uint RangeIndex          { get { return m_RangeIndex; } }
        public float Speed              { get { return m_Speed; } }
        public uint SpellIconID         { get { return m_SpellIconID; } }
        public uint ActiveIconID        { get { return m_ActiveIconID; } }
        public uint SchoolMask          { get { return m_SchoolMask; } }

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
            get { return DBC.SpellPower.GetValueOrDefault(SpellPowerId); }
        }

        public SpellInterruptsEntry SpellInterrupts
        {
            get { return DBC.SpellInterrupts.GetValueOrDefault(SpellInterruptsId); }
        }

        public SpellEquippedItemsEntry SpellEquippedItems
        {
            get { return DBC.SpellEquippedItems.GetValueOrDefault(SpellEquippedItemsId); }
        }

        public IEnumerable<Tuple<string, uint, object>> AttributesList
        {
            get
            {
                if (m_Attributes != 0)
                    yield return new Tuple<string, uint, object>("Attributes", m_Attributes, (SpellAtributes)m_Attributes);
                if (m_AttributesEx != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx1", m_AttributesEx, (SpellAtributeEx)m_AttributesEx);
                if (m_AttributesEx2 != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx2", m_AttributesEx2, (SpellAtributeEx2)m_AttributesEx2);
                if (m_AttributesEx3 != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx3", m_AttributesEx3, (SpellAtributeEx3)m_AttributesEx3);
                if (m_AttributesEx4 != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx4", m_AttributesEx4, (SpellAtributeEx4)m_AttributesEx4);
                if (m_AttributesEx5 != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx5", m_AttributesEx5, (SpellAtributeEx5)m_AttributesEx5);
                if (m_AttributesEx6 != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx6", m_AttributesEx6, (SpellAtributeEx6)m_AttributesEx6);
                if (m_AttributesEx7 != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx7", m_AttributesEx7, (SpellAtributeEx7)m_AttributesEx7);
                if (m_AttributesEx8 != 0)
                    yield return new Tuple<string, uint, object>("AttributesEx8", m_AttributesEx8, (SpellAtributeEx8)m_AttributesEx8);
            }
        }

        public IEnumerable<SpellEffectEntry> SpellEffectList
        {
            get
            {
                if (DBC.SpellEffects.ContainsKey(ID))
                    foreach (var effect in DBC.SpellEffects[ID])
                        yield return effect.Value;
            }
        }

        public uint SpellDifficulty
        {
            get { return SpellDifficultyId; }
        }

        public IEnumerable<SpellEntry> SpellDifficultyList
        {
            get
            {
                SpellDifficultyEntry entry;
                if (DBC.SpellDifficulty.TryGetValue(SpellDifficultyId, out entry))
                    foreach (var spell in entry.SpellList)
                        yield return spell;
            }
        }

        //public string CastTime
        //{
        //    get
        //    {
        //        if (CastingTimeIndex == 0)
        //            return string.Empty;

        //        if (!DBC.SpellCastTimes.ContainsKey(CastingTimeIndex))
        //            return string.Format("CastingTime (Id {0}) = ????", CastingTimeIndex);
        //        else
        //            return string.Format("CastingTime (Id {0}) = {1:F}",
        //                CastingTimeIndex, DBC.SpellCastTimes[CastingTimeIndex].CastTime / 1000.0f);
        //    }
        //}
    }
}
