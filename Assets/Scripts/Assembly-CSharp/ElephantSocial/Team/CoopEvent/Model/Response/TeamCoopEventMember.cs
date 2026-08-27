using System;
using ElephantSocial.Team.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Team.CoopEvent.Model.Response
{
	[Serializable]
	public class TeamCoopEventMember
	{
		[JsonProperty("social_id")]
		public string SocialId;

		[JsonProperty("score")]
		public int Score;

		[JsonProperty("player_info")]
		public PlayerInfo PlayerInfo;
	}
}
