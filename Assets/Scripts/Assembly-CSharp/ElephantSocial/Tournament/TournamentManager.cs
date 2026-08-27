using System;
using System.Collections.Generic;

namespace ElephantSocial.Tournament
{
	public static class TournamentManager
	{
		private static readonly TournamentManagerService Service;

		public static event Action OnTournamentsUpdated
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void Init(Action onInitialized)
		{
		}

		public static List<Tournament> GetTournaments()
		{
			return null;
		}

		public static Tournament GetTournamentById(int tournamentId)
		{
			return null;
		}

		public static TournamentResult GetTournamentResultById(int tournamentId)
		{
			return null;
		}

		public static long GetServerTime()
		{
			return 0L;
		}

		public static void IsOnline(Action<bool> onResult)
		{
		}
	}
}
