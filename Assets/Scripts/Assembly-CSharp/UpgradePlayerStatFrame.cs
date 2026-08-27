using TMPro;
using UnityEngine;

public class UpgradePlayerStatFrame : MonoBehaviour
{
	[SerializeField]
	private GameObject lockIcon;

	[SerializeField]
	private GameObject dotIcon;

	[SerializeField]
	private TextMeshProUGUI description;

	[SerializeField]
	private Color deactiveColor;

	[SerializeField]
	private Color activeColor;

	public void SetPlayerStat(string value, bool isUnlocked)
	{
	}
}
