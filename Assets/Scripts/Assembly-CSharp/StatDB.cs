using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatDB", menuName = "DBs/StatDB")]
public class StatDB : ScriptableObject
{
	[Serializable]
	public class StatsInfos
	{
		public string statName;

		public string statDescription;

		public Sprite statIcon;

		public PlayerStatType typeStat;
	}

	[Serializable]
	public class CharacterStats
	{
		public PlayerStatType typeStat;

		public CharStatSettings[] statValueByRarity;

		public int lvl;

		public bool isIncludedInLevelUp;

		public CharacterStats(PlayerStatType typeStat, CharStatSettings[] statValueByRarity, int lvl)
		{
		}

		public CharacterStats(PlayerStatType typeStat, CharStatSettings[] statValueByRarity, int lvl, bool isIncludedInLevelUp)
		{
		}
	}

	[Serializable]
	public class CharStatSettings
	{
		public CardRarity rarity;

		public float valueStat;
	}

	[Serializable]
	public class StatSet
	{
		public PlayerStatType typeStat;

		public float valueStat;

		public float increasePerLevelCommon;

		public float increasePerLevelUnCommon;

		public float increasePerLevelRare;

		public float increasePerLevelEpic;

		public float increasePerLevelLegendary;

		public float GetStatValueByLevel(int lvlCommon, int lvlUncommon, int lvlRare, int lvlEpic, int lvlLegend)
		{
			return 0f;
		}
	}

	[Serializable]
	public class Skill
	{
		public string nameSkill;

		public string descriptionSkill;

		public SkillType typeSkill;

		public EffectType typeEffect;

		public CardRarity rarity;

		public CardRarity upgradeRarity;

		public Sprite iconSkill;

		public Sprite iconMiniSkill;

		public float skillDuration;

		public float skillEffectDuration;

		[Header("Skill Count")]
		[Min(1f)]
		public int maxSkillCount;

		[Header("Skill Stats")]
		public List<SkillStat> skillStats;

		[Header("Skill Stat Upgrades")]
		public List<SkillUpgradeStat> allSkillsUpgrades;

		[HideInInspector]
		public List<SkillUpgradeStatSaver> ownedSkillUpgradeStats;

		[HideInInspector]
		public SkillUpgradeStatSaver selectedUpgradeStat;

		private int level;

		public bool IsInlocked => false;

		public int GetLevel => 0;

		public void UpgradeLevel(CardRarity upgradeRarit, SkillUpgradeType skillUpgradeType)
		{
		}

		public void UpgradeLevel(SkillUpgradeStatSaver skillUpgradeStat)
		{
		}

		public void UpgradeLevel()
		{
		}

		public void ResetLevel()
		{
		}

		public int GetMaxSkillCount()
		{
			return 0;
		}

		public bool IsSkillCountMaxed()
		{
			return false;
		}

		public bool CanOfferUpgradeType(SkillUpgradeType typeStat)
		{
			return false;
		}

		private static UpgradeRarityHolder GetPositiveSkillCountUpgrade(SkillUpgradeStat skillUpgradeStat, CardRarity requestedRarity)
		{
			return null;
		}

		public bool CanOfferAnyUpgrade()
		{
			return false;
		}

		public float GetStatValueByLevel(SkillUpgradeType typeStat)
		{
			return 0f;
		}

		public float GetStatEndValueByLevel(SkillUpgradeType typeStat, SkillUpgradeStatSaver ssSaverk)
		{
			return 0f;
		}

		public float GetCurrentCoolDown()
		{
			return 0f;
		}

		public float GetSkillDuration()
		{
			return 0f;
		}

		public float GetSkillEffectDuration()
		{
			return 0f;
		}

		public Skill(Skill ss)
		{
		}
	}

	[Serializable]
	public class SkillStat
	{
		public SkillUpgradeType typeStat;

		public float valueStart;
	}

	[Serializable]
	public class SkillUpgradeStat
	{
		public SkillUpgradeType typeStat;

		public List<UpgradeRarityHolder> upgradeAmounts;
	}

	[Serializable]
	public class SkillUpgradeStatSaver
	{
		public SkillUpgradeType typeStat;

		public UpgradeRarityHolder upgradeAmounts;

		public SkillUpgradeStatSaver(SkillUpgradeType typeStat, UpgradeRarityHolder upgradeAmounts)
		{
		}
	}

	[Serializable]
	public class CoolDownSet
	{
		public int startCoolDown;

		public int recudePerLevel;

		public int minValue;

		public int GetCurrentCoolDown(int level)
		{
			return 0;
		}
	}

	[Serializable]
	public class SkillStatRatios
	{
		public SkillUpgradeType skillUpgradeType;

