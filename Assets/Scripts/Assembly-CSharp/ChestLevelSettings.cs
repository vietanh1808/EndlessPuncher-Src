using System;
using System.Collections.Generic;
using UnityEngine;

public class ChestLevelSettings : MonoBehaviour
{
	[Serializable]
	public class CommonChestLevelDefinition
	{
		public int requiredKeysToLevelUp;

		[Range(0f, 100f)]
		public float commonChance;

		[Range(0f, 100f)]
		public float uncommonChance;

		[Range(0f, 100f)]
		public float collectibleKeyChance;
	}

	[Serializable]
	public class EpicChestLevelDefinition
	{
		public int requiredKeysToLevelUp;

		[Range(0f, 100f)]
		public float uncommonChance;

		[Range(0f, 100f)]
		public float rareChance;

		[Range(0f, 100f)]
		public float epicChance;

		[Range(0f, 100f)]
		public float legendaryChance;

		[Range(0f, 100f)]
		public float collectibleKeyChance;
	}

	[Serializable]
	public class CollectibleChestDefinition
	{
		[Range(0f, 100f)]
		public float collectibleChance;

		[Range(0f, 100f)]
		public float currencyChance;

		public int minPieces;

		public int maxPieces;

		[Range(0f, 100f)]
		public float commonChance;

		[Range(0f, 100f)]
		public float uncommonChance;

		[Range(0f, 100f)]
		public float rareChance;

		[Range(0f, 100f)]
		public float epicChance;

		[Range(0f, 100f)]
		public float legendaryChance;

		[Range(0f, 100f)]
		public float mysticalChance;

		public List<CurrencyRewardDefinition> currencyRewards;
	}

	[Serializable]
	public class CollectibleChestLevelDefinition : CollectibleChestDefinition
	{
		public int requiredKeysToLevelUp;
	}

	[Serializable]
	public class HeroChestLevelDefinition
	{
		public int requiredKeysToLevelUp;

		[Range(0f, 100f)]
		public float srShardChance;

		[Range(0f, 100f)]
		public float ssrShardChance;

		[Range(0f, 100f)]
		public float urShardChance;

		[Range(0f, 100f)]
		public float srFullHeroChance;

		[Range(0f, 100f)]
		public float ssrFullHeroChance;

		[Range(0f, 100f)]
		public float urFullHeroChance;

		[Range(0f, 100f)]
		public float heroCurrencyChance;

		public CurrencyTypes heroCurrencyType;

		public int minHeroCurrencyAmount;

		public int maxHeroCurrencyAmount;
	}

	[Serializable]
	public class CurrencyRewardDefinition
	{
		public CurrencyTypes currencyType;

		[Range(0f, 100f)]
		public float chance;

		public int minAmount;

		public int maxAmount;
	}

	private struct ChanceAccessor
	{
		public readonly Func<float> Get;

		public readonly Action<float> Set;

		public ChanceAccessor(Func<float> get, Action<float> set)
		{
			Get = null;
			Set = null;
		}
	}

	private const float TotalChance = 100f;

	private const int FirstLevelRequiredKeys = 10;

	private const int RequiredKeysStep = 5;

	private const float CommonChestCollectibleKeyChance = 3f;

	private const float EpicChestCollectibleKeyChance = 5f;

	private const float CollectibleLevelCurrencyChance = 20f;

	[Header("Common Chest Levels")]
	[SerializeField]
	private List<CommonChestLevelDefinition> commonChestLevels;

	[Header("Epic Chest Levels")]
	[SerializeField]
	private List<EpicChestLevelDefinition> epicChestLevels;

	[Header("Collectible Chest")]
	[SerializeField]
	private CollectibleChestDefinition collectibleChestDefinition;

	[Header("Collectible Chest Levels")]
	[SerializeField]
	private List<CollectibleChestLevelDefinition> collectibleChestLevels;

	[Header("Hero Chest Levels")]
	[SerializeField]
	private List<HeroChestLevelDefinition> heroChestLevels;

	public List<CommonChestLevelDefinition> CommonChestLevels => null;

	public List<EpicChestLevelDefinition> EpicChestLevels => null;

	public CollectibleChestDefinition CollectibleChestBaseDefinition => null;

	public List<CollectibleChestLevelDefinition> CollectibleChestLevels => null;

	public List<HeroChestLevelDefinition> HeroChestLevels => null;

	private void OnValidate()
	{
	}

	public void NormalizeAll()
	{
	}

	private static int GetRequiredKeysForLevelIndex(int levelIndex)
	{
		return 0;
	}

	public static void NormalizeCommon(CommonChestLevelDefinition level)
	{
	}

	public static void NormalizeEpic(EpicChestLevelDefinition level)
	{
	}

	public static void NormalizeCollectible(CollectibleChestDefinition level)
	{
	}

	public static void NormalizeHero(HeroChestLevelDefinition level)
	{
	}

	private static void NormalizeToTotal(float total, params ChanceAccessor[] accessors)
	{
	}

	public static float RoundChance(float value)
	{
		return 0f;
	}
}
