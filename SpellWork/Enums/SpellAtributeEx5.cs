using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellAtributeEx5
    {
        SPELL_ATTR_EX5_ALL                        =        -1,
        SPELL_ATTR_EX5_NONE                       =      0x00,
        SPELL_ATTR_EX5_UNK0                       = 1 << 0x00,            // 0
        SPELL_ATTR_EX5_NO_REAGENT_WHILE_PREP      = 1 << 0x01,            // 1 not need reagents if UNIT_FLAG_PREPARATION
        SPELL_ATTR_EX5_UNK2                       = 1 << 0x02,            // 2 removed at enter arena (e.g. 31850 since 3.3.3)
        SPELL_ATTR_EX5_USABLE_WHILE_STUNNED       = 1 << 0x03,            // 3 usable while stunned
        SPELL_ATTR_EX5_UNK4                       = 1 << 0x04,            // 4
        SPELL_ATTR_EX5_SINGLE_TARGET_SPELL        = 1 << 0x05,            // 5 Only one target can be apply at a time
        SPELL_ATTR_EX5_UNK6                       = 1 << 0x06,            // 6
        SPELL_ATTR_EX5_UNK7                       = 1 << 0x07,            // 7
        SPELL_ATTR_EX5_UNK8                       = 1 << 0x08,            // 8
        SPELL_ATTR_EX5_START_PERIODIC_AT_APPLY    = 1 << 0x09,            // 9  begin periodic tick at aura apply
        SPELL_ATTR_EX5_UNK10                      = 1 << 0x0A,            // 10
        SPELL_ATTR_EX5_UNK11                      = 1 << 0x0B,            // 11
        SPELL_ATTR_EX5_UNK12                      = 1 << 0x0C,            // 12
        SPELL_ATTR_EX5_UNK13                      = 1 << 0x0D,            // 13 haste affects duration (e.g. 8050 since 3.3.3)
        SPELL_ATTR_EX5_UNK14                      = 1 << 0x0E,            // 14
        SPELL_ATTR_EX5_UNK15                      = 1 << 0x0F,            // 15
        SPELL_ATTR_EX5_UNK16                      = 1 << 0x10,            // 16
        SPELL_ATTR_EX5_USABLE_WHILE_FEARED        = 1 << 0x11,            // 17 usable while feared
        SPELL_ATTR_EX5_USABLE_WHILE_CONFUSED      = 1 << 0x12,            // 18 usable while confused
        SPELL_ATTR_EX5_UNK19                      = 1 << 0x13,            // 19
        SPELL_ATTR_EX5_UNK20                      = 1 << 0x14,            // 20
        SPELL_ATTR_EX5_UNK21                      = 1 << 0x15,            // 21
        SPELL_ATTR_EX5_UNK22                      = 1 << 0x16,            // 22
        SPELL_ATTR_EX5_UNK23                      = 1 << 0x17,            // 23
        SPELL_ATTR_EX5_UNK24                      = 1 << 0x18,            // 24
        SPELL_ATTR_EX5_UNK25                      = 1 << 0x19,            // 25
        SPELL_ATTR_EX5_UNK26                      = 1 << 0x1A,            // 26
        SPELL_ATTR_EX5_UNK27                      = 1 << 0x1B,            // 27
        SPELL_ATTR_EX5_UNK28                      = 1 << 0x1C,            // 28
        SPELL_ATTR_EX5_UNK29                      = 1 << 0x1D,            // 29
        SPELL_ATTR_EX5_UNK30                      = 1 << 0x1E,            // 30
        SPELL_ATTR_EX5_UNK31                      = 1 << 0x1F,            // 31 Forces all nearby enemies to focus attacks caster
    };
}
