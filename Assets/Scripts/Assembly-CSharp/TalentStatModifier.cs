using System;
using UnityEngine;

[Serializable]
public class TalentStatModifier : BaseStatModifier
{
	[Header("Stat Scaling")]
	public float multiplierByRarity;

	[HideInInspector]
	public float multiplierByLevel;
}
