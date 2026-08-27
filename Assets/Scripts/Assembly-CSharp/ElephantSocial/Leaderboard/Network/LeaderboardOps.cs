using System;
using System.Collections;
using ElephantSDK;
using ElephantSocial.Model;

namespace ElephantSocial.Leaderboard.Network
{
	public class LeaderboardOps : SocialOps
	{
		public IEnumerator UpdateScore(BoardPlayer boardPlayer, int leaderboardId, string operation, int score, Action<GenericResponse<BoardPlayer>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator GetScore(int leaderboardId, Action<GenericResponse<BoardPlayer>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator GetLeaderboard(int leaderboardId, Action<GenericResponse<LeaderboardContainer>> onResponse, Action<string> onError)
		{
			return null;
		}
	}
}
