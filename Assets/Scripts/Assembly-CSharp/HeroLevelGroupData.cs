using System;
using UnityEngine;

[Serializable]
public class HeroLevelGroupData
{
	[Min(1f)]
	public int minLevel;

	[Min(1f)]
	public int maxLevel;

	[Min(0f)]
	public int requiredRingTier;

	[Min(0f)]
	public float damageMultiplier;

	[Min(0f)]
	public float healthMultiplier;

	[Min(0f)]
	public float defenseMultiplier;

	public HeroLevelGroupData()
	{
	}

	public HeroLevelGroupData(int minLevel, int maxLevel, int requiredRingTier, float damageMultiplier, float healthMultiplier, float defenseMultiplier)
	{
	}

	public float GetStatMultiplier(string statID)
	{
		return 0f;
	}
}
