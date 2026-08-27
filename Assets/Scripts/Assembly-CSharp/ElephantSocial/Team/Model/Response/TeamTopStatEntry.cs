using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model.Response
{
	[Serializable]
	public class TeamTopStatEntry
	{
		[JsonProperty("name")]
		public string Name;

		[JsonProperty("stat_meta_id")]
		public string StatMetaId;

		[JsonProperty("schedule_id")]
		public long ScheduleId;

		[JsonProperty("dimension")]
		public string Dimension;

		[JsonProperty("value")]
		public long Value;

		[JsonProperty("team")]
		public TeamResponse Team;
	}
}
