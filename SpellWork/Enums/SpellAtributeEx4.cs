using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellAtributeEx4
    {
        SPELL_ATTR_EX4_ALL                        =        -1,
        SPELL_ATTR_EX4_NONE                       =      0x00,
        SPELL_ATTR_EX4_UNK0                       = 1 << 0x00,            // 0
        SPELL_ATTR_EX4_UNK1                       = 1 << 0x01,            // 1 proc on finishing move?
        SPELL_ATTR_EX4_UNK2                       = 1 << 0x02,            // 2
        SPELL_ATTR_EX4_UNK3                       = 1 << 0x03,            // 3
        SPELL_ATTR_EX4_UNK4                       = 1 << 0x04,            // 4 This will no longer cause guards to attack on use??
        SPELL_ATTR_EX4_UNK5                       = 1 << 0x05,            // 5
        SPELL_ATTR_EX4_NOT_STEALABLE              = 1 << 0x06,            // 6 although such auras might be dispellable, they cannot be stolen
        SPELL_ATTR_EX4_UNK7                       = 1 << 0x07,            // 7
        SPELL_ATTR_EX4_STACK_DOT_MODIFIER         = 1 << 0x08,            // 8 no effect on non DoTs?
        SPELL_ATTR_EX4_UNK9                       = 1 << 0x09,            // 9
        SPELL_ATTR_EX4_SPELL_VS_EXTEND_COST       = 1 << 0x0A,            // 10 Rogue Shiv have this flag
        SPELL_ATTR_EX4_UNK11                      = 1 << 0x0B,            // 11
        SPELL_ATTR_EX4_UNK12                      = 1 << 0x0C,            // 12
        SPELL_ATTR_EX4_UNK13                      = 1 << 0x0D,            // 13
        SPELL_ATTR_EX4_UNK14                      = 1 << 0x0E,            // 14
        SPELL_ATTR_EX4_UNK15                      = 1 << 0x0F,            // 15
        SPELL_ATTR_EX4_NOT_USABLE_IN_ARENA        = 1 << 0x10,            // 16 not usable in arena
        SPELL_ATTR_EX4_USABLE_IN_ARENA            = 1 << 0x11,            // 17 usable in arena
        SPELL_ATTR_EX4_UNK18                      = 1 << 0x12,            // 18
        SPELL_ATTR_EX4_UNK19                      = 1 << 0x13,            // 19
        SPELL_ATTR_EX4_UNK20                      = 1 << 0x14,            // 20 do not give "more powerful spell" error message
        SPELL_ATTR_EX4_UNK21                      = 1 << 0x15,            // 21
        SPELL_ATTR_EX4_UNK22                      = 1 << 0x16,            // 22
        SPELL_ATTR_EX4_UNK23                      = 1 << 0x17,            // 23
        SPELL_ATTR_EX4_UNK24                      = 1 << 0x18,            // 24
        SPELL_ATTR_EX4_UNK25                      = 1 << 0x19,            // 25 pet scaling auras
        SPELL_ATTR_EX4_CAST_ONLY_IN_OUTLAND       = 1 << 0x1A,            // 26 Can only be used in Outland.
        SPELL_ATTR_EX4_UNK27                      = 1 << 0x1B,            // 27
        SPELL_ATTR_EX4_UNK28                      = 1 << 0x1C,            // 28
        SPELL_ATTR_EX4_UNK29                      = 1 << 0x1D,            // 29
        SPELL_ATTR_EX4_UNK30                      = 1 << 0x1E,            // 30
        SPELL_ATTR_EX4_UNK31                      = 1 << 0x1F,            // 31
    };
}
