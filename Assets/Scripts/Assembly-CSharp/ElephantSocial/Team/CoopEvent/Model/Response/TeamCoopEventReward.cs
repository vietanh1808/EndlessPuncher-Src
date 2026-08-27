using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.CoopEvent.Model.Response
{
	[Serializable]
	public class TeamCoopEventReward
	{
		[JsonProperty("reward_id")]
		public int RewardId;

		[JsonProperty("goal")]
		public long Goal;

		[JsonProperty("claimed")]
		public bool Claimed;
	}
}
