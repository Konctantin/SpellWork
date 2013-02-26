using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    // SpellClassOptions.dbc
    [StructLayout(LayoutKind.Sequential)]
    public class SpellClassOptionsEntry
    {
        public uint Id;                                           // 0        m_ID
        public uint ModalNextSpell;                               // 50       m_modalNextSpell not used
        [StoragePresence(StoragePresenceOption.Include, ArraySize = DBC.MAX_EFFECT_INDEX)]
        public uint[] SpellFamilyFlags;                           // 149-150  m_spellClassMask NOTE: size is 12 bytes!!!
        public uint SpellFamilyName;                              // 148      m_spellClassSet
        public string _Description;                               // 6 4.0.0

        public string Description
        {
            get { return _Description; }
        }
    };

}
