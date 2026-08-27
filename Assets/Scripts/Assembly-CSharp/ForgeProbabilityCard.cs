using System;
using Fubu.Forge;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ForgeProbabilityCard : MonoBehaviour
{
	[Serializable]
	public struct RarityColor
	{
		public ForgeHandler.ItemRarity rarity;

		public Color color;
	}

	[Header("UI References")]
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private TextMeshProUGUI rarityNameText;

	[SerializeField]
	private TextMeshProUGUI currentProbabilityText;

	[SerializeField]
	private TextMeshProUGUI nextProbabilityText;

	[SerializeField]
	private Animator cardAnimator;

	[Header("Rarity Colors")]
	[SerializeField]
	private RarityColor[] rarityColors;

	[SerializeField]
	private ParticleSystem upgradeEffect;

	public void Initialize(ForgeHandler.ItemRarity rarity, (float currentChance, float nextChance) chances)
	{
	}

	public void UpdateCard(ForgeHandler.ItemRarity rarity, (float currentChance, float nextChance) chances)
	{
	}

	public void PlayUpgradeEffects()
	{
	}
}
