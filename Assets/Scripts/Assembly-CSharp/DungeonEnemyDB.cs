using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonEnemyDB", menuName = "Fubu/Dungeon/DungeonEnemyDB")]
public class DungeonEnemyDB : ScriptableObject
{
	[Serializable]
	public class DungeonEnemyEntry
	{
		public GameObject prefab;
	}

	[Min(1f)]
	public float baseHp;

	[Min(0f)]
	public float hpIncreasePerStep;

	[Min(0f)]
	public float baseDamage;

	[Min(0f)]
	public float damageIncreasePerStep;

	public List<DungeonEnemyEntry> enemySequence;

	public DungeonEnemyEntry GetEnemyForStep(int step)
	{
		return null;
	}

	public float GetHpForStep(int step)
	{
		return 0f;
	}

	public float GetDamageForStep(int step)
	{
		return 0f;
	}
}
