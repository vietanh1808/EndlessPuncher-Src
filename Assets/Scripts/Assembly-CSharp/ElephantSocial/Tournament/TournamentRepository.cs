using System;
using System.Collections.Generic;
using ElephantSocial.Tournament.Model;
using ElephantSocial.Tournament.Network;

namespace ElephantSocial.Tournament
{
	public class TournamentRepository
	{
		private readonly TournamentOps _tournamentOps;

		public void GetTournaments(Action<TournamentsResponse> onResponse)
		{
		}

		public void GetMyTournaments(Action<MyTournamentsResponse> onResponse)
		{
		}

		public void GetBoard(int tournamentId, int scheduleId, Action<TournamentBoardResponse> onResponse)
		{
		}

		public void GetMyTournamentResults(Action<MyTournamentResultsResponse> onResponse)
		{
		}

		public void JoinTournament(int tournamentId, int scheduleId, int segmentId, Action<TournamentJoinResponse> onResponse, Action<string> onError)
		{
		}

		public void ClaimTournament(int tournamentId, int scheduleId, Action onResponse, Action<string> onError)
		{
		}

		public void AddScore(int tournamentId, int scheduleId, int score, Action<int> onSuccess, Action<string> onError)
		{
		}

		public void AddMatch(int tournamentId, int scheduleId, List<ScoreUpdate> updates, Action onSuccess, Action<string> onError)
		{
		}

		public void ListMatches(int tournamentId, int scheduleId, Action<List<TournamentMatchItem>> onResponse, Action<string> onError)
		{
		}

		public void SyncOfflineScores(int tournamentId, int scheduleId)
		{
		}
	}
}
