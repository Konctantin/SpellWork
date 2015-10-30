using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellDurationEntry
    {
        public uint ID;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public int[] Duration;
    };
}
