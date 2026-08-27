using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HS_ProjectileMover : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisableTimer_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public HS_ProjectileMover _003C_003E4__this;

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
		public _003CDisableTimer_003Ed__15(int _003C_003E1__state)
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
	protected float speed;

	[SerializeField]
	protected float hitOffset;

	[SerializeField]
	protected bool UseFirePointRotation;

	[SerializeField]
	protected Vector3 rotationOffset;

	[SerializeField]
	protected GameObject hit;

	[SerializeField]
	protected ParticleSystem hitPS;

	[SerializeField]
	protected GameObject flash;

	[SerializeField]
	protected Rigidbody rb;

	[SerializeField]
	protected Collider col;

	[SerializeField]
	protected Light lightSourse;

	[SerializeField]
	protected GameObject[] Detached;

	[SerializeField]
	protected ParticleSystem projectilePS;

	private bool startChecker;

	[SerializeField]
	protected bool notDestroy;

	protected virtual void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CDisableTimer_003Ed__15))]
	protected virtual IEnumerator DisableTimer(float time)
	{
		return null;
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected virtual void OnCollisionEnter(Collision collision)
	{
	}
}
