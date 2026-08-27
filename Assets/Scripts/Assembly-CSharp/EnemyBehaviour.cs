using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour, IEnemy, IStatusEffectTarget, ISkillHitLimitProvider, ISkillTargetPointProvider
{
	private enum CarriedRewardType
	{
		None = 0,
		ChestKey = 1,
		CollectibleChestKey = 2,
		TalentGem = 3,
		InventoryGem = 4,
		PetGem = 5,
		ShopGem = 6,
		EventCurrency = 7,
		RingGem = 8
	}

	private enum EnemyUpdateTier
	{
		Near = 0,
		Mid = 1,
		Far = 2,
		Dormant = 3
	}

	[CompilerGenerated]
	private sealed class _003CDieSection_003Ed__259 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBehaviour _003C_003E4__this;

		private float _003Ct_003E5__2;

		private Vector3 _003CstrtHips_003E5__3;

		private Vector3 _003CendHips_003E5__4;

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
		public _003CDieSection_003Ed__259(int _003C_003E1__state)
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
	private sealed class _003CJumpSection_003Ed__213 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBehaviour _003C_003E4__this;

		private float _003CoriginalStartSpeed_003E5__2;

		private Vector3 _003CposStart_003E5__3;

		private Vector3 _003CposEnd_003E5__4;

		private float _003Ct_003E5__5;

		private bool _003ConlyOne_003E5__6;

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
		public _003CJumpSection_003Ed__213(int _003C_003E1__state)
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
	private sealed class _003CKnockBackRator_003Ed__245 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float force;

		public EnemyBehaviour _003C_003E4__this;

		public Vector3 tdDirection;

		private Vector3 _003Cstrt_003E5__2;

		private Vector3 _003Cendpos_003E5__3;

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
		public _003CKnockBackRator_003Ed__245(int _003C_003E1__state)
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
	private sealed class _003CPlayerDamageOverTimeRoutine_003Ed__151 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBehaviour _003C_003E4__this;

		public float damagePerTick;

		public float tickInterval;

		public float duration;

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
		public _003CPlayerDamageOverTimeRoutine_003Ed__151(int _003C_003E1__state)
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
	private sealed class _003CStunRator_003Ed__181 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBehaviour _003C_003E4__this;

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
		public _003CStunRator_003Ed__181(int _003C_003E1__state)
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
	private static Action<EnemyBehaviour> m_AnyEnemyDied;

	[Header("Chest Key Drop")]
	[SerializeField]
	[Range(0f, 100f)]
	private float chestKeyCarrierChance;

	[SerializeField]
	private ChestTypes carriedChestType;

	[SerializeField]
	private GameObject chestKeyCarrier;

	[SerializeField]
	private GameObject chestKeyCarrierVisual;

	[SerializeField]
	private GameObject chestKeyCarrierVisualEpic;

	[SerializeField]
	private GameObject collectibleChestKeyCarrierVisual;

	[SerializeField]
	private GameObject shopGemCarrierVisualEpic;

	[SerializeField]
	private GameObject talentGemCarrierVisualEpic;

	[SerializeField]
	private GameObject petGemCarrierVisualEpic;

	[SerializeField]
	private GameObject eventCurrencyCarrierVisual;

	[SerializeField]
	private GameObject ringGemCarrierVisual;

	private GameManager gm;

	private InGameUI ui;

	private bool isCheckedTalentEarning;

	private float _multiplierTalentGold;

	private float _multiplierItemGold;

	private float _multiplierTalentExp;

	private EnemyHPControl enemyHPControl;

	private EnemyEffectHolder enemyEffectHolder;

	private PoolControl enemyPool;

	private EnemyItemController extraItems;

	private PlayerStatController psc;

	private IHPControl playerHpControl;

	private EnemyCombatUnitAdapter combatUnitAdapter;

	protected float _damage;

	protected float _rate;

	protected float _range;

	private bool isStopped;

	[SerializeField]
	private float playerCheckInterval;

	[SerializeField]
	private float groundCheckInterval;

	[SerializeField]
	protected float frontCheckInterval;

	[Header("AI Update LOD")]
	[SerializeField]
	private float midRangeDistance;

	[SerializeField]
	private float farRangeDistance;

	[SerializeField]
	private float dormantRangeDistance;

	[SerializeField]
	private float midRangeIntervalMultiplier;

	[SerializeField]
	private float farRangeIntervalMultiplier;

	[SerializeField]
	private float dormantRangeIntervalMultiplier;

	private float _playerCheckCd;

	private float _groundCheckCd;

	private float _frontCheckCd;

	private EnemyUpdateTier _currentUpdateTier;

	[Header("Movement Speed States")]
	[SerializeField]
	private float preRingMoveSpeedScale;

	[SerializeField]
	private float preRingAnimatorMoveSpeedScale;

	[SerializeField]
	private float inRingAnimatorMoveSpeedScale;

	[SerializeField]
	private float approachMoveSpeedScale;

	[SerializeField]
	private float combatMoveSpeedScale;

	[SerializeField]
	private float jumpAnimationSpeedScale;

	private static int moveHash;

	private static int onRingHash;

	private static int deathHash;

	private static int deathResetHash;

	private static int attackHash;

	private static int speedHash;

	private static int hitHash;

	private static int hitStartHash;

	private static int hitEndHash;

	public enemyType typeEnemy;

	private CarriedRewardType carriedRewardType;

	[Header("Movement - Settings")]
	[Tooltip("Percentage by which movement and attack speed are reduced while frozen.")]
	[Range(0f, 100f)]
	public float freezeSlowdownPercent;

	private float _startSpeed;

	private float _startSpeedwRange;

	private float _extraSpeed;

	private float slowSettings;

	private bool stunActive;

	private bool freezeActive;

	private bool _isFirstStunDetected;

	private Coroutine corStun;

	public Animator anim;

	public float speedMultiplier;

	public Transform shadowTransform;

	private Vector3 _desiredVelocity;

	private bool _isWalking;

	[Header("Player - Ground - FrontEnemy Check")]
	public float senseCheckPlayer;

	public LayerMask maskPlayer;

	public LayerMask maskGround;

	public LayerMask maskEnemy;

	public LayerMask maskFrontBorder;

	private Collider[] colPlayer;

	private bool _isTherePlayerEnemyCanAttack;

	private float _playerCheckTimer;

	private bool _isTherePlayer;

	[SerializeField]
	private bool _onGround;

	private float _groundcheckTimer;

	protected bool _jumpTriggered;

	private readonly Collider[] colsRing;

	[Header("ClimbSettings")]
	public AnimationCurve xPosCurve;

	public AnimationCurve yPosCurve;

	public AnimationCurve zPosCurve;

	public AnimationCurve curvePosSpeed;

	private bool _isJumping;

	[Header("Attack settings")]
	public float attackFrequance;

	private float _attackFrequance;

	private Collider[] _attackCols;

	private bool _isKnockBackActive;

	[SerializeField]
	private float knockbackFailSafeDuration;

	private float _knockbackFailSafeTimer;

	public Transform takeDamagePos;

	[SerializeField]
	protected Transform bouncingTarget;

	private bool isUnderVoidEffect;

	private float _timerIsUnderVoidEffect;

	private float _savedLastKnockbackForce;

	private Coroutine knockbackC;

	private RaycastHit[] allRcs;

	private bool _isPulling;

	private float pullTime;

	private const float DeathLaunchMultiplier = 0.7f;

	private bool _isDead;

	private bool _isDespawningOrRemoved;

	protected GameManager GameManagerRef => null;

	protected InGameUI InGameUIRef => null;

	protected EnemyHPControl EnemyHpControl => null;

	protected EnemyEffectHolder EnemyEffectHolderRef => null;

	protected PlayerStatController PlayerStats => null;

	protected EnemyItemController EnemyItems => null;

	protected float DamageValue => 0f;

	protected bool IsDead => false;

	protected bool IsStopped => false;

	protected bool IsPlayerInStoppingRange => false;

	protected bool IsPlayerInAttackRange => false;

	protected bool IsKnockbackActive => false;

	public virtual bool IsBossEnemy => false;

	protected float CurrentMoveSpeed => 0f;

	protected Transform PlayerTransform => null;

	protected float PlayerRange => 0f;

	private float CharSpeed => 0f;

	public static event Action<EnemyBehaviour> AnyEnemyDied
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

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnAwakeInternal()
	{
	}

	protected virtual void OnStartInternal()
	{
	}

	protected virtual void OnEnemyStarted(float hp, float damage, bool isSkillTestScene)
	{
	}

	protected virtual void OnEnemyRespawned()
	{
	}

	protected virtual void OnBeforeAttack()
	{
	}

	protected virtual void OnAfterAttackCompleted()
	{
	}

	protected virtual void OnBeforeDie()
	{
	}

	protected virtual void OnAfterDie()
	{
	}

	protected virtual bool ShouldRunDefaultDeathDrops()
	{
		return false;
	}

	protected void DropDefaultDeathRewards()
	{
	}

	protected virtual void NotifyDeathToOwner()
	{
	}

	public bool IsElitEnemy()
	{
		return false;
	}

	private bool EnsureCombatReferences()
	{
		return false;
	}

	private void StartEnemyCommonInit()
	{
	}

	private void CheckEnemyCommon()
	{
	}

	private EnemyCombatUnitAdapter EnsureCombatUnitAdapter()
	{
		return null;
	}

	public virtual void StartEnemy(float hp, float damage)
	{
	}

	public void StartEnemyForSkillTestScene(float hp, float damage, bool isMove)
	{
	}

	private void RespawnSettings()
	{
	}

	private void RollChestKeyCarrierState()
	{
	}

	private bool ShouldRollCarriedChestKey(GameManager gameManager)
	{
		return false;
	}

	private float GetCarriedChestKeyDropChance(GameManager gameManager)
	{
		return 0f;
	}

	private bool TryRollCollectibleChestKeyCarrier()
	{
		return false;
	}

	private void RollGemCarrierState()
	{
	}

	private bool ShouldDisableCarriedRewards()
	{
		return false;
	}

	private void RefreshCarrierVisuals()
	{
	}

	private bool IsEpicChestType(ChestTypes chestType)
	{
		return false;
	}

	private void DropCarriedChestKey()
	{
	}

	private void DropCarriedCollectibleChestKey()
	{
	}

	private void DropCarriedGem()
	{
	}

	private void SyncChestKeyCarrierStateWithRunQuota()
	{
	}

	private void DelaySpeed()
	{
	}

	public void CheckGameStop()
	{
	}

	public void Tick()
	{
	}

	private void UpdateEnemyUpdateTier()
	{
	}

	private float GetIntervalForCurrentTier(float baseInterval)
	{
		return 0f;
	}

	protected virtual float GetFrontBorderCheckInterval()
	{
		return 0f;
	}

	protected virtual float GetConfiguredHp(float baseHp)
	{
		return 0f;
	}

	protected virtual float GetDeathRewardCoinMultiplier()
	{
		return 0f;
	}

	protected virtual float GetConfiguredDamage(float baseDamage)
	{
		return 0f;
	}

	protected virtual float GetConfiguredAttackRange()
	{
		return 0f;
	}

	protected virtual float GetConfiguredAttackRate()
	{
		return 0f;
	}

	protected virtual float GetConfiguredStartSpeed()
	{
		return 0f;
	}

	protected virtual float GetRandomizedSpeedMultiplier()
	{
		return 0f;
	}

	protected virtual float GetSpawnScaleMultiplier()
	{
		return 0f;
	}

	protected virtual float GetPreferredCombatDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected virtual float GetAttackDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected virtual float GetPreRingMoveSpeedScale(float playerRangeValue)
	{
		return 0f;
	}

	protected virtual float GetApproachMoveSpeedScale(float distanceToPlayer, float playerRangeValue)
	{
		return 0f;
	}

	protected virtual float GetCombatMoveSpeedScale(float playerRangeValue)
	{
		return 0f;
	}

	protected virtual float GetJumpAnimationSpeedScale()
	{
		return 0f;
	}

	protected virtual float GetMoveSpeedScaleForDistance(float distanceToPlayer, float playerRangeValue)
	{
		return 0f;
	}

	protected virtual bool ShouldAttackPlayer(float distanceToPlayer, float playerRangeValue)
	{
		return false;
	}

	protected virtual bool CanUseDefaultMovement()
	{
		return false;
	}

	protected virtual bool CanUseDefaultAttack()
	{
		return false;
	}

	protected virtual bool TryGetCustomMoveDirection(out Vector3 direction)
	{
		direction = default;
		return false;
	}

	protected virtual Vector3 GetLookDirection()
	{
		return default;
	}

	protected virtual float GetDamageToPlayer()
	{
		return 0f;
	}

	protected void DealDamageToPlayer(float damage)
	{
	}

	protected void DealDamageToPlayerInRadius(float damage, float radius)
	{
	}

	private void DealDamageToCachedPlayerHp(int hitCount, float damage)
	{
	}

	protected void SpawnCoins(float amount, Vector3 position)
	{
	}

	protected Coroutine ApplyDamageOverTimeToPlayer(float damagePerTick, float duration, float tickInterval)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayerDamageOverTimeRoutine_003Ed__151))]
	private IEnumerator PlayerDamageOverTimeRoutine(float damagePerTick, float duration, float tickInterval)
	{
		return null;
	}

	private float GetBaseSpeedMultiplier()
	{
		return 0f;
	}

	private float GetAnimationSpeedMultiplier()
	{
		return 0f;
	}

	private void SetAnimSpeed()
	{
	}

	private void UpdateAnimatorPlaybackSpeed()
	{
	}

	public void Freeze(bool slowStarted)
	{
	}

	private float GetFreezeSpeedMultiplier()
	{
		return 0f;
	}

	public void StunActive()
	{
	}

	[IteratorStateMachine(typeof(_003CStunRator_003Ed__181))]
	private IEnumerator StunRator()
	{
		return null;
	}

	private void StopMoving()
	{
	}

	private void MovementHandler()
	{
	}

	private void MovementUpdate()
	{
	}

	protected void SetWalking(bool walking)
	{
	}

	private void UpdatePlayerProximityState()
	{
	}

	private void UpdateAttackTimer()
	{
	}

	private void CheckGround(float elapsedInterval)
	{
	}

	protected virtual void CheckFrontRingBorder()
	{
	}

	[IteratorStateMachine(typeof(_003CJumpSection_003Ed__213))]
	protected virtual IEnumerator JumpSection()
	{
		return null;
	}

	private void AttackingTimer(ref float timer, Action feedback)
	{
	}

	protected virtual void Attack()
	{
	}

	public virtual void AttackCompleted()
	{
	}

	public bool IsLifeStealActive(float value)
	{
		return false;
	}

	public bool IsUnderBurnEffect()
	{
		return false;
	}

	public bool IsUnderFreezEffect()
	{
		return false;
	}

	public bool IsUnderLightningEffect()
	{
		return false;
	}

	public Transform GetTDPos()
	{
		return null;
	}

	public virtual int GetMaxHitsPerCast(SkillType skillType)
	{
		return 0;
	}

	public virtual Transform GetSkillTargetPoint(SkillType skillType)
	{
		return null;
	}

	public virtual void TakeDamage(float damage, bool isCrit, EffectTypeDuration typeEffect)
	{
	}

	protected void RegisterElementQuestProgress(EffectType effectType)
	{
	}

	public void TakeDamageOnlyEffect(EffectTypeDuration typeEffect)
	{
	}

	public virtual void TakeDamage(float damage, bool isCrit, bool playregularhit = false)
	{
	}

	public void VoidEffect()
	{
	}

	private void CheckVoidEscape()
	{
	}

	protected virtual void CheckOutOfArenaFailSafe()
	{
	}

	public virtual void AddForce(Vector3 tdDirection, float force)
	{
	}

	[IteratorStateMachine(typeof(_003CKnockBackRator_003Ed__245))]
	private IEnumerator KnockBackRator(Vector3 tdDirection, float force)
	{
		return null;
	}

	private void CheckKnockbackRecoveryFailSafe()
	{
	}

	private void RecoverFromKnockback()
	{
	}

	public virtual void TakeDamage(Vector3 directionKnockback, float damage)
	{
	}

	public void SetDebugColor(bool isYellow)
	{
	}

	public virtual void Die()
	{
	}

	protected void MarkAsDespawningOrRemoved()
	{
	}

	public bool IsAlive()
	{
		return false;
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDieSection_003Ed__259))]
	protected virtual IEnumerator DieSection(float regularForce = 8f)
	{
		return null;
	}

	protected virtual void OnDisable()
	{
	}

	public void DeactivateEffect(EffectType type)
	{
	}
}
