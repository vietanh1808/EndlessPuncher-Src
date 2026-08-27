using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDB", menuName = "DBs/EnemyDB")]
public class EnemyDB : ScriptableObject
{
	[Serializable]
	public class Enemy
	{
		public enemyType type;

		public GameObject prefab;

		public List<StatAndValue> allStats;

		public float GetStatType(PlayerStatType type)
		{
			return 0f;
		}
	}

	[Serializable]
	public class StatAndValue
	{
		public float valueStatMultiplier;

		public PlayerStatType typeStat;
	}

	public List<Enemy> allEnemy;

	public GameObject GetEnemyObjeWithType(enemyType type)
	{
		return null;
	}

	public Enemy GetEnemyWithType(enemyType type)
	{
		return null;
	}
}
