using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IncrementalsController : MonoBehaviour
{
	public struct PurchaseResult
	{
		public bool Success;

		public bool TriggeredMajorUpgrade;

		public float PaidPrice;

		public int NewMajorLevel;

		public int NewProgress;

		public float NewTotalValue;
	}

	[Serializable]
	public class IncrementalSlotUI
	{
		public int id;

		public Button button;

		public Image glowImage;

		public Slider slider;

		public Image sliderFillColor;

		public TextMeshProUGUI titleText;

		public TextMeshProUGUI priceText;

		public TextMeshProUGUI levelText;

		public TextMeshProUGUI valueText;

		public TextMeshProUGUI mergeDamageText;

		public TextMeshProUGUI progressText;

		public ParticleSystem particle;

		public GameObject mergeBG;

		public Color regularSliderColor;

		public Color mergeSliderColor;
	}

	private const float UnaffordableCardAlpha = 200f / 255f;

	public static Action<int, float, float> IncrementalBonusChanged;

	public static Action<int, int> ExtraArmStateChanged;

	private static IncrementalsController _instance;

	[SerializeField]
	private IncrementalDB incrementalDB;

	[SerializeField]
	private IncrementalSlotUI[] slots;

	[SerializeField]
	private float extraArmInteractionLockDuration;

	private float extraArmInteractionLockedUntil;

	private bool wasExtraArmInteractionLocked;

	private Color[] cachedPriceTextColors;

	private Color[] cachedButtonImageColors;

	private bool _isFirstEnable;

	public static IncrementalsController Instance => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpgradeIncremental(int id)
	{
	}

	public void UpgradeIncrementalBySlotIndex(int slotIndex)
	{
	}

	public void RefreshAll()
	{
	}

	private void CacheSlotVisualDefaults()
	{
	}

	public int GetExtraArmBonus()
	{
		return 0;
	}

	public int GetExtraArmPowerLevel()
	{
		return 0;
	}

	public float GetExtraArmScalePerPowerLevel()
	{
		return 0f;
	}

	public float GetExtraArmMergeDamageBonus()
	{
		return 0f;
	}

	public int GetExtraArmId()
	{
		return 0;
	}

	public int GetIncrementalId(IncrementalDB.IncrementalType type)
	{
		return 0;
	}

	public Transform GetPurchaseButtonTransform(int id)
	{
		return null;
	}

	public Transform GetPurchaseButtonTransform(IncrementalDB.IncrementalType type)
	{
		return null;
	}

	public Transform GetExtraArmPurchaseButtonTransform()
	{
		return null;
	}

	public float GetMaxHpBonus()
	{
		return 0f;
	}

	public float GetIncomeBonus()
	{
		return 0f;
	}

	public float ApplyIncomeMultiplierToReward(float amount, CurrencyTypes currencyType)
	{
		return 0f;
	}

	public float GetCurrentValue(IncrementalDB.IncrementalType type)
	{
		return 0f;
	}

	public float GetCurrentPrice(int id)
	{
		return 0f;
	}

	public int GetCurrentProgress(int id)
	{
		return 0;
	}

	public int GetRequiredProgress(int id)
	{
		return 0;
	}

	public int GetMajorLevel(int id)
	{
		return 0;
	}

	public int GetTotalPurchaseCount(int id)
	{
		return 0;
	}

	public float GetSliderValueNormalized(int id)
	{
		return 0f;
	}

	public float GetCurrentValue(int id)
	{
		return 0f;
	}

	public bool CanPurchase(int id)
	{
		return false;
	}

	public PurchaseResult TryPurchase(int id)
	{
		return default;
	}

	public bool MergeExtraArms()
	{
		return false;
	}

	public void MergeExtraArmsFromUI()
	{
	}

	private PurchaseResult TryPurchaseExtraArm()
	{
		return default;
	}

	private IncrementalSlotUI GetSlot(int id)
	{
		return null;
	}

	private void LockExtraArmInteraction()
	{
	}

	private bool IsExtraArmInteractionLocked()
	{
		return false;
	}

	private void SetSlotActive(IncrementalSlotUI slot, bool isActive)
	{
	}

	private void ApplySlotVisualState(IncrementalSlotUI slot, bool isMergeReady)
	{
	}

	private void ApplyPurchaseAvailabilityVisualState(IncrementalSlotUI slot, int slotIndex, bool canBuy)
	{
	}

	private float GetSavedBonusValue(int id)
	{
		return 0f;
	}

	private float GetBaseValue(IncrementalDB.IncrementalDefinition definition)
	{
		return 0f;
	}

	private float GetCurrentMajorBaseValue(int id, IncrementalDB.IncrementalDefinition definition, float currentTotalValue, int currentProgress)
	{
		return 0f;
	}

	private string FormatValue(IncrementalDB.IncrementalDefinition definition, float totalValue)
	{
		return null;
	}

	private int GetDecimalPlaces(IncrementalDB.IncrementalDefinition definition)
	{
		return 0;
	}

	private string FormatCompactValue(float value, int decimalPlaces)
	{
		return null;
	}

	private float GetNextValueAfterPurchase(int id, IncrementalDB.IncrementalDefinition definition, float currentValue)
	{
		return 0f;
	}

	private float ApplyIncrementalMultiplier(float currentValue, float multiplier)
	{
		return 0f;
	}

	private float GetMinorIncreaseStep(float majorBaseValue, IncrementalDB.IncrementalDefinition definition)
	{
		return 0f;
	}

	private string GetDisplayName(int id, IncrementalDB.IncrementalDefinition definition)
	{
		return null;
	}

	private string GetLevelText(int id, int majorLevel, int totalPurchaseCount)
	{
		return null;
	}

	private string GetValueText(int id, IncrementalDB.IncrementalDefinition definition, float totalValue)
	{
		return null;
	}

	private string GetMergeDamageText(int id)
	{
		return null;
	}

	private float GetDisplayedPlayerMaxHp(float incrementalHpBonus)
	{
		return 0f;
	}
}
