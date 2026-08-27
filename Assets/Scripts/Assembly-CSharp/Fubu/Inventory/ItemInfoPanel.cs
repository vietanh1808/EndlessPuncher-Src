using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Inventory
{
	public class ItemInfoPanel : MonoBehaviour
	{
		[Serializable]
		public class BonusEffectWRarity
		{
			public ItemRarity rarity;

			public GameObject holder;

			public TextMeshProUGUI description;

			public GameObject lockIcon;

			public GameObject dotIcon;

			private Color color;

			public void SetDescription(string tt, Color cc, bool unLocked)
			{
			}

			public void SetLock()
			{
			}

			public void SetUnlocked()
			{
			}
		}

		[Serializable]
		public class PriceInfo
		{
			[SerializeField]
			private CurrencyTypes currencyTypes;

			[SerializeField]
			private bool isScroll;

			[SerializeField]
			private TextMeshProUGUI priceText;

			[SerializeField]
			private GameObject holder;

			public void SetPrice(ItemDB.Item item, ref bool canUpgrade)
			{
			}
		}

		[Serializable]
		public class RarityObjects
		{
			public ItemRarity rarity;

			public GameObject[] rarityObjects;

			public void SetVisibility(bool isActive)
			{
			}
		}

		private static ItemInfoPanel instance;

		public Color[] rarityrTextColors;

		public List<BonusEffectWRarity> bonusesWRarity;

		[SerializeField]
		private RarityObjects[] rarityObjects;

		[SerializeField]
		private GameObject[] miniIcons;

		[SerializeField]
		private GameObject panel;

		[SerializeField]
		private UISizer[] uiSizer;

		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private TextMeshProUGUI descriptionText;

		[SerializeField]
		private TextMeshProUGUI levelText;

		[SerializeField]
		private Button equipButton;

		[SerializeField]
		private Button unequipButton;

		[SerializeField]
		private Button upgradeButton;

		[SerializeField]
		private Button levelUpButtonWShopgem;

		[SerializeField]
		private TextMeshProUGUI levelUpTextWShopgem;

		[SerializeField]
		private int startPriceShopGem;

		[SerializeField]
		private int increasePriceShopGem;

		[SerializeField]
		private Button sellButton;

		[SerializeField]
		private PriceInfo[] priceInfos;

		[SerializeField]
		private ParticleSystem upgradeParticle;

		[Header("Fill")]
		[SerializeField]
		private Slider slider;

		[SerializeField]
		private Image fill;

		[SerializeField]
		private GameObject sliderObject;

		[SerializeField]
		private GameObject arrow;

		[SerializeField]
		private TextMeshProUGUI countText;

		private bool _isPanelActive;

		[Header("Basic Stats")]
		public Animator[] basicAnimators;

		public GameObject[] basicStatParent;

		public GameObject[] basicStatUpgradeHolder;

		public TextMeshProUGUI[] basicStatUpgradeAmouthText;

		public TextMeshProUGUI[] statTexts;

		public TextMeshProUGUI[] statNameTexts;

		public Image[] statIcons;

		public TextMeshProUGUI totalPower;

		public static ItemInfoPanel Current => null;

		public static ItemInfoPanel Instance => null;

		public bool IsPanelActive => false;

		private void Awake()
		{
		}

		public int GetShopGemUpgradePrice(ItemDB.Item item)
		{
			return 0;
		}

		public bool CanUpgradeWithShopGem(ItemDB.Item item)
		{
			return false;
		}

		public void OpenPanel(ItemDB.Item item, ItemCard card)
		{
		}

		public void SetCardStats(ItemCard card)
		{
		}

		private Sprite GetStatIcon(PlayerStatType statType)
		{
			return null;
		}

		private bool TryGetTalentType(PlayerStatType statType, out TalentType talentType)
		{
			talentType = default;
			return false;
		}

		private string FormatBasicStatValue(float value)
		{
			return null;
		}

		private float GetTotalPower(ItemDB.Item itemData)
		{
			return 0f;
		}

		private string Prefix(PlayerStatType type)
		{
			return null;
		}

		private string ValueSuffix(PlayerStatType type)
		{
			return null;
		}

		private string StatDisplayName(PlayerStatType type)
		{
			return null;
		}

		public void UpgradeButton(ItemCard item)
		{
		}

		public void UpgradeButtonWShopGem(ItemCard item)
		{
		}

		private void OpenNoCrystalPanel()
		{
		}

		public void EquipButton(ItemDB.Item item)
		{
		}

		public void UnEquipButton(ItemDB.Item item)
		{
		}

		public void ClosePanel()
		{
		}

		private void RefresSizer()
		{
		}
	}
}
