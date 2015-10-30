using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellRangeEntry
    {
        public uint ID;
        public float MinRange;
        public float MinRangeFriendly;
        public float MaxRange;
        public float MaxRangeFriendly;
        public uint Field5;
        public string _Desc1;
        public string _Desc2;

        public string Description1
        {
            get { return _Desc1; }
        }

        public string Description2
        {
            get { return _Desc2; }
        }
    };
}
