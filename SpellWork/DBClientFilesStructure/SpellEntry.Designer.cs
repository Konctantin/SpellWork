using System;
using System.Collections.Generic;

namespace SpellWork.DBClientFilesStructure
{
    public partial class SpellEntry
    {
        public SpellMiscEntry SpellMisc => DBC.SpellMisc.GetValueOrDefault(m_MiscID);

        public SpellTargetRestrictionsEntry SpellTargetRestrictions => DBC.SpellTargetRestrictions.GetValueOrDefault(m_TargetRestrictionsID);

        public SpellAuraRestrictionsEntry SpellAuraRestrictions => DBC.SpellAuraRestrictions.GetValueOrDefault(m_AuraRestrictionsID);

        public SpellClassOptionsEntry SpellClassOptions => DBC.SpellClassOptions.GetValueOrDefault(m_ClassOptionsID);

        public SpellCooldownsEntry SpellCooldowns => DBC.SpellCooldowns.GetValueOrDefault(m_CooldownsID);

        public SpellCategoriesEntry SpellCategories => DBC.SpellCategories.GetValueOrDefault(m_CategoriesID);

        public SpellShapeshiftEntry SpellShapeshift => DBC.SpellShapeshift.GetValueOrDefault(m_ShapeshiftID);

        public SpellAuraOptionsEntry SpellAuraOptions => DBC.SpellAuraOptions.GetValueOrDefault(m_AuraOptionsID);

        public SpellLevelsEntry SpellLevels => DBC.SpellLevels.GetValueOrDefault(m_LevelsID);

        public SpellCastingRequirementsEntry SpellCastingRequirements => DBC.SpellCastingRequirements.GetValueOrDefault(m_CastingRequirementsID);

        //public SpellPowerEntry SpellPower => DBC.SpellPower.GetValueOrDefault(m_)

        public SpellInterruptsEntry SpellInterrupts => DBC.SpellInterrupts.GetValueOrDefault(m_InterruptsID);

        public SpellReagentsEntry SpellReagents => DBC.SpellReagents.GetValueOrDefault(m_ReagentsID);


        public IEnumerable<Tuple<string, uint, object>> Attributes
        {
            get
            {
                var misk = SpellMisc;
                if (misk.Attributes0  != 0) yield return new Tuple<string, uint, object>("Attribute0",  (uint)misk.Attributes0,  misk.Attributes0 );
                if (misk.Attributes1  != 0) yield return new Tuple<string, uint, object>("Attribute1",  (uint)misk.Attributes1,  misk.Attributes1 );
                if (misk.Attributes2  != 0) yield return new Tuple<string, uint, object>("Attribute2",  (uint)misk.Attributes2,  misk.Attributes2 );
                if (misk.Attributes3  != 0) yield return new Tuple<string, uint, object>("Attribute3",  (uint)misk.Attributes3,  misk.Attributes3 );
                if (misk.Attributes4  != 0) yield return new Tuple<string, uint, object>("Attribute4",  (uint)misk.Attributes4,  misk.Attributes4 );
                if (misk.Attributes5  != 0) yield return new Tuple<string, uint, object>("Attribute5",  (uint)misk.Attributes5,  misk.Attributes5 );
                if (misk.Attributes6  != 0) yield return new Tuple<string, uint, object>("Attribute6",  (uint)misk.Attributes6,  misk.Attributes6 );
                if (misk.Attributes7  != 0) yield return new Tuple<string, uint, object>("Attribute7",  (uint)misk.Attributes7,  misk.Attributes7 );
                if (misk.Attributes8  != 0) yield return new Tuple<string, uint, object>("Attribute8",  (uint)misk.Attributes8,  misk.Attributes8 );
                if (misk.Attributes9  != 0) yield return new Tuple<string, uint, object>("Attribute9",  (uint)misk.Attributes9,  misk.Attributes9 );
                if (misk.Attributes10 != 0) yield return new Tuple<string, uint, object>("Attribute10", (uint)misk.Attributes10, misk.Attributes10);
                if (misk.Attributes11 != 0) yield return new Tuple<string, uint, object>("Attribute11", (uint)misk.Attributes11, misk.Attributes11);
                if (misk.Attributes12 != 0) yield return new Tuple<string, uint, object>("Attribute12", (uint)misk.Attributes12, misk.Attributes12);
                if (misk.Attributes13 != 0) yield return new Tuple<string, uint, object>("Attribute13", (uint)misk.Attributes13, misk.Attributes13);
            }
        }

        public IEnumerable<SpellEffectEntry> SpellEffects
        {
            get
            {
                foreach (var effect in DBC.SpellEffect)
                    if (effect.SpellID == ID)
                        yield return effect;
            }
        }

        public IEnumerable<SkillLineAbilityEntry> SkillLineAbilities
        {
            get
            {
                foreach (var skill in DBC.SkillLineAbility)
                    if (skill.SpellID == ID)
                        yield return skill;
            }
        }

        public IEnumerable<ItemSparseEntry> Items
        {
            get
            {
                foreach (var item in DBC.ItemSparse)
                    if (item.RequiredSpell == ID)
                        yield return item;
            }
        }
    }
}
