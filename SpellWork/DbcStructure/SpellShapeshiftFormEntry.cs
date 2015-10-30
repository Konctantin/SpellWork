using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellShapeshiftFormEntry
    {
        public int Id;
        public int Index;
        public string _name;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 18)]
        public int[] unk;

        public string Name { get { return _name; } }
    }
}
