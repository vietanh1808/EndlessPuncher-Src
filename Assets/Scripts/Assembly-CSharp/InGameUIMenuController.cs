using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class InGameUIMenuController : MonoBehaviour
{
	public static InGameUIMenuController instance;

	[CompilerGenerated]
	private static Action m_GiantEntryConsumed;

	public const string GiantUnlockSaveKey = "giantUnlockKey";

	private const int DailyGiantEntryLimit = 2;

	private const string GiantEntryDateKey = "giant_entry_date";

	private const string GiantEntryUsedCountKey = "giant_entry_used_count";

	private const string GiantEntryBonusCountKey = "giant_entry_bonus_count";

	private const int PetMenuIndex = 0;

	private const int TalentMenuIndex = 1;

	private const int FightMenuIndex = 2;

	private const int InventoryMenuIndex = 3;

	private const int RingUpgradeMenuIndex = 4;

	private const int DungeonMenuUnlockChapter = 3;

	private InGameUI owner;

	[Header("MENU BAR COMPONENTS")]
	[SerializeField]
	private BottomMenu bottomMenu;

	[SerializeField]
	private GameObject tapToStartPanel;

	[SerializeField]
	private CamFollower camFollower;

	[Header("Shop")]
	[SerializeField]
	private Button shopMenuBtn;

	[SerializeField]
	private GameObject shopCurrency;

	[SerializeField]
	private GameObject talentMenuLockedCover;

	[Header("Dungeon")]
	[SerializeField]
	private GameObject dungeonMenuButton;

	[SerializeField]
	private GameObject dungeonPanel;

	[Header("Ring Holder")]
	[SerializeField]
	private RingUpgradeController ringUpgradeController;

	[SerializeField]
	private GameObject currencyHolder;

	[Header("Piggy Bank")]
	[SerializeField]
	private GameObject piggyBankCounter;

	[Header("Quest")]
	[SerializeField]
	private GameObject QuestBtn;

	[SerializeField]
	private GameObject QuestPanel;

	[Header("Chest")]
	public GameObject chestButton;

	public GameObject chestPanel;

	[Header("Shop")]
	[SerializeField]
	private GameObject ShopBtn;

	[SerializeField]
	private GameObject ShoptPanel;

	[Header("Giant")]
	[SerializeField]
	private GameObject GiantBtn;

	[SerializeField]
	private TextMeshProUGUI giantCounter;

	[Header("Daily Reward")]
	[SerializeField]
	private GameObject DailyBtn;

	private bool menuButtonsLocked;

	private bool bottomMenuEventsSubscribed;

	private int lastPanelActivated;

	private bool lastDailyButtonUnlocked;

	public Action menuChangedAction;

	private bool isChestActive;

	private bool isDungeonActive;

	private bool IsCollectibleActive;

	private bool _isShopPanelActive;

	[Header("No-Ads Weekly")]
	[SerializeField]
	private GameObject noAdsOfferBtn;

	[SerializeField]
	private GameObject weeklyActiveBtn;

	[SerializeField]
	private GameObject weeklyDeactiveBtn;

	[SerializeField]
	private bool debugIapShortcutLogs;

	private bool isSubscribedToShopIapEvents;

	private bool isSubscribedToWeeklyIapEvents;

	public int lastMenuID { get; private set; }

	public Button[] MenuBarButtons => null;

	public GameObject TapToStartPanel => null;

	public Transform GiantButtonTransform => null;

	public int RemainingGiantEntries => 0;

	public bool IsChestActivated => false;

	public bool IsDungeonActivated => false;

	public bool TalentPanelActivity => false;

	public static event Action GiantEntryConsumed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void RefreshDailyButtonState()
	{
	}

	public void Initialize(InGameUI owner)
	{
	}

	public void InitializeDefaultState(int menuIndex)
	{
	}

	public void OpenTalentMenu()
	{
	}

	public void SwitchMenuTab(int menuIndex)
	{
	}

	public void SelectMenu(int menuIndex)
	{
	}

	public void ForceMenuState(int menuIndex)
	{
	}

	public void RefreshTalentMenuUnlockState()
	{
	}

	public void RefreshShopCoverUnlockState()
	{
	}

	public void RefreshDungeonMenuLockState()
	{
	}

	public void RefreshGiantButtonState()
	{
	}

	public bool TryConsumeGiantEntry()
	{
		return false;
	}

	public void AddGiantEntries(int amount)
	{
	}

	public void SetMenuButtonsLocked(bool isLocked)
	{
	}

	public void RefreshBackgroundMusicState(bool forceRestart = false)
	{
	}

	public void RefreshStageIndicatorVisibility()
	{
	}

	private void SubscribeBottomMenuEvents()
	{
	}

	private void UnsubscribeBottomMenuEvents()
	{
	}

	private BottomMenu GetBottomMenu()
	{
		return null;
	}

	private bool SelectBottomMenuTab(int menuIndex)
	{
		return false;
	}

	private bool ForceBottomMenuTab(int menuIndex)
	{
		return false;
	}

	private void ClearBottomMenuSelection()
	{
	}

	private void HandleBottomMenuTabChanged(int menuIndex)
	{
	}

	private void HandleMenuSelected(int menuIndex)
	{
	}

	private void ActivateTabPage(int menuIndex)
	{
	}

	private void RefreshCurrencyHolderVisibility(int menuIndex)
	{
	}

	private RingUpgradeController GetRingUpgradeController()
	{
		return null;
	}

	private void HandleBaseSceneMenuCamera(int menuIndex)
	{
	}

	private void RefreshMenuButtonInteractivity()
	{
	}

	private bool IsDungeonMenuUnlocked()
	{
		return false;
	}

	private bool IsGiantUnlocked()
	{
		return false;
	}

	private void RefreshGiantCounter()
	{
	}

	private static int GetRemainingGiantEntries()
	{
		return 0;
	}

	private static int GetUsedGiantEntryCount()
	{
		return 0;
	}

	private static void ResetGiantEntriesIfNeeded()
	{
	}

	public void RefreshPiggyBankCounterState()
	{
	}

	private void RefreshPiggyBankCounterState(int menuIndex)
	{
	}

	public void ActivateChest()
	{
	}

	public void DeactivateChest()
	{
	}

	private void HidePiggyBankPanelForOverlay()
	{
	}

	private void RefreshPiggyBankPanelAfterOverlayClosed()
	{
	}

	public void ActivateDungeon()
	{
	}

	public void DeactivateDungeon()
	{
	}

	public void ActivateCollectible()
	{
	}

	public void DeactivateCollectible()
	{
	}

	public void ActivateShopPanel()
	{
	}

	public void DeactivateShopPanel()
	{
	}

	public void SencronizeIapButtons()
	{
	}

	private bool ResolveShopUnlocked()
	{
		return false;
	}

	private void SetIapShortcutButton(GameObject buttonObject, bool isActive, bool opensShop)
	{
	}

	private void SubscribeIapEvents()
	{
	}

	private void UnsubscribeIapEvents()
	{
	}

	private void HandleNoAdsStatusChanged(bool isActive)
	{
	}

	private void HandleWeeklyAdsStatusChanged(bool isActive)
	{
	}

	private void HandleShopPurchaseSuccess(ShopProductDataSO product)
	{
	}
}
