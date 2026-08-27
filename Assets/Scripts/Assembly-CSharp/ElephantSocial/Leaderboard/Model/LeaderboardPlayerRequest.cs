using System;
using ElephantSocial.Model;

namespace ElephantSocial.Leaderboard.Model
{
	[Serializable]
	public class LeaderboardPlayerRequest : BaseLeaderboardRequest
	{
		public int score;

		public string operation;

		public LeaderboardPlayerRequest(int leaderboardId, BoardPlayer player, string operation)
			: base(0)
		{
		}
	}
}
