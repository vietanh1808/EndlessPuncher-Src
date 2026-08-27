using System;

[Serializable]
public class ItemData
{
	public string itemName;

	public int rarityIndex;

	public int itemLevel;

	public bool isEquipped;

	public ItemData(string itemName, int rarityIndex, int itemLevel, bool isEquipped)
	{
	}
}
