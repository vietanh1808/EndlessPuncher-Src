using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Response
{
	[Serializable]
	public class WarState
	{
		[JsonProperty("end_date")]
		public string EndDate;

		[JsonProperty("phase_1_start_date")]
		public string Phase1StartDate;

		[JsonProperty("my_team_id")]
		public string MyTeamId;

		[JsonProperty("enemy_team_id")]
		public string EnemyTeamId;

		[JsonProperty("phases")]
		public WarPhase[] Phases;

		[JsonProperty("outcome")]
		public string Outcome;

		[JsonIgnore]
		public DateTime EndDateUtc => default;

		[JsonIgnore]
		public DateTime StartDateUtc => default;

		[JsonIgnore]
		public bool IsFinished => false;

		private static DateTime ParseUtc(string s)
		{
			return default;
		}
	}
}
