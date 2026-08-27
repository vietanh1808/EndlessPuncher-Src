using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stat Settings", menuName = "Fubu/Stats/StatSettings")]
public class StatSettings : ScriptableObject
{
	public string statsFolderPath;

	public List<Stat> stats;

	public void ScanAssets()
	{
	}
}
