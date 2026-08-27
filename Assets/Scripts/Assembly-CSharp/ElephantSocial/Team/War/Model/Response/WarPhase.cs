using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Response
{
	[Serializable]
	public class WarPhase
	{
		[JsonProperty("phase")]
		public int Phase;

		[JsonProperty("phase_ends_at")]
		public string PhaseEndsAt;

		[JsonProperty("mine")]
		public WarTeamPhase Mine;

		[JsonProperty("enemy")]
		public WarTeamPhase Enemy;
	}
}
