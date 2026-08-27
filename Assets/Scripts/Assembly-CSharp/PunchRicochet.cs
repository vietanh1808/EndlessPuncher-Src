using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PunchRicochet : SkillBehaviour
{
	[Serializable]
	public class RicochetArm
	{
		[CompilerGenerated]
		private sealed class _003CEndBouncing_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObject punchArm;

			public GameObject punch;

			private Vector3 _003CscaleStart_003E5__2;

			private Vector3 _003CscaleEnd_003E5__3;

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
			public _003CEndBouncing_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003CStartArms_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObject firstEnemy;

			public RicochetArm _003C_003E4__this;

			public int bouncCount;

			private int _003Ccounter_003E5__2;

			private int _003CsafeBounceCount_003E5__3;

			private int _003Ci_003E5__4;

			private GameObject _003CtargetEnemy_003E5__5;

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
			public _003CStartArms_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003CStartBouncing_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObject punch;

			public GameObject punchArm;

			public Vector3 point;

			public GameObject targetEnemy;

			public RicochetArm _003C_003E4__this;

			private Vector3 _003CstrtPos_003E5__2;

			private Vector3 _003Cendpos_003E5__3;

			private Vector3 _003CscaleStart_003E5__4;

			private Vector3 _003CscaleEnd_003E5__5;

			private float _003Ct_003E5__6;

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
			public _003CStartBouncing_003Ed__6(int _003C_003E1__state)
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

		public bool isActive;

		public GameObject[] punch;

		public GameObject[] punchArm;

		private MonoBehaviour mb;

		private List<GameObject> damagedEnemies;

		public void StartRicochet(MonoBehaviour mb, int bouncCount, GameObject firstEnemy)
		{
		}

		[IteratorStateMachine(typeof(_003CStartArms_003Ed__5))]
		private IEnumerator StartArms(int bouncCount, GameObject firstEnemy)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStartBouncing_003Ed__6))]
		private IEnumerator StartBouncing(GameObject punch, GameObject punchArm, Vector3 point, GameObject targetEnemy)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEndBouncing_003Ed__7))]
		private IEnumerator EndBouncing(GameObject punch, GameObject punchArm)
		{
			return null;
		}

		private GameObject GetEnemy()
		{
			return null;
		}

		public void Attack(GameObject enemy)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PunchRicochet _003C_003E4__this;

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
		public _003CCountDown_003Ed__13(int _003C_003E1__state)
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

	private bool _isActive;

	private EffectType _typePunch;

	private GameManager _gm;

	private bool isCounterStarted;

	public List<RicochetArm> ricochetArms;

	public static PunchRicochet Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public override void StartAbility()
	{
	}

	public void ActivatePunch(GameObject startObje, EffectType type)
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__13))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public override void ResetForNewRun()
	{
	}
}
