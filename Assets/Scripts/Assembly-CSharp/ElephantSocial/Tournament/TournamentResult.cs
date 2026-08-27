using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ElephantSocial.Model;

namespace ElephantSocial.Tournament
{
	public class TournamentResult
	{
		public TournamentData TournamentData;

		private readonly TournamentRepository _tournamentRepository;

		[CompilerGenerated]
		private static Action<int, int> m_OnTournamentClaimed;

		public int TournamentId => 0;

		internal static event Action<int, int> OnTournamentClaimed
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

		public TournamentResult(TournamentData tournamentData)
		{
		}

		public void GetBoard(Action<List<BoardPlayer>> onResponse)
		{
		}

		public void Claim(Action onResponse, Action<string> onError)
		{
		}
	}
}
