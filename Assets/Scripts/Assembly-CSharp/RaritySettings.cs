using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rarity Settings", menuName = "Fubu/Rarity/RaritySettings")]
public class RaritySettings : ScriptableObject
{
	public string raritiesFolderPath;

	public List<Rarity> rarities;

	public void ScanAssets()
	{
	}
}
