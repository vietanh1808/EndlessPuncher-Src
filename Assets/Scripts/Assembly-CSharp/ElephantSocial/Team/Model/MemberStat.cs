using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model
{
	[Serializable]
	public class MemberStat
	{
		[JsonProperty("name")]
		public string Name;

		[JsonProperty("stat_meta_id")]
		public string StatMetaId;

		[JsonProperty("schedule_id")]
		public long ScheduleId;

		[JsonProperty("value")]
		public long Value;
	}
}
