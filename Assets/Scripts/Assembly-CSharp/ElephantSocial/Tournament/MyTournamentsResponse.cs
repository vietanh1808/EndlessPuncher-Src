using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament
{
	[Serializable]
	public class MyTournamentsResponse
	{
		[JsonProperty("tournaments")]
		public List<TournamentAndScheduleId> myTournamentIds;
	}
}
