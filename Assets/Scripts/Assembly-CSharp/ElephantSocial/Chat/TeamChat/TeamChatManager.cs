using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ElephantSocial.Chat.Model;
using ElephantSocial.Team;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;

namespace ElephantSocial.Chat.TeamChat
{
	public class TeamChatManager
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public List<ChatMessage> messages;

			public UniTaskCompletionSource<List<ChatMessage>> historyTask;

			public TeamChatManager _003C_003E4__this;

			internal void _003CGetHistoryAsync_003Eb__0(object _, HistoryReceivedEventArgs args)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			public string targetMessageId;

			internal bool _003CSendHelpAsync_003Eb__0(ChatMessage m)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public string targetMessageId;

			internal bool _003CClaimRewardAsync_003Eb__0(ChatMessage m)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass53_0
		{
			public HashSet<string> currentRequestIds;

			public HashSet<string> existingRequestIds;

			internal bool _003CRefreshJoinRequestsAsync_003Eb__3(JoinRequestMessage m)
			{
				return false;
			}

			internal bool _003CRefreshJoinRequestsAsync_003Eb__4(TeamMember r)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CClaimRewardAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string targetMessageId;

			public TeamChatManager _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

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
		private struct _003CGetCurrentTeamChatAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TeamChatManager> _003C_003Et__builder;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

			private UniTask<string>.Awaiter _003C_003Eu__3;

			private UniTask<TeamChatManager>.Awaiter _003C_003Eu__4;

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
		private struct _003CGetHistoryAsync_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<ChatMessage>> _003C_003Et__builder;

			public TeamChatManager _003C_003E4__this;

			public string fromMessageId;

			public int limit;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

			private EventHandler<HistoryReceivedEventArgs> _003ChistoryHandler_003E5__2;

			private UniTask<List<ChatMessage>> _003CjoinRequestsTask_003E5__3;

			private UniTask<AckPayloadWrapper>.Awaiter _003C_003Eu__1;

			private List<ChatMessage> _003ChistoryResult_003E5__4;

			private UniTask<List<ChatMessage>>.Awaiter _003C_003Eu__2;

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
		private struct _003CGetJoinRequestsInParallel_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<List<ChatMessage>> _003C_003Et__builder;

			public TeamChatManager _003C_003E4__this;

			private UniTask<ElephantSocial.Team.Team>.Awaiter _003C_003Eu__1;

			private UniTask<List<TeamMember>>.Awaiter _003C_003Eu__2;

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
		private struct _003CGetTeamChatAsync_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TeamChatManager> _003C_003Et__builder;

			public string teamId;

			private TeamChatManager _003CchatManager_003E5__2;

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
		private struct _003CGrantRewardAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int maxReceiver;

			public TeamChatManager _003C_003E4__this;

			public string rewardId;

			public CancellationToken cancellationToken;

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
		private struct _003CInitializeChannelAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TeamChatManager _003C_003E4__this;

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
		private struct _003CRefreshJoinRequestsAsync_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public TeamChatManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

			private UniTask<ElephantSocial.Team.Team>.Awaiter _003C_003Eu__1;

			private UniTask<List<TeamMember>>.Awaiter _003C_003Eu__2;

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
		private struct _003CRequestHelpAsync_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int requested;

			public TeamChatManager _003C_003E4__this;

			public CancellationToken cancellationToken;

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
		private struct _003CSendHelpAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string targetMessageId;

			public TeamChatManager _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

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
		private struct _003CSendTextMessageAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string text;

			public TeamChatManager _003C_003E4__this;

			public CancellationToken cancellationToken;

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

		private readonly string _teamId;

		private readonly string _socialId;

		private readonly string _channelId;

		private readonly string _chatContextKey;

		private readonly List<ChatMessage> _messages;

		private readonly HashSet<string> _helpedMessageIds;

		private readonly HashSet<string> _claimedMessageIds;

		private bool _isInitialized;

		private bool _isLoadingHistory;

		private bool _isInitializingChannel;

		private static TeamChatManager _instance;

		private static bool _isInitializing;

		[CompilerGenerated]
		private Action<ChatMessage> m_OnNewMessage;

		[CompilerGenerated]
		private Action<ChatMessage> m_OnMessageUpdate;

		[CompilerGenerated]
		private Action<ChatMessage> m_OnMessageDelete;

		[CompilerGenerated]
		private Action<bool> m_OnChatAvailableStatusChanged;

		[CompilerGenerated]
		private Action<string, string> m_OnChatError;

		public event Action<ChatMessage> OnNewMessage
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

		public event Action<ChatMessage> OnMessageUpdate
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

		public event Action<ChatMessage> OnMessageDelete
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

		public event Action<bool> OnChatAvailableStatusChanged
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

		public event Action<string, string> OnChatError
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

		[AsyncStateMachine(typeof(_003CGetCurrentTeamChatAsync_003Ed__27))]
		public static UniTask<TeamChatManager> GetCurrentTeamChatAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGetHistoryAsync_003Ed__28))]
		public UniTask<List<ChatMessage>> GetHistoryAsync(int limit = 100, string fromMessageId = "", CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGetJoinRequestsInParallel_003Ed__29))]
		private UniTask<List<ChatMessage>> GetJoinRequestsInParallel()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSendTextMessageAsync_003Ed__30))]
		public UniTask SendTextMessageAsync(string text, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CRequestHelpAsync_003Ed__31))]
		public UniTask RequestHelpAsync(int requested, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGrantRewardAsync_003Ed__32))]
		public UniTask GrantRewardAsync(int maxReceiver, string rewardId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSendHelpAsync_003Ed__33))]
		public UniTask SendHelpAsync(string targetMessageId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CClaimRewardAsync_003Ed__34))]
		public UniTask ClaimRewardAsync(string targetMessageId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		private Dictionary<string, string> ConvertStringDataSingleLine(string value)
		{
			return null;
		}

		private Dictionary<string, string> ConvertData(string dataType, string value)
		{
			return null;
		}

		private TeamChatManager(string teamId)
		{
		}

		private void Dispose()
		{
		}

		private void SubscribeToEvents()
		{
		}

		private void UnsubscribeFromEvents()
		{
		}

		[AsyncStateMachine(typeof(_003CGetTeamChatAsync_003Ed__41))]
		private static UniTask<TeamChatManager> GetTeamChatAsync(string teamId)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CInitializeChannelAsync_003Ed__42))]
		private UniTask InitializeChannelAsync()
		{
			return default;
		}

		private void HandleElephantChatConnectionStatus(bool isConnected)
		{
		}

		private void HandleConnectionStatusChanged(object sender, ConnectionStatusEventArgs args)
		{
		}

		private void HandleChatClientError(object sender, ErrorEventArgs args)
		{
		}

		private void HandleRequestDenied(object sender, RequestDeniedEventArgs args)
		{
		}

		private void HandleMessageCreated(object sender, MessageCreatedEventArgs args)
		{
		}

		private void SortJoinRequests()
		{
		}

		private void HandleMessageUpdated(object sender, MessageUpdatedEventArgs args)
		{
		}

		private void HandleMessageDeleted(object sender, MessageDeletedEventArgs args)
		{
		}

		private ChatMessage ConvertPayloadToChatMessage(MessageContentPayload payload)
		{
			return null;
		}

		private void RefreshJoinRequests()
		{
		}

		[AsyncStateMachine(typeof(_003CRefreshJoinRequestsAsync_003Ed__53))]
		private UniTaskVoid RefreshJoinRequestsAsync()
		{
			return default;
		}

		private static string GetReportUrl()
		{
			return null;
		}
	}
}
