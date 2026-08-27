using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillInfoPopup : MonoBehaviour
{
	[SerializeField]
	private GameObject panel;

	private SkillCard currentSkillCard;

	[SerializeField]
	private PreviewSkillCard previewSkillCard;

	private Animator animator;

	[SerializeField]
	private ParticleSystem upgradeParticle;

	[Header("Stat")]
	[SerializeField]
	private UpgradeStatFrame statFramePrefab;

	[SerializeField]
	private Transform statFramesContainer;

	private List<UpgradeStatFrame> statFrames;

	[Header("Player Stat")]
	[SerializeField]
	private List<UpgradePlayerStatFrame> playerStatFrames;

	[Header("Background")]
	[SerializeField]
	private Image background;

	[SerializeField]
	private Image decoration;

	[Header("Info")]
	[SerializeField]
	private TextMeshProUGUI nameText;

	[SerializeField]
	private TextMeshProUGUI rarityText;

	[SerializeField]
	private TextMeshProUGUI descriptionText;

	[Header("Buttons")]
	[SerializeField]
	private Button equipButton;

	[SerializeField]
	private Button unequipButton;

	[SerializeField]
	private Button upgradeButton;

	[SerializeField]
	private Button upgradeShopGemButton;

	[SerializeField]
	private TextMeshProUGUI textShopGemButton;

	[Header("Price Shop Gem")]
	[SerializeField]
	private int startPrice;

	[SerializeField]
	private int priceIncrease;

	public bool IsShowing => false;

	public SkillCard CurrentSkillCard => null;

	private void Awake()
	{
	}

	public void ShowInfo(SkillCard skillCard)
	{
	}

	private void SetBackgroundColor(Rarity rarity)
	{
	}

	private int GetNeedCards()
	{
		return 0;
	}

	private void UpgradeSkillLevel()
	{
	}

	private void UpgradeSkillLevelWShopGem()
	{
	}

	private void RefreshGlobalPowerAfterEquippedUpgrade(bool wasEquipped)
	{
	}

	private void OnEquipButtonClick()
	{
	}

	private void OnUnequipButtonClick()
	{
	}

	public void HideInfo()
	{
	}

	private void HideInfo(bool playFeedback)
	{
	}

	private static void PlayClickFeedback()
	{
	}

	private static void PlayUpgradeFeedback()
	{
	}
}
