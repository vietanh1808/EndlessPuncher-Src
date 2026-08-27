using System;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentScoreUpdateWithInfo
	{
		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("social_id")]
		public string SocialId { get; set; }

		[JsonProperty("player_info")]
		public TournamentPlayerInfo PlayerInfo { get; set; }
	}
}
