using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestProbabilityCard : MonoBehaviour
{
	[Serializable]
	public struct RarityColor
	{
		public CollectiblesRarity rarity;

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

	public void SetChestProbabilityCard(CardRarity rarity, (float currentChance, float nextChance) chances, string displayName = null, bool applyRarityColor = true)
	{
	}

	public void SetChestProbabilityCard(CollectiblesRarity rarity, (float currentChance, float nextChance) chances, string displayName = null, bool applyRarityColor = true)
	{
	}

	public void SetProbabilityValues((float currentChance, float nextChance) chances)
	{
	}

	private string FormatProbability(float value)
	{
		return null;
	}

	private bool TryGetRarityColor(CollectiblesRarity rarity, out Color color)
	{
		color = default;
		return false;
	}

	private CollectiblesRarity ToCollectiblesRarity(CardRarity rarity)
	{
		return CollectiblesRarity.Common;
	}
}
