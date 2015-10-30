using System.Runtime.InteropServices;

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