using System.Collections.Generic;
using UnityEngine;

namespace Fubu.Essentials
{
	[CreateAssetMenu(fileName = "DungeonInfo", menuName = "Fubu/Dungeon/DungeonInfo")]
	public class DungeonInfo : ScriptableObject
	{
		public string dungeonName;

		public Sprite dungeonIcon;

		public Sprite ticketIcon;

		public int maximumTicketCount;

		public float rewardMultiplierPerLevel;

		[Min(0f)]
		public int rewardAddPerLevel;

		public RewardEntry uniqueReward;

		public List<RewardEntry> rewards;

		[Header("Gameplay Settings")]
		public bool disablePlayerPunches;

		[Header("Skip Settings")]
		[Min(0f)]
		public float baseSkipGlobalPower;

		[Min(0f)]
		public float skipGlobalPowerIncreasePerLevel;

		[Header("Unlock Settings")]
		public int unlockChapterCount;

		public RewardedType rewardedType;

		public float GetRequiredSkipGlobalPower(int level)
		{
			return 0f;
		}

		public bool HasSkipGlobalPowerRequirement()
		{
			return false;
		}

		public int GetRewardAmount(int baseAmount, int level)
		{
			return 0;
		}
	}
}
