using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class PowerHandler : Singleton<PowerHandler>
{
	public Action OnPowerChanged;

	private Sequence animationSeq;

	[Header("Referances")]
	[SerializeField]
	private GameObject banner;

	[SerializeField]
	private TextMeshProUGUI powerTxt;

	[SerializeField]
	private TextMeshProUGUI changeTxt;

	[SerializeField]
	private GameObject upArrow;

	[SerializeField]
	private GameObject downArrow;

	[SerializeField]
	private Animator animator;

	public float Power { get; private set; }

	public void SyncTotalPower()
	{
	}

	public void RefreshTotalPowerWithChange()
	{
	}

	public void ChangePower(float changeValue)
	{
	}

	private void Show()
	{
	}

	private void Hide()
	{
	}
}
