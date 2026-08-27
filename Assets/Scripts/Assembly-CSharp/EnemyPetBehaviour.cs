using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyPetBehaviour : MonoBehaviour, IEnemy, IEnemyHealth
{
	[CompilerGenerated]
	private sealed class _003CAttackFinishRoutine_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyPetBehaviour _003C_003E4__this;

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
		public _003CAttackFinishRoutine_003Ed__75(int _003C_003E1__state)
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
	private sealed class _003CDeathFinishFallbackRoutine_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyPetBehaviour _003C_003E4__this;

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
		public _003CDeathFinishFallbackRoutine_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CDeathSinkRoutine_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyPetBehaviour _003C_003E4__this;

		private Vector3 _003CstartPosition_003E5__2;

		private Vector3 _003CtargetPosition_003E5__3;

		private float _003Cduration_003E5__4;

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
		public _003CDeathSinkRoutine_003Ed__79(int _003C_003E1__state)
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

	private static readonly int AttackHash;

	private static readonly int DeathHash;

	[Header("Setup")]
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private GameObject projectilePrefab;

	[SerializeField]
	private Transform projectileSpawnPoint;

	[SerializeField]
	private Transform petVisualParent;

	[SerializeField]
	private LayerMask playerMask;

	[Header("Defaults")]
	[SerializeField]
	private float defaultRate;

	[SerializeField]
	private float defaultDamage;

	[SerializeField]
	private float defaultHp;

	[SerializeField]
	private float firstAttackRate;

	[SerializeField]
	private float attackRange;

	[SerializeField]
	private float rotationLerpSpeed;

	[SerializeField]
	private float preAimLeadTime;

	[SerializeField]
	private float fallbackColliderRadius;

	[SerializeField]
	private float deathFinishFallbackDelay;

	[SerializeField]
	private float deathSinkDistance;

	[SerializeField]
	private float deathSinkDuration;

	private float rate;

	private float damage;

	private float maxHp;

	private float currentHp;

	private float attackTimer;

	private bool isAttackAnimating;

	private bool isDead;

	private Transform pendingAttackTarget;

	private Vector3 pendingAttackDirection;

	private GameObject currentPetVisual;

	private Coroutine attackFinishRoutine;

	private Coroutine deathFinishRoutine;

	private Quaternion desiredRotation;

	private bool hasDesiredRotation;

	private bool isFirstAttackPending;

	private bool isDeathSinking;

	private Vector3 projectileSize;

	public int MaxHp => 0;

	public float CurrentHp => 0f;

	public void Configure(Skill skill, float hp, float attackDamage, float attackRate)
	{
	}

	public void SetProjectilePrefab(GameObject petProjectilePrefab)
	{
	}

	public void SetPetVisual(GameObject petVisualPrefab)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void HandleAttackShootEvent()
	{
	}

	public void HandleDeathFinishedEvent()
	{
	}

	public void AttackCompleted()
	{
	}

	public void StartEnemy(float hpValue, float damageValue)
	{
	}

	public void StartEnemyForSkillTestScene(float hpValue, float damageValue, bool isCanMove)
	{
	}

	public void TakeDamage(float damageValue, bool isCrit, EffectTypeDuration type)
	{
	}

	public void TakeDamageOnlyEffect(EffectTypeDuration type)
	{
	}

	public void TakeDamage(float damageValue, bool isCrit, bool isOnlyTDHit = false)
	{
	}

	public void TakeDamage(Vector3 directionKnockback, float damageValue)
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

	public bool IsLastHit(float value)
	{
		return false;
	}

	public GameObject GetGameObject()
	{
		return null;
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

	public bool IsElitEnemy()
	{
		return false;
	}

	public void TakeDamageFromEffect(float damageValue)
	{
	}

	public void SetIceEffectActive(bool isActive)
	{
	}

	private void QueueAttack(Transform target)
	{
	}

	private void FirePendingProjectile()
	{
	}

	private Transform FindTarget()
	{
		return null;
	}

	private void UpdateLookRotation(Transform target)
	{
	}

	private void SetDesiredRotation(Vector3 direction)
	{
	}

	private void RotateTowardsDesiredRotation()
	{
	}

	private LayerMask ResolvePlayerMask()
	{
		return default;
	}

	private void ScheduleAttackFinish()
	{
	}

	[IteratorStateMachine(typeof(_003CAttackFinishRoutine_003Ed__75))]
	private IEnumerator AttackFinishRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDeathFinishFallbackRoutine_003Ed__76))]
	private IEnumerator DeathFinishFallbackRoutine()
	{
		return null;
	}

	private void StartDeathSink()
	{
	}

	private void ResetAnimatorDeathState()
	{
	}

	[IteratorStateMachine(typeof(_003CDeathSinkRoutine_003Ed__79))]
	private IEnumerator DeathSinkRoutine()
	{
		return null;
	}

	private float ResolveSkillStat(Skill skill, string statName, float fallback)
	{
		return 0f;
	}

	private void EnsureEnemyLayer()
	{
	}

	private void SetLayerRecursively(GameObject target, int layer)
	{
	}

	private void EnsureTargetCollider()
	{
	}
}
