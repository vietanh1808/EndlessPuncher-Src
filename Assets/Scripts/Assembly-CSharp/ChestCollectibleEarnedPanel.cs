using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestCollectibleEarnedPanel : MonoBehaviour
{
	[Serializable]
	public class CollectTypeAndValue
	{
		public GameObject holder;

		public Collects[] collects;
	}

	[Serializable]
	public class Collects
	{
		public GameObject obje;

		public TMP_Text value;

		public Image icon;

		public RarityObjs[] rarityObjects;
	}

	[Serializable]
	public class RarityObjs
	{
		public GameObject[] rarityHolder;

		public CollectiblesRarity rarity;

		public void SetVisibility(bool isVisible)
		{
		}
	}

	private class PendingCurrencyReward
	{
		public CurrencyTypes currencyType;

		public int amount;

		public Collects sourceCollect;
	}

	private const string CollectibleCurrencyDescription = "Used to upgrade Collectible items";

	private const string CollectibleKeyName = "Collectible Chest Key";

	private const string CollectibleKeyDescription = "Used to open Collectible chests";

	private static ChestCollectibleEarnedPanel _instance;

	[SerializeField]
	private List<CollectTypeAndValue> collectTypes;

	[SerializeField]
	private RarityObjs[] rarityObjectsPanel;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private Animator panelAnim;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private Button closeButton2;

	[SerializeField]
	private TextMeshProUGUI title;

	[SerializeField]
	private TextMeshProUGUI description;

	[SerializeField]
	private ParticleSystem confettie;

	private bool isPanelActive;

	private int loadedRewardCount;

	private readonly List<PendingCurrencyReward> pendingCurrencyRewards;

	public static ChestCollectibleEarnedPanel Instance => null;

	public bool IsPanelActive => false;

	public int MaxRewardSlotCount => 0;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void LoadCollectible(CollectiblesSO.CollectibleData collectibleData, int pieces)
	{
	}

	public void LoadCurrency(CurrencyTypes currencyType, int amount)
	{
	}

	public void LoadCollectibleKey(Sprite keyIcon, int amount)
	{
	}

	public void BeginLoad()
	{
	}

	public void AddCollectible(CollectiblesSO.CollectibleData collectibleData, string amountText)
	{
	}

	public void AddCollectible(Sprite rewardIcon, string amountText, CollectiblesRarity rarity)
	{
	}

	public void AddCurrency(Sprite rewardIcon, string amountText)
	{
	}

	public void AddCurrency(CurrencyTypes currencyType, Sprite rewardIcon, int amount)
	{
	}

	public void AddCollectibleKey(Sprite keyIcon, int amount)
	{
	}

	public void ShowLoadedRewards()
	{
	}

	public void ClosePanel()
	{
	}

	private Collects SetRewardAtIndex(int rewardIndex, Sprite rewardIcon, string amountText, CollectiblesRarity rarity, bool showRarity)
	{
		return null;
	}

	private void SetCollect(Collects collect, Sprite rewardIcon, string amountText, CollectiblesRarity rarity, bool showRarity)
	{
	}

	private void ClearSlots()
	{
	}

	private void SetCollectibleInfo(string collectibleName, string collectibleDescription)
	{
	}

	private void RefreshHolders()
	{
	}

	private int GetTotalSlotCount()
	{
		return 0;
	}

	private void SetRarityObjects(Collects collect, CollectiblesRarity rarity, bool showSelected)
	{
	}

	private void SetPanelRarityObjects(CollectiblesRarity rarity, bool showSelected)
	{
	}

	private void DelayClose()
	{
	}

	private void PlayConfettie()
	{
	}

	private void PlayPendingCurrencyRewards()
	{
	}

	private Vector3 GetCurrencyRewardSpawnPosition(Collects collect)
	{
		return default;
	}
}
