using TMPro;
using UnityEngine;

public class HeroSkillStarRow : MonoBehaviour
{
	private const string StarFormat = "{0}";

	[SerializeField]
	private TMP_Text requiredStarText;

	[SerializeField]
	private TMP_Text upgradeDescriptionText;

	[SerializeField]
	private Color unlockColor;

	[SerializeField]
	private Color lockColor;

	[SerializeField]
	private GameObject unlockedObject;

	[SerializeField]
	private GameObject lockedObject;

	public void Refresh(HeroSkillStarUpgradeData upgradeData, int currentHeroStar)
	{
	}
}
