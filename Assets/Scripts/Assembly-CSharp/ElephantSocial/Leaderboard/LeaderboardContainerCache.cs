using System;
using ElephantSocial.CachingSystem;

namespace ElephantSocial.Leaderboard
{
	public class LeaderboardContainerCache : GenericCachingSystem<LeaderboardContainer>
	{
		private LeaderboardContainerCache(Action<Action<LeaderboardContainer>, Action<string>> dataRequestAction, int cachingIntervalSeconds)
			: base((Action<Action<LeaderboardContainer>, Action<string>>)null, 0)
		{
		}

		public static LeaderboardContainerCache CreateInstance(Action<Action<LeaderboardContainer>, Action<string>> dataRequestAction, int cachingIntervalSeconds)
		{
			return null;
		}
	}
}
