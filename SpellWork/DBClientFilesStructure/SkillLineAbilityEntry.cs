using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class SkillLineAbilityEntry
    {
        public uint ID;                       // 0
        public uint SkillLine;                // 1
        public uint SpellID;                  // 2
        public uint RaceMask;                 // 3
        public uint ClassMask;                // 4
        public uint MinSkillLineRank;         // 7
        public uint SupercedesSpell;          // 8
        public uint AquireMethod;             // 9
        public uint TrivialSkillLineRankHigh; // 10
        public uint TrivialSkillLineRankLow;  // 11
        public uint NumSkillUps;              // 12
        public uint UniqueBit;                // 13
        public uint TradeSkillCategoryID;     // 14
    };

}
