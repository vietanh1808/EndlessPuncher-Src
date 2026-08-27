using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GranadePunch : SkillBehaviour
{
	[Serializable]
	public class GranadeModel
	{
		private bool canCheckGround;

		public Rigidbody granade;

		public ParticleSystem explosionParticle;

		public ParticleSystem trailParticle;

		private readonly Collider[] colGround;

		public bool IsCheckingGround => false;

		public void AttackInRange()
		{
		}

		public void ThrowGranade(int i)
		{
		}

		public static Vector3 CalculateLaunchVelocity(Vector3 start, Vector3 target, float timeToTarget)
		{
			return default;
		}

		public static void ThrowToTarget(Rigidbody rb, Vector3 target, float timeToTarget)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScaleDown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GranadePunch _003C_003E4__this;

		public GameObject obj;

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
		public _003CScaleDown_003Ed__15(int _003C_003E1__state)
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

	public Vector3[] meteorPoses;

	public float rangeSpawnArea;

	public float rangePunchesHit;

	public float rangeCheckGround;

	public List<GranadeModel> allGranades;

	public LayerMask ground;

	private int downCounter;

	private int activeGrenadeCount;

	private bool isSkillWork;

	public static GranadePunch Instance { get; private set; }

	private void Awake()
	{
	}

	public Vector3 GetAvaliablePos(int currentI, out bool isSelectedpos)
	{
		isSelectedpos = default;
		return default;
	}

	[IteratorStateMachine(typeof(_003CScaleDown_003Ed__15))]
	private IEnumerator ScaleDown(GameObject obj)
	{
		return null;
	}

	private void Update()
	{
	}

	public override void StartAbility()
	{
	}

	private void DelayskillUsed()
	{
	}

	private Vector3 GetSpawnPoint()
	{
		return default;
	}

	private Vector3 GetDirection()
	{
		return default;
	}
}
