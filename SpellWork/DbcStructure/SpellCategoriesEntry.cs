using System.Runtime.InteropServices;

using SpellWork.Enums;

namespace SpellWork.Dbc
{
    // SpellCategories.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellCategoriesEntry
    {
        public uint ID;
        public uint SpellID;
        public uint DifficultyID;
        public uint Category;
        public uint DefenseType;
        public uint DispelType;
        public uint Mechanic;
        public uint PreventionType;
        public uint StartRecoveryCategory;
        public uint ChargeCategory;
    };
}
