using System.Runtime.InteropServices;
using DBFilesClient.NET;
using System.Collections.Generic;
using System.Linq;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellMiscDifficultyEntry
    {
        public uint Id;
        public uint Spell1;
        public uint Spell2;

        //public IEnumerable<SpellEntry> SpellList
        //{
        //    get
        //    {
        //        foreach (var spell in DBC.Spell)
        //            if (Spells.Contains(spell.ID))
        //                yield return spell;
        //    }
        //}
    };
}
