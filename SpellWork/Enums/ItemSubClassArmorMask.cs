using System;

namespace SpellWork.Enums
{
    [Flags]
    public enum ItemSubClassArmorMask
    {
        ALL     = -1,
        MISC    = 1 << 00,
        CLOTH   = 1 << 01,
        LEATHER = 1 << 02,
        MAIL    = 1 << 03,
        PLATE   = 1 << 04,
        BUCKLER = 1 << 05,
        SHIELD  = 1 << 06,
        LIBRAM  = 1 << 07,
        IDOL    = 1 << 08,
        TOTEM   = 1 << 09,
        SIGIL   = 1 << 10,
    };
}
