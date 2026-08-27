using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Response
{
	[Serializable]
	public class WarRankingEntry
	{
		[JsonProperty("social_id")]
		public string SocialId;

		[JsonProperty("score")]
		public long Score;
	}
}
