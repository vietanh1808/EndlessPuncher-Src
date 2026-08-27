using System;
using UnityEngine;

[Serializable]
public class HeroProgressData
{
	public string heroID;

	public bool isUnlocked;

	[Min(0f)]
	public int currentShardAmount;

	[Min(1f)]
	public int currentLevel;

	[Min(0f)]
	public int currentTier;

	[Min(0f)]
	public int currentStar;

	public HeroProgressData()
	{
	}

	public HeroProgressData(string heroID)
	{
	}
}
