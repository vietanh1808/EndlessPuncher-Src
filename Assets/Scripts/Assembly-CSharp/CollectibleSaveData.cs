using System;

[Serializable]
public class CollectibleSaveData
{
	public string collectibleId;

	public bool isActivated;

	public int levelStar;

	public int pieces;

	public CollectibleSaveData()
	{
	}

	public CollectibleSaveData(string collectibleId, int levelStar, int pieces)
	{
	}
}
