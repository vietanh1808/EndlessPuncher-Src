using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonZombieHordeDB", menuName = "Fubu/Dungeon/DungeonZombieHordeDB")]
public class DungeonZombieHordeDB : ScriptableObject
{
	[Serializable]
	public class WaveEntry
	{
		public GameObject enemyPrefab;

		[Min(1f)]
		public int enemyCount;
	}

	[Min(1f)]
	public float baseHp;

	[Min(0f)]
	public float hpIncreasePerStep;

	[Min(0f)]
	public float baseDamage;

	[Min(0f)]
	public float damageIncreasePerStep;

	[SerializeField]
	private List<WaveEntry> waves;

	public int WaveCount => 0;

	public WaveEntry GetWave(int waveIndex)
	{
		return null;
	}

	public float GetTotalHpForStep(int step)
	{
		return 0f;
	}

	public float GetTotalDamageForStep(int step)
	{
		return 0f;
	}

	public float GetEnemyHpPerUnit(int waveIndex)
	{
		return 0f;
	}

	public float GetEnemyDamagePerUnit(int waveIndex)
	{
		return 0f;
	}
}
