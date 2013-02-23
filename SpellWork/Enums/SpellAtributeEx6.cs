using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellAtributeEx6
    {
        SPELL_ATTR_EX6_ALL                        =        -1,
        SPELL_ATTR_EX6_NONE                       =      0x00,
        SPELL_ATTR_EX6_UNK0                       = 1 << 0x00,            // 0 Only Move spell have this flag
        SPELL_ATTR_EX6_ONLY_IN_ARENA              = 1 << 0x01,            // 1 only usable in arena, not used in 3.2.0a and early
        SPELL_ATTR_EX6_UNK2                       = 1 << 0x02,            // 2
        SPELL_ATTR_EX6_UNK3                       = 1 << 0x03,            // 3
        SPELL_ATTR_EX6_UNK4                       = 1 << 0x04,            // 4
        SPELL_ATTR_EX6_UNK5                       = 1 << 0x05,            // 5
        SPELL_ATTR_EX6_UNK6                       = 1 << 0x06,            // 6
        SPELL_ATTR_EX6_UNK7                       = 1 << 0x07,            // 7
        SPELL_ATTR_EX6_UNK8                       = 1 << 0x08,            // 8
        SPELL_ATTR_EX6_UNK9                       = 1 << 0x09,            // 9
        SPELL_ATTR_EX6_UNK10                      = 1 << 0x0A,            // 10
        SPELL_ATTR_EX6_NOT_IN_RAID_INSTANCE       = 1 << 0x0B,            // 11 not usable in raid instance
        SPELL_ATTR_EX6_UNK12                      = 1 << 0x0C,            // 12
        SPELL_ATTR_EX6_UNK13                      = 1 << 0x0D,            // 13
        SPELL_ATTR_EX6_UNK14                      = 1 << 0x0E,            // 14
        SPELL_ATTR_EX6_UNK15                      = 1 << 0x0F,            // 15 not set in 3.0.3
        SPELL_ATTR_EX6_UNK16                      = 1 << 0x10,            // 16
        SPELL_ATTR_EX6_UNK17                      = 1 << 0x11,            // 17
        SPELL_ATTR_EX6_UNK18                      = 1 << 0x12,            // 18
        SPELL_ATTR_EX6_UNK19                      = 1 << 0x13,            // 19
        SPELL_ATTR_EX6_UNK20                      = 1 << 0x14,            // 20
        SPELL_ATTR_EX6_UNK21                      = 1 << 0x15,            // 21
        SPELL_ATTR_EX6_UNK22                      = 1 << 0x16,            // 22
        SPELL_ATTR_EX6_UNK23                      = 1 << 0x17,            // 23 not set in 3.0.3
        SPELL_ATTR_EX6_UNK24                      = 1 << 0x18,            // 24 not set in 3.0.3
        SPELL_ATTR_EX6_UNK25                      = 1 << 0x19,            // 25 not set in 3.0.3
        SPELL_ATTR_EX6_UNK26                      = 1 << 0x1A,            // 26 not set in 3.0.3
        SPELL_ATTR_EX6_UNK27                      = 1 << 0x1B,            // 27 not set in 3.0.3
        SPELL_ATTR_EX6_UNK28                      = 1 << 0x1C,            // 28 not set in 3.0.3
        SPELL_ATTR_EX6_NO_DMG_PERCENT_MODS        = 1 << 0x1D,            // 29 do not apply damage percent mods (usually in cases where it has already been applied)
        SPELL_ATTR_EX6_UNK30                      = 1 << 0x1E,            // 30 not set in 3.0.3
        SPELL_ATTR_EX6_UNK31                      = 1 << 0x1F,            // 31 not set in 3.0.3
    };
}
