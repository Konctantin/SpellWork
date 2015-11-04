using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.DBClientFilesStructure
{
    // SpellTotems.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellTotemsEntry
    {
        public uint Id;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] TotemCategory;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] Totem;
    };
}