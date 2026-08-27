using System;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentPlayerInfo
	{
		[JsonProperty("player_name")]
		public string PlayerName { get; set; }

		[JsonProperty("profile_picture")]
		public string ProfilePicture { get; set; }

		[JsonProperty("status")]
		public int Status { get; set; }

		[JsonProperty("badge")]
		public int Badge { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
