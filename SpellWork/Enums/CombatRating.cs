﻿using System;

namespace SpellWork.Enums
{
    [Flags]
    public enum CombatRating
    {
        CR_WEAPON_SKILL             =      0x00,
        CR_DEFENSE_SKILL            = 1 << 0x00,
        CR_DODGE                    = 1 << 0x01,
        CR_PARRY                    = 1 << 0x02,
        CR_BLOCK                    = 1 << 0x03,
        CR_HIT_MELEE                = 1 << 0x04,
        CR_HIT_RANGED               = 1 << 0x05,
        CR_HIT_SPELL                = 1 << 0x06,
        CR_CRIT_MELEE               = 1 << 0x07,
        CR_CRIT_RANGED              = 1 << 0x08,
        CR_CRIT_SPELL               = 1 << 0x09,
        CR_HIT_TAKEN_MELEE          = 1 << 0x0A,
        CR_HIT_TAKEN_RANGED         = 1 << 0x0B,
        CR_HIT_TAKEN_SPELL          = 1 << 0x0C,
        CR_CRIT_TAKEN_MELEE         = 1 << 0x0D,
        CR_CRIT_TAKEN_RANGED        = 1 << 0x0E,
        CR_CRIT_TAKEN_SPELL         = 1 << 0x0F,
        CR_HASTE_MELEE              = 1 << 0x10,
        CR_HASTE_RANGED             = 1 << 0x11,
        CR_HASTE_SPELL              = 1 << 0x12,
        CR_WEAPON_SKILL_MAINHAND    = 1 << 0x13,
        CR_WEAPON_SKILL_OFFHAND     = 1 << 0x14,
        CR_WEAPON_SKILL_RANGED      = 1 << 0x15,
        CR_EXPERTISE                = 1 << 0x16,
        CR_ARMOR_PENETRATION        = 1 << 0x17,
    };
}
