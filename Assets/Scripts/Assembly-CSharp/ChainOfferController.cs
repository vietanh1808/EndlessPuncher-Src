using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChainOfferController : MonoBehaviour, ISaveable
{
	[CompilerGenerated]
	private sealed class _003CAutoOpenPanelWhenReady_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChainOfferController _003C_003E4__this;

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
		public _003CAutoOpenPanelWhenReady_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CDeactivatePanelAfterAnimationDelay_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChainOfferController _003C_003E4__this;

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
		public _003CDeactivatePanelAfterAnimationDelay_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CScrollToSlotAfterLayout_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChainOfferController _003C_003E4__this;

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
		public _003CScrollToSlotAfterLayout_003Ed__51(int _003C_003E1__state)
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

	public const string ChainOfferUnlockSaveKey = "chainOfferUnlockKey";

	private const string DateFormat = "yyyy-MM-dd";

	private const int ResetIntervalDays = 2;

	private const float PanelDeactivateDelay = 0.2f;

	private const float AutoOpenDelay = 0.35f;

	[SerializeField]
	private ChainOfferSO chainOfferSO;

	[SerializeField]
	private GameObject chainOfferButton;

	[SerializeField]
	private AllertController chainOfferButtonAlert;

	[SerializeField]
	private GameObject chainOfferPanel;

	[SerializeField]
	private Animator chainOfferAnim;

	[SerializeField]
	private ChainOfferSlot chainOfferSlotPrefab;

	[SerializeField]
	private Transform chainOfferSlotParent;

	[SerializeField]
	private ScrollRect chainOfferScrollRect;

	[SerializeField]
	private float scrollToNextSlotDuration;

	[SerializeField]
	private TextMeshProUGUI timerText;

	private readonly List<ChainOfferSlot> spawnedSlots;

	private readonly HashSet<int> claimedSlotIndexes;

	private DateTime lastRuntimeResetCheckDate;

	private string lastResetDate;

	private int pendingPaidSlotIndex;

	private bool isSaveLoaded;

	private bool isSubscribedToShopManager;

	private bool isSubscribedToRemoteConfig;

	private bool isChainOfferPanelOpen;

	private bool autoOpenedPanelThisSession;

	private bool didResetThisSession;

	private Coroutine scrollRoutine;

	private Coroutine panelCloseRoutine;

	private Coroutine autoOpenRoutine;

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

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
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

	private void SetPanelOpen(bool isOpen)
	{
	}

	[IteratorStateMachine(typeof(_003CDeactivatePanelAfterAnimationDelay_003Ed__40))]
	private IEnumerator DeactivatePanelAfterAnimationDelay()
	{
		return null;
	}

	public void RefreshChainOfferButtonState()
	{
	}

	private void RefreshChainOfferAlert()
	{
	}

	private bool HasClaimableFreeOffer()
	{
		return false;
	}

	private void ScheduleAutoOpenIfNeeded()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoOpenPanelWhenReady_003Ed__45))]
	private IEnumerator AutoOpenPanelWhenReady()
	{
		return null;
	}

	private bool CanShowChainOffer()
	{
		return false;
	}

	private static bool IsChainOfferBlockedByScene()
	{
		return false;
	}

	private bool IsChainOfferUnlocked()
	{
		return false;
	}

	private void BuildSlots()
	{
	}

	private void ScrollToLastClaimedSlot()
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToSlotAfterLayout_003Ed__51))]
	private IEnumerator ScrollToSlotAfterLayout(int targetIndex, bool animate)
	{
		return null;
	}

	private int GetLastClaimedSlotIndex()
	{
		return 0;
	}

	private ScrollRect GetChainOfferScrollRect()
	{
		return null;
	}

	private void ClearSlots()
	{
	}

	private void ClaimFreeSlot(int slotIndex)
	{
	}

	private void RequestPaidSlotPurchase(int slotIndex)
	{
	}

	private void HandleShopPurchaseSuccess(ShopProductDataSO product)
	{
	}

	private void HandleShopPurchaseFailed(ShopProductDataSO product, string reason)
	{
	}

	private void TrackPaidSlotTapped(ShopProductDataSO product)
	{
	}

	private void ClaimSlot(int slotIndex)
	{
	}

	private void ScrollToNextOfferSlot(int claimedSlotIndex)
	{
	}

	private void PlaySlotClaimFeedback(int slotIndex)
	{
	}

	private bool GrantRewards(int slotIndex, List<RewardEntry> rewardEntries)
	{
		return false;
	}

	private bool GrantReward(int slotIndex, RewardEntry rewardEntry)
	{
		return false;
	}

	public static bool CanUseRewardEntry(RewardEntry rewardEntry)
	{
		return false;
	}

	private static bool IsLockedCollectibleKeyReward(RewardEntry rewardEntry)
	{
		return false;
	}

	private ChainOfferReward GetReward(int slotIndex)
	{
		return null;
	}

	private bool IsClaimed(int slotIndex)
	{
		return false;
	}

	private bool IsSlotUnlocked(int slotIndex)
	{
		return false;
	}

	private void RefreshSlot(int slotIndex)
	{
	}

	private void TryChainOfferReset()
	{
	}

	private void RefreshTimerText()
	{
	}

	private void CheckResetDateChanged()
	{
	}

	private void SaveLastResetDate(DateTime date)
	{
	}

	private DateTime LoadLastResetDate()
	{
		return default;
	}

	private void TrySubscribeShopManager()
	{
	}

	private void HandleShopInitialized()
	{
	}

	private bool IsSameProduct(ShopProductDataSO expectedProduct, ShopProductDataSO purchasedProduct)
	{
		return false;
	}

	private void UnsubscribeShopManager()
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

	public void OnLoad(SaveData data)
	{
	}

	public void OnSave(SaveData data)
	{
	}
}
