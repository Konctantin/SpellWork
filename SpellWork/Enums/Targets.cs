﻿namespace SpellWork.Enums
{
    /// <summary>
    /// Target
    /// </summary>
    public enum Targets
    {
        NO_FILTER = -1,
        TARGET_UNIT_CASTER                 = 1,
        TARGET_UNIT_NEARBY_ENEMY           = 2,
        TARGET_UNIT_NEARBY_PARTY           = 3,
        TARGET_UNIT_NEARBY_ALLY            = 4,
        TARGET_UNIT_PET                    = 5,
        TARGET_UNIT_TARGET_ENEMY           = 6,
        TARGET_UNIT_SRC_AREA_ENTRY         = 7,
        TARGET_UNIT_DEST_AREA_ENTRY        = 8,
        TARGET_DEST_HOME                   = 9,
        TARGET_UNIT_SRC_AREA_UNK_11        = 11,
        TARGET_UNIT_SRC_AREA_ENEMY         = 15,
        TARGET_UNIT_DEST_AREA_ENEMY        = 16,
        TARGET_DEST_DB                     = 17,
        TARGET_DEST_CASTER                 = 18,
        TARGET_UNIT_CASTER_AREA_PARTY      = 20,
        TARGET_UNIT_TARGET_ALLY            = 21,
        TARGET_SRC_CASTER                  = 22,
        TARGET_GAMEOBJECT_TARGET           = 23,
        TARGET_UNIT_CONE_ENEMY_24          = 24,
        TARGET_UNIT_TARGET_ANY             = 25,
        TARGET_GAMEOBJECT_ITEM_TARGET      = 26,
        TARGET_UNIT_MASTER                 = 27,
        TARGET_DEST_DYNOBJ_ENEMY           = 28,
        TARGET_DEST_DYNOBJ_ALLY            = 29,
        TARGET_UNIT_SRC_AREA_ALLY          = 30,
        TARGET_UNIT_DEST_AREA_ALLY         = 31,
        TARGET_DEST_CASTER_SUMMON          = 32, // front left, doesn't use radius
        TARGET_UNIT_SRC_AREA_PARTY         = 33,
        TARGET_UNIT_DEST_AREA_PARTY        = 34,
        TARGET_UNIT_TARGET_PARTY           = 35,
        TARGET_DEST_CASTER_UNK_36          = 36,
        TARGET_UNIT_LASTTARGET_AREA_PARTY  = 37,
        TARGET_UNIT_NEARBY_ENTRY           = 38,
        TARGET_DEST_CASTER_FISHING         = 39,
        TARGET_GAMEOBJECT_NEARBY_ENTRY     = 40,
        TARGET_DEST_CASTER_FRONT_RIGHT     = 41,
        TARGET_DEST_CASTER_BACK_RIGHT      = 42,
        TARGET_DEST_CASTER_BACK_LEFT       = 43,
        TARGET_DEST_CASTER_FRONT_LEFT      = 44,
        TARGET_UNIT_TARGET_CHAINHEAL_ALLY  = 45,
        TARGET_DEST_NEARBY_ENTRY           = 46,
        TARGET_DEST_CASTER_FRONT           = 47,
        TARGET_DEST_CASTER_BACK            = 48,
        TARGET_DEST_CASTER_RIGHT           = 49,
        TARGET_DEST_CASTER_LEFT            = 50,
        TARGET_GAMEOBJECT_SRC_AREA         = 51,
        TARGET_GAMEOBJECT_DEST_AREA        = 52,
        TARGET_DEST_TARGET_ENEMY           = 53,
        TARGET_UNIT_CONE_ENEMY_54          = 54,
        TARGET_DEST_CASTER_FRONT_LEAP      = 55, // for a leap spell
        TARGET_UNIT_CASTER_AREA_RAID       = 56,
        TARGET_UNIT_TARGET_RAID            = 57,
        TARGET_UNIT_NEARBY_RAID            = 58,
        TARGET_UNIT_CONE_ALLY              = 59,
        TARGET_UNIT_CONE_ENTRY             = 60,
        TARGET_UNIT_TARGET_AREA_RAID_CLASS = 61,
        TARGET_UNK_62                      = 62,
        TARGET_DEST_TARGET_ANY             = 63,
        TARGET_DEST_TARGET_FRONT           = 64,
        TARGET_DEST_TARGET_BACK            = 65,
        TARGET_DEST_TARGET_RIGHT           = 66,
        TARGET_DEST_TARGET_LEFT            = 67,
        TARGET_DEST_TARGET_FRONT_RIGHT     = 68,
        TARGET_DEST_TARGET_BACK_RIGHT      = 69,
        TARGET_DEST_TARGET_BACK_LEFT       = 70,
        TARGET_DEST_TARGET_FRONT_LEFT      = 71,
        TARGET_DEST_CASTER_RANDOM          = 72,
        TARGET_DEST_CASTER_RADIUS          = 73,
        TARGET_DEST_TARGET_RANDOM          = 74,
        TARGET_DEST_TARGET_RADIUS          = 75,
        TARGET_DEST_CHANNEL_TARGET         = 76,
        TARGET_UNIT_CHANNEL_TARGET         = 77,
        TARGET_DEST_DEST_FRONT             = 78,
        TARGET_DEST_DEST_BACK              = 79,
        TARGET_DEST_DEST_RIGHT             = 80,
        TARGET_DEST_DEST_LEFT              = 81,
        TARGET_DEST_DEST_FRONT_RIGHT       = 82,
        TARGET_DEST_DEST_BACK_RIGHT        = 83,
        TARGET_DEST_DEST_BACK_LEFT         = 84,
        TARGET_DEST_DEST_FRONT_LEFT        = 85,
        TARGET_DEST_DEST_RANDOM            = 86,
        TARGET_DEST_DEST                   = 87,
        TARGET_DEST_DYNOBJ_NONE            = 88,
        TARGET_DEST_TRAJ                   = 89,
        TARGET_UNIT_TARGET_MINIPET         = 90,
        TARGET_DEST_DEST_RADIUS            = 91,
        TARGET_UNIT_SUMMONER               = 92,
        TARGET_CORPSE_SRC_AREA_ENEMY       = 93, // NYI
        TARGET_UNIT_VEHICLE                = 94,
        TARGET_UNIT_TARGET_PASSENGER       = 95,
        TARGET_UNIT_PASSENGER_0            = 96,
        TARGET_UNIT_PASSENGER_1            = 97,
        TARGET_UNIT_PASSENGER_2            = 98,
        TARGET_UNIT_PASSENGER_3            = 99,
        TARGET_UNIT_PASSENGER_4            = 100,
        TARGET_UNIT_PASSENGER_5            = 101,
        TARGET_UNIT_PASSENGER_6            = 102,
        TARGET_UNIT_PASSENGER_7            = 103,
        TARGET_UNIT_CONE_ENEMY_104         = 104,
        TARGET_UNIT_UNK_105                = 105, // 1 spell
        TARGET_DEST_CHANNEL_CASTER         = 106,
        TARGET_UNK_DEST_AREA_UNK_107       = 107, // not enough info - only generic spells avalible
        TARGET_GAMEOBJECT_CONE             = 108,
        TARGET_DEST_UNK_110                = 110, // 1 spell
        TARGET_UNK_111                     = 111,
        TARGET_UNK_112                     = 112,
        TARGET_UNK_113                     = 113,
        TARGET_UNK_114                     = 114,
        TARGET_UNK_115                     = 115,
        TARGET_UNK_116                     = 116,
        TARGET_UNK_117                     = 117,
        TARGET_UNK_118                     = 118,
        TARGET_UNK_119                     = 119,
        TARGET_UNK_120                     = 120,
        TARGET_UNK_121                     = 121,
        TARGET_UNK_122                     = 122,
        TARGET_UNK_123                     = 123,
        TARGET_UNK_124                     = 124,
        TARGET_UNK_125                     = 125,
        TARGET_UNK_126                     = 126,
        TARGET_UNK_127                     = 127,
        TARGET_UNK_128                     = 128,
        TARGET_UNK_129                     = 129,
        TARGET_UNK_130                     = 130,
        TARGET_UNK_131                     = 131,
        TARGET_UNK_132                     = 132,
        TARGET_UNK_133                     = 133,
        TARGET_UNK_134                     = 134,
        TARGET_UNK_135                     = 135,
        TARGET_UNK_136                     = 136,
        TARGET_UNK_137                     = 137,
        TARGET_UNK_138                     = 138,
        TARGET_UNK_139                     = 139,
        TARGET_UNK_140                     = 140,
        TARGET_UNK_141                     = 141,
        TARGET_UNK_142                     = 142,
        TARGET_UNK_143                     = 143,
        TARGET_UNK_144                     = 144,
        TARGET_UNK_145                     = 145,
        TARGET_UNK_146                     = 146,
        TARGET_UNK_147                     = 147,
    };
}
