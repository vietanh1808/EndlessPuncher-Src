using System.Collections.Generic;
using Fubu.Inventory.DB;
using UnityEngine;

public class CollectiblesInGameEffects : MonoBehaviour
{
	private static CollectiblesInGameEffects _instance;

	[SerializeField]
	private CollectiblesSO collectiblesSO;

	[SerializeField]
	private bool refreshOnEnable;

	private readonly Dictionary<PlayerStatType, float> statValues;

	private readonly Dictionary<PlayerStatType, float> setPercentValues;

	private readonly Dictionary<ItemSpecialEffect, float> specialEffectValues;

	private readonly Dictionary<string, int> collectibleStarLevels;

	private readonly Dictionary<string, bool> collectibleActivationStates;

	public static CollectiblesInGameEffects Instance => null;

	public IReadOnlyDictionary<string, int> CollectibleStarLevels => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void SetCollectiblesSO(CollectiblesSO value, bool refreshImmediately = true)
	{
	}

	public void Refresh()
	{
	}

	public float GetStatValue(PlayerStatType statType)
	{
		return 0f;
	}

	public float GetSetPercentValue(PlayerStatType statType)
	{
		return 0f;
	}

	public float GetSpecialEffectValue(ItemSpecialEffect specialEffect)
	{
		return 0f;
	}

	public bool HasSpecialEffect(ItemSpecialEffect specialEffect, out float value)
	{
		value = default;
		return false;
	}

	public float GetTotalPower()
	{
		return 0f;
	}

	private CollectiblesSO GetActiveCollectiblesSO()
	{
		return null;
	}

	private void CacheCollectibleStars(CollectiblesSO activeCollectiblesSO)
	{
	}

	private void CacheCollectibleStats(CollectiblesSO activeCollectiblesSO)
	{
	}

	private void CacheSetBonuses(CollectiblesSO activeCollectiblesSO)
	{
	}

	private void CacheSpecialEffectsFromActiveCollectibles(CollectiblesSO activeCollectiblesSO)
	{
	}

	private Dictionary<PlayerStatType, CollectiblesSO.CollectibleSetBonus> GetHighestSetBonusesByStat(List<CollectiblesSO.CollectibleSetBonus> bonuses)
	{
		return null;
	}

	private void AddUnlockedSpecialEffects(CollectiblesSO.CollectibleData collectible, int levelStar)
	{
	}

	private void AddStatValue(PlayerStatType statType, float value)
	{
	}

	private void AddSetPercentValue(PlayerStatType statType, float value)
	{
	}

	private void AddSpecialEffectValue(ItemSpecialEffect specialEffect, float value)
	{
	}

	private int GetRequirementStarLevel(CollectiblesSO.CollectibleSetBonusRequirement requirement)
	{
		return 0;
	}
}
