using System;
using UnityEngine;

namespace AsyncOperands
{
	public static class AsyncVirtual
	{
		public static Coroutine Float(float from, float to, float duration, Action<float> action, AsyncEffector effector = null)
		{
			return null;
		}

		public static void KillAllAsyncs()
		{
		}

		public static Coroutine WaitUntil(Func<bool> predicate, Action action, AsyncEffector effector = null)
		{
			return null;
		}

		public static Coroutine WaitForSeconds(float duration, Action action, AsyncEffector effector = null)
		{
			return null;
		}

		public static void KillAsync(Coroutine coroutine)
		{
		}
	}
}
