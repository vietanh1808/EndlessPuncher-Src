using System;
using UnityEngine;

namespace Fubu.Forge
{
	[Serializable]
	public class SlotStat
	{
		[SerializeField]
		private StatType statType;

		[SerializeField]
		private double statValue;

		[SerializeField]
		private double baseDamage;

		public StatType StatType => StatType.Damage;

		public double StatValue => 0.0;

		public double BaseDamage => 0.0;

		public SlotStat(StatType statType, double statValue, double baseDamage)
		{
		}
	}
}
