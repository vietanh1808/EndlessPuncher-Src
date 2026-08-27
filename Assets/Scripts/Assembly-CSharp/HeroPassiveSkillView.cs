using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroPassiveSkillView : MonoBehaviour
{
	private const string CooldownFormat = "{0:0.##}s";

	private const string EmptyText = "-";

	[Header("Basic Info")]
	[SerializeField]
	private Image skillIconImage;

	[SerializeField]
	private TMP_Text skillNameText;

	[SerializeField]
	private TMP_Text descriptionText;

	[Header("Values")]
	[SerializeField]
	private TMP_Text cooldownText;

	[Header("Star Upgrades")]
	[SerializeField]
	private HeroSkillStarRow[] starRows;

	public void Refresh(HeroSkillData skillData, int currentHeroStar)
	{
	}

	private void RefreshBasicInfo(HeroSkillData skillData)
	{
	}

	private void RefreshValues(HeroSkillData skillData)
	{
	}

	private void RefreshStarRows(HeroSkillData skillData, int currentHeroStar)
	{
	}
}
