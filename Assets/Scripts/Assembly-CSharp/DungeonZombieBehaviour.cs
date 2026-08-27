using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DungeonZombieBehaviour : MonoBehaviour, IEnemy, IStatusEffectTarget
{
	[CompilerGenerated]
	private sealed class _003CDespawnRoutine_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonZombieBehaviour _003C_003E4__this;

		private Vector3 _003CstartPosition_003E5__2;

		private Vector3 _003CtargetPosition_003E5__3;

		private float _003Cduration_003E5__4;

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
		public _003CDespawnRoutine_003Ed__86(int _003C_003E1__state)
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
	private sealed class _003CKnockbackRoutine_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonZombieBehaviour _003C_003E4__this;

		public Vector3 direction;

		public float force;

		private Vector3 _003CstartPosition_003E5__2;

		private Vector3 _003CendPosition_003E5__3;

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
		public _003CKnockbackRoutine_003Ed__83(int _003C_003E1__state)
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
	private sealed class _003CStartEnemyRoutine_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonZombieBehaviour _003C_003E4__this;

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
		public _003CStartEnemyRoutine_003Ed__87(int _003C_003E1__state)
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
	private sealed class _003CStunRoutine_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonZombieBehaviour _003C_003E4__this;

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
		public _003CStunRoutine_003Ed__82(int _003C_003E1__state)
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

	[Header("References")]
	[SerializeField]
	private ZombieHPControl zombieHpControl;

	[SerializeField]
	private EnemyEffectHolder enemyEffectHolder;

	[SerializeField]
	private Transform takeDamagePos;

	[SerializeField]
	private GameObject visualsRoot;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private GameObject[] modelVariants;

	[Header("Movement")]
	[SerializeField]
	private float moveSpeed;

	[Tooltip("Percentage by which movement and attack speed are reduced while frozen.")]
	[Range(0f, 100f)]
	public float freezeSlowdownPercent;

	[SerializeField]
	private float stopDistance;

	[SerializeField]
	private float turnSpeed;

	[SerializeField]
	private Vector2 startDelayRange;

	[SerializeField]
	private float knockbackMoveSpeed;

	[SerializeField]
	private float knockbackFailSafeDuration;

	[Header("Attack")]
	[SerializeField]
	private float attackRange;

	[SerializeField]
	private float attackCooldown;

	[SerializeField]
	private float attackDamageMultiplier;

	[SerializeField]
	private LayerMask maskPlayer;

	[Header("Death")]
	[SerializeField]
	private float destroyDelay;

	[SerializeField]
	private bool disableColliderOnDeath;

	[SerializeField]
	private float sinkStartDelay;

	[SerializeField]
	private float sinkDistance;

	[SerializeField]
	private float sinkDuration;

	private static readonly int IsRunningHash;

	private static readonly int AttackHash;

	private static readonly int HitHash;

	private static readonly int DeathHash;

	private Collider[] cachedColliders;

	private PoolControl poolControl;

	private Coroutine despawnRoutine;

	private PlayerStatController playerStats;

	private InGameUI gameUI;

	private float damageValue;

	private float attackTimer;

	private float knockbackFailSafeTimer;

	private bool isDead;

	private bool isKnockbackActive;

	private bool canAct;

	private bool freezeActive;

	private bool stunActive;

	private bool isUnderVoidEffect;

	private float voidEffectTimer;

	private Coroutine knockbackRoutine;

	private Coroutine stunRoutine;

	private Coroutine startupRoutine;

	private readonly Collider[] attackCols;

	private int selectedModelIndex;

	private Vector3 birnPos;

	public float CurrentHp => 0f;

	public int MaxHp => 0;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void AttackCompleted()
	{
	}

	public void TakeDamage(float damage, bool isCrit, EffectTypeDuration type)
	{
	}

	public void TakeDamageOnlyEffect(EffectTypeDuration type)
	{
	}

	public void TakeDamage(float damage, bool isCrit, bool isOnlyTDHit = false)
	{
	}

	public void TakeDamage(Vector3 directionKnockback, float damage)
	{
	}

	public void AddForce(Vector3 directionKnockback, float force)
	{
	}

	public void VoidEffect()
	{
	}

	public void Die()
	{
	}

	public bool IsAlive()
	{
		return false;
	}

	public bool IsLifeStealActive(float value)
	{
		return false;
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public void StartEnemy(float hpValue, float damage)
	{
	}

	public void StartEnemyForSkillTestScene(float hpValue, float damage, bool isCanMove)
	{
	}

	public Transform GetTDPos()
	{
		return null;
	}

	public void Freeze(bool slowStarted)
	{
	}

	public void StunActive()
	{
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

	public void DeactivateEffect(EffectType type)
	{
	}

	public bool IsElitEnemy()
	{
		return false;
	}

	private void MoveTowards(Vector3 targetPosition)
	{
	}

	private float GetFreezeSpeedMultiplier()
	{
		return 0f;
	}

	private void RotateTowardsPlayer(Vector3 playerPosition)
	{
	}

	private void AttackPlayer()
	{
	}

	private void DealDamageToPlayer()
	{
	}

	private void SetRunning(bool isRunning)
	{
	}

	private bool IsDungeonStartBlocked()
	{
		return false;
	}

	private void CheckVoidEffect()
	{
	}

	[IteratorStateMachine(typeof(_003CStunRoutine_003Ed__82))]
	private IEnumerator StunRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CKnockbackRoutine_003Ed__83))]
	private IEnumerator KnockbackRoutine(Vector3 direction, float force)
	{
		return null;
	}

	private void CheckKnockbackRecoveryFailSafe()
	{
	}

	private void RecoverFromKnockback()
	{
	}

	[IteratorStateMachine(typeof(_003CDespawnRoutine_003Ed__86))]
	private IEnumerator DespawnRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartEnemyRoutine_003Ed__87))]
	private IEnumerator StartEnemyRoutine()
	{
		return null;
	}

	private void RestoreColliders()
	{
	}

	private void SelectRandomModelVariant()
	{
	}

	private void ApplySelectedModelVariant()
	{
	}
}
