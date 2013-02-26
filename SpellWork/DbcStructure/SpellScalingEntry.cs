using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    // SpellScaling.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellScalingEntry
    {
        public uint Id;                                                     // 0        m_ID
        public uint CastTimeMin;                                            // 1
        public uint CastTimeMax;                                            // 2
        public uint CastScalingMaxLevel;                                    // 3
        public uint PlayerClass;                                            // 4        class?
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public float[] Coeff1;                                              // 5-7
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public float[] Coeff2;                                              // 8-10
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public float[] Coeff3;                                              // 11-13
        public float UnkMult;                                               // 14        some coefficient, mostly 1.0f
        public int UnkLevel;                                                // 15        some level
    };

}
