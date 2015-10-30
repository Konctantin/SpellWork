using System;

namespace SpellWork.Enums
{
    public enum SpellSchools
    {
        PHYSICAL   = 0,
        HOLY       = 1,
        FIRE       = 2,
        NATURE     = 3,
        FROST      = 4,
        SHADOW     = 5,
        ARCANE     = 6
    };

    [Flags]
    public enum SpellSchoolMask : uint
    {
        NONE       = 0x00,                         // not exist
        PHYSICAL   = (1 << SpellSchools.PHYSICAL), // PHYSICAL (Armor)
        HOLY       = (1 << SpellSchools.HOLY),
        FIRE       = (1 << SpellSchools.FIRE),
        NATURE     = (1 << SpellSchools.NATURE),
        FROST      = (1 << SpellSchools.FROST),
        SHADOW     = (1 << SpellSchools.SHADOW),
        ARCANE     = (1 << SpellSchools.ARCANE),
    };
}