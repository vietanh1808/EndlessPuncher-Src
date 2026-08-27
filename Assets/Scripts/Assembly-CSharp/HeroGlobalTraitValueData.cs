using System;
using UnityEngine;

[Serializable]
public class HeroGlobalTraitValueData
{
	public HeroGlobalTraitType traitType;

	[Min(0f)]
	public float uncommonValue;

	[Min(0f)]
	public float rareValue;

	[Min(0f)]
	public float epicValue;

	[Min(0f)]
	public float legendaryValue;

	public HeroGlobalTraitValueData()
	{
	}

	public HeroGlobalTraitValueData(HeroGlobalTraitType traitType, float uncommonValue, float rareValue, float epicValue, float legendaryValue)
	{
	}

	public float GetValue(HeroTraitRarity rarity)
	{
		return 0f;
	}
}
