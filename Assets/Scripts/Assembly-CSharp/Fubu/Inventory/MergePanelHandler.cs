using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Inventory
{
	public class MergePanelHandler : MonoBehaviour
	{
		private class MergeBatch
		{
			public ItemSlot slot;

			public int id;

			public ItemRarity rarity;

			public readonly List<ItemCard> cards;
		}

		[Serializable]
		public class StatFUpgrade
		{
			public PlayerStatType stat;

			public TextMeshProUGUI textStat;

			public GameObject statObje;
		}

		[SerializeField]
		private TextMeshProUGUI descriptionInfo;

		[SerializeField]
		private GameObject panel;

		[SerializeField]
		private Transform[] selectedItemHolders;

		[SerializeField]
		private GameObject selectedObjectsHolder;

		[SerializeField]
		private ItemCard fakeItem;

		[SerializeField]
		private GameObject fakeItemObject;

		[SerializeField]
		private Button mergeButton;

		[SerializeField]
		private Button quickMergeButton;

		[SerializeField]
		private Color[] rankColors;

		private ItemCard[] selectedItems;

		private bool isQuickMerging;

		[Header("Upgrade Panel")]
		[SerializeField]
		private GameObject upgradePanel;

		[SerializeField]
		private Image upgradeIcon;

		[SerializeField]
		private Image[] backGrounds;

		[SerializeField]
		private GameObject[] rarityBGs;

		[SerializeField]
		private TextMeshProUGUI levelText;

		[SerializeField]
		private List<StatFUpgrade> stats;

		public void OpenPanel()
		{
		}

		private void OnDestroy()
		{
		}

		public void SelectItem(ItemCard card)
		{
		}

		private ItemCard FindOtherItem(ItemCard card)
		{
			return null;
		}

		public void Merge()
		{
		}

		public void QuickMerge()
		{
		}

		private void MergeCards(ItemCard[] cardsToMerge, bool showUpgradePanel, bool playQuickMergeEffect)
		{
		}

		private void ShowUpgradeResult(ItemDB.Item item, int maxLevel)
		{
		}

		private void UpdateUpgradeStats(ItemDB.Item item)
		{
		}

		private int FindMaxLevel(ItemCard[] cardsToMerge)
		{
			return 0;
		}

		private bool AreCardsStillOwned(ItemCard[] cardsToMerge)
		{
			return false;
		}

		private List<MergeBatch> BuildMergeBatches()
		{
			return null;
		}

		private void RefreshQuickMergeButton()
		{
		}

		private void ClearSelection()
		{
		}

		private void DelayCheckItems()
		{
		}

		private int FindMaxLevel()
		{
			return 0;
		}

		public void CloseMergePanel()
		{
		}

		public void CloseUpgradePanel()
		{
		}

		private void UpdateDescriptionInfo()
		{
		}

		private float GetStatValue(ItemDB.Item item, PlayerStatType statType, int level)
		{
			return 0f;
		}

		private string FormatStatDelta(float value, PlayerStatType statType)
		{
			return null;
		}

		private string GetStatValueSuffix(PlayerStatType statType)
		{
			return null;
		}

		private string GetStatDisplayName(PlayerStatType statType)
		{
			return null;
		}
	}
}
