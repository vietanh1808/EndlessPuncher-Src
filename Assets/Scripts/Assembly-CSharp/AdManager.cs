using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ElephantSDK;
using UnityEngine;

public class AdManager : PersistentSingleton<AdManager>
{
	public enum InterstitialSource
	{
		LevelFail = 0,
		LevelComplete = 1,
		StageClear = 2,
		DungeonClear = 3,
		Restart = 4,
		Other = 5
	}

	public enum RewardedCategory
	{
		Upgrade = 0,
		Cosmetic = 1,
		Booster = 2,
		Income = 3,
		Gatcha = 4,
		Level = 5,
		Other = 6
	}

	public enum RewardedSource
	{
		NormalLevel = 0,
		Shop = 1,
		SpecialLevel = 2,
		Meta = 3,
		IapStore = 4,
		LiveEvent = 5,
		Other = 6
	}

	[CompilerGenerated]
	private sealed class _003CFakeInterstitialFlow_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdManager _003C_003E4__this;

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
		public _003CFakeInterstitialFlow_003Ed__110(int _003C_003E1__state)
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
	private sealed class _003CFakeRewardedFlow_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdManager _003C_003E4__this;

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
		public _003CFakeRewardedFlow_003Ed__111(int _003C_003E1__state)
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
	private sealed class _003CPollSdkInitialization_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdManager _003C_003E4__this;

		private float _003Celapsed_003E5__2;

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
		public _003CPollSdkInitialization_003Ed__50(int _003C_003E1__state)
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

	[Header("Cooldown Settings")]
	[Tooltip("Interstitial reklamlar arası minimum saniye. RemoteConfig'den override edilir.")]
	[SerializeField]
	private float _interstitialCooldownSeconds;

	[Tooltip("Energy unlock olduktan sonra ilk interstitial için bekleme süresi (saniye). RemoteConfig'den override edilir.")]
	[SerializeField]
	private float _firstInterstitialDelaySeconds;

	[Header("Rewarded Settings")]
	[Tooltip("NoEnergyPanel'da RW izlendiğinde verilecek energy miktarı. RemoteConfig'den override edilir.")]
	[SerializeField]
	private int _energyRewardPerAd;

	[SerializeField]
	private int _shopGemRewardPerAd;

	[SerializeField]
	private int _petGemRewardPerAdBtn1;

	[SerializeField]
	private int _petGemRewardPerAdBtn2;

	[Header("Editor Settings")]
	[Tooltip("Editor'da gerçek reklam yerine fake davranış simüle eder. Build'de etkisi yok.")]
	[SerializeField]
	private bool _bypassInEditor;

	[Tooltip("Editor bypass aktifken rewarded simulasyonu kaç saniye sürecek.")]
	[SerializeField]
	private float _editorRewardedFakeDuration;

	[Header("Debug")]
	[SerializeField]
	private bool _showDebugLogs;

	private bool _isSdkInitialized;

	private float _lastInterstitialShownTime;

	private float _energyUnlockedTime;

	private Action<bool> _currentRewardedCallback;

	private bool _currentRewardedSucceeded;

	private bool _isRewardedInProgress;

	private string _currentRewardedItem;

	private int _currentRewardedAmount;

	[CompilerGenerated]
	private Action m_OnAdManagerInitialized;

	[CompilerGenerated]
	private Action m_OnInterstitialShown;

	[CompilerGenerated]
	private Action m_OnInterstitialDismissed;

	[CompilerGenerated]
	private Action<bool> m_OnRewardedVideoCompleted;

	private const string EVENT_SHOP_OPENED = "shop_opened";

	private const string EVENT_IAP_TAPPED = "iap_item_tapped";

	private const string EVENT_IAP_PURCHASED = "iap_item_purchased";

	private const string EVENT_IAP_FAILED = "iap_item_failed";

	private const string EVENT_RW_TAPPED = "rewarded_ad_tapped";

	private const string EVENT_RW_STARTED = "rewarded_ad_started";

	private const string EVENT_RW_COMPLETED = "rewarded_ad_completed";

	private const string EVENT_RW_FAILED = "rewarded_ad_failed";

	private const string EVENT_IAP_RESTORED = "iap_item_restored";

	private const string EVENT_CRYSTAL_USED = "crystal_used";

	private const string ADJUST_TOKEN_IAP_PURCHASE = "3s9tus";

	public bool IsInitialized => false;

	public bool IsInterstitialReady => false;

	public bool IsRewardedVideoReady => false;

	public bool IsEnergyUnlocked => false;

	public bool IsNoAdsActive => false;

	public bool IsWeeklyAdsActive => false;

	public bool IsRewardedInProgress => false;

