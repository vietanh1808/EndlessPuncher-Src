using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MagicLightProbes
{
	public class DublicateVertical
	{
		[CompilerGenerated]
		private sealed class _003CExecutePass_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MagicLightProbes parent;

			private int _003Csteps_003E5__2;

			private List<MLPPointData> _003Ccandidates_003E5__3;

			private List<MLPPointData> _003CsavedNearGeometry_003E5__4;

			private int _003Ci_003E5__5;

			private List<MLPPointData>.Enumerator _003C_003E7__wrap5;

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
			public _003CExecutePass_003Ed__0(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CExecutePass_003Ed__0))]
		public IEnumerator ExecutePass(MagicLightProbes parent)
		{
			return null;
		}
	}
}
