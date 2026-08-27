using TMPro;
using UnityEngine;

public class RingSpecialUpgradeUI : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI nameText;

	[SerializeField]
	private TextMeshProUGUI valueText;

	[SerializeField]
	private TextMeshProUGUI descriptionText;

	[SerializeField]
	private TextMeshProUGUI ringTierText;

	[SerializeField]
	private Color lockColor;

	[SerializeField]
	private Color unlockColor;

	[SerializeField]
	private GameObject unlockObject;

	[SerializeField]
	private GameObject lockObject;

	[SerializeField]
	private Animator animator;

	public void Set(RingUpgradeSO.RingSpecialUpgrade specialUpgrade, int specialLevel, bool isUnlocked)
	{
	}

	public void PlayPop()
	{
	}
}
