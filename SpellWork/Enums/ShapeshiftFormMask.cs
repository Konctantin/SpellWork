using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum ShapeshiftFormMask
    {
        FORM_ALL                = -1,
        FORM_NONE               = 0,
        FORM_CAT                = 1 << 0x00,    // 1
        FORM_TREE               = 1 << 0x01,    // 2
        FORM_TRAVEL             = 1 << 0x02,    // 3
        FORM_AQUA               = 1 << 0x03,    // 4
        FORM_BEAR               = 1 << 0x04,    // 5
        FORM_AMBIENT            = 1 << 0x05,    // 6
        FORM_GHOUL              = 1 << 0x06,    // 7
        FORM_DIREBEAR           = 1 << 0x07,    // 8
        FORM_STEVES_GHOUL       = 1 << 0x08,    // 9
        FORM_THARONJA_SKELETON  = 1 << 0x09,    // 10
        FORM_TEST_OF_STRENGTH   = 1 << 0x0A,    // 11
        FORM_BLB_PLAYER         = 1 << 0x0B,    // 12
        FORM_SHADOW_DANCE       = 1 << 0x0C,    // 13
        FORM_CREATUREBEAR       = 1 << 0x0D,    // 14
        FORM_CREATURECAT        = 1 << 0x0E,    // 15
        FORM_GHOSTWOLF          = 1 << 0x0F,    // 16
        FORM_BATTLESTANCE       = 1 << 0x10,    // 17
        FORM_DEFENSIVESTANCE    = 1 << 0x11,    // 18
        FORM_BERSERKERSTANCE    = 1 << 0x12,    // 19
        FORM_TEST               = 1 << 0x13,    // 20
        FORM_ZOMBIE             = 1 << 0x14,    // 21
        FORM_METAMORPHOSIS      = 1 << 0x15,    // 22
        FORM_UNK1               = 1 << 0x16,    // 23
        FORM_UNK2               = 1 << 0x17,    // 24
        FORM_UNDEAD             = 1 << 0x18,    // 25
        FORM_FRENZY             = 1 << 0x19,    // 26
        FORM_FLIGHT_EPIC        = 1 << 0x1A,    // 27
        FORM_SHADOW             = 1 << 0x1B,    // 28
        FORM_FLIGHT             = 1 << 0x1C,    // 29
        FORM_STEALTH            = 1 << 0x1D,    // 30
        FORM_MOONKIN            = 1 << 0x1E,    // 31
        FORM_SPIRITOFREDEMPTION = 1 << 0x1F,    // 32
    };
}
