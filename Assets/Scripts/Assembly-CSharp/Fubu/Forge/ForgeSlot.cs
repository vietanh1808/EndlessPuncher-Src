using System;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Forge
{
	public class ForgeSlot : MonoBehaviour
	{
		[Header("Configuration")]
		[SerializeField]
		private ForgeItemSlot itemSlot;

		[Header("UI Components")]
		[SerializeField]
		private Image icon;

		[SerializeField]
		private GameObject[] rarityBgs;

		[SerializeField]
		private Animator slotAnimator;

		[SerializeField]
		private Button button;

		private int _slotId;

		private static readonly int PopTrigger;

		private const string HAS_ITEM_KEY_FORMAT = "slot_{0}_has_item";

		private const string DATA_KEY_FORMAT = "slot_{0}_data";

		public ForgeItemSlot ItemSlot => ForgeItemSlot.Weapon;

		public bool HasItem { get; private set; }

		public SlotItem Item { get; private set; }

		private void Awake()
		{
		}

		private void OnSlotClicked()
		{
		}

		public void SetSlot(SlotItem newItem, bool save)
		{
		}

		private void UpdateVisuals()
		{
		}

		public float GetStatValue(StatType statType)
		{
			return 0f;
		}

		public float GetBaseValue(StatType statType)
		{
			return 0f;
		}

		private float GetValueFromStats(StatType statType, Func<SlotStat, double> valueSelector)
		{
			return 0f;
		}

		private void SaveSlot()
		{
		}

		private void LoadSlot()
		{
		}

		public int GetRarity()
		{
			return 0;
		}
	}
}
