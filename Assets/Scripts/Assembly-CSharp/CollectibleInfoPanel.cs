using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleInfoPanel : MonoBehaviour
{
	[Serializable]
	public class RarityObject
	{
		public CollectiblesRarity rarity;

		public GameObject backgroundObject;

		public GameObject iconBackgroundObject;

		public GameObject setBackgroundObject;
	}

	[Serializable]
	public class StatWriter
	{
		public PlayerStatType type;

		public GameObject obje;

		public TextMeshProUGUI currentTextValue;

		public TextMeshProUGUI nextTextValue;

		public void SetVisibility(bool isVisible)
		{
		}

		public void SetValues(string currentValue, string nextValue)
		{
		}
	}

	[Serializable]
	public class SpecialEffectWriter
	{
		public GameObject holder;

		public GameObject lockObje;

		public GameObject dotObje;

		public TextMeshProUGUI starText;

		public TextMeshProUGUI text;

		public Color colorDeactive;

		public Color colorActive;

		public Animator anim;

		public void SetVisibility(bool isVisible)
		{
		}

		public void SetText(string value)
		{
		}

		public void SetData(CollectiblesSO.CollectibleSpecialEffect specialEffect)
		{
		}

		public void SetActiveState(bool isActive)
		{
		}

		public void PlayBounce()
		{
		}
	}

	private const CurrencyTypes StarUpCurrencyType = CurrencyTypes.CollectibleCurrency;

	private static CollectibleInfoPanel _instance;

	[SerializeField]
	private GameObject panelObject;

	[SerializeField]
	private Transform panelTransform;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private TextMeshProUGUI nameText;

	[SerializeField]
	private TextMeshProUGUI descriptionText;

	[SerializeField]
	private TextMeshProUGUI rarityText;

	[SerializeField]
	private TextMeshProUGUI levelText;

	[SerializeField]
	private TextMeshProUGUI setText;

	[SerializeField]
	private GameObject setBadge;

	[SerializeField]
	private TextMeshProUGUI currentStatValueText;

	[SerializeField]
	private TextMeshProUGUI nextStatValueText;

	[SerializeField]
	private GameObject nextStatHolder;

	[SerializeField]
	private TextMeshProUGUI pieceCounterText;

	[SerializeField]
	private Button starUpButton;

	[SerializeField]
	private TextMeshProUGUI starUpPriceText;

	[SerializeField]
	private TextMeshProUGUI starUpShardText;

	[SerializeField]
	private Image shardIcon;

	[SerializeField]
	private GameObject[] stars;

	[SerializeField]
	private RarityObject[] rarityBackgrounds;

	[SerializeField]
	private StatWriter[] statWriters;

	[SerializeField]
	private SpecialEffectWriter[] specialEffectWriters;

	[SerializeField]
	private GameObject shardCurrency;

	[SerializeField]
	private GameObject BtnStar;

	[SerializeField]
	private ParticleSystem starUpParticle;

	[SerializeField]
	private ParticleSystem traitParticle;

	[SerializeField]
	private ParticleSystem confettieParticle;

	[CompilerGenerated]
	private static Action<string> m_StarUpPurchased;

	private CollectiblesSO.CollectibleData selectedCollectibleData;

	private int selectedCurrentLevel;

	private int selectedCurrentPieces;

	private bool isOpen;

	public static CollectibleInfoPanel Instance => null;

	public static event Action<string> StarUpPurchased
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

	public void OpenPanel(CollectiblesSO.CollectibleData collectibleData, int currentLevel, int currentPieces, Vector3 point)
	{
	}

	public void ClosePanel()
	{
	}

	private void DelayClose()
	{
	}

	private void SetHeader(CollectiblesSO.CollectibleData collectibleData, int currentLevel)
	{
	}

	private void SetCollectibleSetText(CollectiblesSO.CollectibleData collectibleData)
	{
	}

	private string GetCollectibleSetName(CollectiblesSO.CollectibleData collectibleData)
	{
		return null;
	}

	private void SetStatValues(CollectiblesSO.CollectibleData collectibleData, int currentLevel)
	{
	}

	private void SetPieceCounter(CollectiblesSO.CollectibleData collectibleData, int currentLevel, int currentPieces)
	{
	}

	private void SetStarUpButton(CollectiblesSO.CollectibleData collectibleData, int currentLevel, int currentPieces)
	{
	}

	private void SetStarUpObjectsActive(bool isActive)
	{
	}

	private string FormatCurrentNeedText(int current, int needed)
	{
		return null;
	}

	private string FormatPriceText(int current, int needed)
	{
		return null;
	}

	private void StarUpSelectedCollectible()
	{
	}

	private static void PlayStarUpFeedback()
	{
	}

	private void SetStars(int levelStar)
	{
	}

	private void RefreshCollectiblePowerState()
	{
	}

	private void PlayStarUpParticles(int previousLevel, int newLevel)
	{
	}

	private void PlayNewStarParticle(int newLevel)
	{
	}

	private void PlayUnlockedTraitParticle(int previousLevel, int newLevel)
	{
	}

	private void PlayConfettieParticle()
	{
	}

	private void PlayParticleAt(ParticleSystem particle, Transform target)
	{
	}

	private void SetRarityBackground(CollectiblesRarity rarity)
	{
	}

	private void SetStatWriters(PlayerStatType statType, float currentValue, float nextValue, bool hasNextLevel)
	{
	}

	private void SetSpecialEffects(CollectiblesSO.CollectibleData collectibleData, int currentLevel)
	{
	}

	private static string FormatSpecialEffect(CollectiblesSO.CollectibleSpecialEffect specialEffect)
	{
		return null;
	}

	private string FormatStatValue(PlayerStatType statType, float value)
	{
		return null;
	}

	private string Prefix(PlayerStatType statType)
	{
		return null;
	}

	private string Suffix(PlayerStatType statType)
	{
		return null;
	}
}
