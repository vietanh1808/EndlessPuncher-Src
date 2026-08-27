using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LaserEnemyBehaviour : EnemyBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayLaserDamageRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LaserEnemyBehaviour _003C_003E4__this;

		private int _003CtickCount_003E5__2;

		private float _003CtickDelay_003E5__3;

		private float _003CtickDamage_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CPlayLaserDamageRoutine_003Ed__17(int _003C_003E1__state)
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

	private static readonly int[] LaserTriggerHashes;

	[SerializeField]
	private float playerRangeRatio;

	[SerializeField]
	private float minimumDistance;

	[SerializeField]
	private float laserDamageMultiplier;

	[SerializeField]
	private float laserDuration;

	[SerializeField]
	private int laserTickCount;

	[SerializeField]
	private Transform rightHandTransform;

	[SerializeField]
	private ParticleSystem laserObject;

	private Coroutine laserRoutine;

	protected override float GetPreferredCombatDistance(float playerRangeValue)
	{
		return 0f;
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

	protected override void OnBeforeDie()
	{
	}

	protected override void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayLaserDamageRoutine_003Ed__17))]
	private IEnumerator PlayLaserDamageRoutine()
	{
		return null;
	}

	private void StopLaserRoutine()
	{
	}
}