		public int ratio;
	}

	[Serializable]
	public class ActiveUpgrades
	{
		public string name;

		public string description;

		public Sprite icon;

		public ActiveUpgradesType typeUpgrade;

		public EffectType effectType;

		public bool canStack;

		public UpgradeRarityHolder[] upgradeAmounts;

		[HideInInspector]
		public UpgradeRarityHolder currentUpgrade;

		private List<UpgradeRarityHolder> earnedRarities;

		public List<UpgradeRarityHolder> GetEarnedRarities()
		{
			return null;
		}

		public void AddEarnedList(CardRarity rarity)
		{
		}

		public void ResetEarnedList()
		{
		}

		public float GetAllEarnedValues()
		{
			return 0f;
		}
	}

	[Serializable]
	public class UpgradeRarityHolder
	{
		public CardRarity rarity;

		public float valueStat;
	}

	[Serializable]
	public class RarityRatios
	{
		[Range(0f, 100f)]
		public int rarityRatio;

		public CardRarity rarity;
	}

	[Serializable]
	public class StatRatios
	{
		public typesSelections typesSelections;

		[Range(0f, 100f)]
		public int ratio;
	}

	public enum typesSelections
	{
		statSelection = 0,
		skillSelection = 1,
		punchSelection = 2,
		activeUpgrades = 3
	}

	[Serializable]
	public class SelectionReturnValue
	{
		public Skill skill;

		public CharacterStats characterStats;

		public CharStatSettings charStatSettings;

		public ActiveUpgrades activeUpgrade;

		public typesSelections typesSelection;

		public SelectionReturnValue(Skill skill, typesSelections typesSelection, CardRarity rarity)
		{
		}

		public SelectionReturnValue(CharacterStats characterStats, typesSelections typesSelection, CharStatSettings charStatSettings)
		{
		}

		public SelectionReturnValue(typesSelections typesSelection)
		{
		}

		public SelectionReturnValue(ActiveUpgrades activeUpgrade, UpgradeRarityHolder upgradeRarity, typesSelections typesSelection)
		{
		}
	}

	public List<CharacterStats> allCharacterStats;

	public List<StatsInfos> allStatInfos;

	public List<Skill> allSkills;

	public List<Skill> ownedSkills;

	public List<SkillStatRatios> tierChanceSkillsStatSelect;

	public List<ActiveUpgrades> allActiveUpgrades;

	public List<ActiveUpgrades> ownedActiveUpgrades;

	private bool _hasGuaranteedSkillSelectionForThisFight;

	private bool _guaranteedSkillSelectionConsumed;

	private SkillType _guaranteedSkillSelectionType;

	public List<RarityRatios> tierChanceStats;

	public List<RarityRatios> tierChanceSkills;

	public List<RarityRatios> tierChanceActiveUpgrade;

	public List<StatRatios> allStatRatios;

	private bool _punchSelected;

	private int _counterStatShow;

	public List<SelectionReturnValue> returnValues;

	public StatsInfos GetStatsInfosWType(PlayerStatType typeStat)
	{
		return null;
	}

	public void AddStat(PlayerStatType type)
	{
	}

	public void ResetPasiveStatLevel()
	{
	}

	public void ResetOwnedSkills()
	{
	}

	public void UnlockAllSkillsForCheat()
	{
	}

	public void AddSkillToOwned(SkillType typeSkill, CardRarity rarity, SkillUpgradeType skillUpgradeType)
	{
	}

	public void AddSkillToOwned(SkillType typeSkill, SkillUpgradeStatSaver skillUpgradeStat)
	{
	}

	public List<Skill> GetSavedSkills()
	{
		return null;
	}

	public float GetSkillStats(SkillType typeSkill, SkillUpgradeType typeStat)
	{
		return 0f;
	}

	public float GetSkillCoolDown(SkillType typeSkill)
	{
		return 0f;
	}

	public float GetSkillDuration(SkillType typeSkill)
	{
		return 0f;
	}

	public float GetSkillActiveTime(SkillType typeSkill)
	{
		return 0f;
	}

	public Skill GetSkill(SkillType typeSkill)
	{
		return null;
	}

	public int GetUnlockedSkillSlotCount()
	{
		return 0;
	}

	public bool CanAddNewSkill()
	{
		return false;
	}

	public bool CanShowSkillSelection()
	{
		return false;
	}

	private SkillUpgradeType GetStatForSkillSelection(int cardRatio)
	{
		return SkillUpgradeType.coolDown;
	}

	private SkillUpgradeType GetAvailableSkillUpgradeType(Skill skill, SkillUpgradeType selectedType, CardRarity rarity)
	{
		return SkillUpgradeType.coolDown;
	}

