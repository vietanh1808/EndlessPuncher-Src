using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament
{
	[Serializable]
	public class MyTournamentResultsResponse
	{
		[JsonProperty("tournaments")]
		public List<TournamentData> myTournamentResults;
	}
}
