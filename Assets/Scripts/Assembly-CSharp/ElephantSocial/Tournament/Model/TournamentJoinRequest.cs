using System;
using Newtonsoft.Json;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class TournamentJoinRequest : BaseTournamentRequest
	{
		[JsonProperty("segment_id")]
		public int SegmentId;

		public TournamentJoinRequest(int tournamentId, int scheduleID, int segmentId)
			: base(0, 0)
		{
		}
	}
}
