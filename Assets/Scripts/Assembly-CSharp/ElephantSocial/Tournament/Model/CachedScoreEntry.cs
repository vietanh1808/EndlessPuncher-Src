using System;

namespace ElephantSocial.Tournament.Model
{
	[Serializable]
	public class CachedScoreEntry
	{
		public int Score { get; set; }

		public int TournamentId { get; set; }

		public int ScheduleId { get; set; }

		public long Date { get; set; }

		public bool Online { get; set; }

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
