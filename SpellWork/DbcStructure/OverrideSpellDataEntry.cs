using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class OverrideSpellDataEntry
    {
        public uint Id;
        // Value 10 also used in SpellInfo.AuraModTypeName
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        public uint[] Spells;
        public uint unk;
        public string AltBarStringIndex; // string
    };

}
