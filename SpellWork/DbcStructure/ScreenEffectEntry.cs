using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class ScreenEffectEntry
    {
        public uint Id;
        public string _Name;
        public uint Unk0;
        public float Unk1;
        public uint Unk2;
        public uint Unk3;           // % of smth?
        public uint Unk4;           // all 0
        public int Unk5;
        public uint Unk6;
        public uint Unk7;
        public int Unk8;

        public string Name
        {
            get { return _Name; }
        }
    };

}
