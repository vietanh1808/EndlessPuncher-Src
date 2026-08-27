using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DeathbombPunch : SkillBehaviour
{
	[Serializable]
	public class DeathBombModel
	{
		[CompilerGenerated]
		private sealed class _003CPunchFall_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DeathBombModel _003C_003E4__this;

			private Vector3 _003CpunchStart_003E5__2;

			private Vector3 _003CpunchEnd_003E5__3;

			private float _003Ct_003E5__4;

			private bool _003CisExpo_003E5__5;

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
			public _003CPunchFall_003Ed__6(int _003C_003E1__state)
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

		public GameObject punch;

		public ParticleSystem puncDecal;

		public ParticleSystem fireTrail;

		public ParticleSystem dashParticle;

		public void SetPos(Vector3 pos)
		{
		}

		public void SpawnAndRun(Vector3 point)
		{
		}

		[IteratorStateMachine(typeof(_003CPunchFall_003Ed__6))]
		public IEnumerator PunchFall()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CScaleDown_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject punch;

		public DeathbombPunch _003C_003E4__this;

		private Vector3 _003CpunchStart_003E5__2;

		private Vector3 _003CpunchEnd_003E5__3;

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
		public _003CScaleDown_003Ed__12(int _003C_003E1__state)
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
	private Vector3[] meteorPoses;

	public float rangeSpawnArea;

	public float rangePunchesHit;

	public List<DeathBombModel> allDeathModels;

	public AnimationCurve curveScaleDown;

	public static DeathbombPunch Instance { get; private set; }

	private void Awake()
	{
	}

	public Vector3 GetAvaliablePos(int currentI, out bool isSelectedpos)
	{
		isSelectedpos = default;
		return default;
	}

	[IteratorStateMachine(typeof(_003CScaleDown_003Ed__12))]
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
}
