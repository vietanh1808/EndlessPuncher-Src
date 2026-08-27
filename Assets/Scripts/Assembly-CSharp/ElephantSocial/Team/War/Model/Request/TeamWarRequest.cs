using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Request
{
	[Serializable]
	public class TeamWarRequest : SocialBaseData
	{
		[JsonProperty("team_war_id")]
		public string TeamWarId;
	}
}
