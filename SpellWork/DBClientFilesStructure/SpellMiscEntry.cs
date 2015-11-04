using System.Runtime.InteropServices;
using SpellWork.Enums;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellMiscEntry
    {
        public uint ID;
        public SpellAttribute0  Attributes0  { get; private set; }
        public SpellAttribute1  Attributes1  { get; private set; }
        public SpellAttribute2  Attributes2  { get; private set; }
        public SpellAttribute3  Attributes3  { get; private set; }
        public SpellAttribute4  Attributes4  { get; private set; }
        public SpellAttribute5  Attributes5  { get; private set; }
        public SpellAttribute6  Attributes6  { get; private set; }
        public SpellAttribute7  Attributes7  { get; private set; }
        public SpellAttribute8  Attributes8  { get; private set; }
        public SpellAttribute9  Attributes9  { get; private set; }
        public SpellAttribute10 Attributes10 { get; private set; }
        public SpellAttribute11 Attributes11 { get; private set; }
        public SpellAttribute12 Attributes12 { get; private set; }
        public SpellAttribute13 Attributes13 { get; private set; }
        public uint CastingTimeIndex;
        public uint DurationIndex;
        public uint RangeIndex;
        public float Speed                   { get; private set; }
        public uint SpellIconID;
        public uint ActiveIconID;
        public SpellSchoolMask SchoolMask    { get; private set; }
        public float MultistrikeSpeedMod     { get; private set; }

        public SpellCastTimesEntry CastTime => DBC.SpellCastTimes.GetValueOrDefault(CastingTimeIndex);
        public SpellDurationEntry Duration  => DBC.SpellDuration.GetValueOrDefault(DurationIndex);
        public SpellRangeEntry Range        => DBC.SpellRange.GetValueOrDefault(RangeIndex);
    }
}
