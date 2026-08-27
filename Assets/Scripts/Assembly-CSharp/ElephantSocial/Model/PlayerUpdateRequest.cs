using System;
using Newtonsoft.Json;

namespace ElephantSocial.Model
{
	[Serializable]
	public class PlayerUpdateRequest : SocialBaseData
	{
		[JsonProperty("player_name")]
		public string playerName;

		[JsonProperty("profile_picture")]
		public string profilePicture;

		public string content;

		public int status;

		public int badge;

		[JsonProperty("level")]
		public long level;

		public PlayerUpdateRequest(Player player)
		{
		}
	}
}
