using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuffBehaviour : MonoBehaviour
{
	[Serializable]
	public struct BuffModelAndStat
	{
		public PlayerStatType type;

		public GameObject obje;
	}

	[CompilerGenerated]
	private sealed class _003CCollectCor_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BuffBehaviour _003C_003E4__this;

		private Vector3 _003Cstart_003E5__2;

		private float _003Ct_003E5__3;

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
		public _003CCollectCor_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CPop_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BuffBehaviour _003C_003E4__this;

		private Vector3 _003CtrasPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

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
		public _003CPop_003Ed__9(int _003C_003E1__state)
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

	public List<BuffModelAndStat> buffModels;

	private PlayerBehaviour pb;

	private PlayerStatController playerStatController;

	private PlayerStatType type;

	private float totalStatValue;

	public ParticleSystem zone;

	public AnimationCurve scalePop;

	public AnimationCurve curveLerp;

	public void SetType(PlayerStatType type, float value)
	{
	}

	[IteratorStateMachine(typeof(_003CPop_003Ed__9))]
	private IEnumerator Pop()
	{
		return null;
	}

	public void Collected()
	{
	}

	[IteratorStateMachine(typeof(_003CCollectCor_003Ed__12))]
	private IEnumerator CollectCor()
	{
		return null;
	}
}