	public int EnergyRewardPerAd => 0;

	public event Action OnAdManagerInitialized
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

	public event Action OnInterstitialShown
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

	public event Action OnInterstitialDismissed
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

	public event Action<bool> OnRewardedVideoCompleted
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

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CPollSdkInitialization_003Ed__50))]
	private IEnumerator PollSdkInitialization()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void InitializeSdk()
	{
	}

	private void HandleSdkInitialized()
	{
	}

	private void LoadRemoteConfig()
	{
	}

	private void SubscribeEvents()
	{
	}

	private void UnsubscribeEvents()
	{
	}

	public bool TryShowInterstitial(InterstitialSource source)
	{
		return false;
	}

	public bool CanShowInterstitial(out string blockReason)
	{
		blockReason = null;
		return false;
	}

	public void ShowRewardedVideo(RewardedCategory category, RewardedSource source, string item, Action<bool> onComplete)
	{
	}

	public void ShowRewardedVideo(RewardedCategory category, RewardedSource source, string item, int rewardAmount, Action<bool> onComplete)
	{
	}

	public void ShowRewardedForEnergy(Action<bool> onComplete = null)
	{
	}

	private void GrantEnergyReward()
	{
	}

	public void ShowRewardedForSkillStatPanelAllClaim(Action<bool> onComplete = null)
	{
	}

	private void GrantSkillStatReward()
	{
	}

	public void ShowRewardedForEndGameX2Claim(Action<bool> onComplete = null)
	{
	}

	private void GrantX2ClaimReward()
	{
	}

	public void ShowRewardedForPetGemRewardBtn1(Action<bool> onComplete = null)
	{
	}

	private void GrantPetGemBtn1ClaimReward()
	{
	}

	public void ShowRewardedForPetGemRewardBtn2(Action<bool> onComplete = null)
	{
	}

	private void GrantPetGemBtn2ClaimReward()
	{
	}

	public void ShowRewardedForShopGemReward(Action<bool> onComplete = null)
	{
	}

	private void GrantShopGemClaimReward()
	{
	}

	public void ShowRewardedForDungeon(RewardedType type, Action<bool> onComplete = null)
	{
	}

	private void GrantDungeonClaimReward(RewardedType type)
	{
	}

	private int GetCurrentLevel()
	{
		return 0;
	}

	public void TrackShopOpened()
	{
	}

	public void TrackIapTapped(string itemId, string itemType, int priceUsdCents)
	{
	}

	public void TrackIapPurchased(string productId, string productType, int priceUsdCents, double revenueUsd)
	{
	}

	public void TrackIapFailed(string itemId, string itemType, string reason, int priceUsdCents)
	{
	}

	public void TrackIapRestored(string productId, string productType)
	{
	}

	public void TrackCrystalUsed(string source, double amount)
	{
	}

	public void TrackRewardedTapped(string source)
	{
	}

	public void TrackRewardedStarted(string source)
	{
	}

	public void TrackRewardedCompleted(string source, int rewardAmount)
	{
	}

	public void TrackRewardedFailed(string source)
	{
	}

	private void HandleEnergyUnlocked()
	{
	}

	public void EnergyUnlocked()
	{
	}

	private void HandleInterstitialShown()
	{
	}

	private void HandleInterstitialDismissed()
	{
	}

	private void HandleRewardedRewardReceived(string networkName)
	{
	}

	private void HandleRewardedClosed()
	{
	}

	private bool IsCooldownPassed()
	{
		return false;
	}

	private float GetRemainingCooldown()
	{
		return 0f;
	}

	private bool IsFirstDelayPassed()
	{
		return false;
	}

	private float GetRemainingFirstDelay()
	{
		return 0f;
	}

	private RollicInterstitialAd.InterstitialAdSource MapInterstitialSource(InterstitialSource source)
	{
		return RollicInterstitialAd.InterstitialAdSource.InLevel;
	}

	private RollicRewardedAd.RewardedAdCategory MapRewardedCategory(RewardedCategory category)
	{
		return RollicRewardedAd.RewardedAdCategory.Upgrade;
	}

	private RollicRewardedAd.RewardedAdSource MapRewardedSource(RewardedSource source)
	{
		return RollicRewardedAd.RewardedAdSource.NormalLevel;
	}

	[IteratorStateMachine(typeof(_003CFakeInterstitialFlow_003Ed__110))]
	private IEnumerator FakeInterstitialFlow()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFakeRewardedFlow_003Ed__111))]
	private IEnumerator FakeRewardedFlow()
	{
		return null;
	}

	private bool ShouldBypassInEditor()
	{
		return false;
	}

	private void Log(string message)
	{
	}
}
