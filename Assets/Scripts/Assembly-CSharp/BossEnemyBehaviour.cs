using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BossEnemyBehaviour : EnemyBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBossJumpSection_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossEnemyBehaviour _003C_003E4__this;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

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
		public _003CBossJumpSection_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CDieSection_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossEnemyBehaviour _003C_003E4__this;

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
		public _003CDieSection_003Ed__33(int _003C_003E1__state)
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

	private const float DeathLaunchMultiplier = 0.7f;

	[SerializeField]
	private string[] bossAttackTriggers;

	[SerializeField]
	private ParticleSystem[] bossAttackParticles;

	[SerializeField]
	private float introDelay;

	[SerializeField]
	private float bossMoveSpeed;

	[SerializeField]
	private float senseRangeOffset;

	[SerializeField]
	private float frontBorderCheckDistance;

	[SerializeField]
	private Rigidbody[] ragdolls;

	[SerializeField]
	private Rigidbody hips;

	[SerializeField]
	private float ragdollHorizontalVelocity;

	[SerializeField]
	private float ragdollVerticalVelocity;

	[SerializeField]
	private float ragdollTorqueVelocity;

	private Vector3 bossDeathImpactDirection;

	private int bossPunchNumber;

	public override bool IsBossEnemy => false;

	protected virtual bool UseBossHpControl => false;

	protected override bool ShouldRunDefaultDeathDrops()
	{
		return false;
	}

	protected override void OnStartInternal()
	{
	}

	protected override void OnEnemyRespawned()
	{
	}

	protected override float GetConfiguredStartSpeed()
	{
		return 0f;
	}

	public override void StartEnemy(float hp, float damage)
	{
	}

	private void BossCome()
	{
	}

	protected override void CheckFrontRingBorder()
	{
	}

	[IteratorStateMachine(typeof(_003CBossJumpSection_003Ed__25))]
	private IEnumerator BossJumpSection()
	{
		return null;
	}

	protected override void Attack()
	{
	}

	public override void AttackCompleted()
	{
	}

	public override void TakeDamage(float damage, bool isCrit, EffectTypeDuration typeEffect)
	{
	}

	public override void TakeDamage(float damage, bool isCrit, bool playregularhit = false)
	{
	}

	public override void TakeDamage(Vector3 directionKnockback, float damage)
	{
	}

	public override void AddForce(Vector3 tdDirection, float force)
	{
	}

	public override void Die()
	{
	}

	[IteratorStateMachine(typeof(_003CDieSection_003Ed__33))]
	protected override IEnumerator DieSection(float regularForce = 8f)
	{
		return null;
	}

	protected override void CheckOutOfArenaFailSafe()
	{
	}

	private void ActivateBossRagdoll()
	{
	}
}
