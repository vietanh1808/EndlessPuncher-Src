using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HpBehaviour : MonoBehaviour, IHPControl
{
	[CompilerGenerated]
	private sealed class _003CGiantLethalSlowMotionRoutine_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HpBehaviour _003C_003E4__this;

		public EndlessGaintBehaviour giant;

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
		public _003CGiantLethalSlowMotionRoutine_003Ed__62(int _003C_003E1__state)
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
	private sealed class _003CMatChange_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HpBehaviour _003C_003E4__this;

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
		public _003CMatChange_003Ed__72(int _003C_003E1__state)
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
	private sealed class _003CPoisonDamageRoutine_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float tickInterval;

		public HpBehaviour _003C_003E4__this;

		public float damagePerTick;

		public float duration;

		private float _003Celapsed_003E5__2;

		private float _003CsafeTickInterval_003E5__3;

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
		public _003CPoisonDamageRoutine_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CSetSliderScale_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HpBehaviour _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CSetSliderScale_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CsetHpValue_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HpBehaviour _003C_003E4__this;

		private float _003Ct_003E5__2;

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
		public _003CsetHpValue_003Ed__76(int _003C_003E1__state)
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

	[Header("Giant Lethal Hit Slow Motion")]
	[SerializeField]
	private float giantLethalSlowMotionScale;

	[SerializeField]
	private float giantLethalSlowMotionHoldDuration;

	private static HpBehaviour _instance;

	private bool _isMassiveShieldEarned;

	private float _shield;

	private float _maxShieldValue;

	private float _maxHpValue;

	private float _totalHp;

	private int _counterFreezingEnemy;

	private PlayerBehaviour playerBehaviour;

	private PlayerStatController psc;

	private ItemsBonusInGame itemsBonus;

	private bool _isGiantLethalSlowMotionActive;

	[SerializeField]
	private TextMeshProUGUI textMeshHP;

	[SerializeField]
	private TextMeshProUGUI textShieldHP;

	[SerializeField]
	private Slider hpSlinder;

	[SerializeField]
	private Slider lateHpSlider;

	[SerializeField]
	private Slider shieldSlider;

	[SerializeField]
	private Animator shieldAnimator;

	public Transform textPoint;

	public Transform shieldTextPoint;

	private Coroutine poisonDamageRoutine;

	[CompilerGenerated]
	private Action<bool> m_PoisonStateChanged;

	public GameObject[] regularMaterials;

	public GameObject[] takeDamageMaterials;

	public GameObject[] grayMaterials;

	private Coroutine corMatChange;

	private Coroutine hpCoro;

	private bool _isScaledBar;

	private Coroutine hpScale;

	[SerializeField]
	private Slider grayDecatingHPSlider;

	[SerializeField]
	private Animator grayDecatingAnimator;

	private bool _isDecatingActive;

	private bool _isDecatingActiveOnlyOne;

	private bool _isReviveOnlyOne;

	private bool _decatingAnimSetted;

	private float _decatingMaxHP;

	private float _decatingCurrentHP;

	private int _savedDecating;

	private int _decatingEnemyCounter;

	public static HpBehaviour Instance => null;

	public float TotalShield
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float TotalHp
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsPoisoned => false;

	public bool IsDecatingActive => false;

	public event Action<bool> PoisonStateChanged
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

	private void SetShieldSliderAndText()
	{
	}

	private void TextShieldHP()
	{
	}

	public float GetHPRatio()
	{
		return 0f;
	}

	public float GetMaxHpValue()
	{
		return 0f;
	}

	public void AddMaxHP(float mHPvalue)
	{
	}

	public void AddHpRecovery(float percentage)
	{
	}

	public void AddHpRegen(float percentage)
	{
	}

	public void AddFreezingHpRegen(float percentage)
	{
	}

	public void AddHpRevive(float value)
	{
	}

	public void LifeStealAdd(float lsValue)
	{
	}

	private void SetSliderAndText()
	{
	}

	private void TextHP()
	{
	}

	private void SyncDungeonPlayerHp()
	{
	}

	private string GetFormattedHpText(float currentHp, float maxHp)
	{
		return null;
	}

	private string FormatPlayerHpValue(float value)
	{
		return null;
	}

	private float GetSafeRatio(float currentValue, float maxValue)
	{
		return 0f;
	}

	public void SetTotalHp(float hp)
	{
	}

	public Transform GetTarget()
	{
		return null;
	}

	private void Start()
	{
	}

	public void ResetForNewRun()
	{
	}

	private void Update()
	{
	}

	private void SetPoisonDamageRoutine(Coroutine routine)
	{
	}

	public void ApplyPoisonDamageOverTime(float damagePerTick, float duration, float tickInterval)
	{
	}

	[IteratorStateMachine(typeof(_003CPoisonDamageRoutine_003Ed__59))]
	private IEnumerator PoisonDamageRoutine(float damagePerTick, float duration, float tickInterval)
	{
		return null;
	}

	public void SetHpValue(float damage, GameObject owner)
	{
	}

	private bool TryStartGiantLethalSlowMotion(GameObject owner)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGiantLethalSlowMotionRoutine_003Ed__62))]
	private IEnumerator GiantLethalSlowMotionRoutine(EndlessGaintBehaviour giant)
	{
		return null;
	}

	private bool IsGiantScene()
	{
		return false;
	}

	private bool TryReviveFromDeath()
	{
		return false;
	}

	private void SetDeathSliderValues()
	{
	}

	private void DieMatsActive()
	{
	}

	private void ReviveMatsActive()
	{
	}

	[IteratorStateMachine(typeof(_003CMatChange_003Ed__72))]
	private IEnumerator MatChange()
	{
		return null;
	}

	private void SetObjectsActive(GameObject[] objects, bool isActive)
	{
	}

	private void EnsureReferences()
	{
	}

	[IteratorStateMachine(typeof(_003CsetHpValue_003Ed__76))]
	private IEnumerator setHpValue()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetSliderScale_003Ed__79))]
	private IEnumerator SetSliderScale()
	{
		return null;
	}

	public void DecatingHpReviveStarted()
	{
	}

	private void DecatingCheck()
	{
	}

	private void DecatingText()
	{
	}

	public void DecatingEnemyCounter()
	{
	}
}
