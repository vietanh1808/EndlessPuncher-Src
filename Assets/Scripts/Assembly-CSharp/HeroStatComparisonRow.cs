using System;
using TMPro;
using UnityEngine;

[Serializable]
public class HeroStatComparisonRow
{
	[SerializeField]
	private TMP_Text currentValueText;

	[SerializeField]
	private TMP_Text nextValueText;

	public void Refresh(float currentValue, float nextValue)
	{
	}

	private static string FormatStatValue(float value)
	{
		return null;
	}
}
