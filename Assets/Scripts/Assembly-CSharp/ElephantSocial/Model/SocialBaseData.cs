using System;
using ElephantSDK;
using Newtonsoft.Json;

namespace ElephantSocial.Model
{
	[Serializable]
	public class SocialBaseData : BaseData
	{
		[JsonProperty("request_id")]
		public long requestId;
	}
}
