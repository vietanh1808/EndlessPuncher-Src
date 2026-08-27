using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Team.CoopEvent.Model.Request
{
	[Serializable]
	public class TeamCoopEventIncrementRequest : SocialBaseData
	{
		[JsonProperty("coop_event_id")]
		public int CoopEventId;

		[JsonProperty("score")]
		public long Score;
	}
}
