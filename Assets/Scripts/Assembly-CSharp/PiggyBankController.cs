using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBankController : MonoBehaviour, ISaveable
{
	[CompilerGenerated]
	private sealed class _003CCloseAfterDelay_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiggyBankController _003C_003E4__this;

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
		public _003CCloseAfterDelay_003Ed__48(int _003C_003E1__state)
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
	private sealed class _003CEnergyFlySequence_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiggyBankController _003C_003E4__this;

		public int energyAmount;

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
		public _003CEnergyFlySequence_003Ed__51(int _003C_003E1__state)
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

	public const string PiggyBankUnlockSaveKey = "piggyBankUnlockKey";

	private static bool waitForBaseReturnAfterUnlock;

	private static bool openInfoPanelAfterFirstFillBaseReturn;

	[SerializeField]
	private PiggyBankSO piggyBankSO;

	[SerializeField]
	private GameObject piggyBankPanel;

	[SerializeField]
	private GameObject iconDeactive;

	[SerializeField]
	private GameObject IconActive;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private Image sliderImage;

	[SerializeField]
	private Color slideroff;

	[SerializeField]
	private Color sliderOn;

	[SerializeField]
	private TextMeshProUGUI sliderText;

	[SerializeField]
	private float closeDelay;

	[Header("Energy Fly Animation")]
	[SerializeField]
	private Image flyingEnergyIconPrefab;

	[SerializeField]
	private Transform flyingEnergyIconParent;

	[SerializeField]
	private Transform energyFlyStartPoint;

	[SerializeField]
	private Transform energyFlyTargetPoint;

	[SerializeField]
	private Animator piggyBankPanelAnimator;

	[SerializeField]
	private float energyFlyDuration;

	[SerializeField]
	private float energyFlyDelayBetweenIcons;

	[SerializeField]
	private float hideAfterEnergyArriveDelay;

	[Header("Info Panel")]
	[SerializeField]
	private GameObject piggyBankInfoPanel;

	[SerializeField]
	private GameObject offerObje;

	[SerializeField]
	private GameObject offerDescriptionObje;

	[SerializeField]
	private GameObject infoIconDeactive;

	[SerializeField]
	private GameObject infoIconActive;

	[SerializeField]
	private Slider sliderInfoPanel;

	[SerializeField]
	private ParticleSystem confettie;

	[SerializeField]
	private ShopButton shopBtn;

	private readonly List<Image> flyingEnergyIcons;

	private readonly List<Coroutine> energyFlyRoutines;

	private Animator infoPanelAnimator;

	private Coroutine closeRoutine;

	private int activeEnergyFlySequenceCount;

	private EnergyHandler subscribedEnergyHandler;

	private bool isOpen;

	private bool isSubscribedToShopManager;

	private int usedEnergy;

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

	public void EnergyUsed(int amount)
	{
	}

	public void RefreshForSoftRestart()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void HidePanelForOverlay()
	{
	}

	public void RefreshAfterOverlayClosed()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseAfterDelay_003Ed__48))]
	private IEnumerator CloseAfterDelay()
	{
		return null;
	}

	private void RefreshUI()
	{
	}

	private void PlayEnergyFlySequence(int energyAmount)
	{
	}

	[IteratorStateMachine(typeof(_003CEnergyFlySequence_003Ed__51))]
	private IEnumerator EnergyFlySequence(int energyAmount)
	{
		return null;
	}

	private void AddEnergyToPiggyBankProgress(int amount)
	{
	}

	private Vector3 GetEnergyFlyStartPosition()
	{
		return default;
	}

	private Transform GetDefaultFlyingIconParent()
	{
		return null;
	}

	private Vector3 GetEnergyFlyTargetPosition()
	{
		return default;
	}

	private static Vector2 GetAnchoredPosition(RectTransform parentRect, Transform point, Vector3 fallbackWorldPosition)
	{
		return default;
	}

	private void PlayPiggyBankPop()
	{
	}

	private void HidePiggyBankPanelWithTrigger()
	{
	}

	private void StopEnergyFlyRoutine()
	{
	}

	private void RefreshInfoPanelContent()
	{
	}

	private bool IsOfferActive()
	{
		return false;
	}

	private bool IsBankFull(int clampedUsedEnergy, int targetEnergy)
	{
		return false;
	}

	private int GetTargetEnergy()
	{
		return 0;
	}

	private void TryOpenInfoPanelAfterFirstFillBaseReturn()
	{
	}

	private bool IsPiggyBankUnlocked()
	{
		return false;
	}

	public static void DelayUnlockedPanelUntilBaseReturn()
	{
	}

	public static bool CanShowUnlockedPiggyBank()
	{
		return false;
	}

	private static bool IsPiggyBankBlockedByScene()
	{
		return false;
	}

	private static bool IsPiggyBankUnlockedBySaveOrChapter()
	{
		return false;
	}

	private void SubscribeEnergyHandler()
	{
	}

	private void UnsubscribeEnergyHandler()
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

	private static bool IsSameProduct(ShopProductDataSO expectedProduct, ShopProductDataSO purchasedProduct)
	{
		return false;
	}

	private void PlayPurchaseConfettie()
	{
	}

	private void ResetPiggyBankProgress()
	{
	}

	public void OnLoad(SaveData data)
	{
	}

	public void OnSave(SaveData data)
	{
	}
}
