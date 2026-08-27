using System;
using Newtonsoft.Json;

namespace ElephantSocial.Team.Model
{
	[Serializable]
	public class TeamStat
	{
		[JsonProperty("previous_stats")]
		public Objective[] PreviousObjectives;

		[JsonProperty("current_stats")]
		public Objective[] CurrentObjectives;
	}
}
