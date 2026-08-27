using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RocketPunch : SkillBehaviour
{
	[Serializable]
	public class RocketModel
	{
		[CompilerGenerated]
		private sealed class _003CPunchThrow_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RocketModel _003C_003E4__this;

			private Vector3 _003CpunchStart_003E5__2;

			private Vector3 _003CpunchEnd_003E5__3;

			private float _003Ct_003E5__4;

			private float _003CmultipCounter_003E5__5;

			private float _003CmultiplierT_003E5__6;

			private bool _003CisTriggeredEnemy_003E5__7;

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
			public _003CPunchThrow_003Ed__5(int _003C_003E1__state)
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

		public GameObject punchRocket;

		public Animator punchRocketAnim;

		public ParticleSystem fireTrail;

		private List<DamagedEnemyModel> damagedEnemies;

		public void SpawnAndRun(Vector3 point)
		{
		}

		[IteratorStateMachine(typeof(_003CPunchThrow_003Ed__5))]
		public IEnumerator PunchThrow()
		{
			return null;
		}
	}

	public class DamagedEnemyModel
	{
		public float tempTimer;

		public GameObject enemy;

		public DamagedEnemyModel(float tempTimer, GameObject enemy)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScaleDown_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject punch;

		public RocketPunch _003C_003E4__this;

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
		public _003CScaleDown_003Ed__11(int _003C_003E1__state)
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

	public float rangeSpawnArea;

	public float rangeNotSpawnArea;

	public float rangePunchHit;

	public List<RocketModel> allRockets;

	public AnimationCurve curveScaleDown;

	private Collider[] cols;

	public static RocketPunch Instance { get; private set; }

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CScaleDown_003Ed__11))]
	private IEnumerator ScaleDown(GameObject punch)
	{
		return null;
	}

	public override void StartAbility()
	{
	}

	private void SkillStartedDelay()
	{
	}

	private Vector3 GetSpawnPoint()
	{
		return default;
	}

	public bool Attack(Transform point, float range, List<DamagedEnemyModel> damagedEnemies)
	{
		return false;
	}
}
