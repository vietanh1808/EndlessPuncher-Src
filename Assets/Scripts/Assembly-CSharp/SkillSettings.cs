using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillSettings", menuName = "Fubu/SkillCards/SkillSettings")]
public class SkillSettings : ScriptableObject
{
	public CurrencyTypes drawSingleCurrency;

	public int drawSingleCost;

	public CurrencyTypes drawMultipleCurrency;

	public int drawMultipleCost;

	public int drawMultipleCount;

	public StatSettings statSettings;

	public int baseUpgradeCardCount;

	public int upgradeCardCountPerLevel;

	public int baseCardCountForLevelUp;

	public float increaseNeededCardPerLevel;

	public string skillsFolderPath;

	public List<Skill> skills;

	public RaritySettings raritySettings;

	public int maxLevel;

	public float rarityWeightIncreasePerLevel;

	public List<int> nextRarityUnlockLevels;

	[HideInInspector]
	public List<LevelRarityWeights> rarityWeightsPerLevel;

	public void ScanAssets()
	{
	}

	public void GenerateRarityWeights()
	{
	}

	private int ComputeGrowingRarityCount(int level)
	{
		return 0;
	}

	public float GetRarityWeight(Rarity rarity, int level)
	{
		return 0f;
	}
}
