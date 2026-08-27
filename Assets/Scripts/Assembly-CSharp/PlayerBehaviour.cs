using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
	[Serializable]
	public class AttackArmConf
	{
		public Vector3 targetPosa;

		public Animator animArm;

		public GameObject[] armObje;

		public PlayerArm arm;

		public bool isAttackActive;

		public Func<float, float>? xFunc;

		public void ActivateArm(bool isActive = true)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public float f;

		public float yDiff;

		internal float _003CSetTargetEnum_003Eb__0(float x)
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public float f;

		public float yDiff;

		internal float _003CPunchScreenRator_003Eb__1(float x)
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateCharacterScale_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

		public Vector3 targetScale;

		private Vector3 _003CstartScale_003E5__2;

		private float _003Ct_003E5__3;

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
		public _003CAnimateCharacterScale_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CDamageBounceRoutine_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

		private Vector3 _003CrestScale_003E5__2;

		private Vector3 _003CtargetScale_003E5__3;

		private float _003ChalfDuration_003E5__4;

		private float _003Ct_003E5__5;

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
		public _003CDamageBounceRoutine_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CDecatingHPStarter_003Ed__139 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

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
		public _003CDecatingHPStarter_003Ed__139(int _003C_003E1__state)
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
	private sealed class _003CDelayLoad_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

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
		public _003CDelayLoad_003Ed__49(int _003C_003E1__state)
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
	private sealed class _003CMergeArmScalePop_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

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
		public _003CMergeArmScalePop_003Ed__27(int _003C_003E1__state)
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
	private sealed class _003CNewArmScalePop_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

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
		public _003CNewArmScalePop_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CPunchScreenRator_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

		private _003C_003Ec__DisplayClass150_0 _003C_003E8__1;

		public Action onPunchImpact;

		private Quaternion _003CstrtQ_003E5__2;

		private AttackArmConf _003Carc_003E5__3;

		private PlayerArm _003CselectedArm_003E5__4;

		private float _003Ct_003E5__5;

		private float _003CfastSpeed_003E5__6;

		private Vector3 _003CstartPos_003E5__7;

		private float _003CarmScaleTime_003E5__8;

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
		public _003CPunchScreenRator_003Ed__150(int _003C_003E1__state)
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
	private sealed class _003CReviveSequance_003Ed__135 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

		public float valueHP;

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
		public _003CReviveSequance_003Ed__135(int _003C_003E1__state)
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
	private sealed class _003CSetTargetEnum_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

		public Transform targetPosition;

		public AttackArmConf arc;

		private _003C_003Ec__DisplayClass108_0 _003C_003E8__1;

		private PlayerArm _003CselectedArm_003E5__2;

		private float _003CfastSpeed_003E5__3;

		private Vector3 _003CstartPos_003E5__4;

		private float _003Ct_003E5__5;

		private float _003CarmScaleTime_003E5__6;

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
		public _003CSetTargetEnum_003Ed__108(int _003C_003E1__state)
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
	private sealed class _003CpopHandsAndAnimLevelUp_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerBehaviour _003C_003E4__this;

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
		public _003CpopHandsAndAnimLevelUp_003Ed__146(int _003C_003E1__state)
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

	[SerializeField]
	private float bodyScalePerArmPowerLevel;

	[SerializeField]
	private float bodyScaleTransitionSpeed;

	[SerializeField]
	private float damageBounceScaleMultiplier;

	[SerializeField]
	private float damageBounceDuration;

	private static PlayerBehaviour _instance;

	private GameManager gm;

	private InGameUI ui;

	private Vector3 baseCharacterScale;

	private Vector3 initialPosition;

	private Quaternion initialRotation;

	private Vector3 initialPlayerModelLocalPosition;

	private Coroutine bodyScaleCoroutine;

	private Coroutine damageBounceCoroutine;

	private Vector3 currentCharacterTargetScale;

	private int _armCount;

	public List<AttackArmConf> allAttackArmConfs;

	private InGameUI gameUI;

	private AttackBehaviour ab;

	private PlayerStatController playerStatController;

	private HpBehaviour pHp;

	[SerializeField]
	private Animator[] animator;

	private Func<float, float>? xFunc;

	[Header("Variables")]
	private int _handCounter;

	[SerializeField]
	private bool isAttackActive;

	[SerializeField]
	private float punchAnimDelay;

	[SerializeField]
	private float punchHitRange;

	[Header("Settings")]
	public PlayerArm[] allArms;

	public AnimationCurve targetMoveCurve;

	public float rotSpeed;

	private bool _isGameStopped;

	private Transform _targetHit;

	private float _attackSpeed;

	[Header("Attack Settings")]
	public LayerMask maskEnemy;

	public LayerMask maskDummy;

	private bool _isRightPunch;

	private float _timerResting;

	private float _prizeResting;

	private bool _restingPrizeActive;

	private bool _gaveRestingPrize;

	private bool _inFight;

	private Collider[] colInRange;

	private readonly Collider[] _enemyQueryBuffer;

	private readonly Collider[] _dummyQueryBuffer;

	private readonly Collider[] _lightningJumpBuffer;

	private readonly Collider[] _hitEnemyBuffer;

	private readonly Collider[] _hitDummyBuffer;

	private readonly Collider[] _effectEnemyBuffer;

	private readonly List<Transform> _targetEnemiesBuffer;

	private readonly bool[] _enemySelectionFlags;

	private readonly bool[] _dummySelectionFlags;

	private float _lastTargetRefreshTime;

	private const float TargetRefreshInterval = 0.2f;

	private bool _combatHasAnyTarget;

	private Transform _combatClosestTarget;

	private int _combatEnemyCount;

	private int _combatDummyCount;

	private static readonly int attackSpeedHash;

	private static readonly int isLeftHash;

	private Coroutine corPunch;

	private int _countAllAttackArm;

	public FreezeShardControl shardPrefab;

	private readonly Dictionary<GameObject, float> _hostileEnemies;

	private const float HostileMemoryDuration = 5f;

	public GameObject localTarget;

	private bool isDead;

	public Transform playerModel;

	public AnimationCurve curvePosLerpPos;

	public Transform punchScreenPoint;

	public static PlayerBehaviour Instance => null;

	public int GetExtraArmCount => 0;

	public int ArmCount => 0;

	public HpBehaviour GetHP => null;

	private int BoneCount => 0;

	public bool IsDead => false;

	private void Awake()
	{
	}

	private void StartCommonInit()
	{
	}

	public bool isReachedMaxArm()
	{
		return false;
	}

	public void CheckStartArmCount()
	{
	}

	public void AddArm()
	{
	}

	[IteratorStateMachine(typeof(_003CNewArmScalePop_003Ed__26))]
	private IEnumerator NewArmScalePop()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMergeArmScalePop_003Ed__27))]
	private IEnumerator MergeArmScalePop()
	{
		return null;
	}

	private bool ShouldSkipExtraArmCameraRestore()
	{
		return false;
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayLoad_003Ed__49))]
	private IEnumerator DelayLoad()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void SetRegularBoxingGloves()
	{
	}

	private int GetSavedIncrementalExtraArmCount()
	{
		return 0;
	}

	private void ApplyPersistentExtraArmCount(int totalExtraArmCount, bool playFeedback)
	{
	}

	private bool IsDungeonOrGiantScene()
	{
		return false;
	}

	private void ApplyArmPowerLevel(int powerLevel)
	{
	}

	private void ApplyCharacterScaleForArmPowerLevel(int powerLevel, bool animate)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateCharacterScale_003Ed__57))]
	private IEnumerator AnimateCharacterScale(Vector3 targetScale)
	{
		return null;
	}

	public void PlayDamageBounce()
	{
	}

	[IteratorStateMachine(typeof(_003CDamageBounceRoutine_003Ed__59))]
	private IEnumerator DamageBounceRoutine()
	{
		return null;
	}

	private void PlayIncrementalExtraArmFeedback()
	{
	}

	private void HandleExtraArmStateChanged(int extraArmCount, int powerLevel)
	{
	}

	private void CheckIsGameStopped()
	{
	}

	private bool CanStart()
	{
		return false;
	}

	private void Update()
	{
	}

	private void LookClotestEnemy()
	{
	}

	private void LateUpdate()
	{
	}

	private void Attacking()
	{
	}

	private bool IsPlayerPunchDisabledByDungeon()
	{
		return false;
	}

	private void AllAttackController()
	{
	}

	private void RestingCounter()
	{
	}

	private bool IsThereEnemyInRange()
	{
		return false;
	}

	public List<Transform> GetEnemies()
	{
		return null;
	}

	private Transform? CheckClotestEnemy()
	{
		return null;
	}

	private void RefreshCombatTargetCacheIfNeeded(bool force = false)
	{
	}

	private void PopulateClosestCombatTarget(Vector3 origin)
	{
	}

	private void PopulateCombatTargetList(Vector3 origin)
	{
	}

	[IteratorStateMachine(typeof(_003CSetTargetEnum_003Ed__108))]
	private IEnumerator SetTargetEnum(Transform targetPosition, AttackArmConf arc)
	{
		return null;
	}

	public void Hit(Vector3 hitPos)
	{
	}

	private bool TryGetEnemyFromCollider(Collider col, out IEnemy enemy)
	{
		enemy = null;
		return false;
	}

	private float GetElementPunchDamage(EffectType type)
	{
		return 0f;
	}

	public void CheckIsEnemyUnderEffect(GameObject enemyHitten)
	{
	}

	private void GiveDamageInRange(float range, GameObject baseEnemy)
	{
	}

	private void FreezExpoGiveDamageInRange(float range, GameObject baseEnemy)
	{
	}

	private void JumpLightningInRange(float range, GameObject baseEnemy)
	{
	}

	private static int GetNearestColliderIndex(Collider[] colliders, int count, bool[] selected, Vector3 point)
	{
		return 0;
	}

	public void ReportHostileAction(GameObject enemy)
	{
	}

	private bool IsEnemyHostile(GameObject enemy)
	{
		return false;
	}

	private static int GetClosestLowestHpColliderIndex(Collider[] colliders, int count, bool[] selected, Vector3 point)
	{
		return 0;
	}

	private static bool TryGetEnemyCurrentHp(Collider col, out float hp)
	{
		hp = default;
		return false;
	}

	public int GetMaxEffectJumpEnemyCount(EffectType type)
	{
		return 0;
	}

	private void ActivateEffectHit(EffectType type)
	{
	}

	private EffectType GetEffectType()
	{
		return EffectType.none;
	}

	private Transform getMostClotest(Collider[] cc)
	{
		return null;
	}

	public void ResetForNewRun()
	{
	}

	public void Dead()
	{
	}

	public void Revive(float valueHP)
	{
	}

	[IteratorStateMachine(typeof(_003CReviveSequance_003Ed__135))]
	private IEnumerator ReviveSequance(float valueHP)
	{
		return null;
	}

	public void ReviveDecatingHealth()
	{
	}

	[IteratorStateMachine(typeof(_003CDecatingHPStarter_003Ed__139))]
	private IEnumerator DecatingHPStarter()
	{
		return null;
	}

	private void PlayRandomDeathAnimation()
	{
	}

	public void Complete()
	{
	}

	public void PlayRoarAnimation()
	{
	}

	public void LevelUpPlayer()
	{
	}

	public void PlayLevelUpAnimationOnly()
	{
	}

	private void AttackAroundHalfRangeEnemies()
	{
	}

	[IteratorStateMachine(typeof(_003CpopHandsAndAnimLevelUp_003Ed__146))]
	private IEnumerator popHandsAndAnimLevelUp()
	{
		return null;
	}

	public void PunchScreen(Action onPunchImpact = null)
	{
	}

	private bool IsDungeonScene()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CPunchScreenRator_003Ed__150))]
	private IEnumerator PunchScreenRator(Action onPunchImpact)
	{
		return null;
	}

	private bool IsPointerOverUIObject()
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
