using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using UnityEngine;

[CreateAssetMenu(fileName = "CollectiblesSO", menuName = "DBs/CollectiblesSO")]
public class CollectiblesSO : ScriptableObject
{
	[Serializable]
	public class CollectibleData
	{
		[Header("Info")]
		public string collectibleId;

		public string collectibleName;

		public Sprite icon;

		public Sprite iconDeactive;

		[TextArea]
		public string description;

		public CollectiblesRarity rarity;

		[Header("Level")]
		public int levelStar;

		public List<int> piecesRequiredPerLevel;

		[HideInInspector]
		public int pieceForLevelUp;

		public List<int> goldRequiredPerStarUp;

		[Header("Stat")]
		public PlayerStatType statType;

		public float activatedStatValue;

		public float value;

		public float increasePerLevel;

		[Header("Special Effects")]
		public List<CollectibleSpecialEffect> specialEffects;

		public float GetStatValue(int level)
		{
			return 0f;
		}

		public float GetStatValue(int level, bool isActivated)
		{
			return 0f;
		}

		public int GetRequiredPiecesForLevel(int level)
		{
			return 0;
		}

		public int GetRequiredPiecesForNextLevel(int currentLevelStar)
		{
			return 0;
		}

		public int GetGoldRequiredForStarUp(int currentLevelStar)
		{
			return 0;
		}

		public bool RequiresPiecesForStarUp(int currentLevelStar)
		{
			return false;
		}

		private int GetShardRequirementBaseByRarity()
		{
			return 0;
		}

		private int GetActivationShardRequirementByRarity()
		{
			return 0;
		}

		public int GetMaxLevel()
		{
			return 0;
		}

		public float GetActiveSpecialEffectValue(ItemSpecialEffect specialEffect, int levelStar)
		{
			return 0f;
		}
	}

	[Serializable]
	public class CollectibleSetData
	{
		[Header("Info")]
		public string setId;

		public string setName;

		[TextArea]
		public string description;

		[Header("Collectibles")]
		public List<string> collectibleIds;

		[Header("Basic Effects")]
		public List<CollectibleSetBonus> basicEffects;

		public bool IsCompleted(Dictionary<string, int> collectibleStarLevels)
		{
			return false;
		}

		public bool IsCompleted(Dictionary<string, bool> collectibleActivationStates)
		{
			return false;
		}

		public bool IsBonusUnlocked(CollectibleSetBonusRequirement requirement, Dictionary<string, int> collectibleStarLevels)
		{
			return false;
		}

		public List<CollectibleSetBonus> GetUnlockedBonuses(Dictionary<string, int> collectibleStarLevels)
		{
			return null;
		}

		public List<CollectibleSetBonus> GetUnlockedBonuses(Dictionary<string, int> collectibleStarLevels, Dictionary<string, bool> collectibleActivationStates)
		{
			return null;
		}

		public float GetActiveBonusValue(PlayerStatType statType, Dictionary<string, int> collectibleStarLevels)
		{
			return 0f;
		}

		public float GetActiveBonusValue(PlayerStatType statType, Dictionary<string, int> collectibleStarLevels, Dictionary<string, bool> collectibleActivationStates)
		{
			return 0f;
		}

		private bool HasRequiredStarLevel(Dictionary<string, int> collectibleStarLevels, int requiredStarLevel)
		{
			return false;
		}

		private bool HasRequiredHighestStarLevel(Dictionary<string, int> collectibleStarLevels, int requiredStarLevel)
		{
			return false;
		}

		private int GetRequiredStarLevel(CollectibleSetBonusRequirement requirement)
		{
			return 0;
		}
	}

	public enum CollectibleSetBonusRequirement
	{
		SetComplete = 0,
		ThreeStar = 1,
		SixStar = 2,
		TenStar = 3
	}

	[Serializable]
	public class CollectibleSetBonus
	{
		public CollectibleSetBonusRequirement requirement;

		public PlayerStatType statType;

		public float value;

		public bool isPercentage;

		[TextArea]
		public string description;
	}

	[Serializable]
	public class CollectibleSpecialEffect
	{
		public ItemSpecialEffect specialEffect;

		[Min(1f)]
		public int requiredStarLevel;

		public float value;

		[TextArea]
		public string description;

		public bool IsUnlocked(int levelStar)
		{
			return false;
		}

		public float GetValue(int level)
		{
			return 0f;
		}
	}

	private const int CollectibleCountPerSet = 4;

	private const int MaxCollectibleLevel = 10;

	[Header("Collectibles")]
	public List<CollectibleData> collectibles;

	[Header("Sets")]
	public List<CollectibleSetData> collectibleSets;

	public CollectibleData GetCollectible(string collectibleId)
	{
		return null;
	}

	public List<CollectibleData> GetCollectiblesByRarity(CollectiblesRarity rarity)
	{
		return null;
	}

	public CollectibleSetData GetSet(string setId)
	{
		return null;
	}

	public List<CollectibleData> GetSetCollectibles(CollectibleSetData setData)
	{
		return null;
	}

	public List<CollectibleSetBonus> GetUnlockedSetBonuses(string setId, Dictionary<string, int> collectibleStarLevels)
	{
		return null;
	}

	public List<CollectibleSetBonus> GetUnlockedSetBonuses(string setId, Dictionary<string, int> collectibleStarLevels, Dictionary<string, bool> collectibleActivationStates)
	{
		return null;
	}

	public float GetActiveSpecialEffectValue(ItemSpecialEffect specialEffect, Dictionary<string, int> collectibleStarLevels)
	{
		return 0f;
	}

	public float GetActiveSpecialEffectValue(ItemSpecialEffect specialEffect, Dictionary<string, int> collectibleStarLevels, Dictionary<string, bool> collectibleActivationStates)
	{
		return 0f;
	}

	private void OnValidate()
	{
	}

	private static void EnsurePiecesRequiredPerLevel(CollectibleData collectible)
	{
	}

	private static void EnsureGoldRequiredPerStarUp(CollectibleData collectible)
	{
	}

	private static List<CollectibleSetBonus> CreateDefaultSetBonuses()
	{
		return null;
	}
}
