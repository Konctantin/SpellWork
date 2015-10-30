namespace SpellWork.Enums
{
    public enum SpellModOp
    {
        DAMAGE                    = 0,
        DURATION                  = 1,
        THREAT                    = 2,
        EFFECT1                   = 3,
        CHARGES                   = 4,
        RANGE                     = 5,
        RADIUS                    = 6,
        CRITICAL_CHANCE           = 7,
        ALL_EFFECTS               = 8,
        NOT_LOSE_CASTING_TIME     = 9,
        CASTING_TIME              = 10,
        COOLDOWN                  = 11,
        EFFECT2                   = 12,
        IGNORE_ARMOR              = 13,
        COST                      = 14, // Used when SpellPowerEntry::PowerIndex == 0
        CRIT_DAMAGE_BONUS         = 15,
        RESIST_MISS_CHANCE        = 16,
        JUMP_TARGETS              = 17,
        CHANCE_OF_SUCCESS         = 18,
        ACTIVATION_TIME           = 19,
        DAMAGE_MULTIPLIER         = 20,
        GLOBAL_COOLDOWN           = 21,
        DOT                       = 22,
        EFFECT3                   = 23,
        BONUS_MULTIPLIER          = 24,
        PROC_PER_MINUTE           = 26,
        VALUE_MULTIPLIER          = 27,
        RESIST_DISPEL_CHANCE      = 28,
        CRIT_DAMAGE_BONUS_2       = 29, //one not used spell
        SPELL_COST_REFUND_ON_FAIL = 30,
        STACK_AMOUNT              = 31, // has no effect on tooltip parsing
        EFFECT4                   = 32,
        EFFECT5                   = 33,
        SPELL_COST2               = 34, // Used when SpellPowerEntry::PowerIndex == 1
        JUMP_DISTANCE             = 35,
        STACK_AMOUNT2             = 37  // same as SPELLMOD_STACK_AMOUNT but affects tooltips
    };
}
