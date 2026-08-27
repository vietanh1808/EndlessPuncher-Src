using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayFrames_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transition _003C_003E4__this;

		public List<Sprite> frames;

		public Action action;

		private List<Sprite>.Enumerator _003C_003E7__wrap1;

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
		public _003CPlayFrames_003Ed__13(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Transition")]
	[SerializeField]
	private Image transitionImage;

	[SerializeField]
	private float durationBetweenTransitionFrames;

	[SerializeField]
	private List<Sprite> transitionOnFrames;

	[SerializeField]
	private List<Sprite> transitionOffFrames;

	private Coroutine transitionRoutine;

	public static Transition Instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void PlayOn(Action action = null)
	{
	}

	public void PlayOff(Action action = null)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayFrames_003Ed__13))]
	private IEnumerator PlayFrames(List<Sprite> frames, Action action = null)
	{
		return null;
	}
}
