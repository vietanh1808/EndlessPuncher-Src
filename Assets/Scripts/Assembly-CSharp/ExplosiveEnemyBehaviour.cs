using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExplosiveEnemyBehaviour : EnemyBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDieSection_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExplosiveEnemyBehaviour _003C_003E4__this;

		public float regularForce;

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
		public _003CDieSection_003Ed__31(int _003C_003E1__state)
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
	private float explodeDistance;

	[SerializeField]
	private float explosionRadius;

	[SerializeField]
	[Range(0f, 1f)]
	private float explosionHealthDamageRatio;

	[SerializeField]
	private float explosionShakeDuration;

	[SerializeField]
	private float explosionShakePower;

	[SerializeField]
	private Transform explosionParticleTarget;

	[SerializeField]
	private ParticleSystem torchParticle;

	[SerializeField]
	private string explodeTrigger;

	[Header("Neck Bounce")]
	[SerializeField]
	private Transform neckBone;

	[SerializeField]
	private float neckBounceInterval;

	[SerializeField]
	private float neckBounceDuration;

	[SerializeField]
	private float neckBounceScaleMultiplier;

	[SerializeField]
	private float neckBounceSpeedMultiplier;

	private Renderer[] cachedRenderers;

	private readonly Collider[] explosionEnemyHits;

	private readonly HashSet<IEnemy> damagedEnemies;

	private Vector3 neckInitialScale;

	private float neckBounceTimer;

	private bool neckScaleCached;

	protected override void Awake()
	{
	}

	protected override void Update()
	{
	}

	protected override float GetPreferredCombatDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected override float GetAttackDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected override bool CanUseDefaultAttack()
	{
		return false;
	}

	protected override void OnEnemyStarted(float hp, float damage, bool isSkillTestScene)
	{
	}

	protected override void OnEnemyRespawned()
	{
	}

	protected override void OnBeforeDie()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void Attack()
	{
	}

	protected virtual void Explode()
	{
	}

	protected virtual void PlayDeathExplosionFx()
	{
	}

	[IteratorStateMachine(typeof(_003CDieSection_003Ed__31))]
	protected override IEnumerator DieSection(float regularForce = 8f)
	{
		return null;
	}

	private void SetModelVisible(bool isVisible)
	{
	}

	private void StartTorchParticle()
	{
	}

	private void StopTorchParticle()
	{
	}

	private void DealDamageToPlayerByHealthPercentageInRadius(float radius)
	{
	}

	private void DealDamageToNearbyEnemiesByHealthPercentage(float radius)
	{
	}

	private void TickNeckBounce()
	{
	}

	private bool CacheNeckBone()
	{
		return false;
	}

	private void ResetNeckBounceState()
	{
	}

	private void ResetNeckTransform()
	{
	}
}
