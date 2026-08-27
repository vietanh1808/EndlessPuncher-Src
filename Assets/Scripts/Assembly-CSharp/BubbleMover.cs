using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BubbleMover : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveBubble_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BubbleMover _003C_003E4__this;

		public Transform overrideSpawn;

		public Transform target;

		private BubbleControl _003Cbubble_003E5__2;

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
		public _003CMoveBubble_003Ed__10(int _003C_003E1__state)
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
	private sealed class _003CMoveBubbleAlongParabola_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BubbleMover _003C_003E4__this;

		public Vector2 start;

		public Vector2 mid;

		public Vector2 target;

		public RectTransform bubble;

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
		public _003CMoveBubbleAlongParabola_003Ed__11(int _003C_003E1__state)
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
	private BubbleControl bubblePrefab;

	[SerializeField]
	private Transform bubbleParent;

	[SerializeField]
	private Camera uiCam;

	[SerializeField]
	private float parabolaHeight;

	[SerializeField]
	private float parabolaWidth;

	[SerializeField]
	private float randomOffset;

	[SerializeField]
	private float bubbleMoveSpeed;

	private Camera mainCam;

	private RectTransform canvasRect;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveBubble_003Ed__10))]
	public IEnumerator MoveBubble(Transform overrideSpawn, Transform target)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveBubbleAlongParabola_003Ed__11))]
	private IEnumerator MoveBubbleAlongParabola(RectTransform bubble, Vector2 start, Vector2 mid, Vector2 target)
	{
		return null;
	}

	private Vector2 GetStartPosition(Transform overrideSpawn, bool isUI)
	{
		return default;
	}

	private Vector2 GetTargetPosition(Transform target)
	{
		return default;
	}

	private Vector2 GetMidPoint(Vector2 start, Vector2 target)
	{
		return default;
	}
}
