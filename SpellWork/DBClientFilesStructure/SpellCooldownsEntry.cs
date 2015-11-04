using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    // SpellCooldowns.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCooldownsEntry
    {
        public uint ID;
        public uint SpellID;
        public uint DifficultyID;
        public uint CategoryRecoveryTime;
        public uint RecoveryTime;
        public uint StartRecoveryTime;
    };
}
