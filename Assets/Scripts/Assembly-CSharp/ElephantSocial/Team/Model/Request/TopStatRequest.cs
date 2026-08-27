using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model.Request
{
	public class TopStatRequest : SocialBaseData
	{
		[JsonProperty("stat_meta_id")]
		public string StatMetaId { get; set; }

		[JsonProperty("limit")]
		public int Limit { get; set; }
	}
}
