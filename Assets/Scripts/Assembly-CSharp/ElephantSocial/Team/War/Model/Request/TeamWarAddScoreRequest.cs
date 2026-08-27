using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Request
{
	[Serializable]
	public class TeamWarAddScoreRequest : TeamWarRequest
	{
		[JsonProperty("score")]
		public long Score;

		[JsonProperty("phase")]
		public int Phase;
	}
}
