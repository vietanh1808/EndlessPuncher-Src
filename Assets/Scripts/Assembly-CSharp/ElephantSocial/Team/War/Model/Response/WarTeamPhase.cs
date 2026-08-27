using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Response
{
	[Serializable]
	public class WarTeamPhase
	{
		[JsonProperty("team_id")]
		public string TeamId;

		[JsonProperty("phase_score")]
		public long PhaseScore;

		[JsonProperty("mvp_social_id")]
		public string MvpSocialId;
	}
}
