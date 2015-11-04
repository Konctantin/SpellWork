using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    // SpellAuraOptions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellAuraOptionsEntry
    {
        public uint ID;                    // 0
        public uint SpellID;               // 1
        public uint DifficultyID;          // 2
        public uint CumulativeAura;        // 3
        public uint ProcChance;            // 4
        public uint ProcCharges;           // 5
        public uint ProcTypeMask;          // 6
        public uint ProcCategoryRecovery;  // 7
        public uint SpellProcsPerMinuteID; // 8
    };
}
