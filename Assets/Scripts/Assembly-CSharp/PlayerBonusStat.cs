using UnityEngine;

[CreateAssetMenu(fileName = "Player Stat", menuName = "Fubu/Stats/PlayerStat")]
public class PlayerBonusStat : ScriptableObject
{
	public string statName;

	public string statDescription;

	public Sprite icon;

	public PlayerBonusStatTypes bonusType;

	public float[] rarityValues;

	[Header("Value display")]
	public string valuePrefix;

	public string valueSuffix;

	public string GetStatDescription(int rarity)
	{
		return null;
	}

	public float GetRarityValue(int rarity)
	{
		return 0f;
	}
}
