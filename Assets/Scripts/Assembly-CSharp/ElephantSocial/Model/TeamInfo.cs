using System;
using Newtonsoft.Json;

namespace ElephantSocial.Model
{
	[Serializable]
	public class TeamInfo
	{
		[JsonProperty("team_id")]
		public string teamId;

		[JsonProperty("team_name")]
		public string teamName;
	}
}
