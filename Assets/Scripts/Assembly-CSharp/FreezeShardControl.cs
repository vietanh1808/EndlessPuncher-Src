using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FreezeShardControl : PoolControl
{
	[CompilerGenerated]
	private sealed class _003CSpreadEnemy_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FreezeShardControl _003C_003E4__this;

		public Transform targetEnemy;

		public float damage;

		private float _003Ct_003E5__2;

		private Vector3 _003CstrtPos_003E5__3;

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
		public _003CSpreadEnemy_003Ed__3(int _003C_003E1__state)
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

	public AnimationCurve curveLerpY;

	public GameObject shard;

	public void JumpToEnemy(Transform target, float damage)
	{
	}

	[IteratorStateMachine(typeof(_003CSpreadEnemy_003Ed__3))]
	private IEnumerator SpreadEnemy(Transform targetEnemy, float damage)
	{
		return null;
	}

	private void Attack(Transform enemy, float damage)
	{
	}
}
