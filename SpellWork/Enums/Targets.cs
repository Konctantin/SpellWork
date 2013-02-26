using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    /// <summary>
    /// Target
    /// </summary>
    public enum Targets
    {
        TARGET_NONE                        = 0,
        TARGET_SELF                        = 1,
        TARGET_RANDOM_ENEMY_CHAIN_IN_AREA  = 2,                 // only one spell has that, but regardless, it's a target type after all
        TARGET_RANDOM_FRIEND_CHAIN_IN_AREA = 3,
        TARGET_4                           = 4,                 // some plague spells that are infectious - maybe targets not-infected friends inrange
        TARGET_PET                         = 5,
        TARGET_CHAIN_DAMAGE                = 6,
        TARGET_AREAEFFECT_INSTANT          = 7,                 // targets around provided destination point
        TARGET_AREAEFFECT_CUSTOM           = 8,
        TARGET_INNKEEPER_COORDINATES       = 9,                 // uses in teleport to innkeeper spells
        TARGET_11                          = 11,                // used by spell 4 'Word of Recall Other'
        TARGET_ALL_ENEMY_IN_AREA           = 15,
        TARGET_ALL_ENEMY_IN_AREA_INSTANT   = 16,
        TARGET_TABLE_X_Y_Z_COORDINATES     = 17,                // uses in teleport spells and some other
        TARGET_EFFECT_SELECT               = 18,                // highly depends on the spell effect
        TARGET_ALL_PARTY_AROUND_CASTER     = 20,
        TARGET_SINGLE_FRIEND               = 21,
        TARGET_CASTER_COORDINATES          = 22,                // used only in TargetA, target selection dependent from TargetB
        TARGET_GAMEOBJECT                  = 23,
        TARGET_IN_FRONT_OF_CASTER          = 24,
        TARGET_DUELVSPLAYER                = 25,
        TARGET_GAMEOBJECT_ITEM             = 26,
        TARGET_MASTER                      = 27,
        TARGET_ALL_ENEMY_IN_AREA_CHANNELED = 28,
        TARGET_29                          = 29,
        TARGET_ALL_FRIENDLY_UNITS_AROUND_CASTER = 30,           // select friendly for caster object faction (in different original caster faction) in TargetB used only with TARGET_ALL_AROUND_CASTER and in self casting range in TargetA
        TARGET_ALL_FRIENDLY_UNITS_IN_AREA  = 31,
        TARGET_MINION                      = 32,
        TARGET_ALL_PARTY                   = 33,
        TARGET_ALL_PARTY_AROUND_CASTER_2   = 34,                // used in Tranquility
        TARGET_SINGLE_PARTY                = 35,
        TARGET_ALL_HOSTILE_UNITS_AROUND_CASTER = 36,
        TARGET_AREAEFFECT_PARTY            = 37,
        TARGET_SCRIPT                      = 38,
        TARGET_SELF_FISHING                = 39,
        TARGET_FOCUS_OR_SCRIPTED_GAMEOBJECT = 40,
        TARGET_TOTEM_EARTH                 = 41,
        TARGET_TOTEM_WATER                 = 42,
        TARGET_TOTEM_AIR                   = 43,
        TARGET_TOTEM_FIRE                  = 44,
        TARGET_CHAIN_HEAL                  = 45,
        TARGET_SCRIPT_COORDINATES          = 46,
        TARGET_DYNAMIC_OBJECT_FRONT        = 47,
        TARGET_DYNAMIC_OBJECT_BEHIND       = 48,
        TARGET_DYNAMIC_OBJECT_LEFT_SIDE    = 49,
        TARGET_DYNAMIC_OBJECT_RIGHT_SIDE   = 50,
        TARGET_AREAEFFECT_GO_AROUND_SOURCE = 51,
        TARGET_AREAEFFECT_GO_AROUND_DEST   = 52,                // gameobject around destination, select by spell_script_target
        TARGET_CURRENT_ENEMY_COORDINATES   = 53,                // set unit coordinates as dest, only 16 target B imlemented
        TARGET_LARGE_FRONTAL_CONE          = 54,
        TARGET_ALL_RAID_AROUND_CASTER      = 56,
        TARGET_SINGLE_FRIEND_2             = 57,
        TARGET_58                          = 58,
        TARGET_59                          = 59,
        TARGET_NARROW_FRONTAL_CONE         = 60,
        TARGET_AREAEFFECT_PARTY_AND_CLASS  = 61,
        TARGET_DUELVSPLAYER_COORDINATES    = 63,
        TARGET_INFRONT_OF_VICTIM           = 64,
        TARGET_BEHIND_VICTIM               = 65,                // used in teleport behind spells, caster/target dependent from spell effect
        TARGET_RIGHT_FROM_VICTIM           = 66,
        TARGET_LEFT_FROM_VICTIM            = 67,
        TARGET_68                          = 68,
        TARGET_69                          = 69,
        TARGET_70                          = 70,
        TARGET_RANDOM_NEARBY_LOC           = 72,                // used in teleport onto nearby locations
        TARGET_RANDOM_CIRCUMFERENCE_POINT  = 73,
        TARGET_74                          = 74,
        TARGET_75                          = 75,
        TARGET_DYNAMIC_OBJECT_COORDINATES  = 76,
        TARGET_SINGLE_ENEMY                = 77,
        TARGET_POINT_AT_NORTH              = 78,                // 78-85 possible _COORDINATES at radius with pi/4 step around target in unknown order, N?
        TARGET_POINT_AT_SOUTH              = 79,                // S?
        TARGET_POINT_AT_EAST               = 80,                // 80/81 must be symmetric from line caster->target, E (base at 82/83, 84/85 order) ?
        TARGET_POINT_AT_WEST               = 81,                // 80/81 must be symmetric from line caster->target, W (base at 82/83, 84/85 order) ?
        TARGET_POINT_AT_NE                 = 82,                // from spell desc: "(NE)"
        TARGET_POINT_AT_NW                 = 83,                // from spell desc: "(NW)"
        TARGET_POINT_AT_SE                 = 84,                // from spell desc: "(SE)"
        TARGET_POINT_AT_SW                 = 85,                // from spell desc: "(SW)"
        TARGET_RANDOM_NEARBY_DEST          = 86,                // "Test Nearby Dest Random" - random around selected destination
        TARGET_SELF2                       = 87,
        TARGET_88                          = 88,                // Smoke Flare(s) and Hurricane
        TARGET_DIRECTLY_FORWARD            = 89,
        TARGET_NONCOMBAT_PET               = 90,
        TARGET_91                          = 91,
        TARGET_92                          = 92,
        TARGET_CONTROLLED_VEHICLE          = 94,
        TARGET_95                          = 95,
        TARGET_VEHICLE_PASSENGER_0         = 96,
        TARGET_VEHICLE_PASSENGER_1         = 97,
        TARGET_VEHICLE_PASSENGER_2         = 98,
        TARGET_VEHICLE_PASSENGER_3         = 99,
        TARGET_VEHICLE_PASSENGER_4         = 100,
        TARGET_VEHICLE_PASSENGER_5         = 101,
        TARGET_VEHICLE_PASSENGER_6         = 102,
        TARGET_VEHICLE_PASSENGER_7         = 103,
        TARGET_IN_FRONT_OF_CASTER_30       = 104,
        TARGET_105                         = 105,
        TARGET_106                         = 106,
        TARGET_107                         = 107,               // possible TARGET_WMO(GO?)_IN_FRONT_OF_CASTER(_30 ?) TODO: Verify the angle!
        TARGET_GO_IN_FRONT_OF_CASTER_90    = 108,
        TARGET_109                         = 109,               // spell 89008
        TARGET_110                         = 110,               // front enemy aoe
        TARGET_111                         = 111,               // not used
        TARGET_112                         = 112,               // spell 89549
        TARGET_113                         = 113,               // not used
        TARGET_114                         = 114,               // not used
        TARGET_115                         = 115,               // not used
        TARGET_116                         = 116,               // not used
        TARGET_117                         = 117,               // test spell 83658
        TARGET_118                         = 118,               // test spell 79579
        TARGET_119                         = 119,               // mass ressurection 83968
        TARGET_120                         = 120,
        TARGET_121                         = 121,               // spell 95750
        TARGET_122                         = 122,               // spell 100661
        TARGET_123                         = 123,
        TARGET_124                         = 124,
        TARGET_125                         = 125,
        TARGET_126                         = 126,
        TARGET_127                         = 127,
    };
}
