using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ElephantSocial.Model;
using ElephantSocial.Tournament.Model;

namespace ElephantSocial.Tournament
{
	public class Tournament
	{
		[CompilerGenerated]
		private static Action m_OnTournamentJoined;

		public TournamentData TournamentData;

		private readonly TournamentRepository _tournamentRepository;

		public bool HasJoined;

		public int TournamentId => 0;

		public long StartTime => 0L;

		public long EndTime => 0L;

		internal static event Action OnTournamentJoined
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Tournament(TournamentData tournamentData)
		{
		}

		public bool IsRunning()
		{
			return false;
		}

		public void Join(Action<List<BoardPlayer>> onResponse, Action<string> onError, int segmentId = 0)
		{
		}

		public void AddScore(int score, Action onResponse, Action<string> onError)
		{
		}

		public void AddMatch(List<ScoreUpdate> scoreUpdates, Action onResponse, Action<string> onError)
		{
		}

		public void ListMatches(Action<List<TournamentMatchItem>> onResponse, Action<string> onError)
		{
		}

		public void GetBoard(Action<List<BoardPlayer>> onResponse)
		{
		}

		public long GetRemainingSeconds()
		{
			return 0L;
		}
	}
}
