using TMPro;
using UnityEngine;

public class HeroGlobalTraitRow : MonoBehaviour
{
	private const string StarFormat = "{0}";

	[SerializeField]
	private TMP_Text requiredStarText;

	[SerializeField]
	private TMP_Text globalTraitText;

	[SerializeField]
	private Color unlockColor;

	[SerializeField]
	private Color lockColor;

	[SerializeField]
	private GameObject unlockedObject;

	[SerializeField]
	private GameObject lockedObject;

	public void Refresh(HeroTraitStarRewardData rewardData, HeroGlobalTraitConfigData globalTraitConfig, int currentHeroStar)
	{
	}
}
