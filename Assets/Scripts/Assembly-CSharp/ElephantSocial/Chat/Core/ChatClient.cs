using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ElephantSocial.Chat.Interface;
using ElephantSocial.Chat.Model;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;
using Newtonsoft.Json;

namespace ElephantSocial.Chat.Core
{
	public sealed class ChatClient : IDisposable
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public string sourceEventId;

			public string channelId;

			public UniTaskCompletionSource<AckPayloadWrapper> ackTcs;

			internal void _003CSendMessageAsync_003Eb__0(object sender, MessageAcknowledgedEventArgs args)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string url;

			public string authToken;

			public ChatClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDisconnectAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ChatClient _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CProcessPendingMessagesAsync_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChatClient _003C_003E4__this;

			public CancellationToken cancellationToken;

			private Tuple<string, string, object, string> _003CpendingMessage_003E5__2;

			private int _003CretryCount_003E5__3;

			private UniTask<AckPayloadWrapper>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003CSendMessageAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AckPayloadWrapper> _003C_003Et__builder;

			public string channelId;

			public string messageType;

			public object payload;

			public ChatClient _003C_003E4__this;

			public bool waitForAck;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

			private EventHandler<MessageAcknowledgedEventArgs> _003CackHandler_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private CancellationTokenSource _003CtimeoutCts_003E5__3;

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

		private readonly IWebSocketClient _webSocketClient;

		private readonly JsonSerializerSettings _jsonSettings;

		private bool _disposed;

		private readonly Queue<Tuple<string, string, object, string>> _pendingMessages;

		private bool _processingPendingMessages;

		[CompilerGenerated]
		private EventHandler<ConnectionStatusEventArgs> m_ConnectionStatusChanged;

		[CompilerGenerated]
		private EventHandler<ErrorEventArgs> m_ErrorOccurred;

		[CompilerGenerated]
		private EventHandler<MessageCreatedEventArgs> m_MessageCreated;

		[CompilerGenerated]
		private EventHandler<MessageUpdatedEventArgs> m_MessageUpdated;

		[CompilerGenerated]
		private EventHandler<MessageDeletedEventArgs> m_MessageDeleted;

		[CompilerGenerated]
		private EventHandler<HistoryReceivedEventArgs> m_HistoryReceived;

		[CompilerGenerated]
		private EventHandler<MessageAcknowledgedEventArgs> m_MessageAcknowledged;

		[CompilerGenerated]
		private EventHandler<RequestDeniedEventArgs> m_RequestDenied;

		public WebSocketState ConnectionState => WebSocketState.Connecting;

		public event EventHandler<ConnectionStatusEventArgs> ConnectionStatusChanged
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

		public event EventHandler<ErrorEventArgs> ErrorOccurred
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

		public event EventHandler<MessageCreatedEventArgs> MessageCreated
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

		public event EventHandler<MessageUpdatedEventArgs> MessageUpdated
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

		public event EventHandler<MessageDeletedEventArgs> MessageDeleted
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

		public event EventHandler<HistoryReceivedEventArgs> HistoryReceived
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

		public event EventHandler<MessageAcknowledgedEventArgs> MessageAcknowledged
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

		public event EventHandler<RequestDeniedEventArgs> RequestDenied
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

		public ChatClient(IWebSocketClient webSocketClient)
		{
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__32))]
		public UniTask ConnectAsync(string url, string authToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CDisconnectAsync_003Ed__33))]
		public UniTask DisconnectAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSendMessageAsync_003Ed__34))]
		public UniTask<AckPayloadWrapper> SendMessageAsync(string channelId, string messageType, object payload, bool waitForAck = false, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		private void ProcessPendingMessages()
		{
		}

		[AsyncStateMachine(typeof(_003CProcessPendingMessagesAsync_003Ed__36))]
		private UniTaskVoid ProcessPendingMessagesAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		private void HandleWebSocketOpen()
		{
		}

		private void HandleWebSocketClose(string reason)
		{
		}

		private void HandleWebSocketError(string errorMessage)
		{
		}

		private void HandleWebSocketMessage(byte[] messageBytes)
		{
		}

		private void ProcessMessageByType(IncomingMessageWrapper incomingWrapper, JsonSerializer serializer)
		{
		}

		private void HandleAckMessage(string channelId, AckPayloadWrapper ackWrapper, JsonSerializer serializer)
		{
		}

		private void NotifyConnectionStatusChanged(bool isConnected, string reason = "")
		{
		}

		private void NotifyError(string title, string message)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		~ChatClient()
		{
		}
	}
}
