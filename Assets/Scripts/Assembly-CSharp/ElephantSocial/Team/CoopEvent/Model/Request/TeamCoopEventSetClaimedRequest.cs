using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Team.CoopEvent.Model.Request
{
	[Serializable]
	public class TeamCoopEventSetClaimedRequest : SocialBaseData
	{
		[JsonProperty("coop_event_id")]
		public int CoopEventId;

		[JsonProperty("reward_id")]
		public int RewardId;

		[JsonProperty("schedule_id")]
		public int ScheduleId;
	}
}
