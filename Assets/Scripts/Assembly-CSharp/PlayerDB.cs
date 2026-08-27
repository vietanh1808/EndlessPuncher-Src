using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDB", menuName = "DBs/PlayerDB")]
public class PlayerDB : ScriptableObject
{
	[Serializable]
	public class Player
	{
		public PlayerTypes typePlayer;

		public List<PlayerStat> playerStats;
	}

	[Serializable]
	public class PlayerStat
	{
		public PlayerStatType statType;

		public float statStartValue;

		public float statIncreaseAmount;

		public float roomStatValue;

		public float GetStatValue()
		{
			return 0f;
		}
	}

	[Serializable]
	public class CollectedStat
	{
		public PlayerStatType statType;

		public float statAmount;

		public CollectedStat(PlayerStatType statType, float statAmount)
		{
		}
	}

	[Serializable]
	public class SerializableList<T>
	{
		public List<T> list;
	}

	[Serializable]
	public class TotalPower
	{
		public PlayerStatType statType;

		public float statMassValue;
	}

	[Serializable]
	public class SpecialBonusPower
	{
		public ItemSpecialEffect specialEffectType;

		public float effectMassValue;
	}

	public const float MaxPermanentPunchRange = 6f;

	[Header("Rank Reward Stats")]
	[SerializeField]
	private float rankUpDamageReward;

	[SerializeField]
	private float rankUpHpReward;

	[SerializeField]
	private float rankUpDefenceReward;

	[SerializeField]
	private float rankUpDamageRewardMultiplier;

	[SerializeField]
	private float rankUpHpRewardMultiplier;

	[SerializeField]
	private float rankUpDefenceRewardMultiplier;

	public List<Player> allPlayers;

	public List<CollectedStat> allRoomStats;

	public List<TotalPower> totalPowers;

	public List<SpecialBonusPower> specialBonusPowers;

	public float GetPlayerStats(PlayerTypes player, PlayerStatType statType)
	{
		return 0f;
	}

	private void CalculateRoomStats()
	{
	}

	public void AddRoomStat(PlayerStatType statType, float amount)
	{
	}

	public bool CanAddRoomStat(PlayerStatType statType, float amount)
	{
		return false;
	}

	private float GetRemainingPermanentRange()
	{
		return 0f;
	}

	private bool NormalizePermanentRange()
	{
		return false;
	}

	public static PlayerStatType GetTalentIncrementStatType(int id)
	{
		return PlayerStatType.damage;
	}

	public float GetRoomStat(PlayerStatType statType)
	{
		return 0f;
	}

	public float GetRankRewardStepValue(PlayerStatType statType, int rewardCount)
	{
		return 0f;
	}

	public float GetRankRewardTotalBonus(PlayerStatType statType)
	{
		return 0f;
	}

	private bool TryGetRankRewardSettings(PlayerStatType statType, out float baseReward, out float multiplier)
	{
		baseReward = default;
		multiplier = default;
		return false;
	}

	public void SaveOwnedItems()
	{
	}

	public void GetSavedStats()
	{
	}

	public List<CollectedStat> GetSavedItems()
	{
		return null;
	}

	public float GetStatPower(PlayerStatType type, float value)
	{
		return 0f;
	}

	public float GetStatPower(ItemSpecialEffect type)
	{
		return 0f;
	}

	public float GetAllStatsPower()
	{
		return 0f;
	}

	private float GetRatePower(PlayerTypes player, float statMassValue)
	{
		return 0f;
	}
}
