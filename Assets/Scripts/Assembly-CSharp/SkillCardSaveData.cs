using System;

[Serializable]
public class SkillCardSaveData
{
	public string skillName;

	public int level;

	public int cardCount;

	public bool isEquipped;

	public SkillCardSaveData(string skillName, int level, int cardCount, bool isEquipped)
	{
	}
}
