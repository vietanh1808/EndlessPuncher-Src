using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerBarBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadStatPanel_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerBarBehaviour _003C_003E4__this;

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
		public _003CLoadStatPanel_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CScaleDown_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerBarBehaviour _003C_003E4__this;

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
		public _003CScaleDown_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003CScaleUp_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerBarBehaviour _003C_003E4__this;

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
		public _003CScaleUp_003Ed__22(int _003C_003E1__state)
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

	private static PowerBarBehaviour _instance;

	private static readonly int popHash;

	public float startExpLevel;

	public float increaseExpPerLevel;

	public Transform expMoveTarget;

	public TextMeshProUGUI textLevel;

	public TextMeshProUGUI textExpValue;

	public Slider sliderLevel;

	public Animator animLevel;

	public Animator animSlider;

	private int _currentLvl;

	private float _currentExpLoad;

	private bool _isScaledUp;

	public static PowerBarBehaviour Instance => null;

	public int GetLevel => 0;

	private bool IsLevelUpPresentationBlocked()
	{
		return false;
	}

	public void AddExp(float valueExp)
	{
	}

	private float ExpValueCalculator()
	{
		return 0f;
	}

	private void SetSlider()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadStatPanel_003Ed__20))]
	private IEnumerator LoadStatPanel()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScaleUp_003Ed__22))]
	private IEnumerator ScaleUp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScaleDown_003Ed__23))]
	private IEnumerator ScaleDown()
	{
		return null;
	}

	public void ResetForNewRun()
	{
	}

	public void DeadExpSlider()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
