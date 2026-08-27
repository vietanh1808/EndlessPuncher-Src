using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroAscendConfigData
{
	[Header("Limits")]
	[Min(1f)]
	public int tiersPerStar;

	[Min(0f)]
	public int maxStar;

	[Header("Ascend Table")]
	public List<HeroAscendStarData> starProgression;

	public int GetAscendShardCost(int currentStar)
	{
		return 0;
	}

	public float GetAscendMultiplier(int targetStar, int targetTier)
	{
		return 0f;
	}

	public HeroAscendStarData GetStarData(int star)
	{
		return null;
	}

	public bool TryGetNextAscendTarget(int currentStar, int currentTier, out int targetStar, out int targetTier)
	{
		targetStar = default;
		targetTier = default;
		return false;
	}

	public float CalculateAscendedStat(float currentStat, int currentStar, int currentTier, string statID)
	{
		return 0f;
	}

	public static bool AffectsStat(string statID)
	{
		return false;
	}
}
