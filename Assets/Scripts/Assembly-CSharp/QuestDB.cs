using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestDB", menuName = "DBs/QuestDB")]
public class QuestDB : ScriptableObject
{
	[Serializable]
	public class Quest
	{
		private const float NeedTargetMultiplierPerLevel = 1.5f;

		public string name;

		public int id;

		public int idGroup;

		public string description;

		public QuestType questType;

		public RewardQuest reward;

		public int needQuestTarget;

		public bool preventDifficultyIncrease;

		public float collectedQuestTarget;

		public int level;

		public int maxLevel;

		public bool isActive;

		public bool IsReachecMax()
		{
			return false;
		}

		public void GetQuestData()
		{
		}

		public void SetLevel()
		{
		}

		public void QuestActive(bool active)
		{
		}

		public void AddCollect(float valueCollect, bool isAdding = true)
		{
		}

		public Quest(Quest q)
		{
		}
	}

	[Serializable]
	public class RewardQuest
	{
		public Sprite icon;

		public int rewardAmouth;

		public RewardType rewardType;
	}

	[Serializable]
	public class RewardProgression
	{
		public RewardType rewardType;

		public int startAmount;

		public int increasePerIndex;

		public float multiplierPerIndex;

		public int GetAmount(int rewardIndex)
		{
			return 0;
		}
	}

	[Serializable]
	public class SerializableList<T>
	{
		public List<T> list;
	}

	private const int UnlockChestQuestMinTalentUpgrade = 90;

	private const string QuestDebugPrefix = "[QuestSelection]";

	private static readonly QuestType[] EarlyQuestOrder;

	public List<Quest> allQuests;

	public List<Quest> savedQuests;

	public List<int> lastCompleteds;

	[Header("Energy Quest Rewards")]
	[SerializeField]
	[Min(1f)]
	private int energyRewardStartAmount;

	[SerializeField]
	[Min(0f)]
	private int energyRewardIncreasePerClaim;

	public List<RewardProgression> rewardProgressions;

	public void GetAllQuestData()
	{
	}

	public void ResetAllCollectedQuestTargets()
	{
	}

	public RewardQuest ClaimQuest(QuestType type)
	{
		return null;
	}

	public void CollectQuest(QuestType type, float valueCollect, bool isAdding = true)
	{
	}

	public List<Quest> GetQuests()
	{
		return null;
	}

	public Quest GetReplacementQuest(List<QuestType> excludedQuestTypes)
	{
		return null;
	}

	private void SetOnlyQuestsActive(IEnumerable<QuestType> activeQuestTypes)
	{
	}

	private bool IsInventoryUnlocked()
	{
		return false;
	}

	private bool IsUnlockChestQuestAvailable()
	{
		return false;
	}

	private bool IsFreezeQuestAvailable()
	{
		return false;
	}

	private bool IsQuestBlockedByFeatureUnlock(Quest quest)
	{
		return false;
	}

	public bool IsQuestCanSelectable(List<Quest> selectedQuests, int selectedID)
	{
		return false;
	}

	private string GetQuestSelectionBlockReason(List<Quest> selectedQuests, int selectedID)
	{
		return null;
	}

	private Quest GetNextEarlyQuest(QuestType questType, List<Quest> selectedQuests)
	{
		return null;
	}

	private string GetQuestDebugLabel(Quest quest, int fallbackIndex = -1)
	{
		return null;
	}

	private string FormatQuestList(List<Quest> quests)
	{
		return null;
	}

	private void PrepareQuestForActivation(Quest quest)
	{
	}

	private int GetCurrentReachRankQuestOrder()
	{
		return 0;
	}

	private int GetCurrentEarlyQuestProgress()
	{
		return 0;
	}

	private void EnsureSavedQuestsInitialized()
	{
	}

	private void RefreshAllQuestRewards()
	{
	}

	private void RefreshQuestReward(Quest quest)
	{
	}

	private int GetRewardAmount(RewardType rewardType)
	{
		return 0;
	}

	private int GetEnergyRewardAmount(int rewardIndex)
	{
		return 0;
	}

	private void IncreaseRewardIndex(RewardType rewardType)
	{
	}

	private RewardQuest CloneReward(RewardQuest reward)
	{
		return null;
	}

	private void NormalizeQuestReward(RewardQuest reward)
	{
	}

	public void GetSave()
	{
	}

	public void SaveOwnedItems()
	{
	}

	public List<Quest> GetSavedItems()
	{
		return null;
	}

	public void SaveLastCompleteds()
	{
	}

	public List<int> GetLastCompletedQuests()
	{
		return null;
	}
}
