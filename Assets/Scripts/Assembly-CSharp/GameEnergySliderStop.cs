using System;
using TMPro;
using UnityEngine;

[Serializable]
public class GameEnergySliderStop
{
	[SerializeField]
	private TextMeshProUGUI energyText;

	[SerializeField]
	private TextMeshProUGUI multiplierText;

	[SerializeField]
	private int energyAmount;

	[SerializeField]
	private float multiplier;

	[SerializeField]
	private int minEnergyNeed;

	[SerializeField]
	private GameObject[] activeObject;

	[SerializeField]
	private GameObject[] deactiveObject;

	[SerializeField]
	private Color regularColor;

	[SerializeField]
	private Color deactifColor;

	public int EnergyAmount => 0;

	public float Multiplier => 0f;

	public int MinEnergyNeed => 0;

	public void SetSelected(bool isSelected)
	{
	}

	public void RefreshText()
	{
	}
}
