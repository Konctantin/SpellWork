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
        public uint Id;                                          // 0        m_ID
        public int EquippedItemClass;                            // 70       m_equippedItemClass (value)
        public int EquippedItemInventoryTypeMask;                // 72       m_equippedItemInvTypes (mask)
        public int EquippedItemSubClassMask;                     // 71       m_equippedItemSubclass (mask)
    };

}
