using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ElephantSocial.Inbox.Model;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;

namespace ElephantSocial.Inbox
{
	public static class InboxService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetInboxAsync_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<InboxItem>> _003C_003Et__builder;

			private UniTask<ElephantSocial.Inbox.Model.Response.InboxResponse>.Awaiter _003C_003Eu__1;

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
		private struct _003CMarkAsReadAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int inboxItemId;

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

		[AsyncStateMachine(typeof(_003CGetInboxAsync_003Ed__0))]
		public static UniTask<List<InboxItem>> GetInboxAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CMarkAsReadAsync_003Ed__1))]
		public static UniTask MarkAsReadAsync(int inboxItemId)
		{
			return default;
		}
	}
}