	private bool HasSkillUpgradeForRarity(Skill skill, SkillUpgradeType upgradeType, CardRarity rarity)
	{
		return false;
	}

	public void ResetOwnedActiveUpgrades()
	{
	}

	public void AddActiveUpgrade(ActiveUpgrades activeUpgrades, UpgradeRarityHolder rarityHolder)
	{
	}

	public List<ActiveUpgrades> GetAllActiveSkills()
	{
		return null;
	}

	public int GetActiveUpgradeLevel(ActiveUpgradesType typeUpgrade)
	{
		return 0;
	}

	public void ResetAllActiveUpgradesList()
	{
	}

	public Sprite GetActiveUpgradeIcon(ActiveUpgradesType upgradesType)
	{
		return null;
	}

	public int GetUnlockedActiveUpgradeSlotCount()
	{
		return 0;
	}

	public int GetUsedActiveUpgradeSlotCount()
	{
		return 0;
	}

	public bool CanOfferActiveUpgradeSelection()
	{
		return false;
	}

	private bool CanAddActiveUpgrade(ActiveUpgradesType upgradeType)
	{
		return false;
	}

	private bool IsActiveUpgradeAvailable(ActiveUpgrades activeUpgrade)
	{
		return false;
	}

	private bool CanOfferPassiveStat(PlayerStatType typeStat)
	{
		return false;
	}

	private CharacterStats GetCharacterStatWithRarity()
	{
		return null;
	}

	private void ConfigureSelectedUpgradeStat(Skill skill, CardRarity rarity)
	{
	}

	private UpgradeRarityHolder GetSkillUpgradeRarityHolder(SkillUpgradeStat skillUpgradeStat, CardRarity rarity)
	{
		return null;
	}

	private static UpgradeRarityHolder GetPositiveSkillCountUpgrade(SkillUpgradeStat skillUpgradeStat, CardRarity requestedRarity)
	{
		return null;
	}

	private Skill GetSkillWithRarity(CardRarity rarity, bool isActiveSkill = false)
	{
		return null;
	}

	private Skill GetGuaranteedSkillForFirstFightSelection(CardRarity rarity)
	{
		return null;
	}

	private Dictionary<EffectType, int> GetOwnedSkillEffectWeights()
	{
		return null;
	}

	private float GetActiveUpgradeWeight(ActiveUpgrades activeUpgrade, Dictionary<EffectType, int> ownedEffectWeights)
	{
		return 0f;
	}

	private ActiveUpgrades GetActiveUpgradesRandom()
	{
		return null;
	}

	private UpgradeRarityHolder GetUpgradeRarityHolder(ActiveUpgrades activeUpgrades, CardRarity rarity)
	{
		return null;
	}

	public StatsInfos GetStatInfo(PlayerStatType statType)
	{
		return null;
	}

	private CardRarity GetRarityForSkill(int cardRatio)
	{
		return CardRarity.Common;
	}

	private CardRarity GetRarityForActiveUpgrade(int cardRatio)
	{
		return CardRarity.Common;
	}

	private CardRarity GetRarityForStats(int cardRatio)
	{
		return CardRarity.Common;
	}

	private typesSelections GetSelectionType()
	{
		return typesSelections.statSelection;
	}

	private typesSelections NormalizeSelectionType(typesSelections typeOfSelection)
	{
		return typesSelections.statSelection;
	}

	private bool IsFirstChapterSelectionRestricted()
	{
		return false;
	}

	private typesSelections GetAllowedSelectionType(bool isAdventurerActive, int currentSelectionCount)
	{
		return typesSelections.statSelection;
	}

	public List<SelectionReturnValue> GetRandomStats(int listLength, bool isRerol = false)
	{
		return null;
	}

	public Skill GetRandomSkillFromCard(int rarity)
	{
		return null;
	}

	public SelectionReturnValue GetRandomSkillByRarity(Skill selectedSkill, int rarity)
	{
		return null;
	}

	private bool GetIsStatOrSkillSelected(List<SelectionReturnValue> selectionReturnValues, typesSelections tt, Skill selectedSkill, CharacterStats selectedStat, ActiveUpgrades activeUpgrades)
	{
		return false;
	}

	private bool IsSameSkillUpgradeCardAlreadySelected(List<SelectionReturnValue> selectionReturnValues, typesSelections tt, Skill selectedSkill)
	{
		return false;
	}

	private bool GetIsSkillSelected(Skill selectedSkill)
	{
		return false;
	}

	private bool HasUnlockedSkillForSelection()
	{
		return false;
	}
}
