using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using UnityEngine;

public class ToastMessages : MonoBehaviour
{
	[Serializable]
	public class ToastSet
	{
		public GameObject prefabtoast;

		public toastType typeToast;

		public List<GameObject> poolToast;

		public ToastWriter GetReadyToast()
		{
			return null;
		}
	}

	private const float activeUpgradeToastCooldown = 2f;

	private static ToastMessages _instance;

	private readonly Dictionary<ActiveUpgradeToastGroup, float> lastActiveUpgradeToastTimes;

	public List<ToastSet> alltoast;

	public static ToastMessages instance => null;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void LoadToast(string textValue, toastType type)
	{
	}

	public void LoadToastItemBonus(ItemSpecialEffect effect, toastType type)
	{
	}

	public void LoadToastActiveUpgrade(ActiveUpgradesType effect, toastType type)
	{
	}

	private bool ShouldSkipActiveUpgradeToast(ActiveUpgradesType effect)
	{
		return false;
	}

	private bool IsSilentActiveUpgrade(ActiveUpgradesType effect)
	{
		return false;
	}

	private ActiveUpgradeToastGroup GetActiveUpgradeToastGroup(ActiveUpgradesType effect)
	{
		return ActiveUpgradeToastGroup.other;
	}

	private string GetItemBonusName(ItemSpecialEffect ef)
	{
		return null;
	}

	private string GetUpgradeBonusName(ActiveUpgradesType ef)
	{
		return null;
	}
}
