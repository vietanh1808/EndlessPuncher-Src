using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventPassController : MonoBehaviour, ISaveable
{
	[CompilerGenerated]
	private sealed class _003CAnimateEventCurrencyProgressRoutine_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventPassController _003C_003E4__this;

		public int fromCurrencyValue;

		public int toCurrencyValue;

		private float _003Cduration_003E5__2;

		private float _003Celapsed_003E5__3;

		private int _003ClastAppliedValue_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimateEventCurrencyProgressRoutine_003Ed__126(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateIngameEarnRoutine_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventPassController _003C_003E4__this;

		public int fromCurrencyValue;

		public int toCurrencyValue;

		private float _003Cduration_003E5__2;

		private float _003Celapsed_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimateIngameEarnRoutine_003Ed__115(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateProgress_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int toCurrencyValue;

		public int fromCurrencyValue;

		public EventPassController _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003Celapsed_003E5__3;

		private int _003ClastAppliedValue_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimateProgress_003Ed__81(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CHideEventCurrencyPanelAfterDelay_003Ed__127 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventPassController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CHideEventCurrencyPanelAfterDelay_003Ed__127(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScrollToSlotAfterLayout_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventPassController _003C_003E4__this;

		public int targetIndex;

		public bool animate;

		private ScrollRect _003CscrollRect_003E5__2;

		private float _003CtargetNormalizedPosition_003E5__3;

		private float _003CstartNormalizedPosition_003E5__4;

		private float _003Celapsed_003E5__5;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CScrollToSlotAfterLayout_003Ed__105(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSetEventCurrencyPanelActiveAfterDelay_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventPassController _003C_003E4__this;

		public bool isActive;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSetEventCurrencyPanelActiveAfterDelay_003Ed__130(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSetIngameEarnPanelActiveAfterDelay_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventPassController _003C_003E4__this;

		public bool isActive;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSetIngameEarnPanelActiveAfterDelay_003Ed__118(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const string EventPassUnlockSaveKey = "eventPassUnlockKey";

	private const string DateFormat = "yyyy-MM-dd";

	private const float EventCurrencyPanelStateDelay = 0.2f;

	private const float IapPanelCloseDelay = 0.2f;

	[CompilerGenerated]
	private static Action m_ClaimableRewardStateChanged;

	[SerializeField]
	private EventPassSO eventPassSO;

	[SerializeField]
	private GameObject eventPassButton;

	[SerializeField]
	private GameObject eventPassPanel;

	[SerializeField]
	private Animator eventPassPanelAnim;

	[SerializeField]
	private EventPassSlot startslot;

	[SerializeField]
	private EventPassSlot prefabSlot;

	[SerializeField]
	private EventPassSlot prefabSlot2;

	[SerializeField]
	private Transform slotParent;

	[SerializeField]
	private Slider mainSlider;

	[SerializeField]
	private ScrollRect eventPassScrollRect;

	[SerializeField]
	private float scrollToNextSlotDuration;

	[SerializeField]
	private TextMeshProUGUI textBattlePassTitle;

	[SerializeField]
	private TextMeshProUGUI textSlider;

	[SerializeField]
	private TextMeshProUGUI textStep;

	[SerializeField]
	private TextMeshProUGUI timerText;

	[SerializeField]
	[Min(1f)]
	private int eventPassResetIntervalDays;

	[Header("EVENT CURRENCY")]
	[SerializeField]
	private GameObject panelCurrnecy;

	[SerializeField]
	private Animator panelCurrnecyAnim;

	[SerializeField]
	private GameObject targetCurrnecy;

	[SerializeField]
	private Slider sliderCurrency;

	[SerializeField]
	private TextMeshProUGUI textSliderCurrency;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private TextMeshProUGUI textStepCurrency;

	[Header("IngameEarned Event")]
	[SerializeField]
	private GameObject panelIngameEarn;

	[SerializeField]
	private Animator panelIngameEarnAnim;

	[SerializeField]
	private Slider sliderIngameEarn;

	[Header("IAP")]
	[SerializeField]
	private bool isPassActive;

	[SerializeField]
	private GameObject iapButton;

	[SerializeField]
	private GameObject textActivated;

	[SerializeField]
	private GameObject textNotActivated;

	[Header("Event Shop Panel")]
	[SerializeField]
	private GameObject iapPanel;

	[SerializeField]
	private Button iapPanelBtn;

	[SerializeField]
	private Animator iapPanelAnim;

	[Header("Animation")]
	[SerializeField]
	private float progressFillDuration;

	[SerializeField]
	private float eventCurrencyPanelHideDelay;

	[SerializeField]
	private int maxEventCurrencyVisualTokenCount;

	private readonly List<EventPassSlot> spawnedSlots;

	private readonly HashSet<int> claimedRegularRewardIndexes;

	private readonly HashSet<int> claimedPassRewardIndexes;

	private bool isEventPassPanelOpen;

	private int lastShownCurrencyValue;

	private int currentDisplayedCurrencyValue;

	private int eventDisplayedCurrencyValue;

	private Coroutine progressRoutine;

	private Coroutine eventCurrencyRoutine;

	private Coroutine eventCurrencyPanelStateRoutine;

	private Coroutine ingameEarnRoutine;

	private Coroutine ingameEarnPanelStateRoutine;

	private Coroutine scrollRoutine;

	private bool isSubscribedToShopManager;

	private CurrenciesHandler subscribedCurrenciesHandler;

	private string lastResetDate;

	private DateTime lastRuntimeResetCheckDate;

	private bool isSaveLoaded;

	private int currentBattlePassNameIndex;

	public static EventPassController Instance { get; private set; }

	public static event Action ClaimableRewardStateChanged
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

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void OpenPanel()
	{
	}

	public void ClosePanel()
	{
	}

	public void TogglePanel()
	{
	}

	public void ActivatePass()
	{
	}

	public void RefreshSlots()
	{
	}

	private void OpenPanelWithProgressAnimation()
	{
	}

	private void BuildSlots(int currencyValue)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateProgress_003Ed__81))]
	private IEnumerator AnimateProgress(int fromCurrencyValue, int toCurrencyValue)
	{
		return null;
	}

	private void ApplyProgressValue(int currencyValue, bool refreshEventCurrencyProgress = true)
	{
	}

	private void RefreshMainProgress(int currentCurrencyValue)
	{
	}

	private void RefreshEventCurrencyProgress(int currentCurrencyValue)
	{
	}

	private void RefreshProgressUI(int currentCurrencyValue, Slider progressSlider, TextMeshProUGUI sliderText, TextMeshProUGUI stepText, bool resetTextAtPreviousTarget = false)
	{
	}

	private EventPassRewardEntry GetNextReward(int currentCurrencyValue, out int rewardIndex)
	{
		rewardIndex = default;
		return null;
	}

	private void SetProgressText(TextMeshProUGUI stepText, TextMeshProUGUI sliderText, int step, int currentValue, int targetValue)
	{
	}

	private static void SetSliderValue(Slider slider, float value)
	{
	}

	private void SetupSlot(EventPassSlot slot, int rewardIndex, int currentCurrencyValue)
	{
	}

	private void RefreshClaimReadyStates(int currencyValue)
	{
	}

	public void ClaimRegularReward(int rewardIndex)
	{
	}

	public void ClaimPassReward(int rewardIndex)
	{
	}

	public void OpenIapPanel()
	{
	}

	public void CloseIapPanel()
	{
	}

	private void DisableIapPanel()
	{
	}

	private void SubscribeIapPanelButton()
	{
	}

	private void UnsubscribeIapPanelButton()
	{
	}

	private bool IsRewardReady(EventPassRewardEntry reward, int currencyValue, bool isClaimed)
	{
		return false;
	}

	private bool IsPassRewardReady(EventPassRewardEntry reward, int currencyValue, bool isClaimed)
	{
		return false;
	}

	private bool GrantReward(RewardEntry rewardEntry, int amount, Vector3 sourcePosition)
	{
		return false;
	}

	private Vector3 GetRewardSourcePosition(int rewardIndex)
	{
		return default;
	}

	private EventPassSlot GetSlot(int rewardIndex)
	{
		return null;
	}

	private void ScrollToLastClaimedSlot()
	{
	}

	private void ScrollToNextEventPassSlot(int claimedRewardIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToSlotAfterLayout_003Ed__105))]
	private IEnumerator ScrollToSlotAfterLayout(int targetIndex, bool animate)
	{
		return null;
	}

	private int GetLastClaimedSlotIndex()
	{
		return 0;
	}

	private int GetSlotCount()
	{
		return 0;
	}

	private ScrollRect GetEventPassScrollRect()
	{
		return null;
	}

	private void StopScrollRoutine()
	{
	}

	private int GetTargetCurrencyValue(int rewardIndex)
	{
		return 0;
	}

	private int GetCurrentCurrencyValue()
	{
		return 0;
	}

	public void CollectEventCurrencyFromWorld(float amount, Vector3 worldPosition)
	{
	}

	public void ShowEndOfRunEventCurrencyReward(int amount, Vector3 sourcePosition, bool sourceIsUI = true)
	{
	}

	public void ShowIngameEarnedCurrency(int earnedAmount)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateIngameEarnRoutine_003Ed__115))]
	private IEnumerator AnimateIngameEarnRoutine(int fromCurrencyValue, int toCurrencyValue)
	{
		return null;
	}

	private void SetIngameEarnSliderValue(int currencyValue)
	{
	}

	private void HideIngameEarnPanel()
	{
	}

	[IteratorStateMachine(typeof(_003CSetIngameEarnPanelActiveAfterDelay_003Ed__118))]
	private IEnumerator SetIngameEarnPanelActiveAfterDelay(bool isActive)
	{
		return null;
	}

	private void StopIngameEarnRoutine()
	{
	}

	private void StopIngameEarnPanelStateRoutine()
	{
	}

	private void ShowEventCurrencyPanel()
	{
	}

	private void SubscribeCurrencyEvents()
	{
	}

	private void UnsubscribeCurrencyEvents()
	{
	}

	private void HandleEventCurrencyChanged()
	{
	}

	private void AnimateEventCurrencyProgress(int currentCurrencyValue)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateEventCurrencyProgressRoutine_003Ed__126))]
	private IEnumerator AnimateEventCurrencyProgressRoutine(int fromCurrencyValue, int toCurrencyValue)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideEventCurrencyPanelAfterDelay_003Ed__127))]
	private IEnumerator HideEventCurrencyPanelAfterDelay()
	{
		return null;
	}

	private void StopEventCurrencyRoutine()
	{
	}

	private void HideEventCurrencyPanel()
	{
	}

	[IteratorStateMachine(typeof(_003CSetEventCurrencyPanelActiveAfterDelay_003Ed__130))]
	private IEnumerator SetEventCurrencyPanelActiveAfterDelay(bool isActive)
	{
		return null;
	}

	private void StopEventCurrencyPanelStateRoutine()
	{
	}

	private Transform GetDefaultSlotParent()
	{
		return null;
	}

	private void ClearSpawnedSlots()
	{
	}

	private void StopProgressRoutine(bool saveCurrentValue = false)
	{
	}

	private void SetPanelOpen(bool isOpen)
	{
	}

	public void RefreshEventPassButtonState()
	{
	}

	public bool HasClaimableReward()
	{
		return false;
	}

	private bool IsEventPassUnlocked()
	{
		return false;
	}

	private void CheckReset()
	{
	}

	private void TryReset(DateTime today)
	{
	}

	private void ResetProgress(DateTime resetDate)
	{
	}

	private void RefreshBattlePassTitle()
	{
	}

	private void AdvanceBattlePassTitle()
	{
	}

	private void RefreshTimerText()
	{
	}

	private DateTime GetNextResetDate(DateTime resetDate)
	{
		return default;
	}

	private int GetResetIntervalDays()
	{
		return 0;
	}

	private void ResetEventPassCurrency()
	{
	}

	private DateTime LoadLastResetDate()
	{
		return default;
	}

	private void SaveLastResetDate(DateTime date)
	{
	}

	private void RefreshIapState()
	{
	}

	private void TrySubscribeShopManager()
	{
	}

	private void UnsubscribeShopManager()
	{
	}

	private void HandleShopPurchaseSuccess(ShopProductDataSO purchasedProduct)
	{
	}

	private void SaveLastShownCurrencyValue(int currencyValue)
	{
	}

	private void SaveProgress()
	{
	}

	public void OnLoad(SaveData data)
	{
	}

	public void OnSave(SaveData data)
	{
	}

	private static void NotifyClaimableRewardStateChanged()
	{
	}
}
