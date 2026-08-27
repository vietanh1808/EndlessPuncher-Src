using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroAscendStarData
{
	[Min(0f)]
	public int star;

	[Min(0f)]
	public int shardCost;

	public List<HeroAscendTierData> tiers;

	public HeroAscendStarData()
	{
	}

	public HeroAscendStarData(int star, int shardCost, params float[] tierMultipliers)
	{
	}

	public float GetTierMultiplier(int tier)
	{
		return 0f;
	}
}
