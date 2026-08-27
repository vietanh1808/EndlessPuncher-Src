using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentFinishRequest : SocialBaseData
	{
		[JsonProperty("tournament_id")]
		public int tournamentId;

		[JsonProperty("schedule_id")]
		public int scheduleID;

		public TournamentFinishRequest(int tournamentId, int scheduleID)
		{
		}
	}
}
