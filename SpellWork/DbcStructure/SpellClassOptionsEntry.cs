using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    // SpellClassOptions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellClassOptionsEntry
    {
        public uint Id;
        public uint ModalNextSpell;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 4)]
        public uint[] SpellFamilyFlags;
        public uint SpellFamilyName;
        public string _Description;
    };
}
