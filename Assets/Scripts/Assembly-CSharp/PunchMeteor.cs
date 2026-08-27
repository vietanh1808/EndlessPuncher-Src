using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PunchMeteor : SkillBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPunchFall_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int i;

		public PunchMeteor _003C_003E4__this;

		public GameObject punch;

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
		public _003CPunchFall_003Ed__13(int _003C_003E1__state)
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

	public float rangeCheckEnemy;

	public float rangeSpawnArea;

	public float rangePunchesHit;

	public GameObject[] punches;

	public ParticleSystem[] punchTrails;

	public ParticleSystem[] punchDecals;

	[SerializeField]
	private Vector3[] meteorPoses;

	public static PunchMeteor Instance { get; private set; }

	private void Awake()
	{
	}

	public Vector3 GetAvaliablePos(int currentI, out bool isSelectedpos)
	{
		isSelectedpos = default;
		return default;
	}

	[IteratorStateMachine(typeof(_003CPunchFall_003Ed__13))]
	public IEnumerator PunchFall(int i, GameObject punch)
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
