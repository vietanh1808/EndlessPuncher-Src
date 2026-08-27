using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TierValueConfigs", menuName = "DBs/TierValueConfigs", order = 0)]
public class TalentTierDB : ScriptableObject
{
	[Serializable]
	public class TierValuePerLevel
	{
		public int level;

		public TierToCount[] tierCC;

		public TalentRarity GetTierThisRatio(int value)
		{
			return TalentRarity.Common;
		}
	}

	[Serializable]
	public class TierToCount
	{
		public int percentage;

		public TalentRarity tier;
	}

	public List<TierValuePerLevel> TierValuePersForWeapon;

	public TalentRarity GetTalent(int value)
	{
		return TalentRarity.Common;
	}
}
