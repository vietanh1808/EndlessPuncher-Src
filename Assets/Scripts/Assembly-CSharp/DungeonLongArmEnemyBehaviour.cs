using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DungeonLongArmEnemyBehaviour : EnemyBehaviour
{
	[Serializable]
	public class AttackArmConf
	{
		public Vector3 targetPosa;

		public PlayerArm arm;

		public bool isAttackActive;

		public Func<float, float>? xFunc;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public float f;

		public float yDiff;

		internal float _003CSetTargetEnum_003Eb__0(float x)
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAttackArmsRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonLongArmEnemyBehaviour _003C_003E4__this;

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
		public _003CAttackArmsRoutine_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CDieSection_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonLongArmEnemyBehaviour _003C_003E4__this;

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

	[CompilerGenerated]
	private sealed class _003CSetTargetEnum_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackArmConf arc;

		public DungeonLongArmEnemyBehaviour _003C_003E4__this;

		private _003C_003Ec__DisplayClass43_0 _003C_003E8__1;

		public Transform targetPosition;

		private PlayerArm _003CselectedArm_003E5__2;

		private float _003CfastSpeed_003E5__3;

		private Vector3 _003CstartPos_003E5__4;

		private float _003Ct_003E5__5;

		private float _003CarmScaleTime_003E5__6;

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
		public _003CSetTargetEnum_003Ed__43(int _003C_003E1__state)
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

	private static readonly int[] DeathAnimHashes;

	private static readonly int deathAnimHash1;

	private static readonly int deathAnimHash3;

	private static readonly int attackHash;

	private static readonly int hitHash;

	[SerializeField]
	private bool facePlayerWhileIdle;

	[SerializeField]
	private float idleTurnSpeed;

	[SerializeField]
	private float deathAnimationDelay;

	[SerializeField]
	private float deathAnimationDuration;

	public List<AttackArmConf> allAttackArmConfs;

	private Coroutine attackRoutine;

	private bool notifyDungeonSuccessOnAfterDie;

	private static readonly int attackSpeedHash;

	private static readonly int isLeftHash;

	private int _handCounter;

	private int _countAllAttackArm;

	private int _attackCounter;

	[SerializeField]
	private float punchAnimDelay;

	public AnimationCurve targetMoveCurve;

	private int BoneCount => 0;

	protected override void OnStartInternal()
	{
	}

	private void LateUpdate()
	{
	}

	protected override void Update()
	{
	}

	protected override bool CanUseDefaultMovement()
	{
		return false;
	}

	protected override void CheckFrontRingBorder()
	{
	}

	protected override float GetPreRingMoveSpeedScale(float playerRangeValue)
	{
		return 0f;
	}

	protected override float GetApproachMoveSpeedScale(float distanceToPlayer, float playerRangeValue)
	{
		return 0f;
	}

	protected override float GetCombatMoveSpeedScale(float playerRangeValue)
	{
		return 0f;
	}

	protected override bool CanUseDefaultAttack()
	{
		return false;
	}

	protected override bool ShouldRunDefaultDeathDrops()
	{
		return false;
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

	public override void Die()
	{
	}

	protected override void NotifyDeathToOwner()
	{
	}

	protected override void OnAfterDie()
	{
	}

	[IteratorStateMachine(typeof(_003CDieSection_003Ed__31))]
	protected override IEnumerator DieSection(float regularForce = 8f)
	{
		return null;
	}

	protected override void Attack()
	{
	}

	public override void AttackCompleted()
	{
	}

	[IteratorStateMachine(typeof(_003CAttackArmsRoutine_003Ed__41))]
	private IEnumerator AttackArmsRoutine()
	{
		return null;
	}

	protected override void OnEnemyStarted(float hp, float damage, bool isSkillTestScene)
	{
	}

	[IteratorStateMachine(typeof(_003CSetTargetEnum_003Ed__43))]
	private IEnumerator SetTargetEnum(Transform targetPosition, AttackArmConf arc)
	{
		return null;
	}

	private void SyncDungeonEnemyHp(bool forceZero = false)
	{
	}
}
