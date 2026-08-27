using UnityEngine;

namespace Fubu.Stats
{
	[CreateAssetMenu(fileName = "StatsDB", menuName = "Fubu/Stats/StatsDB")]
	public class StatsDB : ScriptableObject
	{
		[SerializeField]
		private Stat[] stats;

		public Stat GetStat(StatTypes statType)
		{
			return null;
		}
	}
}
