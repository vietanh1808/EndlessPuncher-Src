using System;
using Newtonsoft.Json;

namespace ElephantSocial.HonorWall
{
	[Serializable]
	public class Honor
	{
		public int id { get; set; }

		[JsonProperty("name")]
		public string name { get; set; }

		[JsonProperty("description")]
		public string description { get; set; }

		[JsonProperty("social_id")]
		public string social_id { get; set; }

		[JsonProperty("player_name")]
		public string player_name { get; set; }

		[JsonProperty("unlocked_at")]
		public long unlocked_at { get; set; }
	}
}
