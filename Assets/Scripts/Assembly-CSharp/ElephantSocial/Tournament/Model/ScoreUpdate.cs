using System;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class ScoreUpdate
	{
		[JsonProperty("social_id")]
		public string SocialId { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

		public ScoreUpdate()
		{
		}

		public ScoreUpdate(string socialId, int score)
		{
		}
	}
}
