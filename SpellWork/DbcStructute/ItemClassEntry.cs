using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class ItemClassEntry
    {
        public uint Id;
        public uint unk1;
        public uint unk2;
        public uint unk3;
        public uint unk4;
        public string _Name;

        public string Name { get { return _Name; } }
    }
}

