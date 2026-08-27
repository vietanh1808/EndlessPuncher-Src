using System;
using UnityEngine;

[Serializable]
public class ItemStatModifier : BaseStatModifier
{
	[Header("Stat Scaling")]
	public float multiplierByRarity;

	public float multiplierByLevel;
}
