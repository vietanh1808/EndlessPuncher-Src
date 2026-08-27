using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentListMatchesResponse
	{
		[JsonProperty("matches")]
		public List<TournamentMatchItem> Matches { get; set; }
	}
}
