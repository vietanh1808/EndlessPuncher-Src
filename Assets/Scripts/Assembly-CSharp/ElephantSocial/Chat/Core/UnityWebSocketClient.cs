using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ElephantSocial.Chat.Interface;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;

namespace ElephantSocial.Chat.Core
{
	public class UnityWebSocketClient : IWebSocketClient, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCloseAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UnityWebSocketClient _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CConnectAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string url;

			public UnityWebSocketClient _003C_003E4__this;

			public Dictionary<string, string> headers;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CHandleCloseAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UnityWebSocketClient _003C_003E4__this;

			public string reason;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CReceiveLoopAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UnityWebSocketClient _003C_003E4__this;

			public CancellationToken cancellationToken;

			private byte[] _003Cbuffer_003E5__2;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private WebSocketReceiveResult _003Cresult_003E5__5;

			private object _003C_003E7__wrap5;

			private int _003C_003E7__wrap6;

			private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

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
		private struct _003CSendTextAsync_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UnityWebSocketClient _003C_003E4__this;

			public string data;

			private TaskAwaiter _003C_003Eu__1;

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

		private ClientWebSocket _webSocket;

		private ElephantSocial.Chat.Interface.WebSocketState _state;

		private readonly object _stateLock;

		private CancellationTokenSource _receiveCts;

		private const int ReceiveBufferSize = 8192;

		private List<byte> _messageBuffer;

		[CompilerGenerated]
		private Action m_OnOpen;

		[CompilerGenerated]
		private Action<string> m_OnClose;

		[CompilerGenerated]
		private Action<string> m_OnError;

		[CompilerGenerated]
		private Action<byte[]> m_OnMessage;

		public ElephantSocial.Chat.Interface.WebSocketState State => ElephantSocial.Chat.Interface.WebSocketState.Connecting;

		public event Action OnOpen
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

		public event Action<string> OnClose
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

		public event Action<string> OnError
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

		public event Action<byte[]> OnMessage
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

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__21))]
		public UniTask ConnectAsync(string url, Dictionary<string, string> headers = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CReceiveLoopAsync_003Ed__22))]
		private UniTask ReceiveLoopAsync(CancellationToken cancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CHandleCloseAsync_003Ed__23))]
		private UniTask HandleCloseAsync(string reason)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSendTextAsync_003Ed__24))]
		public UniTask SendTextAsync(string data)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CCloseAsync_003Ed__25))]
		public UniTask CloseAsync()
		{
			return default;
		}

		public void Dispose()
		{
		}
	}
}
