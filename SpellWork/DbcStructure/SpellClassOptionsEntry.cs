using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DBFilesClient.NET;
using SpellWork.Enums;

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

        public override string ToString()
        {
            if (Id == 0) return "";

            return string.Format(
                "Family ({0}){1}, flag 0x{2:X8} {3:X8} {4:X8}\r\n" +
                "\tModal next spell: {5}\r\n" +
                "\tAura ToolTip: {6}",
                SpellFamilyName, (SpellFamilyNames)SpellFamilyName,
                SpellFamilyFlags[0], SpellFamilyFlags[1], SpellFamilyFlags[2],
                ModalNextSpell, Description
                );

        }
    };

}
