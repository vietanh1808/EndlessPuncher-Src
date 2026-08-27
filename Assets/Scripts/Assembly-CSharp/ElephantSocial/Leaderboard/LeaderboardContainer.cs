using System;

namespace ElephantSocial.Leaderboard
{
	[Serializable]
	public class LeaderboardContainer
	{
		public string country;

		public LeaderboardRecords global;

		public LeaderboardRecords local;
	}
}
