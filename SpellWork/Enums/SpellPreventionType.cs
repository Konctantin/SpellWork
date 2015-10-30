namespace SpellWork.Enums
{
    public enum SpellPreventionType
    {
        NONE    = 0,
        SILENCE = 1,
        PACIFY  = 2,
        UNK     = 3 // Only a few spells have this, but most of the should be interruptable.
    };
}
