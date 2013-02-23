using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum InventoryTypeMask
    {
        ALL             = -1,
        NON_EQUIP       = 1 << 00,
        HEAD            = 1 << 01,
        NECK            = 1 << 02,
        SHOULDERS       = 1 << 03,
        BODY            = 1 << 04,
        CHEST           = 1 << 05,
        WAIST           = 1 << 06,
        LEGS            = 1 << 07,
        FEET            = 1 << 08,
        WRISTS          = 1 << 09,
        HANDS           = 1 << 10,
        FINGER          = 1 << 11,
        TRINKET         = 1 << 12,
        WEAPON          = 1 << 13,
        SHIELD          = 1 << 14,
        RANGED          = 1 << 15,
        CLOAK           = 1 << 16,
        WEAPON_2H       = 1 << 17,
        BAG             = 1 << 18,
        TABARD          = 1 << 19,
        ROBE            = 1 << 20,
        WEAPONMAINHAND  = 1 << 21,
        WEAPONOFFHAND   = 1 << 22,
        HOLDABLE        = 1 << 23,
        AMMO            = 1 << 24,
        THROWN          = 1 << 25,
        RANGEDRIGHT     = 1 << 26,
        QUIVER          = 1 << 27,
        RELIC           = 1 << 28,
    };
}
