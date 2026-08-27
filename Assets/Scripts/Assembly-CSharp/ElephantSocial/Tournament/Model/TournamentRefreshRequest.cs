using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentRefreshRequest : SocialBaseData
	{
		[JsonProperty("tournament_id")]
		public int tournamentId;

		[JsonProperty("schedule_id")]
		public int scheduleId;

		public TournamentRefreshRequest(int tournamentId, int scheduleId)
		{
		}
	}
}
