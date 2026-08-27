using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentMatchItem
	{
		[JsonProperty("game_id")]
		public int GameId { get; set; }

		[JsonProperty("server_id")]
		public int ServerId { get; set; }

		[JsonProperty("tournament_id")]
		public int TournamentId { get; set; }

		[JsonProperty("schedule_id")]
		public int ScheduleId { get; set; }

		[JsonProperty("metadata")]
		public string Metadata { get; set; }

		[JsonProperty("score_updates")]
		public List<TournamentScoreUpdateWithInfo> ScoreUpdates { get; set; }

		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }
	}
}
