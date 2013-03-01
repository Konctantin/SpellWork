using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum ProcFlagsEx : uint
    {
        PROC_EX_NONE                    = 0x0000000,                 // If none can trigger on Hit/Crit only (passive spells MUST defined by SpellFamily flag)

        PROC_EX_NORMAL_HIT              = 0x0000001,                 // If set only from normal hit (only damage spells)
        PROC_EX_CRITICAL_HIT            = 0x0000002,

        PROC_EX_MISS                    = 0x0000004,
        PROC_EX_RESIST                  = 0x0000008,

        PROC_EX_DODGE                   = 0x0000010,
        PROC_EX_PARRY                   = 0x0000020,

        PROC_EX_BLOCK                   = 0x0000040,
        PROC_EX_EVADE                   = 0x0000080,

        PROC_EX_IMMUNE                  = 0x0000100,
        PROC_EX_DEFLECT                 = 0x0000200,

        PROC_EX_ABSORB                  = 0x0000400,
        PROC_EX_REFLECT                 = 0x0000800,

        PROC_EX_INTERRUPT               = 0x0001000,                 // Melee hit result can be Interrupt (not used)
        PROC_EX_FULL_BLOCK              = 0x0002000,                 // block al attack damage

        PROC_EX_RESERVED2               = 0x0004000,
        PROC_EX_RESERVED3               = 0x0008000,

        PROC_EX_EX_TRIGGER_ALWAYS       = 0x0010000,                 // If set trigger always ( no matter another flags) used for drop charges
        PROC_EX_EX_ONE_TIME_TRIGGER     = 0x0020000                  // If set trigger always but only one time (not used)
    };
}
