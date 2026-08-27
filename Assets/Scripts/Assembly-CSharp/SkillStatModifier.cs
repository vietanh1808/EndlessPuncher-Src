using System;
using UnityEngine;

[Serializable]
public class SkillStatModifier : BaseStatModifier
{
	[Header("Stat Scaling")]
	public float[] increseValuePerLevelInJumpLevel;

	private int maxLevel;
}
