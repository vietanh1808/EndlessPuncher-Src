using System;
using Fubu.Inventory;
using TMPro;
using UnityEngine;

[Serializable]
public class Scroll
{
	public ItemSlot slot;

	public GameObject gameObject;

	public TextMeshProUGUI countText;

	private string GetName()
	{
		return null;
	}

	public void SetText()
	{
	}

	public void SaveScroll(int count)
	{
	}

	public int GetScrollCount()
	{
		return 0;
	}

	public void UseScroll(int count)
	{
	}

	public void AddScroll(int count)
	{
	}
}
