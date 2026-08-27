using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Team.CoopEvent.Model.Request
{
	[Serializable]
	public class TeamCoopEventRequest : SocialBaseData
	{
		[JsonProperty("coop_event_id")]
		public int CoopEventId;
	}
}
