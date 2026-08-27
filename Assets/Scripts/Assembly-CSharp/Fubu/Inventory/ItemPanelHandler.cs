using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;

namespace Fubu.Inventory
{
	public class ItemPanelHandler : MonoBehaviour, ITabPanel
	{
		[Serializable]
		public class Slot
		{
			public ItemSlot itemSlot;

			public Transform holder;

			private ItemCard card;

			public Animator animator;

			public void SetCard(ItemCard card)
			{
			}

			public ItemCard GetCard()
			{
				return null;
			}

			public void TakeOf()
			{
			}
		}

		[Serializable]
		public class StatInfo
		{
			public PlayerStatType statType;

			public TextMeshProUGUI[] statText;

			public float baseValue;

			private float totalValue;

			public void SetTotalValue(List<ItemCard> cards)
			{
			}

			public float GetTotalValue()
			{
				return 0f;
			}

			private string GetSymbol(PlayerStatType type)
			{
				return null;
			}

			private string GetSymbolPrefix(PlayerStatType type)
			{
				return null;
			}
		}

		[Serializable]
		public class SerializableList<T>
		{
			public List<T> list;
		}

		[Serializable]
		public class SavedItemData
		{
			public ItemSlot slot;

			public int id;

			public int rarity;

			public int level;

			public int count;

			public bool isUsing;
		}

		private static ItemPanelHandler instance;

		public bool stackItems;

		[Header("Tab Panel")]
		[SerializeField]
		private GameObject tabPanelObject;

		[SerializeField]
		private Animator animPanel;

		[SerializeField]
		private Transform itemHolder;

		[SerializeField]
		private ItemCard itemCardPrefab;

		[SerializeField]
		private Color[] rankColors;

		[SerializeField]
		private Slot[] slots;

		[SerializeField]
		private StatInfo[] statInfos;

		[SerializeField]
		private Scroll[] scrolls;

		[SerializeField]
		private MergePanelHandler mergePanelHandler;

		[SerializeField]
		private GameObject coverLock;

		[SerializeField]
		private TextMeshProUGUI globalPowerText;

		public GameObject maxPermanentRangeUpgradeText;

		private bool isMergePanelActive;

		private InGameUIMenuController menuController;

		private List<ItemCard> cards;

		[SerializeField]
		private GameObject greenGemCounterObject;

		public Action itemAddedAction;

		private const string SAVE_KEY_V2 = "ownedItems_v2";

		private const string SAVE_KEY_LEGACY = "ownedItemadi";

		public static ItemPanelHandler Instance => null;

		public List<ItemCard> GetCards => null;

		public void TakeOfItem(ItemCard card)
		{
		}

		public Slot FindSlot(ItemSlot slot)
		{
			return null;
		}

		public float GetItemStatTotalValue(PlayerStatType statType)
		{
			return 0f;
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void PanelActivated()
		{
		}

		private InGameUIMenuController GetMenuController()
		{
			return null;
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private GameObject GetTabPanelObject()
		{
			return null;
		}

		public void SetStatValues()
		{
		}

		private void SyncGlobalPowerText()
		{
		}

		private void RefreshGlobalPowerText()
		{
		}

		public void RefreshForSoftRestart()
		{
		}

		private void RefreshEquippedSlotVisuals()
		{
		}

		public void SetScrolls()
		{
		}

		private void SetStats()
		{
		}

		private void RefreshPermanentRangeStatText()
		{
		}

		private void RefreshMaxPermanentRangeUpgradeText()
		{
		}

		public bool WouldUpgradeExceedPermanentRange(ItemCard item)
		{
			return false;
		}

		private float CalculateRawEquippedStatTotal(PlayerStatType statType, ItemCard overrideCard, int overrideLevel)
		{
			return 0f;
		}

		private void CreateItems()
		{
		}

		public ItemCard CreateItem(ItemDB.Item item, bool isMerged)
		{
			return null;
		}

		private void FixItemOrderByRarity()
		{
		}

		public void CardButton(ItemCard card)
		{
		}

		public void OpenUpgradePanel(ItemCard item)
		{
		}

		public void UnEquip(ItemDB.Item item)
		{
		}

		public void Equip(ItemDB.Item item)
		{
		}

		private void RefreshCharacterStatUI()
		{
		}

		private void RefreshEquippedItemBonuses()
		{
		}

		private ItemCard FindCard(ItemDB.Item item)
		{
			return null;
		}

		public ItemCard FindCard(ItemSlot slot, int id)
		{
			return null;
		}

		public ItemCard FindCard(ItemSlot slot, int id, ItemRarity rarity)
		{
			return null;
		}

		public void OpenMergePanel()
		{
		}

		public void CloseMerge(ItemCard[] itemCardsInMergeSlotes)
		{
		}

		public ItemDB.Item GetSloteHolded(ItemSlot slot)
		{
			return null;
		}

		public List<ItemCard> GetCurrentCards()
		{
			return null;
		}

		public void SaveOwnedItems()
		{
		}

		public List<ItemDB.Item> GetSavedItems()
		{
			return null;
		}

		private List<ItemDB.Item> LoadFromV2()
		{
			return null;
		}

		private List<ItemDB.Item> MigrateLegacySave()
		{
			return null;
		}

		private ItemDB.Item GetFreshItemFromDB(ItemSlot slot, int id, ItemRarity rarity)
		{
			return null;
		}

		private void SaveOwnedItemsFromList(List<ItemDB.Item> savedItems)
		{
		}

		public void RemoveCard(ItemCard selectedItem)
		{
		}

		public Scroll FindScroll(ItemSlot itemSlot)
		{
			return null;
		}

		public void UpgradeAllCards()
		{
		}

		public bool CheckIsThereMergeableItemReturnBool()
		{
			return false;
		}

		public bool CheckIsThereAvaliableUpgradeItem()
		{
			return false;
		}

		public bool CheckIsThereAvaliableItem()
		{
			return false;
		}

		public bool IsThisCardCanMergable(ItemDB.Item item)
		{
			return false;
		}

		public void LoadStatPanel()
		{
		}

		public void CloseStatPanel()
		{
		}

		public void CheckAllCardUpgrade()
		{
		}

		public float GetAllActiveBonus(ItemSpecialEffect itemSpecial)
		{
			return 0f;
		}

		public static bool IsRarityTraitUnlocked(ItemDB.Item itemData, ItemDB.StatsByRarity rarityStats)
		{
			return false;
		}

		public float GetTotalPowerInUsingItems()
		{
			return 0f;
		}

		private float GetTotalPower(ItemDB.Item itemData)
		{
			return 0f;
		}
	}
}
