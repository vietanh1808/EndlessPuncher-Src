using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Request
{
	[Serializable]
	public class TeamWarPhaseRankingRequest : TeamWarRankingRequest
	{
		[JsonProperty("phase")]
		public int Phase;
	}
}
