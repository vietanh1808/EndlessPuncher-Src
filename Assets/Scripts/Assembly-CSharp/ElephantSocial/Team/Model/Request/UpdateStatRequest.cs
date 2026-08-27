using ElephantSocial.Model;
using ElephantSocial.Team.Model.Enum;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model.Request
{
	public class UpdateStatRequest : SocialBaseData
	{
		[JsonProperty("stat_meta_id")]
		public string StatMetaId { get; set; }

		[JsonProperty("op")]
		[JsonConverter(typeof(StatOpJsonConverter))]
		public StatOp Op { get; set; }

		[JsonProperty("val")]
		public long Val { get; set; }
	}
}
