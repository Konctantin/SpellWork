﻿namespace SpellWork.Enums
{
    public enum SpellEffects
    {
        NO_FILTER = -1,
        SPELL_EFFECT_INSTAKILL                          = 1,
        SPELL_EFFECT_SCHOOL_DAMAGE                      = 2,
        SPELL_EFFECT_DUMMY                              = 3,
        SPELL_EFFECT_PORTAL_TELEPORT                    = 4, // Unused (4.3.4)
        SPELL_EFFECT_TELEPORT_UNITS                     = 5,
        SPELL_EFFECT_APPLY_AURA                         = 6,
        SPELL_EFFECT_ENVIRONMENTAL_DAMAGE               = 7,
        SPELL_EFFECT_POWER_DRAIN                        = 8,
        SPELL_EFFECT_HEALTH_LEECH                       = 9,
        SPELL_EFFECT_HEAL                               = 10,
        SPELL_EFFECT_BIND                               = 11,
        SPELL_EFFECT_PORTAL                             = 12,
        SPELL_EFFECT_RITUAL_BASE                        = 13, // Unused (4.3.4)
        SPELL_EFFECT_RITUAL_SPECIALIZE                  = 14, // Unused (4.3.4)
        SPELL_EFFECT_RITUAL_ACTIVATE_PORTAL             = 15, // Unused (4.3.4)
        SPELL_EFFECT_QUEST_COMPLETE                     = 16,
        SPELL_EFFECT_WEAPON_DAMAGE_NOSCHOOL             = 17,
        SPELL_EFFECT_RESURRECT                          = 18,
        SPELL_EFFECT_ADD_EXTRA_ATTACKS                  = 19,
        SPELL_EFFECT_DODGE                              = 20,
        SPELL_EFFECT_EVADE                              = 21,
        SPELL_EFFECT_PARRY                              = 22,
        SPELL_EFFECT_BLOCK                              = 23,
        SPELL_EFFECT_CREATE_ITEM                        = 24,
        SPELL_EFFECT_WEAPON                             = 25,
        SPELL_EFFECT_DEFENSE                            = 26,
        SPELL_EFFECT_PERSISTENT_AREA_AURA               = 27,
        SPELL_EFFECT_SUMMON                             = 28,
        SPELL_EFFECT_LEAP                               = 29,
        SPELL_EFFECT_ENERGIZE                           = 30,
        SPELL_EFFECT_WEAPON_PERCENT_DAMAGE              = 31,
        SPELL_EFFECT_TRIGGER_MISSILE                    = 32,
        SPELL_EFFECT_OPEN_LOCK                          = 33,
        SPELL_EFFECT_SUMMON_CHANGE_ITEM                 = 34,
        SPELL_EFFECT_APPLY_AREA_AURA_PARTY              = 35,
        SPELL_EFFECT_LEARN_SPELL                        = 36,
        SPELL_EFFECT_SPELL_DEFENSE                      = 37,
        SPELL_EFFECT_DISPEL                             = 38,
        SPELL_EFFECT_LANGUAGE                           = 39,
        SPELL_EFFECT_DUAL_WIELD                         = 40,
        SPELL_EFFECT_JUMP                               = 41,
        SPELL_EFFECT_JUMP_DEST                          = 42,
        SPELL_EFFECT_TELEPORT_UNITS_FACE_CASTER         = 43,
        SPELL_EFFECT_SKILL_STEP                         = 44,
        SPELL_EFFECT_PLAY_MOVIE                         = 45,
        SPELL_EFFECT_SPAWN                              = 46,
        SPELL_EFFECT_TRADE_SKILL                        = 47,
        SPELL_EFFECT_STEALTH                            = 48,
        SPELL_EFFECT_DETECT                             = 49,
        SPELL_EFFECT_TRANS_DOOR                         = 50,
        SPELL_EFFECT_FORCE_CRITICAL_HIT                 = 51, // Unused (4.3.4)
        SPELL_EFFECT_GUARANTEE_HIT                      = 52, // Unused (4.3.4)
        SPELL_EFFECT_ENCHANT_ITEM                       = 53,
        SPELL_EFFECT_ENCHANT_ITEM_TEMPORARY             = 54,
        SPELL_EFFECT_TAMECREATURE                       = 55,
        SPELL_EFFECT_SUMMON_PET                         = 56,
        SPELL_EFFECT_LEARN_PET_SPELL                    = 57,
        SPELL_EFFECT_WEAPON_DAMAGE                      = 58,
        SPELL_EFFECT_CREATE_RANDOM_ITEM                 = 59,
        SPELL_EFFECT_PROFICIENCY                        = 60,
        SPELL_EFFECT_SEND_EVENT                         = 61,
        SPELL_EFFECT_POWER_BURN                         = 62,
        SPELL_EFFECT_THREAT                             = 63,
        SPELL_EFFECT_TRIGGER_SPELL                      = 64,
        SPELL_EFFECT_APPLY_AREA_AURA_RAID               = 65,
        SPELL_EFFECT_CREATE_MANA_GEM                    = 66,
        SPELL_EFFECT_HEAL_MAX_HEALTH                    = 67,
        SPELL_EFFECT_INTERRUPT_CAST                     = 68,
        SPELL_EFFECT_DISTRACT                           = 69,
        SPELL_EFFECT_PULL                               = 70,
        SPELL_EFFECT_PICKPOCKET                         = 71,
        SPELL_EFFECT_ADD_FARSIGHT                       = 72,
        SPELL_EFFECT_UNTRAIN_TALENTS                    = 73,
        SPELL_EFFECT_APPLY_GLYPH                        = 74,
        SPELL_EFFECT_HEAL_MECHANICAL                    = 75,
        SPELL_EFFECT_SUMMON_OBJECT_WILD                 = 76,
        SPELL_EFFECT_SCRIPT_EFFECT                      = 77,
        SPELL_EFFECT_ATTACK                             = 78,
        SPELL_EFFECT_SANCTUARY                          = 79,
        SPELL_EFFECT_ADD_COMBO_POINTS                   = 80,
        SPELL_EFFECT_CREATE_HOUSE                       = 81,
        SPELL_EFFECT_BIND_SIGHT                         = 82,
        SPELL_EFFECT_DUEL                               = 83,
        SPELL_EFFECT_STUCK                              = 84,
        SPELL_EFFECT_SUMMON_PLAYER                      = 85,
        SPELL_EFFECT_ACTIVATE_OBJECT                    = 86,
        SPELL_EFFECT_GAMEOBJECT_DAMAGE                  = 87,
        SPELL_EFFECT_GAMEOBJECT_REPAIR                  = 88,
        SPELL_EFFECT_GAMEOBJECT_SET_DESTRUCTION_STATE   = 89,
        SPELL_EFFECT_KILL_CREDIT                        = 90,
        SPELL_EFFECT_THREAT_ALL                         = 91,
        SPELL_EFFECT_ENCHANT_HELD_ITEM                  = 92,
        SPELL_EFFECT_FORCE_DESELECT                     = 93,
        SPELL_EFFECT_SELF_RESURRECT                     = 94,
        SPELL_EFFECT_SKINNING                           = 95,
        SPELL_EFFECT_CHARGE                             = 96,
        SPELL_EFFECT_CAST_BUTTON                        = 97,
        SPELL_EFFECT_KNOCK_BACK                         = 98,
        SPELL_EFFECT_DISENCHANT                         = 99,
        SPELL_EFFECT_INEBRIATE                          = 100,
        SPELL_EFFECT_FEED_PET                           = 101,
        SPELL_EFFECT_DISMISS_PET                        = 102,
        SPELL_EFFECT_REPUTATION                         = 103,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT1                = 104,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT2                = 105,
        SPELL_EFFECT_CHANGE_RAID_MARKER                 = 106,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT4                = 107,
        SPELL_EFFECT_DISPEL_MECHANIC                    = 108,
        SPELL_EFFECT_RESURRECT_PET                      = 109,
        SPELL_EFFECT_DESTROY_ALL_TOTEMS                 = 110,
        SPELL_EFFECT_DURABILITY_DAMAGE                  = 111,
        SPELL_EFFECT_112                                = 112,
        SPELL_EFFECT_RESURRECT_NEW                      = 113,
        SPELL_EFFECT_ATTACK_ME                          = 114,
        SPELL_EFFECT_DURABILITY_DAMAGE_PCT              = 115,
        SPELL_EFFECT_SKIN_PLAYER_CORPSE                 = 116,
        SPELL_EFFECT_SPIRIT_HEAL                        = 117,
        SPELL_EFFECT_SKILL                              = 118,
        SPELL_EFFECT_APPLY_AREA_AURA_PET                = 119,
        SPELL_EFFECT_TELEPORT_GRAVEYARD                 = 120,
        SPELL_EFFECT_NORMALIZED_WEAPON_DMG              = 121,
        SPELL_EFFECT_122                                = 122, // Unused (4.3.4)
        SPELL_EFFECT_SEND_TAXI                          = 123,
        SPELL_EFFECT_PULL_TOWARDS                       = 124,
        SPELL_EFFECT_MODIFY_THREAT_PERCENT              = 125,
        SPELL_EFFECT_STEAL_BENEFICIAL_BUFF              = 126,
        SPELL_EFFECT_PROSPECTING                        = 127,
        SPELL_EFFECT_APPLY_AREA_AURA_FRIEND             = 128,
        SPELL_EFFECT_APPLY_AREA_AURA_ENEMY              = 129,
        SPELL_EFFECT_REDIRECT_THREAT                    = 130,
        SPELL_EFFECT_PLAY_SOUND                         = 131,
        SPELL_EFFECT_PLAY_MUSIC                         = 132,
        SPELL_EFFECT_UNLEARN_SPECIALIZATION             = 133,
        SPELL_EFFECT_KILL_CREDIT2                       = 134,
        SPELL_EFFECT_CALL_PET                           = 135,
        SPELL_EFFECT_HEAL_PCT                           = 136,
        SPELL_EFFECT_ENERGIZE_PCT                       = 137,
        SPELL_EFFECT_LEAP_BACK                          = 138,
        SPELL_EFFECT_CLEAR_QUEST                        = 139,
        SPELL_EFFECT_FORCE_CAST                         = 140,
        SPELL_EFFECT_FORCE_CAST_WITH_VALUE              = 141,
        SPELL_EFFECT_TRIGGER_SPELL_WITH_VALUE           = 142,
        SPELL_EFFECT_APPLY_AREA_AURA_OWNER              = 143,
        SPELL_EFFECT_KNOCK_BACK_DEST                    = 144,
        SPELL_EFFECT_PULL_TOWARDS_DEST                  = 145,
        SPELL_EFFECT_ACTIVATE_RUNE                      = 146,
        SPELL_EFFECT_QUEST_FAIL                         = 147,
        SPELL_EFFECT_TRIGGER_MISSILE_SPELL_WITH_VALUE   = 148,
        SPELL_EFFECT_CHARGE_DEST                        = 149,
        SPELL_EFFECT_QUEST_START                        = 150,
        SPELL_EFFECT_TRIGGER_SPELL_2                    = 151,
        SPELL_EFFECT_SUMMON_RAF_FRIEND                  = 152,
        SPELL_EFFECT_CREATE_TAMED_PET                   = 153,
        SPELL_EFFECT_DISCOVER_TAXI                      = 154,
        SPELL_EFFECT_TITAN_GRIP                         = 155,
        SPELL_EFFECT_ENCHANT_ITEM_PRISMATIC             = 156,
        SPELL_EFFECT_CREATE_ITEM_2                      = 157,
        SPELL_EFFECT_MILLING                            = 158,
        SPELL_EFFECT_ALLOW_RENAME_PET                   = 159,
        SPELL_EFFECT_160                                = 160,
        SPELL_EFFECT_TALENT_SPEC_COUNT                  = 161,
        SPELL_EFFECT_TALENT_SPEC_SELECT                 = 162,
        SPELL_EFFECT_163                                = 163, // Unused (4.3.4)
        SPELL_EFFECT_REMOVE_AURA                        = 164,
        SPELL_EFFECT_DAMAGE_FROM_MAX_HEALTH_PCT         = 165,
        SPELL_EFFECT_GIVE_CURRENCY                      = 166,
        SPELL_EFFECT_UPDATE_PLAYER_PHASE                = 167,
        SPELL_EFFECT_ALLOW_CONTROL_PET                  = 168, // NYI
        SPELL_EFFECT_DESTROY_ITEM                       = 169,
        SPELL_EFFECT_UPDATE_ZONE_AURAS_AND_PHASES       = 170, // NYI
        SPELL_EFFECT_171                                = 171, // Summons gamebject
        SPELL_EFFECT_RESURRECT_WITH_AURA                = 172,
        SPELL_EFFECT_UNLOCK_GUILD_VAULT_TAB             = 173, // Guild tab unlocked (guild perk)
        SPELL_EFFECT_APPLY_AURA_ON_PET                  = 174, // NYI
        SPELL_EFFECT_175                                = 175, // Unused (4.3.4)
        SPELL_EFFECT_SANCTUARY_2                        = 176, // NYI
        SPELL_EFFECT_177                                = 177,
        SPELL_EFFECT_178                                = 178, // Unused (4.3.4)
        SPELL_EFFECT_CREATE_AREATRIGGER                 = 179,
        SPELL_EFFECT_UPDATE_AREATRIGGER                 = 180, // NYI
        SPELL_EFFECT_REMOVE_TALENT                      = 181,
        SPELL_EFFECT_182                                = 182,
        SPELL_EFFECT_183                                = 183,
        SPELL_EFFECT_REPUTATION_2                       = 184, // NYI
        SPELL_EFFECT_185                                = 185,
        SPELL_EFFECT_186                                = 186,
        SPELL_EFFECT_RANDOMIZE_ARCHAEOLOGY_DIGSITES     = 187, // NYI
        SPELL_EFFECT_188                                = 188,
        SPELL_EFFECT_LOOT                               = 189, // NYI, lootid in MiscValue ?
        SPELL_EFFECT_190                                = 190,
        SPELL_EFFECT_TELEPORT_TO_DIGSITE                = 191, // NYI
        SPELL_EFFECT_UNCAGE_BATTLEPET                   = 192,
        SPELL_EFFECT_START_PET_BATTLE                   = 193,
        SPELL_EFFECT_194                                = 194,
        SPELL_EFFECT_195                                = 195,
        SPELL_EFFECT_196                                = 196,
        SPELL_EFFECT_197                                = 197,
        SPELL_EFFECT_198                                = 198,
        SPELL_EFFECT_199                                = 199,
        SPELL_EFFECT_HEAL_BATTLEPET_PCT                 = 200, // BYI
        SPELL_EFFECT_ENABLE_BATTLE_PETS                 = 201, // NYI
        SPELL_EFFECT_202                                = 202,
        SPELL_EFFECT_203                                = 203,
        SPELL_EFFECT_CHANGE_BATTLEPET_QUALITY           = 204,
        SPELL_EFFECT_LAUNCH_QUEST_CHOICE                = 205,
        SPELL_EFFECT_206                                = 206,
        SPELL_EFFECT_LAUNCH_QUEST_TASK                  = 207, // Starts one of the "progress bar" quests
        SPELL_EFFECT_208                                = 208,
        SPELL_EFFECT_209                                = 209,
        SPELL_EFFECT_LEARN_GARRISON_BUILDING            = 210,
        SPELL_EFFECT_LEARN_GARRISON_SPECIALIZATION      = 211,
        SPELL_EFFECT_212                                = 212,
        SPELL_EFFECT_213                                = 213,
        SPELL_EFFECT_CREATE_GARRISON                    = 214,
        SPELL_EFFECT_UPGRADE_CHARACTER_SPELLS           = 215, // Unlocks boosted players' spells (ChrUpgrade*.db2)
        SPELL_EFFECT_CREATE_SHIPMENT                    = 216,
        SPELL_EFFECT_UPGRADE_GARRISON                   = 217,
        SPELL_EFFECT_218                                = 218,
        SPELL_EFFECT_219                                = 219,
        SPELL_EFFECT_ADD_GARRISON_FOLLOWER              = 220,
        SPELL_EFFECT_221                                = 221,
        SPELL_EFFECT_CREATE_HEIRLOOM_ITEM               = 222,
        SPELL_EFFECT_CHANGE_ITEM_BONUSES                = 223,
        SPELL_EFFECT_ACTIVATE_GARRISON_BUILDING         = 224,
        SPELL_EFFECT_GRANT_BATTLEPET_LEVEL              = 225,
        SPELL_EFFECT_226                                = 226,
        SPELL_EFFECT_227                                = 227,
        SPELL_EFFECT_228                                = 228,
        SPELL_EFFECT_SET_FOLLOWER_QUALITY               = 229,
        SPELL_EFFECT_INCREASE_FOLLOWER_ITEM_LEVEL       = 230,
        SPELL_EFFECT_INCREASE_FOLLOWER_EXPERIENCE       = 231,
        SPELL_EFFECT_REMOVE_PHASE                       = 232,
        SPELL_EFFECT_RANDOMIZE_FOLLOWER_ABILITIES       = 233,
        SPELL_EFFECT_234                                = 234,
        SPELL_EFFECT_235                                = 235,
        SPELL_EFFECT_GIVE_EXPERIENCE                    = 236, // Increases players XP
        SPELL_EFFECT_GIVE_RESTED_EXPERIENCE_BONUS       = 237,
        SPELL_EFFECT_INCREASE_SKILL                     = 238,
        SPELL_EFFECT_END_GARRISON_BUILDING_CONSTRUCTION = 239, // Instantly finishes building construction
        SPELL_EFFECT_240                                = 240,
        SPELL_EFFECT_241                                = 241,
        SPELL_EFFECT_242                                = 242,
        SPELL_EFFECT_APPLY_ENCHANT_ILLUSION             = 243,
        SPELL_EFFECT_LEARN_FOLLOWER_ABILITY             = 244,
        SPELL_EFFECT_UPGRADE_HEIRLOOM                   = 245,
        SPELL_EFFECT_FINISH_GARRISON_MISSION            = 246,
        SPELL_EFFECT_ADD_GARRISON_MISSION               = 247,
        SPELL_EFFECT_FINISH_SHIPMENT                    = 248,
        SPELL_EFFECT_249                                = 249,
        SPELL_EFFECT_TAKE_SCREENSHOT                    = 250, // Serverside marker for selfie screenshot - achievement check
        SPELL_EFFECT_SET_GARRISON_CACHE_SIZE            = 251,
    };
}
