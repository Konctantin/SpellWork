using System;

namespace SpellWork.Enums
{
    [Flags]
    public enum SpellCastTargetFlags : uint
    {
        NONE            = 0x00000000,
        UNUSED_1        = 0x00000001,               // not used
        UNIT            = 0x00000002,               // pguid
        UNIT_RAID       = 0x00000004,               // not sent, used to validate target (if raid member)
        UNIT_PARTY      = 0x00000008,               // not sent, used to validate target (if party member)
        ITEM            = 0x00000010,               // pguid
        SOURCE_LOCATION = 0x00000020,               // pguid, 3 float
        DEST_LOCATION   = 0x00000040,               // pguid, 3 float
        UNIT_ENEMY      = 0x00000080,               // not sent, used to validate target (if enemy)
        UNIT_ALLY       = 0x00000100,               // not sent, used to validate target (if ally)
        CORPSE_ENEMY    = 0x00000200,               // pguid
        UNIT_DEAD       = 0x00000400,               // not sent, used to validate target (if dead creature)
        GAMEOBJECT      = 0x00000800,               // pguid, used with TARGET_GAMEOBJECT_TARGET
        TRADE_ITEM      = 0x00001000,               // pguid
        STRING          = 0x00002000,               // string
        GAMEOBJECT_ITEM = 0x00004000,               // not sent, used with TARGET_GAMEOBJECT_ITEM_TARGET
        CORPSE_ALLY     = 0x00008000,               // pguid
        UNIT_MINIPET    = 0x00010000,               // pguid, used to validate target (if non combat pet)
        GLYPH_SLOT      = 0x00020000,               // used in glyph spells
        DEST_TARGET     = 0x00040000,               // sometimes appears with DEST_TARGET spells (may appear or not for a given spell)
        EXTRA_TARGETS   = 0x00080000,               // uint32 counter, loop { vec3 - screen position (?), guid }, not used so far
        UNIT_PASSENGER  = 0x00100000,               // guessed, used to validate target (if vehicle passenger)
        UNK400000       = 0X00400000,
        UNK1000000      = 0X01000000,
        UNK4000000      = 0X04000000,
        UNK10000000     = 0X10000000,
        UNK40000000     = 0X40000000,
    };
}
