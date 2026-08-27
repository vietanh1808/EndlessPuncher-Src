using System;
using ElephantSocial.Model;
using Newtonsoft.Json;

namespace ElephantSocial.HonorWall
{
	[Serializable]
	public class HonorWallGrantRequest : SocialBaseData
	{
		[JsonProperty("id")]
		public int id;
	}
}
