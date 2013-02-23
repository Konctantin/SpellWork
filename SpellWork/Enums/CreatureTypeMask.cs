using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum CreatureTypeMask
    {
        ALL             = -1,
        NONE            = 0,
        BEAST           = 1 << 00,
        DRAGONKIN       = 1 << 01,
        DEMON           = 1 << 02,
        ELEMENTAL       = 1 << 03,
        GIANT           = 1 << 04,
        UNDEAD          = 1 << 05,
        HUMANOID        = 1 << 06,
        CRITTER         = 1 << 07,
        MECHANICAL      = 1 << 08,
        NOT_SPECIFIED   = 1 << 09,
        TOTEM           = 1 << 10,
        NON_COMBAT_PET  = 1 << 11,
        GAS_CLOUD       = 1 << 12,
    };
}
