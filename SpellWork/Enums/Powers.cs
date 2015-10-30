namespace SpellWork.Enums
{
    public enum Powers : uint
    {
        MANA            = 0,
        RAGE            = 1,
        FOCUS           = 2,
        ENERGY          = 3,
        COMBO_POINTS    = 4,
        RUNES           = 5,
        RUNIC_POWER     = 6,
        SOUL_SHARDS     = 7,
        ECLIPSE         = 8,
        HOLY_POWER      = 9,
        ALTERNATE_POWER = 10,           // Used in some quests
        DARK_FORCE      = 11,
        CHI             = 12,
        SHADOW_ORBS     = 13,
        BURNING_EMBERS  = 14,
        DEMONIC_FURY    = 15,
        ARCANE_CHARGES  = 16,
        ALL             = 127,          // default for class?
        HEALTH          = 0xFFFFFFFE    // (-2 as signed value)
    };
}