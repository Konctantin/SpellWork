using System.Collections.Generic;

namespace SpellWork.Dbc
{
    public partial class SpellEntry
    {
        public uint ID => m_ID;
        public string SpellName => m_Name;
        public string NameSubtext => m_NameSubtext;
        public string Description => m_Description;
        public string AuraDescription => m_AuraDescription;

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


        public IEnumerable<SpellEffectEntry> SpellEffects
        {
            get
            {
                foreach (var effect in DBC.SpellEffect)
                    if (effect.SpellID == m_ID)
                        yield return effect;
            }
        }

        public IEnumerable<SkillLineAbilityEntry> SkillLineAbilities
        {
            get
            {
                foreach (var skill in DBC.SkillLineAbility)
                    if (skill.SpellID == m_ID)
                        yield return skill;
            }
        }
    }
}
