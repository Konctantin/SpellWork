using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class CurrencyTypesEntry
    {
        public uint Id;
        public uint Category;
        public string _Name;
        public string _Icon;
        public uint Unk0;
        public uint Unk1_Archaeology;
        public uint Unk2_Archaeology;
        public uint TotalCap;
        public uint WeekCap;
        public uint Unk3;
        public string _Desc;

        public string Name { get { return _Name; } }
        public string Icon { get { return _Icon; } }
        public string Desc { get { return _Desc; } }
    };
}
