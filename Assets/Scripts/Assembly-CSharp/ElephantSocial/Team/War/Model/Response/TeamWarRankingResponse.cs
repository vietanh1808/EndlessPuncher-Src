using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Response
{
	[Serializable]
	public class TeamWarRankingResponse
	{
		[JsonProperty("ranking")]
		public WarRanking Ranking;
	}
}
