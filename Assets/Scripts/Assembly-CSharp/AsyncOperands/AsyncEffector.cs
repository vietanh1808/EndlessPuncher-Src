using System;
using UnityEngine;

namespace AsyncOperands
{
	public class AsyncEffector
	{
		public readonly AnimationCurve lerpCurve;

		public readonly Action onComplete;

		public readonly Action onEachLoopComplete;

		public readonly float delay;

		public readonly int loop;

		public readonly TimeSteps timeStep;

		public static readonly AnimationCurve Lineer;

		public static readonly AnimationCurve InSine;

		public static readonly AnimationCurve OutSine;

		public static readonly AnimationCurve InBack;

		public static readonly AnimationCurve OutBack;

		public static readonly AnimationCurve Breathe;

		public static readonly AnimationCurve InOutSine;

		public static readonly AnimationCurve PopUp;

		public static readonly AnimationCurve XSquared;

		public AsyncEffector()
		{
		}

		public AsyncEffector(LerpCurves curves = LerpCurves.Lineer, float delay = 0f, int loop = 0, TimeSteps timeSteps = TimeSteps.Update, AnimationCurve lerpCurve = null, Action onComplete = null, Action onEachLoopComplete = null)
		{
		}
	}
}
