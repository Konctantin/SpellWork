using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

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

        public string Name { get { return _name; } }

        public override string ToString()
        {
            return string.Format("Dispel type: ({0}) {1}", Id, Name);
        }
    }
}
