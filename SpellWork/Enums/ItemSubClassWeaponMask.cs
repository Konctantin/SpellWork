using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
     [Flags]
    public enum ItemSubClassWeaponMask
    {
        ALL             = -1,
        AXE             = 1 << 00,
        AXE2            = 1 << 01,
        BOW             = 1 << 02,
        GUN             = 1 << 03,
        MACE            = 1 << 04,
        MACE2           = 1 << 05,
        POLEARM         = 1 << 06,
        SWORD           = 1 << 07,
        SWORD2          = 1 << 08,
        obsolete        = 1 << 09,
        STAFF           = 1 << 10,
        EXOTIC          = 1 << 11,
        EXOTIC2         = 1 << 12,
        FIST            = 1 << 13,
        MISC            = 1 << 14,
        DAGGER          = 1 << 15,
        THROWN          = 1 << 16,
        SPEAR           = 1 << 17,
        CROSSBOW        = 1 << 18,
        WAND            = 1 << 19,
        FISHING_POLE    = 1 << 20
    };
}
