using Newtonsoft.Json;

namespace ElephantSocial.Chat.Model
{
	public class MemberLeftData
	{
		[JsonProperty("social_id")]
		public string SocialId { get; set; }

		[JsonProperty("player_name")]
		public string PlayerName { get; set; }

		[JsonProperty("profile_picture")]
		public string ProfilePicture { get; set; }

		[JsonProperty("team_id")]
		public string TeamId { get; set; }
	}
}
