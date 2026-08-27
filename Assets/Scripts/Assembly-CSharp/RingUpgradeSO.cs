using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using UnityEngine;

[CreateAssetMenu(fileName = "RingUpgradeSO", menuName = "DBs/RingUpgradeSO")]
public class RingUpgradeSO : ScriptableObject
{
	[Serializable]
	public class RingUpgradeStat
	{
		public PlayerStatType typeStat;

		public float increasePerLevel;

		public string prefix;

		public string suffix;
	}

	[Serializable]
	public class RingSpecialUpgrade
	{
		public ItemSpecialEffect specialEffect;

		public float valueSpecialEffect;

		public string specialDescription;
	}

	private const int StatCount = 3;

	[Header("Level Progression")]
	public int purchaseCountPerStar;

	public int starsPerSpecialLevel;

	[Header("Price")]
	public CurrencyTypes currencyType;

	public float startPrice;

	public float priceIncreasePerPurchase;

	[Header("Offer")]
	public float offerPriceValue;

	public float offerEarnedPriceValue;

	[Header("Stats")]
	public RingUpgradeStat[] stats;

	[Header("Special Upgrades")]
	public List<RingSpecialUpgrade> specialUpgrades;

	[Header("Ring name icons")]
	public string[] ringNames;

	public Sprite[] ringIcons;

	public int GetStarLevel(int purchaseCount)
	{
		return 0;
	}

	public float GetPrice(int purchaseCount)
	{
		return 0f;
	}

	public float GetStarProgress(int purchaseCount)
	{
		return 0f;
	}

	public int GetPurchaseCountInCurrentStar(int purchaseCount)
	{
		return 0;
	}

	public int GetRemainingPurchaseCountForNextStar(int purchaseCount)
	{
		return 0;
	}

	public int GetStatLevel(int purchaseCount)
	{
		return 0;
	}

	public int GetSpecialLevel(int purchaseCount)
	{
		return 0;
	}

	public int GetStarLevelInCurrentSpecialLevel(int purchaseCount)
	{
		return 0;
	}

	public float GetSpecialLevelProgress(int purchaseCount)
	{
		return 0f;
	}

	public string GetRingName(int specialLevel)
	{
		return null;
	}

	public Sprite GetRingIcon(int specialLevel)
	{
		return null;
	}

	public RingUpgradeStat GetStat(int index)
	{
		return null;
	}

	public float GetIncreasePerLevel(PlayerStatType statType)
	{
		return 0f;
	}

	public float GetIncreaseByLevel(PlayerStatType statType, int level)
	{
		return 0f;
	}

	public float GetIncreaseByPurchaseCount(PlayerStatType statType, int purchaseCount)
	{
		return 0f;
	}

	public RingUpgradeStat GetStat(PlayerStatType statType)
	{
		return null;
	}

	public RingSpecialUpgrade GetSpecialUpgradeByLevel(int level)
	{
		return null;
	}

	public RingSpecialUpgrade GetSpecialUpgradeByPurchaseCount(int purchaseCount)
	{
		return null;
	}

	public List<RingSpecialUpgrade> GetActiveSpecialUpgrades(int level)
	{
		return null;
	}

	public float GetActiveSpecialEffectValue(ItemSpecialEffect specialEffect, int level)
	{
		return 0f;
	}

	public List<RingSpecialUpgrade> GetActiveSpecialUpgradesByPurchaseCount(int purchaseCount)
	{
		return null;
	}

	public float GetActiveSpecialEffectValueByPurchaseCount(ItemSpecialEffect specialEffect, int purchaseCount)
	{
		return 0f;
	}

	private void OnValidate()
	{
	}
}
