using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellDurationEntry
    {
        public uint ID;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = DBC.MAX_EFFECT_INDEX)]
        public int[] Duration;

        public override string ToString()
        {
            return String.Format("Duration: ID ({0})  {1}, {2}, {3}", ID, Duration[0], Duration[1], Duration[2]);
        }
    };

}
