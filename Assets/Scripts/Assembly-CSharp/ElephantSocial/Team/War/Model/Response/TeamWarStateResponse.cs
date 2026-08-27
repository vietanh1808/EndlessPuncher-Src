using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.War.Model.Response
{
	[Serializable]
	public class TeamWarStateResponse
	{
		[JsonProperty("state")]
		public WarState State;
	}
}
