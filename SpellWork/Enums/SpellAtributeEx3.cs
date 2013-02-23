using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellAtributeEx3
    {
        SPELL_ATTR_EX3_ALL                        =        -1,
        SPELL_ATTR_EX3_NONE                       =      0x00,
        SPELL_ATTR_EX3_UNK0                       = 1 << 0x00,            // 0
        SPELL_ATTR_EX3_UNK1                       = 1 << 0x01,            // 1
        SPELL_ATTR_EX3_UNK2                       = 1 << 0x02,            // 2
        SPELL_ATTR_EX3_UNK3                       = 1 << 0x03,            // 3
        SPELL_ATTR_EX3_UNK4                       = 1 << 0x04,            // 4 Druid Rebirth only this spell have this flag
        SPELL_ATTR_EX3_UNK5                       = 1 << 0x05,            // 5
        SPELL_ATTR_EX3_UNK6                       = 1 << 0x06,            // 6
        SPELL_ATTR_EX3_UNK7                       = 1 << 0x07,            // 7 create a separate (de)buff stack for each caster
        SPELL_ATTR_EX3_UNK8                       = 1 << 0x08,            // 8
        SPELL_ATTR_EX3_UNK9                       = 1 << 0x09,            // 9
        SPELL_ATTR_EX3_MAIN_HAND                  = 1 << 0x0A,            // 10 Main hand weapon required
        SPELL_ATTR_EX3_BATTLEGROUND               = 1 << 0x0B,            // 11 Can casted only on battleground
        SPELL_ATTR_EX3_CAST_ON_DEAD               = 1 << 0x0C,            // 12 target is a dead player (not every spell has this flag)
        SPELL_ATTR_EX3_UNK13                      = 1 << 0x0D,            // 13
        SPELL_ATTR_EX3_UNK14                      = 1 << 0x0E,            // 14 "Honorless Target" only this spells have this flag
        SPELL_ATTR_EX3_UNK15                      = 1 << 0x0F,            // 15 Auto Shoot, Shoot, Throw,  - this is autoshot flag
        SPELL_ATTR_EX3_UNK16                      = 1 << 0x10,            // 16 no triggers effects that trigger on casting a spell??
        SPELL_ATTR_EX3_UNK17                      = 1 << 0x11,            // 17 no triggers effects that trigger on casting a spell??
        SPELL_ATTR_EX3_UNK18                      = 1 << 0x12,            // 18
        SPELL_ATTR_EX3_UNK19                      = 1 << 0x13,            // 19
        SPELL_ATTR_EX3_DEATH_PERSISTENT           = 1 << 0x14,            // 20 Death persistent spells
        SPELL_ATTR_EX3_UNK21                      = 1 << 0x15,            // 21
        SPELL_ATTR_EX3_REQ_WAND                   = 1 << 0x16,            // 22 Req wand
        SPELL_ATTR_EX3_UNK23                      = 1 << 0x17,            // 23
        SPELL_ATTR_EX3_REQ_OFFHAND                = 1 << 0x18,            // 24 Req offhand weapon
        SPELL_ATTR_EX3_UNK25                      = 1 << 0x19,            // 25 no cause spell pushback ?
        SPELL_ATTR_EX3_UNK26                      = 1 << 0x1A,            // 26
        SPELL_ATTR_EX3_UNK27                      = 1 << 0x1B,            // 27
        SPELL_ATTR_EX3_UNK28                      = 1 << 0x1C,            // 28
        SPELL_ATTR_EX3_UNK29                      = 1 << 0x1D,            // 29
        SPELL_ATTR_EX3_UNK30                      = 1 << 0x1E,            // 30
        SPELL_ATTR_EX3_UNK31                      = 1 << 0x1F,            // 31
    };
}
