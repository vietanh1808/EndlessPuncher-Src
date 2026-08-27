using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonPetDB", menuName = "Fubu/Dungeon/DungeonPetDB")]
public class DungeonPetDB : ScriptableObject
{
	[Serializable]
	public class DungeonPetLevelEntry
	{
		public Skill[] petSkills;
	}

	private const int DefaultLevelCount = 30;

	private const int PetsPerLevel = 3;

	[Min(1f)]
	public float baseTotalHp;

	[Min(0f)]
	public float totalHpMultiplierPerStep;

	[Min(0f)]
	public float baseTotalDamage;

	[Min(0f)]
	public float totalDamageMultiplierPerStep;

	[Min(0.01f)]
	public float fallbackRate;

	public List<DungeonPetLevelEntry> petSequence;

	public Skill GetPetForStep(int step, int petIndex)
	{
		return null;
	}

	public float GetTotalHpForStep(int step)
	{
		return 0f;
	}

	public float GetHpPerPetForStep(int step, int petCount)
	{
		return 0f;
	}

	public float GetTotalDamageForStep(int step)
	{
		return 0f;
	}

	public float GetDamagePerPetForStep(int step, int petCount)
	{
		return 0f;
	}

	public float GetRate(Skill skill)
	{
		return 0f;
	}

	private void Reset()
	{
	}

	private void OnValidate()
	{
	}

	private void EnsureSequenceShape()
	{
	}
}
