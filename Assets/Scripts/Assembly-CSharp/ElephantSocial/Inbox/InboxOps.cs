using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ElephantSocial.Inbox.Model.Request;
using ElephantSocial.Inbox.Model.Response;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;

namespace ElephantSocial.Inbox
{
	public class InboxOps : GenericResponseOps
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CMakeRequestAsync_003Ed__0<T> : IAsyncStateMachine where T : new()
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public InboxOps _003C_003E4__this;

			public object data;

			public string url;

			private UniTask<T>.Awaiter _003C_003Eu__1;

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
		private struct _003CMakeVoidRequestAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public InboxOps _003C_003E4__this;

			public object data;

			public string url;

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

		[AsyncStateMachine(typeof(_003CMakeRequestAsync_003Ed__0<>))]
		private UniTask<T> MakeRequestAsync<T>(string url, object data) where T : new()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CMakeVoidRequestAsync_003Ed__1))]
		private UniTask MakeVoidRequestAsync(string url, object data)
		{
			return default;
		}

		public UniTask<InboxResponse> GetInboxAsync(GetInboxRequest request)
		{
			return default;
		}

		public UniTask MarkAsReadAsync(MarkAsReadRequest request)
		{
			return default;
		}
	}
}
