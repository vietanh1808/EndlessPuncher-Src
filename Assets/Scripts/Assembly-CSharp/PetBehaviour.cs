using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PetBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttackFinishRoutine_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PetBehaviour _003C_003E4__this;

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
		public _003CAttackFinishRoutine_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CDeathFinishFallbackRoutine_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PetBehaviour _003C_003E4__this;

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
		public _003CDeathFinishFallbackRoutine_003Ed__49(int _003C_003E1__state)
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
	private PetProjectilePool projectilePool;

	[SerializeField]
	private GameObject projectilePrefab;

	[SerializeField]
	private Transform projectileSpawnPoint;

	[SerializeField]
	private Transform petVisualParent;

	[SerializeField]
	private LayerMask enemyMask;

	[Header("Defaults")]
	[SerializeField]
	private float defaultRate;

	[SerializeField]
	private float defaultDamage;

	[SerializeField]
	private float firstAttackRate;

	[SerializeField]
	private float attackRange;

	[SerializeField]
	private float rotationLerpSpeed;

	[SerializeField]
	private float preAimLeadTime;

	[SerializeField]
	private float deathDisableFallbackDelay;

	private readonly Collider[] enemyBuffer;

	private float rate;

	private float damage;

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

	private Vector3 projectileSize;

	public void StartPet(float rate, float damage)
	{
	}

	public void SetProjectilePrefab(GameObject petProjectilePrefab)
	{
	}

	public void SetPetVisual(GameObject petVisualPrefab)
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

	public void Die()
	{
	}

	public void ResetForNewRun()
	{
	}

	private void QueueAttack(Transform target)
	{
	}

	private void FirePendingProjectile()
	{
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

	private Transform FindTarget()
	{
		return null;
	}

	private LayerMask ResolveEnemyMask()
	{
		return default;
	}

	private void ScheduleAttackFinish()
	{
	}

	[IteratorStateMachine(typeof(_003CAttackFinishRoutine_003Ed__47))]
	private IEnumerator AttackFinishRoutine()
	{
		return null;
	}

	private void ResetAnimatorDeathState()
	{
	}

	[IteratorStateMachine(typeof(_003CDeathFinishFallbackRoutine_003Ed__49))]
	private IEnumerator DeathFinishFallbackRoutine()
	{
		return null;
	}
}
