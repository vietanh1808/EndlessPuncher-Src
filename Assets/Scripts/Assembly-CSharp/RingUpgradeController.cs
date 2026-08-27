using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RingUpgradeController : Singleton<RingUpgradeController>, ITabPanel
{
	[Serializable]
	public class RingStatUI
	{
		[SerializeField]
		private GameObject root;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private TextMeshProUGUI currentValueText;

		[SerializeField]
		private TextMeshProUGUI nextLevelValueText;

		private Color currentValueDefaultColor;

		private bool hasCurrentValueDefaultColor;

		public void Set(string statName, float currentValue, float nextLevelValue, string prefix, string suffix)
		{
		}

		public void PlayUpgradeFeedback()
		{
		}

		private void CacheCurrentValueDefaultColor()
		{
		}

		private string FormatValue(float value, string prefix, string suffix)
		{
			return null;
		}

		public void SetActive(bool isActive)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CHidePanelAfterDelay_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RingUpgradeController _003C_003E4__this;

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
		public _003CHidePanelAfterDelay_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003CScrollToCurrentSpecialUpgradeAfterLayout_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RingUpgradeController _003C_003E4__this;

		public int specialLevel;

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
		public _003CScrollToCurrentSpecialUpgradeAfterLayout_003Ed__125(int _003C_003E1__state)
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

	public const string PurchaseCountKey = "RingUpgradePurchaseCount";

	private const string ShowTriggerName = "show";

	private const string HideTriggerName = "hide";

	private const float HidePanelDelay = 0.15f;

	private const int UnlockStage = 4;

	private const int TapHoldHintPressCount = 3;

	private const float TapHoldHintScaleInDuration = 0.1f;

	private const float TapHoldHintVisibleDuration = 2f;

	private const float TapHoldHintScaleOutDuration = 0.2f;

	private const int QuickPurchaseVisualStarLimit = 20;

	private const float QuickProgressArrivalTweenDuration = 0.2f;

	private const float QuickProgressFullVisibleDuration = 0.2f;

	private const int NewTierStarBlinkCount = 3;

	private const float NewTierStarBlinkInterval = 0.05f;

	[Header("Data")]
	[SerializeField]
	private RingUpgradeSO ringUpgradeSO;

	[Header("Ring")]
	[SerializeField]
	private GameObject tabPanelObject;

	[SerializeField]
	private TextMeshProUGUI ringName;

	[SerializeField]
	private Image ringIcon;

	[SerializeField]
	private Animator panel;

	[SerializeField]
	private GameObject transitionCover;

	[SerializeField]
	private GameObject currencyRing;

	[SerializeField]
	private RingLevelUpSystem ringLevelUpSystem;

	[SerializeField]
	private SceneEnvironmentControl sceneEnvironmentControl;

	[SerializeField]
	private GameObject tapHoldObje;

	[SerializeField]
	private Vector3 tapHoldObjeVisibleScale;

	[Header("Progress")]
	[SerializeField]
	private Slider starProgressSlider;

	[SerializeField]
	private TextMeshProUGUI starProgressText;

	[SerializeField]
	private TextMeshProUGUI statLevelCurrent;

	[SerializeField]
	private TextMeshProUGUI statLevelNext;

	[SerializeField]
	private GameObject[] starObjects;

	[SerializeField]
	private GameObject[] shineObjects;

	[SerializeField]
	private ParticleSystem starParticle;

	[SerializeField]
	private ParticleSystem starParticleConfetties;

	[Header("Stats")]
	[SerializeField]
	private RingStatUI[] statUIs;

	[Header("Special Effects")]
	[SerializeField]
	private TextMeshProUGUI specialLevelText;

	[SerializeField]
	private ScrollRect specialUpgradeScrollRect;

	[SerializeField]
	private List<RingSpecialUpgradeUI> specialUpgradeUIs;

	[Header("Purchase")]
	[SerializeField]
	private HoldButton purchaseHoldButton;

	[SerializeField]
	private TextMeshProUGUI priceText;

	[SerializeField]
	private Button quickPurchaseButton;

	[SerializeField]
	private TextMeshProUGUI quickPurchasePriceText;

	[Header("Offer Special Currency")]
	[SerializeField]
	private Button timerButton;

	[SerializeField]
	private Button offerButton;

	[SerializeField]
	private TextMeshProUGUI rewardedCounter;

	[SerializeField]
	private TextMeshProUGUI offerPrice;

	[SerializeField]
	private TextMeshProUGUI offerEarnedPrice;

	private Coroutine hidePanelRoutine;

	private Coroutine specialUpgradeScrollRoutine;

	private int lastCenteredSpecialLevel;

	private Tween tapHoldHintTween;

	private Tween quickPurchaseProgressTween;

	private Vector3 tapHoldObjeDefaultScale;

	private bool hasTapHoldObjeDefaultScale;

	private int tapHoldHintPressCount;

	private bool tapHoldHintShown;

	private bool isCurrencyChangeSubscribed;

	private bool hasPendingPurchase;

	private int pendingPreviousPurchaseCount;

	private int pendingPurchaseCount;

	private int activeSingleUpgradeVisualCount;

	public RingUpgradeSO GetRingUpgradeSO => null;

	private int PurchaseCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int GetSavedPurchaseCount()
	{
		return 0;
	}

	public static RingUpgradeSO GetActiveRingUpgradeSO()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SubscribeCurrencyChanges()
	{
	}

	private void UnsubscribeCurrencyChanges()
	{
	}

	private void RefreshCurrencyDependentUI()
	{
	}

	private void OnDestroy()
	{
	}

	public void ShowPanel()
	{
	}

	public void Show()
	{
	}

	public void RefreshUnlockState()
	{
	}

	public void HidePanel()
	{
	}

	public void Hide()
	{
	}

	private void SetRingLightMode(bool isRingMode)
	{
	}

	[IteratorStateMachine(typeof(_003CHidePanelAfterDelay_003Ed__80))]
	private IEnumerator HidePanelAfterDelay()
	{
		return null;
	}

	private GameObject GetTabPanelObject()
	{
		return null;
	}

	public void BuyUpgrade()
	{
	}

	private void PlaySingleUpgradeButtonBounce()
	{
	}

	private void TrackTapHoldHintPress()
	{
	}

	private void ShowTapHoldHint()
	{
	}

	private void ResetTapHoldHintState()
	{
	}

	private void HideTapHoldHintImmediately()
	{
	}

	private void CacheTapHoldObjeDefaultScale()
	{
	}

	public void BuyQuickUpgrade()
	{
	}

	public void BuyOffer()
	{
	}

	public void RefreshUI(bool playStarUpgradeFeedback = false)
	{
	}

	private void RefreshRingLevelUpSystem(int specialLevel, int currentSpecialStarLevel)
	{
	}

	private void RefreshRingInfo(int specialLevel)
	{
	}

	private void RefreshStarObjects(int currentSpecialStarLevel, bool playUpgradeFeedback)
	{
	}

	private void PlayStarUnlockedParticles(Transform starTransform)
	{
	}

	private string GetStatLevelText(int statLevel)
	{
		return null;
	}

	private void RefreshStats(int statLevel)
	{
	}

	private void RefreshPurchaseButton()
	{
	}

	public bool CanPurchaseUpgrade()
	{
		return false;
	}

	private void RefreshOfferButton(bool canBuy, bool isTimerActive)
	{
	}

	private void OpenNoCrystalPanel()
	{
	}

	private bool IsUnlocked()
	{
		return false;
	}

	private int GetQuickPurchaseAmount()
	{
		return 0;
	}

	private float GetQuickPurchasePrice(int purchaseAmount)
	{
		return 0f;
	}

	private void StartSingleUpgradeVisual(int previousPurchaseCount, int targetPurchaseCount)
	{
	}

	private void BeginPendingPurchase(int previousPurchaseCount, int targetPurchaseCount)
	{
	}

	private void CompletePendingPurchase()
	{
	}

	private Vector3 GetPurchaseButtonSourcePosition(bool useQuickPurchaseButton)
	{
		return default;
	}

	private void SpawnRingCurrencyVisuals(int visualCount, Vector3 sourcePosition, Vector3 targetPosition, float scatterDuration, float movementSpeed, Action onIconArrived, Action onComplete)
	{
	}

	private Vector3 GetStarProgressFillTipPosition()
	{
		return default;
	}

	private Vector3 GetStarProgressTargetPosition(float normalizedProgress)
	{
		return default;
	}

	private void PlayPurchaseProgressFeedback(int previousPurchaseCount, int currentPurchaseCount, float previousProgress, bool useQuickFillFeedback)
	{
	}

	private bool UnlocksNewTier(int previousPurchaseCount, int currentPurchaseCount)
	{
		return false;
	}

	private void PlayNewTierProgressFeedback(float fromProgress, int previousPurchaseCount, int currentPurchaseCount, Vector3 sourcePosition, Vector3 targetPosition, int visualCount, bool useQuickFillFeedback)
	{
	}

	private void PlayStatUpgradeFeedback(int previousPurchaseCount, int currentPurchaseCount)
	{
	}

	private void PlaySpecialLevelCompletionSound(int previousPurchaseCount, int currentPurchaseCount)
	{
	}

	private void SetStarProgressTextFull()
	{
	}

	private void SetStarProgressTextForSliderValue(float normalizedValue)
	{
	}

	private void SetAllStarsVisual(bool isActive)
	{
	}

	private void SetPurchaseButtonsInteractable(bool interactable)
	{
	}

	private void StopQuickPurchaseProgressFeedback()
	{
	}

	private void RefreshSpecialUpgrades(int specialLevel)
	{
	}

	private void PlaySpecialUpgradeUnlockFeedback(int previousPurchaseCount, int currentPurchaseCount)
	{
	}

	private void ScrollToCurrentSpecialUpgrade(int specialLevel)
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToCurrentSpecialUpgradeAfterLayout_003Ed__125))]
	private IEnumerator ScrollToCurrentSpecialUpgradeAfterLayout(int specialLevel)
	{
		return null;
	}

	private ScrollRect GetSpecialUpgradeScrollRect()
	{
		return null;
	}

	private RectTransform GetSpecialUpgradeContent()
	{
		return null;
	}

	private void SnapSpecialUpgradeContentToTop(RectTransform content)
	{
	}

	private string GetStatName(PlayerStatType statType)
	{
		return null;
	}

	public float StatValue(PlayerStatType statType)
	{
		return 0f;
	}

	public float GetTotalPower()
	{
		return 0f;
	}

	private void RefreshPlayerStatsAfterPurchase()
	{
	}
}
