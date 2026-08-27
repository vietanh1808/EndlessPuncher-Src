using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DamageBufferEnemyBehaviour : EnemyBehaviour, IEnemyDamageModifierProvider
{
	[CompilerGenerated]
	private sealed class _003CJumpSection_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DamageBufferEnemyBehaviour _003C_003E4__this;

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
		public _003CJumpSection_003Ed__16(int _003C_003E1__state)
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

	private const float AuraScaleMultiplier = 1.5f;

	[SerializeField]
	private float auraRadius;

	[SerializeField]
	private float damageMultiplier;

	[SerializeField]
	private float stopRangeRatio;

	[SerializeField]
	private float moveSpeedMultiplier;

	[SerializeField]
	private ParticleSystem zoneParticle;

	private Vector3 zoneParticleBaseScale;

	private bool zoneParticleScaleCached;

	protected override void OnAwakeInternal()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnEnemyRespawned()
	{
	}

	protected override void OnBeforeDie()
	{
	}

	protected override float GetPreferredCombatDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected override float GetConfiguredStartSpeed()
	{
		return 0f;
	}

	protected override bool CanUseDefaultAttack()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CJumpSection_003Ed__16))]
	protected override IEnumerator JumpSection()
	{
		return null;
	}

	public float GetOutgoingDamageMultiplier(EnemyBehaviour sourceEnemy)
	{
		return 0f;
	}

	private void StartZoneParticle()
	{
	}

	private void StopZoneParticle()
	{
	}

	private void CacheZoneParticleScale()
	{
	}
}
