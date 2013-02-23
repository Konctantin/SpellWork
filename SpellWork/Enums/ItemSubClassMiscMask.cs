using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellWork.Enums
{
    [Flags]
    public enum ItemSubClassMiscMask
    {
        ALL     = -1,
        JUNK    = 1 << 0,
        REAGENT = 1 << 1,
        PET     = 1 << 2,
        HOLIDAY = 1 << 3,
        OTHER   = 1 << 4,
        MOUNT   = 1 << 5,
    };
}
