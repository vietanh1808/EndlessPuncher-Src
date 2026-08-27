using System;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class PlayerScore
	{
		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("date")]
		public long Date { get; set; }

		[JsonProperty("online")]
		public bool Online { get; set; }

		public PlayerScore()
		{
		}

		public PlayerScore(int score, long date, bool online)
		{
		}
	}
}
