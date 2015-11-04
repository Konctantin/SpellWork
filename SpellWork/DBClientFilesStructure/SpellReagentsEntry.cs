using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.DBClientFilesStructure
{
    // SpellReagents.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellReagentsEntry
    {
        public uint Id;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 8)]
        public int[] Reagent;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 8)]
        public uint[] ReagentCount;
    };
}
