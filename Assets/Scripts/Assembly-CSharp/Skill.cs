using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Fubu/SkillCards/Skill")]
public class Skill : ScriptableObject
{
	public string skillName;

	public string skillDescription;

	public Sprite skillIcon;

	public Rarity rarity;

	public GameObject prefab;

	public GameObject prefabProjectile;

	public SkillStatModifier[] stats;

	public PlayerBonusStat[] statsForPlayerBonus;
}
