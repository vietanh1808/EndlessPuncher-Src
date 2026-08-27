using System;
using System.Collections.Generic;
using UnityEngine;

namespace Fubu.Forge
{
	[CreateAssetMenu(fileName = "ForgeDB", menuName = "DBs/ForgeDB")]
	public class ForgeDB : ScriptableObject
	{
		[Serializable]
		public class Item
		{
			public string uIName;

			public string description;

			public ForgeItemRarity itemRarity;

			public ForgeItemSlot slot;

			public Stat[] stats;

			public Sprite icon;

			public int id;

			public int level;

			public bool isUsing;

			public Item(Item t)
			{
			}

			public Item(string uIName, string description, ForgeItemRarity itemRarity, ForgeItemSlot slot, Stat[] stats, Sprite icon, int id, int level, bool isUsing)
			{
			}

			public Stat GetStat(StatType type)
			{
				return null;
			}

			public void RandomizeStats()
			{
			}
		}

		[Serializable]
		public class Stat
		{
			public StatType statType;

			public float[] statValues;

			private int level;

			public Stat(StatType statType, float[] statValues)
			{
			}

			public Stat(StatType statType, float startValue, float endValue, int size)
			{
			}

			public double GetValue(bool hasValue, float value, bool isTest)
			{
				return 0.0;
			}

			public void RandomizeLevel()
			{
			}
		}

		[Serializable]
		public class Price
		{
			public int price;

			public CurrencyTypes currencyType;
		}

		[Serializable]
		public class Reward
		{
			public ForgeSlot Slot;

			public int id;

			public int count;

			public Reward(ForgeSlot slot, int id, int count)
			{
			}
		}

		[SerializeField]
		public List<Item> items;

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

		public Item FindItem(ForgeItemSlot slot, int id)
		{
			return null;
		}

		public List<Item> FindItemsBySlot(ForgeItemSlot slot)
		{
			return null;
		}

		public Item FindRandomItem(ForgeItemRarity rndRarity, ForgeItemSlot rndSlot)
		{
			return null;
		}

		public Item FindRandomItem()
		{
			return null;
		}
	}
}
