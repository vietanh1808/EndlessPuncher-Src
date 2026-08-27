using System;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentRequest : BaseTournamentRequest
	{
		public TournamentRequest(int tournamentId, int scheduleID)
			: base(0, 0)
		{
		}
	}
}
