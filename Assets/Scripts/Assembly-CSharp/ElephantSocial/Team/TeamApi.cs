using System;
using ElephantSocial.Model;
using ElephantSocial.Team.CoopEvent.Model.Response;
using ElephantSocial.Team.Model;
using ElephantSocial.Team.Model.Enum;
using ElephantSocial.Team.Model.Response;
using ElephantSocial.Team.Network;
using ElephantSocial.Team.War.Model.Response;
using ElephantUniTask.Threading.Tasks;

namespace ElephantSocial.Team
{
	public class TeamApi
	{
		private static readonly Lazy<TeamApi> _instance;

		private readonly TeamOps _teamOps;

		public static TeamApi Instance => null;

		public UniTask<TeamsListResponse> ListTeamsAsync(string searchTerm = "")
		{
			return default;
		}

		public UniTask<Player> GetPlayerAsync()
		{
			return default;
		}

		public UniTask<TeamResponse> GetTeamAsync(string teamId)
		{
			return default;
		}

		public UniTask<TeamResponse> CreateTeamAsync(string name, string description, int capacity, int requiredLevel, int teamType, int badge)
		{
			return default;
		}

		public UniTask<TeamResponse> JoinTeamAsync(string teamId)
		{
			return default;
		}

		public UniTask<TeamResponse> LeaveTeamAsync()
		{
			return default;
		}

		public UniTask<TeamResponse> UpdateTeamAsync(string name, int capacity, int requiredLevel, int teamType, string description, int badge)
		{
			return default;
		}

		public UniTask<TeamResponse> PromoteMemberAsync(string targetSocialId)
		{
			return default;
		}

		public UniTask<TeamResponse> DemoteMemberAsync(string targetSocialId)
		{
			return default;
		}

		public UniTask<TeamResponse> KickMemberAsync(string targetSocialId)
		{
			return default;
		}

		public UniTask<JoinRequestsResponse> GetJoinRequestsAsync()
		{
			return default;
		}

		public UniTask<PlayerJoinRequestsResponse> GetPlayerJoinRequestsAsync()
		{
			return default;
		}

		public UniTask AcceptJoinRequestAsync(string targetSocialId)
		{
			return default;
		}

		public UniTask RejectJoinRequestAsync(string targetSocialId)
		{
			return default;
		}

		public UniTask IncrementStat(int incrementValue, string statId)
		{
			return default;
		}

		public UniTask UpdateTeamStat(string statMetaId, StatOp op, long val)
		{
			return default;
		}

		public UniTask UpdatePlayerStat(string statMetaId, StatOp op, long val)
		{
			return default;
		}

		public UniTask<TeamTopStatResponse> GetTeamTopStatAsync(string statMetaId, int limit)
		{
			return default;
		}

		public UniTask<PlayerTopStatResponse> GetPlayerTopStatAsync(string statMetaId, int limit)
		{
			return default;
		}

		public UniTask<bool> IsServerHealthyAsync()
		{
			return default;
		}

		public UniTask<TeamCoopEventResponse> GetTeamCoopEventAsync(int coopEventId)
		{
			return default;
		}

		public UniTask IncrementTeamCoopEventAsync(int coopEventId, int score)
		{
			return default;
		}

		public UniTask SetTeamCoopEventClaimedAsync(int coopEventId, int rewardId, int scheduleId)
		{
			return default;
		}

		public UniTask<TeamCoopEventResponse> CheckTeamCoopEventRewardsAsync()
		{
			return default;
		}

		public UniTask<TeamWarStateResponse> GetWarStateAsync(string teamWarId)
		{
			return default;
		}

		public UniTask<TeamWarRankingResponse> GetWarRankingAsync(string teamWarId, string teamId = null)
		{
			return default;
		}

		public UniTask<TeamWarRankingResponse> GetWarPhaseRankingAsync(string teamWarId, int phase, string teamId = null)
		{
			return default;
		}

		public UniTask AddWarScoreAsync(string teamWarId, long score, int phase)
		{
			return default;
		}
	}
}
