using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RingEnvironmentControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScaleDown_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject itemEnv;

		public RingEnvironmentControl _003C_003E4__this;

		private Vector3 _003CstrtScale_003E5__2;

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
		public _003CScaleDown_003Ed__4(int _003C_003E1__state)
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

	public Vector3 boxSize;

	public LayerMask maskItemEnv;

	public List<GameObject> envItems;

	private void CheckItemAroundRing()
	{
	}

	[IteratorStateMachine(typeof(_003CScaleDown_003Ed__4))]
	private IEnumerator ScaleDown(GameObject itemEnv)
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
