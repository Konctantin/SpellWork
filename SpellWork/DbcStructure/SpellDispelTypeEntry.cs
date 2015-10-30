using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellDispelTypeEntry
    {
        public int Id;
        public string _name;
        public int unk1;
        public int IsDispelled;
        public int unk2;
    }
}
