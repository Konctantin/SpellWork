using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    // SpellInterrupts.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellInterruptsEntry
    {
        public uint ID;
        public uint SpellID;
        public uint DifficultyID;
        public uint AuraInterruptFlags0;
        public uint AuraInterruptFlags1;
        public uint ChannelInterruptFlags0;
        public uint ChannelInterruptFlags1;
        public uint InterruptFlags;
    };
}
