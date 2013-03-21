using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellSchoolMask : uint
    {
        MASK_NONE      = 0x00,                         // not exist
        MASK_PHYSICAL  = (1 << SpellSchools.PHYSICAL), // PHYSICAL (Armor)
        MASK_HOLY      = (1 << SpellSchools.HOLY),
        MASK_FIRE      = (1 << SpellSchools.FIRE),
        MASK_NATURE    = (1 << SpellSchools.NATURE),
        MASK_FROST     = (1 << SpellSchools.FROST),
        MASK_SHADOW    = (1 << SpellSchools.SHADOW),
        MASK_ARCANE    = (1 << SpellSchools.ARCANE),
    };
}
