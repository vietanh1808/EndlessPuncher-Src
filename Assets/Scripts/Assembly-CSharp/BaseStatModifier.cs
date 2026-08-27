using System;
using UnityEngine;

[Serializable]
public class BaseStatModifier
{
	[Header("Stat Modifier")]
	public Stat stat;

	public float baseValue;
}
