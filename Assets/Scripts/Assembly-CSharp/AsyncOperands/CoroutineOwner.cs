using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AsyncOperands
{
	public class CoroutineOwner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDefaultCoroutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AsyncEffector effector;

			public float duration;

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
			public _003CDefaultCoroutine_003Ed__2(int _003C_003E1__state)
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

		private static CoroutineOwner Instance;

		private static bool hasInstance;

		[IteratorStateMachine(typeof(_003CDefaultCoroutine_003Ed__2))]
		public IEnumerator DefaultCoroutine(float duration, AsyncEffector effector)
		{
			return null;
		}

		public static CoroutineOwner GetInstance()
		{
			return null;
		}

		public static Coroutine StartAsyncOperand(IEnumerator coroutine, UnityEngine.Object owner, ref Action onCoroutineEnded)
		{
			return null;
		}

		public static void KillOperand(Coroutine coroutine)
		{
		}

		public static void KillAllAsyncs()
		{
		}
	}
}
