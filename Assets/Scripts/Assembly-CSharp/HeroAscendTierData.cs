using System;
using UnityEngine;

[Serializable]
public class HeroAscendTierData
{
	[Min(1f)]
	public int tier;

	[Min(0f)]
	public float statMultiplier;

	public HeroAscendTierData()
	{
	}

	public HeroAscendTierData(int tier, float statMultiplier)
	{
	}
}
