using System.Runtime.InteropServices;
using SpellWork.Enums;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellMiscEntry
    {
        public uint ID;
        public SpellAttribute0  Attributes;
        public SpellAttribute1  AttributesEx;
        public SpellAttribute2  AttributesExB;
        public SpellAttribute3  AttributesExC;
        public SpellAttribute4  AttributesExD;
        public SpellAttribute5  AttributesExE;
        public SpellAttribute6  AttributesExF;
        public SpellAttribute7  AttributesExG;
        public SpellAttribute8  AttributesExH;
        public SpellAttribute9  AttributesExI;
        public SpellAttribute10 AttributesExJ;
        public SpellAttribute11 AttributesExK;
        public SpellAttribute12 AttributesExL;
        public SpellAttribute13 AttributesExM;
        public uint CastingTimeIndex;
        public uint DurationIndex;
        public uint RangeIndex;
        public float Speed;
        public uint SpellIconID;
        public uint ActiveIconID;
        public SpellSchoolMask SchoolMask;
        public float MultistrikeSpeedMod;
    }
}
