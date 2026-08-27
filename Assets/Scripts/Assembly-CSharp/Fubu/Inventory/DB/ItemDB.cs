using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Fubu.Inventory.DB
{
	[CreateAssetMenu(fileName = "ItemDB", menuName = "Inventory/DBs/ItemDB")]
	public class ItemDB : ScriptableObject
	{
		[Serializable]
		public class UpgradePercentages
		{
			[Tooltip("Separate upgrade groups for each item stat. Missing stat tables use the legacy shared table below.")]
			public StatUpgradePercentages[] statUpgradePercentages;

			[Tooltip("Legacy shared upgrade groups used when a stat-specific table is not configured.")]
			public ItemUpgrade[] upgradeItem;

			public float CalculateUpgradeStat(float startValue, PlayerStatType statType, int level)
			{
				return 0f;
			}

			public float CalculateUpgradeStat(float startValue, int level)
			{
				return 0f;
			}

			private float CalculateUpgradeStat(float startValue, ItemUpgrade[] upgrades, int level)
			{
				return 0f;
			}

			public float CalculateUpgradePrice(float startPrice, int level)
			{
				return 0f;
			}
		}

		[Serializable]
		public class ItemUpgrade
		{
			public int upgradeGroup;

			public int minLevel;

			public int maxLevel;

			public float upgradePercentage;
		}

		[Serializable]
		public class StatUpgradePercentages
		{
			public PlayerStatType statType;

			public ItemUpgrade[] upgradeItem;
		}

		[Serializable]
		public class Item
		{
			public string uIName;

			public string description;

			public ItemRarity itemRarity;

			public ItemSlot slot;

			public StatsByRarity[] statsWRarity;

			[FormerlySerializedAs("prices")]
			public UpgradePrice[] upgradePrices;

			public Sprite icon;

			public int count;

			public int id;

			[Tooltip("The item ID that will be created after the merge. If can't merge must be the same as ID ")]
			public int mergeItemID;

			public int level;

			[Tooltip("Upgrade for stacked items. \"upgrade Prices\" is used for separate items.")]
			public int[] itemCountsForStackUpgrade;

			public bool isUsing;

			public StatsByRarity GetStatsByRarity()
			{
				return null;
			}

			public Item(Item t)
			{
			}

			public Item(string name, string description, Sprite sprite, ItemRarity itemRarity, ItemSlot itemSlot, int id, int[] itemCountsForStackUpgrade, Stat[] stats, StatsByRarity[] statsWRarity, int maxLevel)
			{
			}

			public StatPlayer GetStat(PlayerStatType type)
			{
				return null;
			}

			public float GetItemSpecialEffect()
			{
				return 0f;
			}
		}

		[Serializable]
		public class StatsByRarity
		{
			public ItemRarity itemRarity;

			public StatPlayer[] stats;

			public ItemSpecialEffect specialEffect;

			public float valueSpecialEffect;

			public string specialDescription;
		}

		[Serializable]
		public class StatPlayer
		{
			public PlayerStatType statType;

			public float statValues;
		}

		[Serializable]
		public class Stat
		{
			public PlayerStatType statType;

			public float[] statValues;

			public float statStart;

			public float statIcrease;

			public Stat(PlayerStatType statType, float[] statValues)
			{
			}

			public Stat(PlayerStatType statType, float startValue, float endValue, int size)
			{
			}
		}

		[Serializable]
		public class UpgradePrice
		{
			public Price prices;

			public Price GetPrice(CurrencyTypes type)
			{
				return null;
			}
		}

		[Serializable]
		public class Price
		{
			public int startPrice;

			public int priceIncrease;

			public RarityPrice[] rarityPrices;

			public CurrencyTypes currencyType;

			public int GetCurrentPrice(int lvl)
			{
				return 0;
			}

			public int GetCurrentPrice(int lvl, ItemRarity rarity)
			{
				return 0;
			}

			public int GetRarityPrice(ItemRarity rarity)
			{
				return 0;
			}
		}

		[Serializable]
		public class RarityPrice
		{
			public ItemRarity rarity;

			public int price;
		}

		[Serializable]
		public class Reward
		{
			public ItemSlot Slot;

			public ItemRarity rarity;

			public int id;

			public int count;

			public Reward(ItemSlot slot, int id, int count, ItemRarity rarity)
			{
			}
		}

		[SerializeField]
		public List<Item> items;

		public UpgradePercentages upgradePercentages;

		public List<Item> GetItems()
		{
			return null;
		}

		public void AddItem(Item i)
		{
		}

		public void RemoveItem(Item i)
		{
		}

		public Item FindItem(ItemSlot slot, int id)
		{
			return null;
		}

		public Item FindItem(ItemSlot slot, int id, ItemRarity rarity)
		{
			return null;
		}

		public List<Item> FindItemsBySlot(ItemSlot slot)
		{
			return null;
		}

		public float GetAllActiveBonus(ItemSpecialEffect itemSpecial)
		{
			return 0f;
		}
	}
}
