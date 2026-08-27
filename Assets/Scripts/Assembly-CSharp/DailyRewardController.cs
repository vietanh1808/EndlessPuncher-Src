using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;

public class DailyRewardController : MonoBehaviour, ISaveable
{
	[CompilerGenerated]
	private static Action m_ClaimableStateChanged;

	private const string DateFormat = "yyyy-MM-dd";

	private const int DaysInRewardList = 7;

	private static bool hasAutoOpenedPanelThisSession;

	[Header("Data")]
	[SerializeField]
	private DailyRewardSO dailyRewardSO;

	[Header("UI")]
	[SerializeField]
	private TextMeshProUGUI timerText;

	[SerializeField]
	private GameObject dailyRewardPanel;

	[SerializeField]
	private Transform closePoint;

	[SerializeField]
	private List<DailyRewardSlot> slots;

	[Header("Behaviour")]
	[SerializeField]
	private bool openPanelOnUnlock;

	private string lastClaimDate;

	private int rewardListIndex;

	private int nextDayIndex;

	private bool isLoaded;

	private bool isSubscribedToRemoteConfig;

	private bool wasUnlocked;

	private bool isDailyRewardPanelOpen;

	private bool autoOpenedPanelOnThisInstance;

	private bool lastClaimedTodayState;

	private float nextTimerRefreshTime;

	public static DailyRewardController Instance { get; private set; }

	public bool IsPanelOpen => false;

	public bool IsRewardUnlocked => false;

	public bool HasClaimedToday => false;

	public bool HasClaimableReward => false;

	public Transform ClosePointTransform => null;

	public static event Action ClaimableStateChanged
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

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void SubscribeRemoteConfig()
	{
	}

	private void UnsubscribeRemoteConfig()
	{
	}

	private void HandleRemoteConfigLoaded()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void RefreshUnlockState()
	{
	}

	private bool IsUnlocked()
	{
		return false;
	}

	private void HandleUnlocked()
	{
	}

	private void TryAutoOpenPanelOncePerSession()
	{
	}

	private void EvaluateStreakAndRefresh()
	{
	}

	private void EvaluateStreak()
	{
	}

	private void RefreshUI()
	{
	}

	public void OpenDailyRewardPanel()
	{
	}

	private bool CanClaimToday()
	{
		return false;
	}

	public void OpenPanel()
	{
	}

	public void CloseDailyRewardPanel()
	{
	}

	public void ClosePanel()
	{
	}

	public void ToggleDailyRewardPanel()
	{
	}

	public void TogglePanel()
	{
	}

	private void SetDailyRewardPanelOpen(bool isOpen)
	{
	}

	private bool IsTodayReward(int dayIndex, bool canClaimToday, bool claimedToday)
	{
		return false;
	}

	private DailyRewardSlotState GetSlotState(int dayIndex, bool canClaimToday)
	{
		return DailyRewardSlotState.Locked;
	}

	public DailyRewardSlot GetClaimableSlot()
	{
		return null;
	}

	private void ClaimRewardFromSlot(int dayIndex, DailyRewardSlot slot)
	{
	}

	private void ClaimReward(int dayIndex, DailyRewardSlot slot)
	{
	}

	private bool CanGrantRewards(IReadOnlyList<RewardEntry> rewards)
	{
		return false;
	}

	private bool GrantRewards(IReadOnlyList<RewardEntry> rewards, DailyRewardSlot slot)
	{
		return false;
	}

	private bool GrantReward(RewardEntry rewardEntry, DailyRewardSlot slot, int rewardIndex)
	{
		return false;
	}

	private void AdvanceRewardList()
	{
	}

	private void SaveProgress()
	{
	}

	private void RefreshTimerTextIfNeeded()
	{
	}

	private void RefreshTimerText()
	{
	}

	private DateTime LoadLastClaimDate()
	{
		return default;
	}

	public void OnLoad(SaveData data)
	{
	}

	public void OnSave(SaveData data)
	{
	}
}
