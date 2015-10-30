using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellDifficultyEntry
    {
        public uint Id;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 4)]
        public uint[] Spells;
    };
}
