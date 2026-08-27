using System;
using UnityEngine;

[Serializable]
public class HeroTraitStarRewardData
{
	[Min(1f)]
	public int requiredStar;

	public HeroTraitRarity rarity;

	public HeroGlobalTraitType traitType;

	public HeroTraitStarRewardData()
	{
	}

	public HeroTraitStarRewardData(int requiredStar, HeroTraitRarity rarity, HeroGlobalTraitType traitType)
	{
	}
}
