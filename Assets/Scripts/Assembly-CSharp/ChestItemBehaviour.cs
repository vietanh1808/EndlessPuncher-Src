using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestItemBehaviour : MonoBehaviour
{
	private int _chestShopPriceCommon;

	private int _chestShopPriceEpic;

	private int _chestShopPriceCollectible;

	private int _chestShopPriceHero;

	public ChestTypes typeChest;

	public GameObject[] chestIcons;

	public TextMeshProUGUI chestCount;

	[SerializeField]
	private GameObject commonChestLevelPanel;

	[SerializeField]
	private TextMeshProUGUI commonChestLevelText;

	[SerializeField]
	private TextMeshProUGUI sliderPercentageText;

	[SerializeField]
	private Slider commonChestProgressFill;

	[Header("Shop Button Settings")]
	[SerializeField]
	private GameObject keyBtn;

	[SerializeField]
	private Button shopBtn;

	[SerializeField]
	private TextMeshProUGUI shopBtnText;

	[SerializeField]
	private GameObject epicKey;

	[SerializeField]
	private GameObject colletibleKey;

	private Button cachedButton;

	private int totalChestCountForDisplay;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void ShopButtonConfig()
	{
	}

	private void SetKeyVisuals(bool showEpicKey, bool showCollectibleKey)
	{
	}

	public void CompletePurcaseShopGem()
	{
	}

	public void SpawnChest(ChestTypes typeChest)
	{
	}

	public void RefreshVisuals()
	{
	}

	private void OpenNoCrystalPanel()
	{
	}

	public void ChestOpened(int amountOpened)
	{
	}

	public void ChestOpenedWShopgem(int amountOpened)
	{
	}

	private void RefreshLevelVisuals()
	{
	}

	private int GetChestLevelDisplay()
	{
		return 0;
	}

	private float GetChestLevelProgress01()
	{
		return 0f;
	}

	private int GetChestLevelCurrentProgress()
	{
		return 0;
	}

	private int GetChestLevelRequiredProgress()
	{
		return 0;
	}

	public void LoadChestRarityTable()
	{
	}
}
