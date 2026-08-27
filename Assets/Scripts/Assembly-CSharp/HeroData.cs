using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroData
{
	[Header("Basic Info")]
	public HeroBasicInfoData basicInfo;

	[Header("Base Stats")]
	public HeroStatsData baseStats;

	[Header("Combat Positioning")]
	public HeroCombatPositioningData combatPositioning;

	[Header("Unlock Configuration")]
	public HeroUnlockConfigurationData unlockConfiguration;

	[Header("Auto Attack")]
	public HeroSkillData autoAttack;

	[Header("Active Skill")]
	public HeroSkillData activeSkill;

	[Header("Passive Skill")]
	public HeroSkillData passiveSkill;

	[Header("Global Trait Progression")]
	public List<HeroTraitStarRewardData> starTraitRewards;
}
