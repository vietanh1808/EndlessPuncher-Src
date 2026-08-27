using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
	[CompilerGenerated]
	private static Action<UpgradeData> m_OnUpgradePurchased;

	private Dictionary<UpgradeData, int> _upgradeLevels;

	private const string SAVE_KEY_PREFIX = "UpgradeLevel_";

	public static UpgradeManager Instance { get; private set; }

	public static event Action<UpgradeData> OnUpgradePurchased
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public int GetLevelFor(UpgradeData data)
	{
		return 0;
	}

	public double GetCostFor(UpgradeData data)
	{
		return 0.0;
	}

	public float GetValueFor(UpgradeData data)
	{
		return 0f;
	}

	public bool IsUpgradeLocked(UpgradeData data, UpgradeableAreaBase area, out string reason)
	{
		reason = null;
		return false;
	}

	public bool TryPurchaseUpgrade(UpgradeData data, UpgradeableAreaBase area)
	{
		return false;
	}

	private void SaveLevel(UpgradeData data)
	{
	}

	private int LoadLevel(UpgradeData data)
	{
		return 0;
	}
}
