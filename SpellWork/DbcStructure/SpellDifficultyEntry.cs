using System.Collections.Generic;
using System.Runtime.InteropServices;
using DBFilesClient.NET;

namespace SpellWork.Dbc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellDifficultyEntry
    {
        public uint Id;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 4)]
        public uint[] Spells;

        public IEnumerable<SpellEntry> SpellList
        {
            get 
            {
                foreach (var spell_id in Spells)
                {
                    SpellEntry spell;
                    if (DBC.Spell.TryGetValue(spell_id, out spell))
                        yield return spell;
                }
            }
        }
    };
}
