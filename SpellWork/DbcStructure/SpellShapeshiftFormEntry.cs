using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellShapeshiftFormEntry
    {
        public uint ID;
        public uint BonusActionBar;
        public string Name_lang;
        public uint Flags;
        public int CreatureType;
        public uint AttackIconID;
        public uint CombatRoundTime;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 4)]
        public uint[] CreatureDisplayID;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 8)]
        public uint[] PresetSpellID;
        public uint MountTypeID;
        public uint ExitSoundEntriesID;
    }
}
