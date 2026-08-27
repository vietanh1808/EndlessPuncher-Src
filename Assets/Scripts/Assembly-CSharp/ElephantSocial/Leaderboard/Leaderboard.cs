using System;
using System.Collections.Generic;
using ElephantSocial.Leaderboard.Network;
using ElephantSocial.Model;

namespace ElephantSocial.Leaderboard
{
	public class Leaderboard : GenericResponseOps
	{
		private readonly LeaderboardOps _leaderboardOps;

		private LeaderboardContainerCache _leaderboardContainerCache;

		private int leaderboardId;

		private BoardPlayer boardPlayer;

		private bool _isInitializeRequested;

		private long nextUnixSeconds;

		public Leaderboard(int leaderboardId)
		{
		}

		public void Init(Action onResponse, Action<string> onError)
		{
		}

		public void SetScore(int score, Action<BoardPlayer> onResponse, Action<string> onError)
		{
		}

		public void AddScore(int scoreToAdd, Action<BoardPlayer> onResponse, Action<string> onError)
		{
		}

		public void GetLeaderboard(Action<LeaderboardContainer> onResponse, Action<string> onError)
		{
		}

		public long GetNextUnixSeconds()
		{
			return 0L;
		}

		public BoardPlayer GetBoardPlayer()
		{
			return null;
		}

		private void RenewPlayerData()
		{
		}

		private void SortLeaderboardContainer(LeaderboardContainer leaderboardContainer, Action<LeaderboardContainer> onResponse)
		{
		}

		private static List<BoardPlayer> SortLeaderboard(List<BoardPlayer> list)
		{
			return null;
		}

		private List<BoardPlayer> UpdatePlayer(BoardPlayer targetBoardPlayer, List<BoardPlayer> boardPlayerList)
		{
			return null;
		}

		private void RequestLeaderboardContainer(Action<LeaderboardContainer> onResponse, Action<string> onError)
		{
		}

		private void InitPlayer(Action<BoardPlayer> onResponse, Action<string> onError)
		{
		}

		private void InitLeaderboardCache(Action<Action<LeaderboardContainer>, Action<string>> requestLeaderboardAction, Action onInitialized, Action<string> onError)
		{
		}
	}
}
