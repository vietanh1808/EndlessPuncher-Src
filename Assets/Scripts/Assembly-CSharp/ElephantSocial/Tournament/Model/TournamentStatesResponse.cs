using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentStatesResponse
	{
		[JsonProperty("tournament_states")]
		public List<StateInfo> tournamentStates;
	}
}
