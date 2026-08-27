using System;
using ElephantSDK;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class GeneralTournamentRequest : BaseData
	{
		[JsonProperty("elephant_id")]
		public string elephantId;
	}
}
