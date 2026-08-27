using UnityEngine;

[CreateAssetMenu(fileName = "New Stat", menuName = "Fubu/Stats/Stat")]
public class Stat : ScriptableObject
{
	public string statName;

	public Sprite icon;

	public float statPowerMultiplier;

	[Header("Value display")]
	public string valuePrefix;

	public string valueSuffix;
}
