using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ElephantSocial.Chat.Interface;
using ElephantSocial.Chat.Model;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;

namespace ElephantSocial.Chat.Core
{
	public static class ElephantChat
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public EventHandler<ConnectionStatusEventArgs> connectionHandler;

			public UniTaskCompletionSource<bool> connectionTcs;

			internal void _003CConnectInternalAsync_003Eb__0(object sender, ConnectionStatusEventArgs args)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			private bool _003CconnectedSuccessfully_003E5__2;

			private string _003CsocialId_003E5__3;

			private CancellationTokenSource _003CconnectTimeoutCts_003E5__4;

			private CancellationTokenSource _003ClinkedCts_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<AckPayloadWrapper>.Awaiter _003C_003Eu__2;

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
		private struct _003CConnectInternalAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string url;

			public string authToken;

			private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

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
		private struct _003CStartReconnectionLoopAsync_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			private CancellationToken _003Ctoken_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

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

		private static ChatClient _chatClientInstance;

		private static IWebSocketClient _nativeClientInstance;

		private static bool _isInitialized;

		private static bool _isConnecting;

		private static CancellationTokenSource _connectionCts;

		[CompilerGenerated]
		private static Action<bool> m_OnConnectionStatusChanged;

		private static bool _isAttemptingReconnection;

		private static int _reconnectionAttempts;

		private const int MaxReconnectionAttempts = 5;

		private const int ReconnectionBaseDelayMs = 2000;

		private const int ReconnectionMaxDelayMs = 30000;

		private static CancellationTokenSource _reconnectionCts;

		private static bool _explicitDisconnect;

		public static ChatClient Client => null;

		public static WebSocketState ConnectionState => WebSocketState.Connecting;

		public static bool IsInitialized => false;

		public static bool IsAttemptingReconnection => false;

		public static event Action<bool> OnConnectionStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__23))]
		public static UniTask<bool> ConnectAsync()
		{
			return default;
		}

		private static void InitializeWebSocket()
		{
		}

		[AsyncStateMachine(typeof(_003CConnectInternalAsync_003Ed__25))]
		private static UniTask ConnectInternalAsync(string url, string authToken)
		{
			return default;
		}

		private static void HandleChatClientError(object sender, ErrorEventArgs args)
		{
		}

		private static void HandleChatClientConnectionStatusChanged(object sender, ConnectionStatusEventArgs args)
		{
		}

		private static void StartReconnectionLoop()
		{
		}

		[AsyncStateMachine(typeof(_003CStartReconnectionLoopAsync_003Ed__29))]
		private static UniTaskVoid StartReconnectionLoopAsync()
		{
			return default;
		}

		private static void CleanupResources()
		{
		}

		private static string GetChatUrl()
		{
			return null;
		}
	}
}
