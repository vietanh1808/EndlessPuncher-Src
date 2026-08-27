using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUpgradeType", menuName = "Tycoon/Upgrade Type Data")]
public class UpgradeData : ScriptableObject
{
	[SerializeField]
	[HideInInspector]
	private string upgradeID;

	[Header("General Info")]
	public string upgradeName;

	public Sprite upgradeIcon;

	[TextArea(3, 5)]
	public string upgradeDescription;

	[Header("Cost Calculation")]
	public int baseCost;

	public double costMultiplier;

	[Header("Value Calculation")]
	public float baseValue;

	public float increaseValuePerLevel;

	[Header("Select Primary Upgrade (Primary Upgrade affects the star level bar)")]
	public bool isPrimaryUpgrade;

	[Header("Blocked By Upgrade")]
	public UpgradeData blockedByUpgrade;

	[Header("Dependencies")]
	public List<PrimaryDependency> blockedDependencies;

	public string UpgradeID => null;
}
