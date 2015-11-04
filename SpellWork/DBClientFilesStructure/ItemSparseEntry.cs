using DBFilesClient.NET;
using System.Runtime.InteropServices;

namespace SpellWork.DBClientFilesStructure
{
    [StructLayout(LayoutKind.Sequential)]
    public class ItemSparseEntry
    {
        public uint ID { get; private set; }
        public uint  Quality;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public uint[]  Flags;
        float Unk1;
        float Unk2;
        public uint  BuyCount;
        public uint  BuyPrice;
        public uint  SellPrice;
        public uint  InventoryType;
        public int   AllowableClass;
        public int   AllowableRace;
        public uint  ItemLevel;
        public int   RequiredLevel;
        public uint  RequiredSkill;
        public uint  RequiredSkillRank;
        public uint  RequiredSpell;
        public uint  RequiredHonorRank;
        public uint  RequiredCityRank;
        public uint  RequiredReputationFaction;
        public uint  RequiredReputationRank;
        public uint  MaxCount;
        public uint  Stackable;
        public uint  ContainerSlots;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        public int[] ItemStatType;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        public int[] ItemStatValue;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        public int[] ItemStatAllocation;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        public float[] ItemStatSocketCostMultiplier;
        public uint  ScalingStatDistribution;
        public uint  DamageType;
        public uint  Delay;
        public float RangedModRange;
        public uint  Bonding;
        public string Name { get; private set; }
        public string Name2;
        public string Name3;
        public string Name4;
        public string Description { get; private set; }
        public uint  PageText;
        public uint  LanguageID;
        public uint  PageMaterial;
        public uint  StartQuest;
        public uint  LockID;
        public int   Material;
        public uint  Sheath;
        public uint  RandomProperty;
        public uint  RandomSuffix;
        public uint  ItemSet;
        public uint  Area;
        public uint  Map;
        public uint  BagFamily;
        public uint  TotemCategory;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public uint[]  SocketColor;
        public uint  SocketBonus;
        public uint  GemProperties;
        public float ArmorDamageModifier;
        public uint  Duration;
        public uint  ItemLimitCategory;
        public uint  HolidayID;
        public float StatScalingFactor;
        public uint  CurrencySubstitutionID;
        public uint  CurrencySubstitutionCount;
        public uint  ItemNameDescriptionID;
    }
}
