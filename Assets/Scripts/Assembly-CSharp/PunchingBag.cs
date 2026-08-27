using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PunchingBag : MonoBehaviour, IHitable
{
	[CompilerGenerated]
	private sealed class _003CDeadStuation_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PunchingBag _003C_003E4__this;

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
		public _003CDeadStuation_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CDownDestroy_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Rigidbody gg;

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
		public _003CDownDestroy_003Ed__16(int _003C_003E1__state)
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

	private static readonly int takeDamageHash;

	private Animator anim;

	private bool _isDead;

	private PlayerBehaviour pb;

	private InGameUI gameUI;

	public Collider colPunchBag;

	public GameObject[] bodyParts;

	[Range(0f, 1f)]
	[SerializeField]
	private float chestDropRate;

	private int takedDamage;

	public List<GameObject> models;

	private void Start()
	{
	}

	public void Spawn()
	{
	}

	private void DelayActive()
	{
	}

	private void CreateBuff()
	{
	}

	public void TakeDamage(float damageValue, Vector3 damagePoint)
	{
	}

	private void SetModels(int value)
	{
	}

	[IteratorStateMachine(typeof(_003CDownDestroy_003Ed__16))]
	private IEnumerator DownDestroy(Rigidbody gg)
	{
		return null;
	}

	public void CreateGoldUI(Vector3 obje, float goldValue)
	{
	}

	[IteratorStateMachine(typeof(_003CDeadStuation_003Ed__18))]
	public IEnumerator DeadStuation(bool isFighted = false)
	{
		return null;
	}

	public void TakeDamage(float damage)
	{
	}
}
