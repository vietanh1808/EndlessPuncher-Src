using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model.Response
{
	[Serializable]
	public class PlayerTopStatEntry
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

		[JsonProperty("player")]
		public Player Player;
	}
}
