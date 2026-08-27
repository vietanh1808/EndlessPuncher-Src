using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Request
{
	[Serializable]
	public class TeamWarRankingRequest : TeamWarRequest
	{
		[JsonProperty("team_id", NullValueHandling = NullValueHandling.Ignore)]
		public string TeamId;
	}
}
