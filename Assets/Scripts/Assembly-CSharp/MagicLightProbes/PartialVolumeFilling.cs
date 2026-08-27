using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MagicLightProbes
{
	public class PartialVolumeFilling
	{
		public enum TargetPoint
		{
			Unlit = 0,
			Equivalent = 1,
			Free = 2
		}

		[CompilerGenerated]
		private sealed class _003CExecutePass_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TargetPoint targetPoint;

			public MagicLightProbes parent;

			public MLPVolume currentVolume;

			public bool realtimeEditing;

			private List<MLPPointData> _003CtempList_003E5__2;

			private List<Vector3> _003CrealTimeEditingList_003E5__3;

			private List<Vector3> _003CtargetPoints_003E5__4;

			private float _003CfillingRate_003E5__5;

			private Vector3[] _003Cexit_003E5__6;

			private int _003Ci_003E5__7;

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
			public _003CExecutePass_003Ed__1(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CExecutePass_003Ed__1))]
		public IEnumerator ExecutePass(MagicLightProbes parent, TargetPoint targetPoint, MLPVolume currentVolume = null, bool realtimeEditing = false)
		{
			return null;
		}
	}
}
