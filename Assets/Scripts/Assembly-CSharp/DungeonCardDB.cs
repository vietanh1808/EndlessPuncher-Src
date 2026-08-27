using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonCardDB", menuName = "Fubu/Dungeon/DungeonCardDB")]
public class DungeonCardDB : ScriptableObject
{
	[Serializable]
	public class DungeonCarEntry
	{
		public GameObject prefab;
	}

	[Min(1f)]
	public float baseHp;

	[Min(0f)]
	public float hpIncreasePerStep;

	public List<DungeonCarEntry> carSequence;

	public DungeonCarEntry GetCarForStep(int step)
	{
		return null;
	}

	public float GetHpForStep(int step)
	{
		return 0f;
	}
}
