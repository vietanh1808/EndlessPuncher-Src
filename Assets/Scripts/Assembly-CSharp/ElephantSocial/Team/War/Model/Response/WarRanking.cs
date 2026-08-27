using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Response
{
	[Serializable]
	public class WarRanking
	{
		[JsonProperty("board")]
		public WarRankingEntry[] Board;
	}
}
