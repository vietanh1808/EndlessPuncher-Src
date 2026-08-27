using System;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament
{
	[Serializable]
	public class TournamentAndScheduleId
	{
		[JsonProperty("tournament_id")]
		public int tournamentId;

		[JsonProperty("schedule_id")]
		public int scheduleId;

		[JsonProperty("id")]
		private int id
		{
			set
			{
			}
		}
	}
}
