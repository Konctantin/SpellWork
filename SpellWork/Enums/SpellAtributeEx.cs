using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellAtributeEx
    {
        SPELL_ATTR_EX_ALL                         =        -1,
        SPELL_ATTR_EX_NONE                        =      0x00,
        SPELL_ATTR_EX_UNK0                        = 1 << 0x00,            // 0
        SPELL_ATTR_EX_DRAIN_ALL_POWER             = 1 << 0x01,            // 1 use all power (Only paladin Lay of Hands and Bunyanize)
        SPELL_ATTR_EX_CHANNELED_1                 = 1 << 0x02,            // 2 channeled 1
        SPELL_ATTR_EX_UNK3                        = 1 << 0x03,            // 3
        SPELL_ATTR_EX_UNK4                        = 1 << 0x04,            // 4
        SPELL_ATTR_EX_NOT_BREAK_STEALTH           = 1 << 0x05,            // 5 Not break stealth
        SPELL_ATTR_EX_CHANNELED_2                 = 1 << 0x06,            // 6 channeled 2
        SPELL_ATTR_EX_NEGATIVE                    = 1 << 0x07,            // 7
        SPELL_ATTR_EX_NOT_IN_COMBAT_TARGET        = 1 << 0x08,            // 8 Spell req target not to be in combat state
        SPELL_ATTR_EX_UNK9                        = 1 << 0x09,            // 9
        SPELL_ATTR_EX_NO_INITIAL_AGGRO            = 1 << 0x0A,            // 10 no generates threat on cast 100%
        SPELL_ATTR_EX_UNK11                       = 1 << 0x0B,            // 11
        SPELL_ATTR_EX_UNK12                       = 1 << 0x0C,            // 12
        SPELL_ATTR_EX_UNK13                       = 1 << 0x0D,            // 13
        SPELL_ATTR_EX_UNK14                       = 1 << 0x0E,            // 14
        SPELL_ATTR_EX_DISPEL_AURAS_ON_IMMUNITY    = 1 << 0x0F,            // 15 remove auras on immunity
        SPELL_ATTR_EX_UNAFFECTED_BY_SCHOOL_IMMUNE = 1 << 0x10,            // 16 unaffected by school immunity
        SPELL_ATTR_EX_UNK17                       = 1 << 0x11,            // 17
        SPELL_ATTR_EX_UNK18                       = 1 << 0x12,            // 18
        SPELL_ATTR_EX_UNK19                       = 1 << 0x13,            // 19
        SPELL_ATTR_EX_REQ_COMBO_POINTS1           = 1 << 0x14,            // 20 Req combo points on target
        SPELL_ATTR_EX_UNK21                       = 1 << 0x15,            // 21
        SPELL_ATTR_EX_REQ_COMBO_POINTS2           = 1 << 0x16,            // 22 Req combo points on target
        SPELL_ATTR_EX_UNK23                       = 1 << 0x17,            // 23
        SPELL_ATTR_EX_UNK24                       = 1 << 0x18,            // 24 Req fishing pole??
        SPELL_ATTR_EX_UNK25                       = 1 << 0x19,            // 25
        SPELL_ATTR_EX_UNK26                       = 1 << 0x1A,            // 26
        SPELL_ATTR_EX_UNK27                       = 1 << 0x1B,            // 27
        SPELL_ATTR_EX_UNK28                       = 1 << 0x1C,            // 28
        SPELL_ATTR_EX_UNK29                       = 1 << 0x1D,            // 29
        SPELL_ATTR_EX_UNK30                       = 1 << 0x1E,            // 30 overpower
        SPELL_ATTR_EX_UNK31                       = 1 << 0x1F,            // 31
    };
}
