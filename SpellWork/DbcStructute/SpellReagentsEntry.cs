using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    // SpellReagents.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellReagentsEntry
    {
        public uint Id;                                           // 0        m_ID
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 8)]
        public int[] Reagent;                                    // 54-61    m_reagent
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 8)]
        public uint[] ReagentCount;                               // 62-69    m_reagentCount
    };

}
