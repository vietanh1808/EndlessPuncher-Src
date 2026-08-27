using System;
using System.Collections.Generic;

[Serializable]
public class SaveData
{
	public string lastSaveDate;

	public int version;

	public ShopSaveData shop;

	public string chainOfferLastResetDate;

	public List<int> chainOfferClaimedSlotIndexes;

	public List<CollectibleSaveData> collectibleSaveDatas;

	public List<CurrencySaveData> currencySaveDatas;

	public string dailyRewardLastClaimDate;

	public int dailyRewardListIndex;

	public int dailyRewardNextDayIndex;

	public bool hasActiveDungeon;

	public string activeDungeonName;

	public int activeDungeonLevel;

	public string lastTicketResetDate;

	public bool isFinishedDungeon;

	public List<DungeonSaveData> dungeons;

	public int energy;

	public string lastRegenDate;

	public bool isEnergySetted;

	public int eventPassLastShownCurrencyValue;

	public string eventPassLastResetDate;

	public bool eventPassPremiumActive;

	public int eventPassBattlePassNameIndex;

	public List<int> eventPassClaimedRegularIndexes;

	public List<int> eventPassClaimedPassIndexes;

	public int heroStage;

	public List<HeroProgressData> heroProgressDatas;

	public List<ItemData> itemSaveDatas;

	public int piggyBankUsedEnergy;

	public float sfxVolume;

	public float musicVolume;

	public bool hapticStatus;

	public int skillLevel;

	public int skillTotalCardCount;

	public List<SkillCardSaveData> skillSaveDatas;

	public List<TalentData> talentSaveDatas;
}
