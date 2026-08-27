using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model
{
	[Serializable]
	public class TeamMemberResponse
	{
		[JsonProperty("helps")]
		public int Helps;

		[JsonProperty("player_info")]
		public PlayerInfo PlayerInfo;

		[JsonProperty("role")]
		public int Role;

		[JsonProperty("score")]
		public int Score;

		[JsonProperty("score_2")]
		public int Score2;

		[JsonProperty("social_id")]
		public string SocialId;

		[JsonProperty("team_id")]
		public string TeamId;

		[JsonProperty("status")]
		public int Status;

		[JsonProperty("stats")]
		public MemberStat[] Stats;
	}
}
