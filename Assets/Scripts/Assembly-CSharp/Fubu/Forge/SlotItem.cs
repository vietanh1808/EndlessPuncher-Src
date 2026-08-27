using System;
using UnityEngine;

namespace Fubu.Forge
{
	[Serializable]
	public class SlotItem
	{
		[SerializeField]
		private string uiName;

		[SerializeField]
		private ForgeHandler.ItemRarity itemRarity;

		[SerializeField]
		private ForgeItemSlot slot;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private SlotStat[] slotStats;

		[SerializeField]
		private int sellPrice;

		public string UIName => null;

		public ForgeHandler.ItemRarity ItemRarity => ForgeHandler.ItemRarity.Common;

		public ForgeItemSlot Slot => ForgeItemSlot.Weapon;

		public Sprite Icon => null;

		public int SellPrice => 0;

		public SlotStat[] SlotStats => null;

		public SlotItem(string uiName, ForgeHandler.ItemRarity itemRarity, ForgeItemSlot slot, Sprite icon, SlotStat[] slotStats, int sellPrice)
		{
		}

		public SlotStat GetStat(StatType statType)
		{
			return null;
		}

		public int GetPower()
		{
			return 0;
		}
	}
}
