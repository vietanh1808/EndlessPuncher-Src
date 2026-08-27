using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ElephantSDK
{
	public class ElephantPushElephantManager : IPushElephantAdapter, IElephantAdapter
	{
		[CompilerGenerated]
		private sealed class _003CSendDeviceToken_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ElephantPushElephantManager _003C_003E4__this;

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
			public _003CSendDeviceToken_003Ed__2(int _003C_003E1__state)
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

		private string _deviceToken;

		public void AskPushPermission()
		{
		}

		[IteratorStateMachine(typeof(_003CSendDeviceToken_003Ed__2))]
		private IEnumerator SendDeviceToken()
		{
			return null;
		}

		public void SetDeviceToken(string token)
		{
		}

		public void SendPushNotificationOpenEvent(string combinedIds)
		{
		}

		public void ReceiveNotificationPermission(string response)
		{
		}
	}
}
