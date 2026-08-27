using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(EventTrigger))]
public class HoldButton : MonoBehaviour
{
	[Serializable]
	private class ButtonValues
	{
		public Image image;

		public Sprite normalImage;

		public Sprite pressedImage;

		public Sprite disabledImage;

		public bool interactable;

		private bool isPressed;

		public void Down()
		{
		}

		public void Up()
		{
		}

		public void SetInteractable(bool value)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CHoldEnum_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HoldButton _003C_003E4__this;

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
		public _003CHoldEnum_003Ed__21(int _003C_003E1__state)
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
	private ButtonValues buttonValues;

	[SerializeField]
	private bool autoRepeatEnabled;

	[SerializeField]
	private float holdRepeatStartDelay;

	[SerializeField]
	private float holdRepeatInterval;

	[Space(10f)]
	[SerializeField]
	private UnityEvent onClick;

	private bool isPointerHeld;

	private Coroutine holdCoroutine;

	public bool interactable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAutoRepeatClick { get; private set; }

	public void SetAutoRepeatEnabled(bool value)
	{
	}

	private void Start()
	{
	}

	public void AddListener(UnityAction action)
	{
	}

	public void RemoveListener(UnityAction action)
	{
	}

	private void OnHoldBegin()
	{
	}

	private void OnHoldEnd()
	{
	}

	[IteratorStateMachine(typeof(_003CHoldEnum_003Ed__21))]
	private IEnumerator HoldEnum()
	{
		return null;
	}

	private void OnClick()
	{
	}
}
