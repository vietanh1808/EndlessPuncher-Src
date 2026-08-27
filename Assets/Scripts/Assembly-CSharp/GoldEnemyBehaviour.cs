using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GoldEnemyBehaviour : EnemyBehaviour
{
	private enum RingTraversalState
	{
		Outside = 0,
		Inside = 1,
		Exited = 2
	}

	[CompilerGenerated]
	private sealed class _003CJumpSection_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CJumpSection_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CTraverseRingJump_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoldEnemyBehaviour _003C_003E4__this;

		public bool isExitJump;

		private Vector3 _003CposStart_003E5__2;

		private Vector3 _003CposEnd_003E5__3;

		private float _003Ct_003E5__4;

		private bool _003CshadowShown_003E5__5;

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
		public _003CTraverseRingJump_003Ed__32(int _003C_003E1__state)
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
	private float moveSpeedMultiplier;

	[SerializeField]
	private float hitCoinAmount;

	[SerializeField]
	private float deathCoinAmount;

	[SerializeField]
	private float fallbackPassDistance;

	[SerializeField]
	private float exitDistance;

	[SerializeField]
	private float borderCheckDistance;

	[SerializeField]
	private float enterJumpForwardDistance;

	[SerializeField]
	private float exitJumpForwardDistance;

	[SerializeField]
	private float jumpHeight;

	[SerializeField]
	private float jumpDurationMultiplier;

	[SerializeField]
	private float borderCheckDelayAfterEnter;

	private Vector3 moveDirection;

	private readonly Collider[] traversalRingCols;

	private RingTraversalState traversalState;

	private bool traversalActive;

	private bool escapedWithoutReward;

	private float nextBorderCheckTime;

	public AnimationCurve yPosCurvereverse;

	protected override void OnEnemyStarted(float hp, float damage, bool isSkillTestScene)
	{
	}

	protected override void OnEnemyRespawned()
	{
	}

	protected override float GetConfiguredStartSpeed()
	{
		return 0f;
	}

	protected override float GetDeathRewardCoinMultiplier()
	{
		return 0f;
	}

	protected override bool ShouldAttackPlayer(float distanceToPlayer, float playerRangeValue)
	{
		return false;
	}

	private void UpdateMoveDirection()
	{
	}

	protected override bool TryGetCustomMoveDirection(out Vector3 direction)
	{
		direction = default;
		return false;
	}

	private void EscapeDespawn()
	{
	}

	protected override Vector3 GetLookDirection()
	{
		return default;
	}

	protected override bool CanUseDefaultAttack()
	{
		return false;
	}

	protected override float GetFrontBorderCheckInterval()
	{
		return 0f;
	}

	protected override void CheckFrontRingBorder()
	{
	}

	[IteratorStateMachine(typeof(_003CJumpSection_003Ed__30))]
	protected override IEnumerator JumpSection()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTraverseRingJump_003Ed__32))]
	private IEnumerator TraverseRingJump(bool isExitJump)
	{
		return null;
	}

	public override void TakeDamage(float damage, bool isCrit, EffectTypeDuration typeEffect)
	{
	}

	public override void TakeDamage(float damage, bool isCrit, bool playregularhit = false)
	{
	}

	public override void AddForce(Vector3 tdDirection, float force)
	{
	}

	protected override void OnBeforeDie()
	{
	}

	protected override void OnAfterAttackCompleted()
	{
	}
}
