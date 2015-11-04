using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class SkillLineEntry
    {
        public uint ID;                   // 0        m_ID
        public int CategoryID;            // 1        m_categoryID
        public string DisplayName_lang;   // 2        m_displayName_lang
        public string Description_lang;   // 3        m_description_lang
        public uint SpellIconID;          // 4        m_spellIconID
        public string AlternateVerb_lang; // 5        m_alternateVerb_lang
        public uint CanLink;              // 6        m_canLink (prof. with recipes)
        public uint ParentSkillLineID;    // 7
        public uint Flags;                // 8
    };
}
