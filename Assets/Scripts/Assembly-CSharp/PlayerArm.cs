using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerArm : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COffsetEnum_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerArm _003C_003E4__this;

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
		public _003COffsetEnum_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CScaleEnum_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int i;

		public PlayerArm _003C_003E4__this;

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
		public _003CScaleEnum_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CTurnToAnim_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerArm _003C_003E4__this;

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
		public _003CTurnToAnim_003Ed__21(int _003C_003E1__state)
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

	public Transform sholderBone;

	public Transform armBone;

	public Transform forearmBone;

	public Transform handBone;

	public Transform[] armBones;

	public bool isRight;

	public float lerpRate;

	public float offsetRadius;

	private Vector3[] posses;

	private Vector3[] offsets;

	private Vector3[] offsetTargets;

	private Vector3[] scales;

	private int _powerLevel;

	private float _powerScalePerLevel;

	private bool isOffsetActive;

	public void Init()
	{
	}

	public void SetPowerLevel(int powerLevel, float powerScalePerLevel)
	{
	}

	public void StartOffsets(MonoBehaviour mb)
	{
	}

	public void StopOffsets()
	{
	}

	[IteratorStateMachine(typeof(_003COffsetEnum_003Ed__19))]
	private IEnumerator OffsetEnum()
	{
		return null;
	}

	public void SetArmBonesToAnim()
	{
	}

	[IteratorStateMachine(typeof(_003CTurnToAnim_003Ed__21))]
	public IEnumerator TurnToAnim()
	{
		return null;
	}

	private void UpdatePoses()
	{
	}

	public void SetArmPosition(Vector3 pos, Func<float, float> xFunc)
	{
	}

	public Vector3 GetDir()
	{
		return default;
	}

	public void OnUpgraded()
	{
	}

	public void OnUp(float time)
	{
	}

	public void OnUpMax(float time)
	{
	}

	public void OnDown(float time)
	{
	}

	public void OnDownMax(float time)
	{
	}

	private void ScaleUp(int i, float t)
	{
	}

	private void ScaleUpMax(int i, float t)
	{
	}

	private void ScaleDown(int i, float t)
	{
	}

	private void ScaleDownMax(int i, float t)
	{
	}

	[IteratorStateMachine(typeof(_003CScaleEnum_003Ed__34))]
	private IEnumerator ScaleEnum(int i)
	{
		return null;
	}

	private Vector3 GetPoweredScale(int index)
	{
		return default;
	}

	private void ApplyCurrentBaseScale()
	{
	}
}
