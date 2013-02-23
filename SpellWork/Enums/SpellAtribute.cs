using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellAtribute
    {
        SPELL_ATTR_ALL                            =        -1,
        SPELL_ATTR_NONE                           =      0x00,  
        SPELL_ATTR_UNK0                           = 1 << 0x00,            // 0
        SPELL_ATTR_RANGED                         = 1 << 0x01,            // 1 All ranged abilites have this flag
        SPELL_ATTR_ON_NEXT_SWING_1                = 1 << 0x02,            // 2 on next swing
        SPELL_ATTR_UNK3                           = 1 << 0x03,            // 3 not set in 3.0.3
        SPELL_ATTR_UNK4                           = 1 << 0x04,            // 4 isAbility
        SPELL_ATTR_TRADESPELL                     = 1 << 0x05,            // 5 trade spells, will be added by client to a sublist of profession spell
        SPELL_ATTR_PASSIVE                        = 1 << 0x06,            // 6 Passive spell
        SPELL_ATTR_UNK7                           = 1 << 0x07,            // 7 can't be linked in chat?
        SPELL_ATTR_UNK8                           = 1 << 0x08,            // 8 hide created item in tooltip (for effect=24)
        SPELL_ATTR_UNK9                           = 1 << 0x09,            // 9
        SPELL_ATTR_ON_NEXT_SWING_2                = 1 << 0x0A,            // 10 on next swing 2
        SPELL_ATTR_UNK11                          = 1 << 0x0B,            // 11
        SPELL_ATTR_DAYTIME_ONLY                   = 1 << 0x0C,            // 12 only useable at daytime, not set in 2.4.2
        SPELL_ATTR_NIGHT_ONLY                     = 1 << 0x0D,            // 13 only useable at night, not set in 2.4.2
        SPELL_ATTR_INDOORS_ONLY                   = 1 << 0x0E,            // 14 only useable indoors, not set in 2.4.2
        SPELL_ATTR_OUTDOORS_ONLY                  = 1 << 0x0F,            // 15 Only useable outdoors.
        SPELL_ATTR_NOT_SHAPESHIFT                 = 1 << 0x10,            // 16 Not while shapeshifted
        SPELL_ATTR_ONLY_STEALTHED                 = 1 << 0x11,            // 17 Must be in stealth
        SPELL_ATTR_UNK18                          = 1 << 0x12,            // 18
        SPELL_ATTR_LEVEL_DAMAGE_CALCULATION       = 1 << 0x13,            // 19 spelldamage depends on caster level
        SPELL_ATTR_STOP_ATTACK_TARGET             = 1 << 0x14,            // 20 Stop attack after use this spell (and not begin attack if use)
        SPELL_ATTR_IMPOSSIBLE_DODGE_PARRY_BLOCK   = 1 << 0x15,            // 21 Cannot be dodged/parried/blocked
        SPELL_ATTR_UNK22                          = 1 << 0x16,            // 22
        SPELL_ATTR_UNK23                          = 1 << 0x17,            // 23 castable while dead?
        SPELL_ATTR_CASTABLE_WHILE_MOUNTED         = 1 << 0x18,            // 24 castable while mounted
        SPELL_ATTR_DISABLED_WHILE_ACTIVE          = 1 << 0x19,            // 25 Activate and start cooldown after aura fade or remove summoned creature or go
        SPELL_ATTR_UNK26                          = 1 << 0x1A,            // 26
        SPELL_ATTR_CASTABLE_WHILE_SITTING         = 1 << 0x1B,            // 27 castable while sitting
        SPELL_ATTR_CANT_USED_IN_COMBAT            = 1 << 0x1C,            // 28 Cannot be used in combat
        SPELL_ATTR_UNAFFECTED_BY_INVULNERABILITY  = 1 << 0x1D,            // 29 unaffected by invulnerability (hmm possible not...)
        SPELL_ATTR_UNK30                          = 1 << 0x1E,            // 30 breakable by damage?
        SPELL_ATTR_CANT_CANCEL                    = 1 << 0x1F,            // 31 positive aura can't be canceled
    };
}
