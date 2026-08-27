using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MissilePunches : SkillBehaviour
{
	[Serializable]
	public class RocketBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CScaleDown_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RocketBehaviour _003C_003E4__this;

			private float _003Ct_003E5__2;

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
			public _003CScaleDown_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CScaleUP_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RocketBehaviour _003C_003E4__this;

			private float _003Ct_003E5__2;

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
			public _003CScaleUP_003Ed__15(int _003C_003E1__state)
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

		public Transform rocket;

		public float speed;

		public float rotationSpeed;

		public int numberOfWaypoints;

		public Vector3 areaSize;

		private List<Vector3> waypoints;

		private int currentWaypointIndex;

		private Vector3 currentTargetPosition;

		private Vector3 smoothDirection;

		public ParticleSystem fireTrail;

		public LayerMask enemyLayer;

		private readonly Collider[] enemyColliderBuffer;

		private bool _isStarted;

		private Transform enemyP;

		public float rangeHit;

		public bool IsStarted => false;

		public void SetStart()
		{
		}

		[IteratorStateMachine(typeof(_003CScaleUP_003Ed__15))]
		public IEnumerator ScaleUP()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CScaleDown_003Ed__16))]
		public IEnumerator ScaleDown()
		{
			return null;
		}

		private void GenerateWaypoints()
		{
		}

		public Transform GetEnemyAround()
		{
			return null;
		}

		public void MoveAndRotateTowardsWaypoint()
		{
		}

		private void AttackEnemy()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartRocketsInDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissilePunches _003C_003E4__this;

		private int _003CpunchValue_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CStartRocketsInDelay_003Ed__8(int _003C_003E1__state)
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

	public List<RocketBehaviour> allPuchRockets;

	public static MissilePunches Instance { get; private set; }

	private void Awake()
	{
	}

	public override void StartAbility()
	{
	}

	[IteratorStateMachine(typeof(_003CStartRocketsInDelay_003Ed__8))]
	private IEnumerator StartRocketsInDelay()
	{
		return null;
	}

	private void Update()
	{
	}
}
