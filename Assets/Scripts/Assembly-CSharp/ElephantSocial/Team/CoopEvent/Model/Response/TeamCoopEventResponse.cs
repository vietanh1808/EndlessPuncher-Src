using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.CoopEvent.Model.Response
{
	[Serializable]
	public class TeamCoopEventResponse
	{
		[JsonProperty("id")]
		public int Id;

		[JsonProperty("name")]
		public string Name;

		[JsonProperty("description")]
		public string Description;

		[JsonProperty("total_score")]
		public long TotalScore;

		[JsonProperty("end_date")]
		public long EndDate;

		[JsonProperty("members")]
		public TeamCoopEventMember[] Members;

		[JsonProperty("rewards")]
		public TeamCoopEventReward[] Rewards;

		[JsonProperty("schedule_id")]
		public int ScheduleId;
	}
}
