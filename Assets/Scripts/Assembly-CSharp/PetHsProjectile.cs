using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PetHsProjectile : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CReturnToPoolWithDelay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PetHsProjectile _003C_003E4__this;

		public float delay;

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
		public _003CReturnToPoolWithDelay_003Ed__24(int _003C_003E1__state)
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
	private float moveSpeed;

	[SerializeField]
	private float maxLifetime;

	[SerializeField]
	private float hitRadius;

	[SerializeField]
	private ParticleSystem projectileEffect;

	[SerializeField]
	private ParticleSystem hitEffect;

	[SerializeField]
	private ParticleSystem flashEffect;

	private readonly Collider[] hitBuffer;

	private readonly RaycastHit[] castHitBuffer;

	private float damage;

	private float spawnHeight;

	private Vector3 moveDirection;

	private float lifeTimer;

	private bool isFlying;

	private bool isReturning;

	private LayerMask enemyMask;

	private PetProjectilePool pool;

	public void Launch(Vector3 spawnPosition, Vector3 direction, float projectileDamage, LayerMask mask)
	{
	}

	public void SetPool(PetProjectilePool projectilePool)
	{
	}

	private void Update()
	{
	}

	private void TryHitEnemy(Vector3 previousPosition, Vector3 nextPosition)
	{
	}

	private bool TryHitEnemyAtPosition(Vector3 position)
	{
		return false;
	}

	private bool TryDamageEnemy(Collider hit, Vector3 hitPosition)
	{
		return false;
	}

	private void PlayHitEffect(Vector3 hitPosition)
	{
	}

	private void ReturnToPool()
	{
	}

	[IteratorStateMachine(typeof(_003CReturnToPoolWithDelay_003Ed__24))]
	private IEnumerator ReturnToPoolWithDelay(float delay)
	{
		return null;
	}

	private void DeactivateObje()
	{
	}

	private void OnDisable()
	{
	}
}
