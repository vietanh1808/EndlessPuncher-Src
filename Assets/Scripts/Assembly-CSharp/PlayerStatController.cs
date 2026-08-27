using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Inventory;
using Fubu.Inventory.DB;
using UnityEngine;

public class PlayerStatController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDefenceEarnWithTime_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStatController _003C_003E4__this;

		public float defenceValue;

		public float time;

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
		public _003CDefenceEarnWithTime_003Ed__144(int _003C_003E1__state)
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
	private sealed class _003CIncreaseCritChanceWT_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStatController _003C_003E4__this;

		public float ratio;

		public float time;

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
		public _003CIncreaseCritChanceWT_003Ed__87(int _003C_003E1__state)
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
	private sealed class _003CIncreaseRateWT_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStatController _003C_003E4__this;

		public float ratio;

		public float time;

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
		public _003CIncreaseRateWT_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CRangeLoad_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStatController _003C_003E4__this;

		public float range;

		private Vector3 _003Cscale_003E5__2;

		private Vector3 _003CendScale_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CRangeLoad_003Ed__74(int _003C_003E1__state)
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

	private const int IncrementalMaxHpId = 1;

	private static PlayerStatController _instance;

	private GameManager gm;

	private PlayerBehaviour pb;

	private ItemsBonusInGame itemBonus;

	private ItemPanelHandler itemPanel;

	private CollectiblesInGameEffects collectibleEffects;

	private InGameUI ui;

	private HpBehaviour pHp;

	private ComboCounter combo;

	public PlayerTypes player;

	private bool _extraArmIncreasePunchDamageRatioIsActive;

	private float _extraArmIncreasePunchDamageRatio;

	private bool _extraDamageIncreaseEveryComboScoreIsActive;

	private float _extraDamageIncreaseEveryComboScore;

	private bool _getDamageIncreaseBelowHPIsActive;

	private float _getDamageIncreaseBelowHP;

	private float _damage;

	private float _inGameDamage;

	private List<float> _inGameDamageList;

	private bool _extraArmSkillDamageIncreaseRatioIsActive;

	private float _extraArmSkillDamageIncreaseRatio;

	private bool _skillDamageIncreaseRatioIsActive;

	private float _skillDamageIncreaseRatio;

	private float _skillDamage;

	private float _inGameSkillDamage;

	private float _rate;

	private float _inGameRate;

	private float _inGameRateExtraFromCards;

	private float _inGameRateExtraFromComboReach5x;

	private bool _inGameRateExtraFromComboReach5xIsActive;

	private List<float> _inGameRateList;

	private Coroutine corIncRate;

	public Transform rangeObje;

	private bool _punchRangeIncreaseRatioIsActive;

	private float _punchRangeIncreaseRatio;

	private float _range;

	private float _inGameRange;

	private List<float> _inGameRangeList;

	public AnimationCurve curveRangePop;

	private float _savedRange;

	private bool _increaseCritChanceRatioIsActive;

	private float _increaseCritChanceRatio;

	private float _critChance;

	private float _inGameCritChance;

	private float _inGameCritChanceExtraFromCards;

	private List<float> _inGameCritChanceList;

	private Coroutine corIncCritChance;

	private bool _extraArmIncreaseCritDamageRatioIsActive;

	private float _extraArmIncreaseCritDamageRatio;

	private bool _increaseCritDamageRatioIsActive;

	private float _increaseCritDamageRatio;

	private float _critDamage;

	private float _inGameCritDamage;

	private float _maxHP;

	private float _inGameMaxHP;

	private List<float> _inGameMaxHPList;

	private float _hpRecovery;

	private float _inGameHpRecovery;

	private float _lifesteal;

	private float _inGameLifesteal;

	private List<float> _inGameLifestealList;

	private bool _knockbackIncreaseRatioIsActive;

	private float _knockbackIncreaseRatio;

	private float _knockBack;

	private float _inGameKnockback;

	private bool _extraArmShieldValueIsActive;

	private float _extraArmShieldValue;

	private bool _shieldIncreaseValueIsActive;

	private float _shieldIncreaseValue;

	private bool _inGameShieldExtraFromComboReach3xIsActive;

	private float _inGameShieldExtraFromComboReach3x;

	private float _shield;

	private float _shieldAfterKillingEnemies50;

	private float _inGameShield;

	private List<float> _inGameShieldList;

	private float _exp;

	private float _inGameExp;

	private List<float> _inGameExpList;

	public static PlayerStatController instance => null;

	public float Damage => 0f;

	public float DamageWOItem => 0f;

	public float SkillDamage => 0f;

	public float TotalSkillDamageUpgrade => 0f;

	public float Rate => 0f;

	public float RateWOItem => 0f;

	public float Range => 0f;

	public float RangeWOItem => 0f;

	public float CritChance => 0f;

	public float CritChanceWOItem => 0f;

	public float CritDamage => 0f;

	public float CritDamageWOItem => 0f;

	public float MaxHP => 0f;

	public float MaxHPWOItem => 0f;

	public float HpRecovery => 0f;

	public float HpRecoveryWOItem => 0f;

	public float Lifesteal => 0f;

	public float LifestealWOItem => 0f;

	public float Knockback => 0f;

	public float KnockbackWOItem => 0f;

	public float Shield => 0f;

	public float ShieldWOItem => 0f;

	public float Exp => 0f;

	public float ExpWOItem => 0f;

	private void Awake()
	{
	}

	private void StartCommonInit()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void GetItemBonuses()
	{
	}

	private float GetExtraArmMergeDamageBonus()
	{
		return 0f;
	}

	private bool IsDungeonOrGiantScene()
	{
		return false;
	}

	private bool IsDungeonRangeBonusScene()
	{
		return false;
	}

	private float GetRingStat(PlayerStatType statType)
	{
		return 0f;
	}

	private float GetCollectibleStat(PlayerStatType statType)
	{
		return 0f;
	}

	private float ApplyCollectibleSetPercent(PlayerStatType statType, float statValue)
	{
		return 0f;
	}

	public void IncraseRateWTime(float ratio, float time)
	{
	}

	[IteratorStateMachine(typeof(_003CIncreaseRateWT_003Ed__60))]
	private IEnumerator IncreaseRateWT(float ratio, float time)
	{
		return null;
	}

	public float GetPermanentRange()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CRangeLoad_003Ed__74))]
	private IEnumerator RangeLoad(float range)
	{
		return null;
	}

	public void IncraseCritChanceWTime(float ratio, float time)
	{
	}

	[IteratorStateMachine(typeof(_003CIncreaseCritChanceWT_003Ed__87))]
	private IEnumerator IncreaseCritChanceWT(float ratio, float time)
	{
		return null;
	}

	private void HandleIncrementalBonusChanged(int id, float newValue, float delta)
	{
	}

	public void RefreshMaxHpFromStats()
	{
	}

	private void RefreshMaxHpFromStats(float delta)
	{
	}

	public void GainDefenceAfterKill50Enemies(float defenceValue)
	{
	}

	[IteratorStateMachine(typeof(_003CDefenceEarnWithTime_003Ed__144))]
	private IEnumerator DefenceEarnWithTime(float time, float defenceValue)
	{
		return null;
	}

	public void AddStat(PlayerStatType type, float value)
	{
	}

	public float GetCurrentStatValue(PlayerStatType type)
	{
		return 0f;
	}

	public float GetCurrentStatValueWOItems(PlayerStatType type)
	{
		return 0f;
	}

	public void ResetForNewRun()
	{
	}
}
