using System;
using System.Collections.Generic;
using ElephantSocial.Model;

namespace ElephantSocial.Leaderboard
{
	[Serializable]
	public class LeaderboardRecords
	{
		public long next;

		public List<BoardPlayer> records;

		public List<BoardPlayer> GetRecords()
		{
			return null;
		}
	}
}
