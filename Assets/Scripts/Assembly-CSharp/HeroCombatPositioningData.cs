using System;
using UnityEngine;

[Serializable]
public class HeroCombatPositioningData
{
	[Min(0f)]
	public float preferredDistance;

	[Min(0f)]
	public float attackRange;
}
