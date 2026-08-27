using System;
using UnityEngine;

[Serializable]
public class RarityWeight
{
	public Rarity rarity;

	[Range(0f, 1f)]
	public float weight;
}
