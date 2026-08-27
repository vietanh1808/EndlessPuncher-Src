using System;
using System.Collections.Generic;
using UnityEngine;

namespace Fubu.Inventory.DB
{
	[CreateAssetMenu(fileName = "ScrollDB", menuName = "Inventory/DBs/ScrollDB")]
	public class ScrollDB : ScriptableObject
	{
		[Serializable]
		public class Scroll
		{
			public Sprite icon;

			public string uIName;

			public string description;

			public ItemSlot slot;

			public int count;

			public Scroll(Scroll t)
			{
			}

			public int GetCount()
			{
				return 0;
			}
		}

		[Serializable]
		public class Reward
		{
			public ItemSlot slot;

			public int count;
		}

		[Serializable]
		public class SerializableList<T>
		{
			public List<T> list;
		}

		public List<Scroll> scrolls;

		public void AddScroll(Scroll s)
		{
		}

		public void SaveScrolls()
		{
		}

		public Scroll FindScroll(ItemSlot slot)
		{
			return null;
		}

		public void SaveJson()
		{
		}

		public void GetJson()
		{
		}

		public void UseScroll(ItemSlot itemSlot, int i)
		{
		}

		public int GetCount(ItemSlot slot)
		{
			return 0;
		}
	}
}
