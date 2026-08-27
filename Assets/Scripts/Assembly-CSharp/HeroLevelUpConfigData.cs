using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroLevelUpConfigData
{
	[Header("Currency")]
	public string levelUpCurrencyName;

	[Header("Limits")]
	[Min(1f)]
	public int maxLevel;

	[Header("Upgrade Cost")]
	[Min(0f)]
	public int baseUpgradeCost;

	[Min(1f)]
	public int costIncreaseInterval;

	[Min(1f)]
	public float costMultiplier;

	[Header("Level Groups")]
	public List<HeroLevelGroupData> levelGroups;

	public int GetUpgradeCost(int currentLevel)
	{
		return 0;
	}

	public HeroLevelGroupData GetLevelGroup(int level)
	{
		return null;
	}

	public float GetStatMultiplier(int level, string statID)
	{
		return 0f;
	}

	public float CalculateLevelStat(float baseStat, int currentLevel, string statID)
	{
		return 0f;
	}
}
