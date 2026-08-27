using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RarityChanceFrame : MonoBehaviour
{
	[Header("Level Up")]
	[SerializeField]
	private ParticleSystem levelUpParticle;

	[Header("UI")]
	[SerializeField]
	private Image background;

	[SerializeField]
	private Image pattern;

	[SerializeField]
	private Image innerLight;

	[SerializeField]
	private Image nextBackground;

	[SerializeField]
	private Image border;

	[SerializeField]
	private TextMeshProUGUI rarityNameTxt;

	[SerializeField]
	private TextMeshProUGUI currentChanceTxt;

	[SerializeField]
	private TextMeshProUGUI nextChanceTxt;

	public Rarity Rarity { get; private set; }

	public void Initialize(Rarity rarity)
	{
	}

	public void UpdateChances(float currentChance, float nextChance)
	{
	}

	private string FormatProbability(float value)
	{
		return null;
	}

	public void PlayRarityUpgradeEffect()
	{
	}

	private void PlayLevelUpParticle()
	{
	}
}
