using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroGlobalTraitConfigData
{
	[Header("Trait Bonus Table")]
	public List<HeroGlobalTraitValueData> traitValues;

	public float GetTraitValue(HeroGlobalTraitType traitType, HeroTraitRarity rarity)
	{
		return 0f;
	}

	public float GetTotalGlobalBonus(HeroData heroData, HeroProgressData progressData, HeroGlobalTraitType traitType)
	{
		return 0f;
	}

	public List<HeroTraitStarRewardData> GetUnlockedTraitRewards(HeroData heroData, int currentStar)
	{
		return null;
	}

	private HeroGlobalTraitValueData GetTraitValueData(HeroGlobalTraitType traitType)
	{
		return null;
	}
}
