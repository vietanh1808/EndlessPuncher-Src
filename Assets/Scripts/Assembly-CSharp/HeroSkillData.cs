using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroSkillData
{
	public string skillName;

	public Sprite icon;

	[TextArea(2, 5)]
	public string description;

	public bool hasCooldown;

	[Min(0f)]
	public float cooldown;

	public bool hasBaseDamageOrEffectValue;

	public float baseDamageOrEffectValue;

	public bool usesHeroDamageMultiplier;

	[Min(0f)]
	public float heroDamageMultiplier;

	public List<HeroSkillStarUpgradeData> starUpgrades;
}
