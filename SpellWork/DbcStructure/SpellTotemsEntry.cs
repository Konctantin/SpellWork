using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    // SpellTotems.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellTotemsEntry
    {
        public uint Id;                                           // 0        m_ID
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] TotemCategory;                              // 162-163  m_requiredTotemCategoryID
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] Totem;                                      // 52-53    m_totem
    };
}
