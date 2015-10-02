using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    // SpellEquippedItems.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellEquippedItemsEntry
    {
        public uint Id;
        public int EquippedItemClass;
        public int EquippedItemInventoryTypeMask;
        public int EquippedItemSubClassMask;
    };
}