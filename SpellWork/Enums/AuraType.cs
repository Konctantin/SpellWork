﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    /// <summary>
    ///
    /// </summary>
    public enum AuraType
    {
        NONE = 0,
        BIND_SIGHT = 1,
        MOD_POSSESS = 2,
        PERIODIC_DAMAGE = 3,
        DUMMY = 4,
        MOD_CONFUSE = 5,
        MOD_CHARM = 6,
        MOD_FEAR = 7,
        PERIODIC_HEAL = 8,
        MOD_ATTACKSPEED = 9,
        MOD_THREAT = 10,
        MOD_TAUNT = 11,
        MOD_STUN = 12,
        MOD_DAMAGE_DONE = 13,
        MOD_DAMAGE_TAKEN = 14,
        DAMAGE_SHIELD = 15,
        MOD_STEALTH = 16,
        MOD_STEALTH_DETECT = 17,
        MOD_INVISIBILITY = 18,
        MOD_INVISIBILITY_DETECTION = 19,
        OBS_MOD_HEALTH = 20,                         // 20,21 unofficial
        OBS_MOD_MANA = 21,
        MOD_RESISTANCE = 22,
        PERIODIC_TRIGGER_SPELL = 23,
        PERIODIC_ENERGIZE = 24,
        MOD_PACIFY = 25,
        MOD_ROOT = 26,
        MOD_SILENCE = 27,
        REFLECT_SPELLS = 28,
        MOD_STAT = 29,
        MOD_SKILL = 30,
        MOD_INCREASE_SPEED = 31,
        MOD_INCREASE_MOUNTED_SPEED = 32,
        MOD_DECREASE_SPEED = 33,
        MOD_INCREASE_HEALTH = 34,
        MOD_INCREASE_ENERGY = 35,
        MOD_SHAPESHIFT = 36,
        EFFECT_IMMUNITY = 37,
        STATE_IMMUNITY = 38,
        SCHOOL_IMMUNITY = 39,
        DAMAGE_IMMUNITY = 40,
        DISPEL_IMMUNITY = 41,
        PROC_TRIGGER_SPELL = 42,
        PROC_TRIGGER_DAMAGE = 43,
        TRACK_CREATURES = 44,
        TRACK_RESOURCES = 45,
        SA_46 = 46,                                     // Ignore all Gear test spells
        MOD_PARRY_PERCENT = 47,
        PERIODIC_TRIGGER_BY_CLIENT = 48,             // Client periodic trigger spell by self (3 spells in 3.3.5a)
        MOD_DODGE_PERCENT = 49,
        MOD_CRITICAL_HEALING_AMOUNT = 50,
        MOD_BLOCK_CHANCE_PERCENT = 51,
        MOD_CRIT_PERCENT = 52,
        PERIODIC_LEECH = 53,
        MOD_HIT_CHANCE = 54,
        MOD_SPELL_HIT_CHANCE = 55,
        TRANSFORM = 56,
        MOD_SPELL_CRIT_CHANCE = 57,
        MOD_INCREASE_SWIM_SPEED = 58,
        MOD_DAMAGE_DONE_CREATURE = 59,
        MOD_PACIFY_SILENCE = 60,
        MOD_SCALE = 61,
        PERIODIC_HEALTH_FUNNEL = 62,
        SA_63 = 63,                                     // old SPELL_AURA_PERIODIC_MANA_FUNNEL
        PERIODIC_MANA_LEECH = 64,
        MOD_CASTING_SPEED_NOT_STACK = 65,
        FEIGN_DEATH = 66,
        MOD_DISARM = 67,
        MOD_STALKED = 68,
        SCHOOL_ABSORB = 69,
        EXTRA_ATTACKS = 70,
        MOD_SPELL_CRIT_CHANCE_SCHOOL = 71,
        MOD_POWER_COST_SCHOOL_PCT = 72,
        MOD_POWER_COST_SCHOOL = 73,
        REFLECT_SPELLS_SCHOOL = 74,
        MOD_LANGUAGE = 75,
        FAR_SIGHT = 76,
        MECHANIC_IMMUNITY = 77,
        MOUNTED = 78,
        MOD_DAMAGE_PERCENT_DONE = 79,
        MOD_PERCENT_STAT = 80,
        SPLIT_DAMAGE_PCT = 81,
        WATER_BREATHING = 82,
        MOD_BASE_RESISTANCE = 83,
        MOD_REGEN = 84,
        MOD_POWER_REGEN = 85,
        CHANNEL_DEATH_ITEM = 86,
        MOD_DAMAGE_PERCENT_TAKEN = 87,
        MOD_HEALTH_REGEN_PERCENT = 88,
        PERIODIC_DAMAGE_PERCENT = 89,
        SA_90 = 90,                                     // old SPELL_AURA_MOD_RESIST_CHANCE
        MOD_DETECT_RANGE = 91,
        PREVENTS_FLEEING = 92,
        MOD_UNATTACKABLE = 93,
        INTERRUPT_REGEN = 94,
        GHOST = 95,
        SPELL_MAGNET = 96,
        MANA_SHIELD = 97,
        MOD_SKILL_TALENT = 98,
        MOD_ATTACK_POWER = 99,
        AURAS_VISIBLE = 100,
        MOD_RESISTANCE_PCT = 101,
        MOD_MELEE_ATTACK_POWER_VERSUS = 102,
        MOD_TOTAL_THREAT = 103,
        WATER_WALK = 104,
        FEATHER_FALL = 105,
        HOVER = 106,
        ADD_FLAT_MODIFIER = 107,
        ADD_PCT_MODIFIER = 108,
        ADD_TARGET_TRIGGER = 109,
        MOD_POWER_REGEN_PERCENT = 110,
        ADD_CASTER_HIT_TRIGGER = 111,
        OVERRIDE_CLASS_SCRIPTS = 112,
        MOD_RANGED_DAMAGE_TAKEN = 113,
        MOD_RANGED_DAMAGE_TAKEN_PCT = 114,
        MOD_HEALING = 115,
        MOD_REGEN_DURING_COMBAT = 116,
        MOD_MECHANIC_RESISTANCE = 117,
        MOD_HEALING_PCT = 118,
        SA_119 = 119,                                   // old SPELL_AURA_SHARE_PET_TRACKING
        UNTRACKABLE = 120,
        EMPATHY = 121,
        MOD_OFFHAND_DAMAGE_PCT = 122,
        MOD_TARGET_RESISTANCE = 123,
        MOD_RANGED_ATTACK_POWER = 124,
        MOD_MELEE_DAMAGE_TAKEN = 125,
        MOD_MELEE_DAMAGE_TAKEN_PCT = 126,
        RANGED_ATTACK_POWER_ATTACKER_BONUS = 127,
        MOD_POSSESS_PET = 128,
        MOD_SPEED_ALWAYS = 129,
        MOD_MOUNTED_SPEED_ALWAYS = 130,
        MOD_RANGED_ATTACK_POWER_VERSUS = 131,
        MOD_INCREASE_ENERGY_PERCENT = 132,
        MOD_INCREASE_HEALTH_PERCENT = 133,
        MOD_MANA_REGEN_INTERRUPT = 134,
        MOD_HEALING_DONE = 135,
        MOD_HEALING_DONE_PERCENT = 136,
        MOD_TOTAL_STAT_PERCENTAGE = 137,
        MOD_MELEE_HASTE = 138,
        FORCE_REACTION = 139,
        MOD_RANGED_HASTE = 140,
        MOD_RANGED_AMMO_HASTE = 141,
        MOD_BASE_RESISTANCE_PCT = 142,
        MOD_RESISTANCE_EXCLUSIVE = 143,
        SAFE_FALL = 144,
        MOD_PET_TALENT_POINTS = 145,
        ALLOW_TAME_PET_TYPE = 146,
        MECHANIC_IMMUNITY_MASK = 147,
        RETAIN_COMBO_POINTS = 148,
        REDUCE_PUSHBACK = 149,                      //    Reduce Pushback
        MOD_SHIELD_BLOCKDAMAGE = 150,
        TRACK_STEALTHED = 151,                      //    Track Stealthed
        MOD_DETECTED_RANGE = 152,                    //    Mod Detected Range
        SPLIT_DAMAGE_FLAT = 153,                     //    Split Damage Flat
        MOD_STEALTH_LEVEL = 154,                     //    Stealth Level Modifier
        MOD_WATER_BREATHING = 155,                   //    Mod Water Breathing
        MOD_REPUTATION_GAIN = 156,                   //    Mod Reputation Gain
        PET_DAMAGE_MULTI = 157,                      //    Mod Pet Damage
        MOD_SHIELD_BLOCKVALUE = 158,
        NO_PVP_CREDIT = 159,
        MOD_AOE_AVOIDANCE = 160,
        MOD_HEALTH_REGEN_IN_COMBAT = 161,
        POWER_BURN_MANA = 162,
        MOD_CRIT_DAMAGE_BONUS = 163,
        SA_164 = 164,
        MELEE_ATTACK_POWER_ATTACKER_BONUS = 165,
        MOD_ATTACK_POWER_PCT = 166,
        MOD_RANGED_ATTACK_POWER_PCT = 167,
        MOD_DAMAGE_DONE_VERSUS = 168,
        MOD_CRIT_PERCENT_VERSUS = 169,
        DETECT_AMORE = 170,
        MOD_SPEED_NOT_STACK = 171,
        MOD_MOUNTED_SPEED_NOT_STACK = 172,
        SA_173 = 173,                                   // old SPELL_AURA_ALLOW_CHAMPION_SPELLS
        MOD_SPELL_DAMAGE_OF_STAT_PERCENT = 174,      // by defeult intelect, dependent from SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT
        MOD_SPELL_HEALING_OF_STAT_PERCENT = 175,
        SPIRIT_OF_REDEMPTION = 176,
        AOE_CHARM = 177,
        MOD_DEBUFF_RESISTANCE = 178,
        MOD_ATTACKER_SPELL_CRIT_CHANCE = 179,
        MOD_FLAT_SPELL_DAMAGE_VERSUS = 180,
        SA_181 = 181,                                   // old SPELL_AURA_MOD_FLAT_SPELL_CRIT_DAMAGE_VERSUS - possible flat spell crit damage versus
        MOD_RESISTANCE_OF_STAT_PERCENT = 182,
        MOD_CRITICAL_THREAT = 183,
        MOD_ATTACKER_MELEE_HIT_CHANCE = 184,
        MOD_ATTACKER_RANGED_HIT_CHANCE = 185,
        MOD_ATTACKER_SPELL_HIT_CHANCE = 186,
        MOD_ATTACKER_MELEE_CRIT_CHANCE = 187,
        MOD_ATTACKER_RANGED_CRIT_CHANCE = 188,
        MOD_RATING = 189,
        MOD_FACTION_REPUTATION_GAIN = 190,
        USE_NORMAL_MOVEMENT_SPEED = 191,
        MOD_MELEE_RANGED_HASTE = 192,
        HASTE_ALL = 193,
        MOD_IGNORE_ABSORB_SCHOOL = 194,
        MOD_IGNORE_ABSORB_FOR_SPELL = 195,
        MOD_COOLDOWN = 196,                          // only 24818 Noxious Breath
        MOD_ATTACKER_SPELL_AND_WEAPON_CRIT_CHANCE = 197,
        SA_198 = 198,                                   // old SPELL_AURA_MOD_ALL_WEAPON_SKILLS
        MOD_INCREASES_SPELL_PCT_TO_HIT = 199,
        MOD_KILL_XP_PCT = 200,
        FLY = 201,
        IGNORE_COMBAT_RESULT = 202,
        MOD_ATTACKER_MELEE_CRIT_DAMAGE = 203,
        MOD_ATTACKER_RANGED_CRIT_DAMAGE = 204,
        MOD_ATTACKER_SPELL_CRIT_DAMAGE = 205,
        MOD_FLIGHT_SPEED = 206,
        MOD_FLIGHT_SPEED_MOUNTED = 207,
        MOD_FLIGHT_SPEED_STACKING = 208,
        MOD_FLIGHT_SPEED_MOUNTED_STACKING = 209,
        MOD_FLIGHT_SPEED_NOT_STACKING = 210,
        MOD_FLIGHT_SPEED_MOUNTED_NOT_STACKING = 211,
        MOD_RANGED_ATTACK_POWER_OF_STAT_PERCENT = 212,
        MOD_RAGE_FROM_DAMAGE_DEALT = 213,
        SA_214 = 214,
        ARENA_PREPARATION = 215,
        HASTE_SPELLS = 216,
        SA_217 = 217,
        HASTE_RANGED = 218,
        MOD_MANA_REGEN_FROM_STAT = 219,
        MOD_RATING_FROM_STAT = 220,
        IGNORED = 221,
        SA_222 = 222,
        SA_223 = 223,
        SA_224 = 224,
        PRAYER_OF_MENDING = 225,
        PERIODIC_DUMMY = 226,
        PERIODIC_TRIGGER_SPELL_WITH_VALUE = 227,
        DETECT_STEALTH = 228,
        MOD_AOE_DAMAGE_AVOIDANCE = 229,
        SA_230 = 230,
        PROC_TRIGGER_SPELL_WITH_VALUE = 231,
        MECHANIC_DURATION_MOD = 232,
        SA_233 = 233,
        MECHANIC_DURATION_MOD_NOT_STACK = 234,
        MOD_DISPEL_RESIST = 235,
        CONTROL_VEHICLE = 236,
        MOD_SPELL_DAMAGE_OF_ATTACK_POWER = 237,
        MOD_SPELL_HEALING_OF_ATTACK_POWER = 238,
        MOD_SCALE_2 = 239,
        MOD_EXPERTISE = 240,
        FORCE_MOVE_FORWARD = 241,
        MOD_SPELL_DAMAGE_FROM_HEALING = 242,
        SA_243 = 243,
        COMPREHEND_LANGUAGE = 244,
        MOD_DURATION_OF_MAGIC_EFFECTS = 245,
        MOD_DURATION_OF_EFFECTS_BY_DISPEL = 246,
        MIRROR_IMAGE = 247,
        MOD_COMBAT_RESULT_CHANCE = 248,
        CONVERT_RUNE = 249,
        MOD_INCREASE_HEALTH_2 = 250,
        MOD_ENEMY_DODGE = 251,
        SLOW_ALL = 252,
        MOD_BLOCK_CRIT_CHANCE = 253,
        MOD_DISARM_OFFHAND = 254,
        MOD_MECHANIC_DAMAGE_TAKEN_PERCENT = 255,
        NO_REAGENT_USE = 256,
        MOD_TARGET_RESIST_BY_SPELL_CLASS = 257,
        SA_258 = 258,
        MOD_PERIODIC_HEAL = 259,
        SCREEN_EFFECT = 260,
        PHASE = 261,
        IGNORE_UNIT_STATE = 262,
        ALLOW_ONLY_ABILITY = 263,
        SA_264 = 264,
        SA_265 = 265,
        SA_266 = 266,
        MOD_IMMUNE_AURA_APPLY_SCHOOL = 267,
        MOD_ATTACK_POWER_OF_STAT_PERCENT = 268,
        MOD_IGNORE_DAMAGE_REDUCTION_SCHOOL = 269,
        MOD_IGNORE_TARGET_RESIST = 270,              // Possibly need swap vs 195 aura used only in 1 spell Chaos Bolt Passive
        MOD_DAMAGE_FROM_CASTER = 271,
        MAELSTROM_WEAPON = 272,
        X_RAY = 273,
        SA_274 = 274,
        MOD_IGNORE_SHAPESHIFT = 275,
        SA_276 = 276,                                   // Only "Test Mod Damage % Mechanic" spell, possible mod damage done
        MOD_MAX_AFFECTED_TARGETS = 277,
        MOD_DISARM_RANGED = 278,
        INITIALIZE_IMAGES = 279,
        MOD_TARGET_ARMOR_PCT = 280,
        MOD_HONOR_GAIN = 281,
        MOD_BASE_HEALTH_PCT = 282,
        MOD_HEALING_RECEIVED = 283,                  // Possibly only for some spell family class spells
        SA_284,
        MOD_ATTACK_POWER_OF_ARMOR = 285,
        ABILITY_PERIODIC_CRIT = 286,
        DEFLECT_SPELLS = 287,
        MOD_PARRY_FROM_BEHIND_PERCENT = 288,
        SA_289 = 289,
        MOD_ALL_CRIT_CHANCE = 290,
        MOD_QUEST_XP_PCT = 291,
        OPEN_STABLE = 292,
        ADD_MECHANIC_ABILITIES = 293,
        STOP_NATURAL_MANA_REGEN = 294,
        SA_295 = 295,
        SET_VEHICLE_ID = 296,
        SA_297 = 297,
        SA_298 = 298,
        SA_299 = 299,
        SA_300 = 300,
        HEAL_ABSORB = 301,
        SA_302 = 302,
        SA_303 = 303,
        FAKE_INEBRIATE = 304,
        MOD_MINIMUM_SPEED = 305,
        SA_306 = 306,
        SA_307 = 307,
        SA_308 = 308,
        SA_309 = 309,
        MOD_PET_AOE_DAMAGE_AVOIDANCE = 310,
        SA_311 = 311,
        SA_312 = 312,
        SA_313 = 313,
        PREVENT_RESURRECTION = 314,
        UNDERWATER_WALKING = 315,
        SA_316 = 316,
        MOD_INCREASE_SPELL_POWER_PCT = 317,
        MASTERY = 318,
        MOD_MELEE_ATTACK_SPEED = 319,
        MOD_RANGED_ATTACK_SPEED = 320,
        SA_321 = 321,
        INTERFERE_TARGETING = 322,
        SA_323 = 323,
        SA_324 = 324,
        SA_325 = 325,
        SA_326 = 326,
        SA_327 = 327,
        SA_328 = 328,
        MOD_RUNIC_POWER_REGEN = 329,
        ALLOW_CAST_WHILE_MOVING = 330,
        MOD_WEATHER = 331,
        OVERRIDE_ACTIONBAR_SPELLS = 332,
        OVERRIDE_ACTIONBAR_SPELLS_2 = 333,
        BLIND_SIGHT = 334,
        SA_335 = 335,
        FLIGHT_RESTRICTIONS = 336,
        MOD_VENDOR_PRICE = 337,
        MOD_DURABILITY_LOSS = 338,
        MOD_SKILLCHANCE = 339,
        MOD_RESSURECTED_HEALTH = 340,
        SA_341 = 341,
        MOD_ATTACKSPEED_2 = 342,
        MOD_ALL_DAMAGE_FROM_CASTER = 343,
        MOD_AUTOATTACK_DAMAGE = 344,
        MOD_IGNORE_ARMOR_PCT = 345,
        SA_346 = 346,
        MOD_CD_FROM_HASTE = 347,
        MOD_MONEY_TO_GUILD_BANK = 348,
        MOD_CURRENCY_GAIN = 349,
        MOD_MATERIAL_GAIN = 350,
        SA_351 = 351,
        ALLOW_WORGEN_TRANSFORM = 352,
        CAMOUFLAGE = 353,
        MOD_HEALING_DONE_FROM_PCT_HEALTH = 354,
        SA_355 = 355,
        MOD_DAMAGE_DONE_FROM_PCT_POWER = 356,
        SA_357 = 357,
        WORGEN_TRANSFORM = 358,
        SA_359 = 359,
        PROC_DUPLICATE_SPELLS = 360,
        SA_361 = 361,
        SA_362 = 362,
        SA_363 = 363,
        SA_364 = 364,
        SA_365 = 365,
        MOD_SPELL_POWER_OF_ATTACK_POWER = 366,
        SA_367 = 367,
        SA_368 = 368,
        SA_369 = 369,       
        SA_370 = 370,
    };
}
