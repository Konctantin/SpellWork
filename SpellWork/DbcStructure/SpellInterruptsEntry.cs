using System.Runtime.InteropServices;

namespace SpellWork.Dbc
{
    // SpellInterrupts.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellInterruptsEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint AuraInterruptFlags;                           // 33       m_auraInterruptFlags
        public uint Unk1;                                         // 34       4.0.0
        public uint ChannelInterruptFlags;                        // 35       m_channelInterruptFlags
        public uint Unk2;                                         // 36       4.0.0
        public uint InterruptFlags;                               // 32       m_interruptFlags
    };

}
