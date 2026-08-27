using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroCard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActivationClickRoutine_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HeroCard _003C_003E4__this;

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
		public _003CActivationClickRoutine_003Ed__66(int _003C_003E1__state)
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

	private const string LockedText = "Locked";

	private const string LevelFormat = "Lv. {0}";

	private const string ShardFormat = "{0}/{1}";

	[Header("Basic Info")]
	[SerializeField]
	private Image heroIconImage;

	[SerializeField]
	private TMP_Text heroNameText;

	[Header("Progress")]
	[SerializeField]
	private TMP_Text levelText;

	[SerializeField]
	private GameObject shardSliderHolder;

	[SerializeField]
	private GameObject starHolder;

	[SerializeField]
	private HeroCardStar[] stars;

	[SerializeField]
	private TMP_Text lockedStateText;

	[SerializeField]
	private TMP_Text shardProgressText;

	[SerializeField]
	private Slider shardProgressSlider;

	[SerializeField]
	private Image shardProgressFillImage;

	[Header("State Objects")]
	[SerializeField]
	private GameObject activateObject;

	[SerializeField]
	private GameObject lockedObject;

	[SerializeField]
	private GameObject tierUpDot;

	[SerializeField]
	private GameObject levelUpDot;

	[Header("Activation")]
	[SerializeField]
	private Animator activationAnimator;

	[SerializeField]
	[Min(0f)]
	private float activationInfoPanelDelay;

	[Header("Level Up")]
	[SerializeField]
	private CurrencyTypes levelUpCurrencyType;

	[Header("Rarity Objects")]
	[SerializeField]
	private GameObject[] srRarityObjects;

	[SerializeField]
	private GameObject[] ssrRarityObjects;

	[SerializeField]
	private GameObject[] urRarityObjects;

	[Header("Click")]
	[SerializeField]
	private Button clickButton;

	[CompilerGenerated]
	private Action<HeroCard> m_Clicked;

	private bool currencyChangeSubscribed;

	private Coroutine activationClickRoutine;

	public HeroDatabaseSO HeroDatabase { get; private set; }

	public HeroData HeroData { get; private set; }

	public HeroProgressData ProgressData { get; private set; }

	public event Action<HeroCard> Clicked
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

	private void OnDestroy()
	{
	}

	public void Setup(HeroDatabaseSO heroDatabase, HeroData heroData, HeroProgressData progressData)
	{
	}

	public void Setup(HeroData heroData, HeroProgressData progressData)
	{
	}

	public void Refresh()
	{
	}

	private void RefreshBasicInfo(HeroBasicInfoData basicInfo)
	{
	}

	private void RefreshRarity(Rarity rarity)
	{
	}

	private static string NormalizeRarityName(string rarityName)
	{
		return null;
	}

	private static void SetActive(GameObject[] targets, bool isActive)
	{
	}

	private void RefreshState(bool isUnlocked)
	{
	}

	private void RefreshProgress(bool isUnlocked)
	{
	}

	private void RefreshStars(bool isUnlocked, int currentStar, int currentTier)
	{
	}

	private void RefreshShardProgress()
	{
	}

	private void RefreshUpgradeDots(bool isUnlocked)
	{
	}

	private bool CanLevelUp()
	{
		return false;
	}

	private bool CanAscend()
	{
		return false;
	}

	private bool IsHeroUnlocked()
	{
		return false;
	}

	private bool CanActivateHero()
	{
		return false;
	}

	private void SubscribeCurrencyChanged()
	{
	}

	private void UnsubscribeCurrencyChanged()
	{
	}

	private void HandleCurrencyChanged()
	{
	}

	private void StartActivationClickRoutine()
	{
	}

	private void StopActivationClickRoutine()
	{
	}

	[IteratorStateMachine(typeof(_003CActivationClickRoutine_003Ed__66))]
	private IEnumerator ActivationClickRoutine()
	{
		return null;
	}

	private void PlayActivationPop()
	{
	}

	private void UnlockHeroForTest()
	{
	}

	private static bool CanBuy(CurrenciesHandler currencies, float cost, CurrencyTypes currencyType)
	{
		return false;
	}

	private void HandleClicked()
	{
	}
}
