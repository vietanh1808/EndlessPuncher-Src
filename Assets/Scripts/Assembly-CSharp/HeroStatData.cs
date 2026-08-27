using System;
using UnityEngine;

[Serializable]
public class HeroStatData
{
	public string statID;

	public string statName;

	[Min(0f)]
	public float baseValue;

	public HeroStatData()
	{
	}

	public HeroStatData(string statID, string statName)
	{
	}
}
