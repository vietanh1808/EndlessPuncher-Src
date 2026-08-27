using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentAddScoresRequest : BaseTournamentRequest
	{
		[JsonProperty("player_scores")]
		public List<PlayerScore> PlayerScores { get; }

		public TournamentAddScoresRequest(int tournamentId, int scheduleID, List<PlayerScore> scores)
			: base(0, 0)
		{
		}
	}
}
