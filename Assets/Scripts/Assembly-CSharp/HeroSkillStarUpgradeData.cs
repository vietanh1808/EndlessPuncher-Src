using System;
using UnityEngine;

[Serializable]
public class HeroSkillStarUpgradeData
{
	[Min(0f)]
	public int requiredStar;

	public HeroSkillUpgradeType upgradeType;

	public float value;

	[TextArea(2, 4)]
	public string description;
}
