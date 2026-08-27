using System.Collections.Generic;
using UnityEngine;

public class UpgradeableAreaBase : MonoBehaviour
{
	[Header("Area Settings")]
	public string areaName;

	public Sprite areaIcon;

	[Header("Available Upgrades")]
	public List<UpgradeData> availableUpgrades;

	[Header("Star Level Settings")]
	public List<int> starLevelThresholds;

	private UpgradeData primaryUpgradeForStars;

	protected virtual void Start()
	{
	}

	protected void ClickTrigger()
	{
	}

	public void OpenUpgradePanel()
	{
	}

	public StarProgress GetCurrentStarProgress()
	{
		return default;
	}

	public UpgradeData GetPrimaryUpgrade()
	{
		return null;
	}
}
