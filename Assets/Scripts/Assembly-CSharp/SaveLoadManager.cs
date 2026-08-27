using System;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
	private static readonly int[] fallbackSkillSlotUnlockChapters;

	public const string cardLevels = "CardLevels";

	public const string equippedCards = "EquippedCards";

	public const string boughtCards = "BoughtCards";

	public const string watchedRewardedForCards = "WatchedRewardedForCards";

	public static void SetQuestItem(string name, float amount, int level, bool isDaily = false)
	{
	}

	public static void SetQuestIsCompleted(int index, bool isCompleted, bool isBonus)
	{
	}

	public static bool IsQuestCompleted(int index, bool isBonus)
	{
		return false;
	}

	public static (float, int) GetQuestItem(string name, bool isDaily = false)
	{
		return default;
	}

	public static void SetTime(long time, string key)
	{
	}

	public static long GetTime(string key)
	{
		return 0L;
	}

	public static void SetDay(int day, string key)
	{
	}

	public static int GetDay(string key)
	{
		return 0;
	}

	public static void SetRaid(string key, int count, int rewCount, int level)
	{
	}

	public static (int, int, int) GetRaid(string key)
	{
		return default;
	}

	public static void SetCardCounter(string key, int count, int level)
	{
	}

	public static (int, int) GetCardCounter(string key)
	{
		return default;
	}

	public static void SetCardWatchedRewardedCount(string key, int count)
	{
	}

	public static int GetCardWatchedRewardedCount(string key)
	{
		return 0;
	}

	public static void SetTutorial(int tut)
	{
	}

	public static int GetTutorial()
	{
		return 0;
	}

	public static void SetTutorial(string name, bool value)
	{
	}

	public static bool GetTutorial(string name)
	{
		return false;
	}

	public static void SetHP(float hp)
	{
	}

	public static float GetHP()
	{
		return 0f;
	}

	public static void SetPurchaseUnit(string key, int value)
	{
	}

	public static int GetPurchaseUnit(string key)
	{
		return 0;
	}

	public static void SetUnlocked(string key)
	{
	}

	public static bool IsUnlocked(string key)
	{
		return false;
	}

	public static bool IsUnlockedRaw(string key)
	{
		return false;
	}

	public static void ClearUnlocked(string key)
	{
	}

	public static void SetAutoMerge(bool value)
	{
	}

	public static bool GetAutoMerge()
	{
		return false;
	}

	public static void SetCurrency(string name, float amount)
	{
	}

	public static float GetCurrency(string name)
	{
		return 0f;
	}

	public static void SetPlayerStats(int level, float xp)
	{
	}

	public static void GetStats(out int level, out float xp)
	{
		level = default;
		xp = default;
	}

	public static void SetChapterHighScore(int chapter, float score)
	{
	}

	public static float GetChapterHighScore(int chapter)
	{
		return 0f;
	}

	public static void SetWave(int wave)
	{
	}

	public static int GetWave()
	{
		return 0;
	}

	public static void SetPurchasable(int id, int level, long price)
	{
	}

	public static (int, long) GetPurchasable(int id)
	{
		return default;
	}

	public static void SetLevel(int wave)
	{
	}

	public static int GetLevel()
	{
		return 0;
	}

	public static void SetStat(string name, int level)
	{
	}

	public static int GetStat(string name)
	{
		return 0;
	}

	public static void SetBuff(string name, int level)
	{
	}

	public static int GetBuff(string name)
	{
		return 0;
	}

	public static void SetLastPlayedLevel(int i)
	{
	}

	public static int GetLastPlayedLevel()
	{
		return 0;
	}

	public static void IncreaseFakeLevel()
	{
	}

	public static int GetFakeLevel()
	{
		return 0;
	}

	public static void SetChapter(int value)
	{
	}

	public static int GetChapter()
	{
		return 0;
	}

	public static void SetFakeChapter(int value)
	{
	}

	public static int GetFakeChapter()
	{
		return 0;
	}

	public static bool IsChestUnlocked()
	{
		return false;
	}

	public static void UnlockChestFeature()
	{
	}

	public static bool IsInventoryUnlocked()
	{
		return false;
	}

	public static void SetTalentMenuUnlocked()
	{
	}

	public static bool IsTalentMenuUnlocked()
	{
		return false;
	}

	public static bool IsTalentMenuUnlockedRaw()
	{
		return false;
	}

	public static int GetChapterForEvent()
	{
		return 0;
	}

	public static int GetHeroStage()
	{
		return 0;
	}

	public static void SetHeroStage(int value, bool saveImmediately = true)
	{
	}

	public static HeroProgressData GetHeroProgressData(string heroId)
	{
		return null;
	}

	public static HeroProgressData GetOrCreateHeroProgressData(string heroId, bool saveImmediately = false)
	{
		return null;
	}

	public static int GetSelectableSkillMaxCount()
	{
		return 0;
	}

	public static void SetSelectableSkillMaxCount(int value)
	{
	}

	public static void SetSoundVolume(float i)
	{
	}

	public static float GetSoundVolume()
	{
		return 0f;
	}

	public static void SetMusicVolume(float i)
	{
	}

	public static float GetMusicVolume()
	{
		return 0f;
	}

	public static void SetHapticState(int i)
	{
	}

	public static bool GetHapticState()
	{
		return false;
	}

	public static void SetLastInterstitialTime(float lastInterTime)
	{
	}

	public static float GetLastInterstitialTime()
	{
		return 0f;
	}

	public static void SetSpeedUpActive(bool active)
	{
	}

	public static bool GetSpeedUpActive()
	{
		return false;
	}

	public static void SetSpeedUpMultiplier(float multiplier)
	{
	}

	public static float GetSpeedUpMultiplier()
	{
		return 0f;
	}

	public static void SetRateUsShowed()
	{
	}

	public static bool IsRateUsShowed()
	{
		return false;
	}

	public static void IncreaseIncrementalLevel(int id)
	{
	}

	public static int GetIncrementalLevel(int id)
	{
		return 0;
	}

	public static void SetIncrementalLevel(int id, int value)
	{
	}

	public static int GetIncrementalProgress(int id)
	{
		return 0;
	}

	public static void SetIncrementalProgress(int id, int value)
	{
	}

	public static int GetIncrementalTotalPurchaseCount(int id)
	{
		return 0;
	}

	public static void SetIncrementalTotalPurchaseCount(int id, int value)
	{
	}

	public static void IncreaseIncrementalTotalPurchaseCount(int id)
	{
	}

	public static float GetIncrementalBonusValue(int id)
	{
		return 0f;
	}

	public static void SetIncrementalBonusValue(int id, float value)
	{
	}

	public static float GetIncrementalMajorBaseValue(int id)
	{
		return 0f;
	}

	public static void SetIncrementalMajorBaseValue(int id, float value)
	{
	}

	public static int GetExtraArmCount()
	{
		return 0;
	}

	public static void SetExtraArmCount(int value)
	{
	}

	public static int GetExtraArmPowerLevel()
	{
		return 0;
	}

	public static void SetExtraArmPowerLevel(int value)
	{
	}

	public static int GetExtraArmTotalPurchaseCount()
	{
		return 0;
	}

	public static void SetExtraArmTotalPurchaseCount(int value)
	{
	}

	public static void IncreaseExtraArmTotalPurchaseCount()
	{
	}

	public static void ResetAllIncrementals()
	{
	}

	public static int GetRewardIndex(CurrencyTypes currencyType)
	{
		return 0;
	}

	public static void IncreaseRewardIndex(CurrencyTypes currencyType)
	{
	}

	public static void SetNextDay(DateTime dateTime)
	{
	}

	public static DateTime? GetNextDay()
	{
		return null;
	}

	public static void SetPvpRewardCount(int count)
	{
	}

	public static int GetPvpRewardCount()
	{
		return 0;
	}

	public static void SetMission(int index)
	{
	}

	public static int GetMission()
	{
		return 0;
	}

	public static string GetMissionData()
	{
		return null;
	}

	public static void SetMissionData(string data)
	{
	}

	public static void SetRoomLevel(int value)
	{
	}

	public static int GetRoomLevel()
	{
		return 0;
	}

	public static void SetRoomItelLevel(int value)
	{
	}

	public static int GetRoomItemLevel()
	{
		return 0;
	}

	public static int GetPunchCount()
	{
		return 0;
	}

	public static void SetPunchCount(int level)
	{
	}

	public static int GetMaxSkillCount()
	{
		return 0;
	}

	public static void SetMaxSkillCount(int level)
	{
	}

	public static int GetActiveUpgradeCardUnlockChapter(int cardIndex)
	{
		return 0;
	}

	public static int GetUnlockedActiveUpgradeCardCountForChapter(int currentChapter, int totalCardCount)
	{
		return 0;
	}

	public static int GetSkillSlotUnlockChapter(int slotIndex)
	{
		return 0;
	}

	public static int GetFallbackSkillSlotUnlockChapter(int slotIndex)
	{
		return 0;
	}

	public static int GetUnlockedSkillSlotCountForChapter(int currentChapter)
	{
		return 0;
	}

	public static bool IsSkillSlotUnlockedForChapter(int slotIndex, int currentChapter)
	{
		return false;
	}

	public static void SyncSkillSlotCountWithChapter()
	{
	}

	public static void SetPendingUnlockedSkillSlotIndex(int slotIndex)
	{
	}

	public static bool TryConsumePendingUnlockedSkillSlotIndex(out int slotIndex)
	{
		slotIndex = default;
		return false;
	}

	public static void SetPendingUnlockedActiveUpgradeCardIndex(int cardIndex)
	{
	}

	public static bool TryConsumePendingUnlockedActiveUpgradeCardIndexes(out List<int> cardIndexes)
	{
		cardIndexes = null;
		return false;
	}

	public static int GetChestValue(int valueChest)
	{
		return 0;
	}

	public static void SetChestValue(int valueChest, int level)
	{
	}

	public static int GetCommonChestOpenedCount()
	{
		return 0;
	}

	public static void SetCommonChestOpenedCount(int value)
	{
	}

	public static void IncreaseCommonChestOpenedCount(int amount = 1)
	{
	}

	public static int GetEpicChestOpenedCount()
	{
		return 0;
	}

	public static void SetEpicChestOpenedCount(int value)
	{
	}

	public static void IncreaseEpicChestOpenedCount(int amount = 1)
	{
	}

	public static int GetBossChestKillProgress()
	{
		return 0;
	}

	public static void SetBossChestKillProgress(int value)
	{
	}

	public static int GetBossChestRewardCount()
	{
		return 0;
	}

	public static void SetBossChestRewardCount(int value)
	{
	}

	public static int GetTalentIncrmeental(int idInc)
	{
		return 0;
	}

	public static void SetTalentIncrmeental(int idInc, int level)
	{
	}

	public static int GetTotalTalentUpgrade()
	{
		return 0;
	}

	public static void SetTotalTalentUpgrade(int level)
	{
	}

	public static bool HasRankRewardCount()
	{
		return false;
	}

	public static int GetRankRewardCount()
	{
		return 0;
	}

	public static void SetRankRewardCount(int count)
	{
	}

	public static void IncreaseRankRewardCount(int amount = 1)
	{
	}

	public static bool GetSkillIsUnlocked(SkillType skillType)
	{
		return false;
	}

	public static void SetSkillIsUnlocked(SkillType skillType)
	{
	}

	public static void SetPendingGuaranteedSkillForNextFight(SkillType skillType)
	{
	}

	public static bool TryConsumePendingGuaranteedSkillForNextFight(out SkillType skillType)
	{
		skillType = default;
		return false;
	}

	public static int GetEarlyQuestProgress()
	{
		return 0;
	}

	public static void SetEarlyQuestProgress(int value)
	{
	}

	public static int GetQuestLevel(QuestType quest)
	{
		return 0;
	}

	public static void SetQuestLevel(QuestType quest, int lvl)
	{
	}

	public static bool GetQuestActive(QuestType quest)
	{
		return false;
	}

	public static void SetQuestActive(QuestType quest, bool active)
	{
	}

	public static int GetQuestRewardIndex(RewardType rewardType)
	{
		return 0;
	}

	public static void SetQuestRewardIndex(RewardType rewardType, int value)
	{
	}

	public static bool GetSlotPurchased(int id)
	{
		return false;
	}

	public static void SetSlotPurchased(int id)
	{
	}

	public static void ReSetSlotPurchased(int id)
	{
	}

	public static int GetSlotPurchaseLevel(int id)
	{
		return 0;
	}

	public static void SetSlotPurchaseLevel(int id, int level)
	{
	}

	public static void IncreaseSlotPurchaseLevel(int id)
	{
	}

	public static void ReSetSlotPurchaseLevel(int id)
	{
	}

	public static int GetPurchasedTalentType(TalentType type)
	{
		return 0;
	}

	public static void SetPurchasedTalentType(TalentType type)
	{
	}

	public static void ReSetPurchasedTalentType(TalentType type)
	{
	}

	public static int CanActivateOnSceneTalentType(TalentType type)
	{
		return 0;
	}

	public static void SetCanActivateOnSceneTalentType(TalentType type)
	{
	}

	public static void ReSetCanActivateOnSceneTalentType(TalentType type)
	{
	}

	public static int GetLastSelectedTalentTree()
	{
		return 0;
	}

	public static void SetLastSelectedTalentTree(int lvl)
	{
	}

	public static bool GetSlotTalentTypeSelected()
	{
		return false;
	}

	public static void SetSlotTalentTypeSelected()
	{
	}

	public static void ReSetSlotTalentTypeSelected()
	{
	}

	public static int GetTalentAndID(int id)
	{
		return 0;
	}

	public static void SetTalentAndID(int id, TalentType type)
	{
	}

	public static int GetTalentSlotPurchaseCount()
	{
		return 0;
	}

	public static void SetTalentSlotPurchaseCount(int amount)
	{
	}

	public static void SetLastPurchasedTalentCard(int i)
	{
	}

	public static int GetLastPurchasedTalentCard()
	{
		return 0;
	}

	public static void SetTalentIDTypeChanged(int i)
	{
	}

	public static bool GetTalentIDTypeChanged(int i)
	{
		return false;
	}

	public static void SetCalimedRewardedDaily(RewardedType tyoe, int level)
	{
	}

	public static int GetCalimedRewardedDaily(RewardedType tyoe)
	{
		return 0;
	}
}
