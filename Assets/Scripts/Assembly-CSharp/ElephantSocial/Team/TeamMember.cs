using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ElephantSocial.Model;
using ElephantSocial.Team.Model;
using ElephantSocial.Team.Model.Enum;
using ElephantUniTask.Threading.Tasks;
using ElephantUniTask.Threading.Tasks.CompilerServices;

namespace ElephantSocial.Team
{
	public class TeamMember
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDemoteMemberAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public TeamMember _003C_003E4__this;

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
		private struct _003CPromoteMemberAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public TeamMember _003C_003E4__this;

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

		public string id;

		public string name;

		public int score;

		public int helps;

		public TeamMemberRole role;

		public int badge;

		public string profilePicture;

		public int status;

		public long level;

		public bool isOnline;

		public long lastSeen;

		public List<MemberStat> stats;

		public static TeamMember FromServerModel(TeamMemberResponse serverModel)
		{
			return null;
		}

		public Player GetProfile()
		{
			return null;
		}

		public MemberStat GetStat(string statMetaId)
		{
			return null;
		}

		public long GetStatValue(string statMetaId)
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CPromoteMemberAsync_003Ed__16))]
		public UniTask<bool> PromoteMemberAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CDemoteMemberAsync_003Ed__17))]
		public UniTask<bool> DemoteMemberAsync()
		{
			return default;
		}
	}
}
