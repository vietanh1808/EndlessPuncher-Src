using System;
using System.Collections.Generic;
using Fubu.Inventory;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestInfoPanel : MonoBehaviour
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
	public class RarityObjects
	{
		public ItemRarity rarity;

		public GameObject[] rarityObjects;

		public void SetVisibility(bool isActive)
		{
		}
	}

	public TextMeshProUGUI chestCountertext;

	[SerializeField]
	private Animator chestCounterAnimator;

	[SerializeField]
	private ParticleSystem particleChestCounter;

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
	private Sprite collectibleKeyIcon;

	[SerializeField]
	private Button equipButton;

	[SerializeField]
	private Button equipButton2;

	private ItemDB.Item selectedItem;

	private bool _isPanelActive;

	[Header("Basic Stats")]
	public GameObject[] basicStatParent;

	public TextMeshProUGUI[] statTexts;

	public TextMeshProUGUI[] statNameTexts;

	public Image[] statIcons;

	public TextMeshProUGUI totalPower;

	public bool IsPanelActive => false;

	public Sprite CollectibleKeyIcon => null;

	public void OpenCollectiblePanel(CollectiblesSO.CollectibleData collectibleData, int pieces, int currentChestIndex = 1, int totalChestCount = 1)
	{
	}

	public void OpenCurrencyPanel(CurrencyTypes currencyType, int amount, int currentChestIndex = 1, int totalChestCount = 1)
	{
	}

	public void OpenCollectibleKeyPanel(Sprite keyIcon, int amount, int currentChestIndex = 1, int totalChestCount = 1)
	{
	}

	public void OpenPanel(ItemDB.Item item, int currentChestIndex = 1, int totalChestCount = 1)
	{
	}

	private void ConfigureCloseButtons()
	{
	}

	private void HideItemOnlyObjects()
	{
	}

	private void SetDescriptionText(string description)
	{
	}

	private void SetRarityVisibility(ItemRarity rarity)
	{
	}

	private static ItemRarity ToItemRarity(CollectiblesRarity rarity)
	{
		return ItemRarity.Common;
	}

	private void SetChestCounterText(int currentChestIndex, int totalChestCount)
	{
	}

	public void SetCardStats(ItemDB.Item card)
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

	private string FormatItemStatValue(float value)
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

	public void UnlockedButton()
	{
	}

	public void ClosePanel()
	{
	}

	public void RefreshSizer()
	{
	}

	private void RefresSizer()
	{
	}
}
