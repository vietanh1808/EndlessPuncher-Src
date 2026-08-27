using System;

namespace ElephantSocial.Leaderboard.Model
{
	[Serializable]
	public class LeaderboardRequest : BaseLeaderboardRequest
	{
		public LeaderboardRequest(int leaderboardId)
			: base(0)
		{
		}
	}
}
