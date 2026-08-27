using System;
using System.Collections.Generic;
using ElephantSocial.Tournament.Model;

namespace ElephantSocial.Tournament
{
	public class TournamentDataStore
	{
		public class OfflineScore
		{
			public int Score { get; set; }

			public long Timestamp { get; set; }
		}

		private static readonly Lazy<TournamentDataStore> _instance;

		private const string TournamentResponseDataStoreKey = "TournamentResponseStoreKey";

		private const string MyTournamentsResponseDataStoreKey = "MyTournamentsResponseKey";

		private const string MyTournamentResultsDataStoreKey = "MyTournamentResultsResponseKey";

		private const string TournamentBoardResponseStoreKey = "TournamentBoardResponseKey";

		private const string OfflineScoresKeyPrefix = "OfflineScores_Tournament_";

		private const string OfflineScoresKeyIndex = "OfflineScores_KeyIndex";

		public static TournamentDataStore Instance => null;

		private static void Save<T>(string saveKey, T data)
		{
		}

		private static bool Load<T>(string key, out T loadedData)
		{
			loadedData = default;
			return false;
		}

		public void SetTournaments(TournamentsResponse tournamentResponse)
		{
		}

		public TournamentsResponse GetTournaments()
		{
			return null;
		}

		public void SetMyTournamentsResponse(MyTournamentsResponse myTournamentsResponse)
		{
		}

		public MyTournamentsResponse GetMyTournamentsResponse()
		{
			return null;
		}

		public void SetMyTournamentResults(MyTournamentResultsResponse data)
		{
		}

		public MyTournamentResultsResponse GetMyTournamentResults()
		{
			return null;
		}

		private string PrepareBoardPrefKey(int tournamentId, int scheduleId)
		{
			return null;
		}

		public TournamentBoardResponse GetTournamentBoardResponse(int tournamentId, int scheduleId)
		{
			return null;
		}

		public void SetTournamentBoardResponse(int tournamentId, int scheduleId, TournamentBoardResponse tournamentBoardResponse)
		{
		}

		private string GetOfflineScoresKey(int tournamentId, int scheduleId)
		{
			return null;
		}

		public void SaveOfflineScore(int tournamentId, int scheduleId, int score)
		{
		}

		public List<OfflineScore> GetOfflineScores(int tournamentId, int scheduleId)
		{
			return null;
		}

		public void DeleteOfflineScores(int tournamentId, int scheduleId)
		{
		}

		public List<(int, int)> GetAllOfflineScoreTournaments()
		{
			return null;
		}

		private string GetStorageKey(int tournamentId, int scheduleId)
		{
			return null;
		}

		private void AddKeyToIndex(string key)
		{
		}

		private void RemoveKeyFromIndex(string key)
		{
		}

		private List<string> GetAllKeysFromIndex()
		{
			return null;
		}

		private void SaveKeyIndex(List<string> keys)
		{
		}

		public void CleanupAllOfflineScores()
		{
		}

		private bool ParseTournamentKey(string key, out int tournamentId, out int scheduleId)
		{
			tournamentId = default;
			scheduleId = default;
			return false;
		}
	}
}
