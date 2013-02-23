using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellAtributeEx2
    {
        SPELL_ATTR_EX2_ALL                        =        -1,
        SPELL_ATTR_EX2_NONE                       =      0x00,
        SPELL_ATTR_EX2_UNK0                       = 1 << 0x00,            // 0
        SPELL_ATTR_EX2_UNK1                       = 1 << 0x01,            // 1
        SPELL_ATTR_EX2_CANT_REFLECTED             = 1 << 0x02,            // 2 ? used for detect can or not spell reflected // do not need LOS (e.g. 18220 since 3.3.3)
        SPELL_ATTR_EX2_UNK3                       = 1 << 0x03,            // 3 auto targeting? (e.g. fishing skill enhancement items since 3.3.3)
        SPELL_ATTR_EX2_UNK4                       = 1 << 0x04,            // 4
        SPELL_ATTR_EX2_AUTOREPEAT_FLAG            = 1 << 0x05,            // 5
        SPELL_ATTR_EX2_UNK6                       = 1 << 0x06,            // 6 only usable on tabbed by yourself
        SPELL_ATTR_EX2_UNK7                       = 1 << 0x07,            // 7
        SPELL_ATTR_EX2_UNK8                       = 1 << 0x08,            // 8 not set in 3.0.3
        SPELL_ATTR_EX2_UNK9                       = 1 << 0x09,            // 9
        SPELL_ATTR_EX2_UNK10                      = 1 << 0x0A,            // 10
        SPELL_ATTR_EX2_HEALTH_FUNNEL              = 1 << 0x0B,            // 11
        SPELL_ATTR_EX2_UNK12                      = 1 << 0x0C,            // 12
        SPELL_ATTR_EX2_UNK13                      = 1 << 0x0D,            // 13
        SPELL_ATTR_EX2_UNK14                      = 1 << 0x0E,            // 14
        SPELL_ATTR_EX2_UNK15                      = 1 << 0x0F,            // 15 not set in 3.0.3
        SPELL_ATTR_EX2_UNK16                      = 1 << 0x10,            // 16
        SPELL_ATTR_EX2_UNK17                      = 1 << 0x11,            // 17 suspend weapon timer instead of resetting it, (?Hunters Shot and Stings only have this flag?)
        SPELL_ATTR_EX2_UNK18                      = 1 << 0x12,            // 18 Only Revive pet - possible req dead pet
        SPELL_ATTR_EX2_NOT_NEED_SHAPESHIFT        = 1 << 0x13,            // 19 does not necessarly need shapeshift
        SPELL_ATTR_EX2_UNK20                      = 1 << 0x14,            // 20
        SPELL_ATTR_EX2_DAMAGE_REDUCED_SHIELD      = 1 << 0x15,            // 21 for ice blocks, pala immunity buffs, priest absorb shields, but used also for other spells -> not sure!
        SPELL_ATTR_EX2_UNK22                      = 1 << 0x16,            // 22
        SPELL_ATTR_EX2_UNK23                      = 1 << 0x17,            // 23 Only mage Arcane Concentration have this flag
        SPELL_ATTR_EX2_UNK24                      = 1 << 0x18,            // 24
        SPELL_ATTR_EX2_UNK25                      = 1 << 0x19,            // 25
        SPELL_ATTR_EX2_UNK26                      = 1 << 0x1A,            // 26 unaffected by school immunity
        SPELL_ATTR_EX2_UNK27                      = 1 << 0x1B,            // 27
        SPELL_ATTR_EX2_UNK28                      = 1 << 0x1C,            // 28 no breaks stealth if it fails??
        SPELL_ATTR_EX2_CANT_CRIT                  = 1 << 0x1D,            // 29 Spell can't crit
        SPELL_ATTR_EX2_UNK30                      = 1 << 0x1E,            // 30
        SPELL_ATTR_EX2_FOOD_BUFF                  = 1 << 0x1F,            // 31 Food or Drink Buff (like Well Fed)
    };
}
