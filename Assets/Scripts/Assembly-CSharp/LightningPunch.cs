using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LightningPunch : SkillBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LightningPunch _003C_003E4__this;

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
		public _003CCountDown_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CPunchWaiter_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LightningPunch _003C_003E4__this;

		private bool _003CisWaiting_003E5__2;

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
		public _003CPunchWaiter_003Ed__12(int _003C_003E1__state)
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

	private bool _isActivedParticle;

	private Coroutine corPunch;

	private bool isCounterStarted;

	public static LightningPunch Instance { get; private set; }

	public bool IsActive => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public override void StartAbility()
	{
	}

	[IteratorStateMachine(typeof(_003CPunchWaiter_003Ed__12))]
	private IEnumerator PunchWaiter()
	{
		return null;
	}

	public void ActivatePunch()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__15))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public override void ResetForNewRun()
	{
	}
}
