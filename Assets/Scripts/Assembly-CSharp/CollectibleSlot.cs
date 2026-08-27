using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleSlot : MonoBehaviour
{
	[Serializable]
	public class RarityBgColor
	{
		public CollectiblesRarity rarity;

		public Color colorBg;

		public Color colorOutline;

		public Color colorBorder;
	}

	private const CurrencyTypes StarUpCurrencyType = CurrencyTypes.CollectibleCurrency;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private TextMeshProUGUI title;

	[SerializeField]
	private Vector3 localTextpos;

	[SerializeField]
	private Vector3 localTextposActivete;

	[SerializeField]
	private TextMeshProUGUI pieceCounter;

	[SerializeField]
	private GameObject[] stars;

	[SerializeField]
	private Slider piecesSlider;

	[SerializeField]
	private Button button;

	[SerializeField]
	private Image imageBackGround;

	[SerializeField]
	private Image imageBorder;

	[SerializeField]
	private Image imageOutline;

	[SerializeField]
	private RarityBgColor[] colorBackGrounds;

	[SerializeField]
	private GameObject activateBanner;

	[SerializeField]
	private GameObject deactiveCover;

	[SerializeField]
	private GameObject notificationDot;

	[SerializeField]
	private Animator animColl;

	[SerializeField]
	private Image sliderFill;

	[SerializeField]
	private Color sliderDeactifColor;

	[SerializeField]
	private Color sliderActifColor;

	private CollectiblesSO.CollectibleData collectibleData;

	private int currentLevelStar;

	private int currentPieces;

	private bool isActivated;

	private bool isInCollectibleSet;

	private Button activateBannerButton;

	[CompilerGenerated]
	private static Action<CollectibleSlot> m_CollectibleActivated;

	public CollectiblesSO.CollectibleData CollectibleData => null;

	public CollectiblesRarity Rarity => CollectiblesRarity.Common;

	public bool CanUpgrade => false;

	public bool CanActivate => false;

	public static event Action<CollectibleSlot> CollectibleActivated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetData(CollectiblesSO.CollectibleData data)
	{
	}

	public void SetData(CollectiblesSO.CollectibleData data, int levelStar, int currentPieces)
	{
	}

	public void SetData(CollectiblesSO.CollectibleData data, int levelStar, int currentPieces, bool inCollectibleSet)
	{
	}

	private static Sprite GetDisplayIcon(CollectiblesSO.CollectibleData data, int levelStar)
	{
		return null;
	}

	private void OpenInfoPanel()
	{
	}

	private void ActivateCollectible()
	{
	}

	private static void PlayClickFeedback()
	{
	}

	private static void PlayPurchaseFeedback()
	{
	}

	private void RefreshCollectiblePowerState()
	{
	}

	private bool IsWaitingForActivation(CollectiblesSO.CollectibleData data, int levelStar, int pieces)
	{
		return false;
	}

	private void SetActivateBanner(bool isActive)
	{
	}

	private void SetNotificationState(bool isActive)
	{
	}

	private void SetDeactiveCover(bool isActive)
	{
	}

	private void SetStars(int levelStar)
	{
	}

	private void SetPieceProgress(int currentPieces, int requiredPieces)
	{
	}

	private void ApplyRarityColors(CollectiblesRarity rarity)
	{
	}

	private RarityBgColor GetRarityColors(CollectiblesRarity rarity)
	{
		return null;
	}

	private Color GetDefaultBackgroundColor(CollectiblesRarity rarity)
	{
		return default;
	}

	private Color GetDefaultBorderColor(CollectiblesRarity rarity)
	{
		return default;
	}

	private Color GetDefaultOutlineColor(CollectiblesRarity rarity)
	{
		return default;
	}

	private void Clear()
	{
	}
}
