using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ElephantSocial.Chat.Model;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;

namespace ElephantSocial.Chat.Core
{
	public class PersonalNotificationManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectToPersonalChannel_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PersonalNotificationManager _003C_003E4__this;

			private UniTask<AckPayloadWrapper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static PersonalNotificationManager _instance;

		private readonly string _personalChannelId;

		private readonly string _socialId;

		private bool _isInitialized;

		private bool _isConnecting;

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__5))]
		public static UniTask InitializeAsync()
		{
			return default;
		}

		public static void Dispose()
		{
		}

		private PersonalNotificationManager(string socialId)
		{
		}

		[AsyncStateMachine(typeof(_003CConnectToPersonalChannel_003Ed__8))]
		private UniTask ConnectToPersonalChannel()
		{
			return default;
		}

		private void HandleConnectionStatusChanged(bool isConnected)
		{
		}

		private void HandlePersonalMessage(object sender, MessageCreatedEventArgs args)
		{
		}
	}
}
