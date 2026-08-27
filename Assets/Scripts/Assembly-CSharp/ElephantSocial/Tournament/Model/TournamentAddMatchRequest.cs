using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentAddMatchRequest : BaseTournamentRequest
	{
		[JsonProperty("score_updates")]
		public List<ScoreUpdate> ScoreUpdates { get; }

		public TournamentAddMatchRequest(int tournamentId, int scheduleID, List<ScoreUpdate> updates)
			: base(0, 0)
		{
		}
	}
}
