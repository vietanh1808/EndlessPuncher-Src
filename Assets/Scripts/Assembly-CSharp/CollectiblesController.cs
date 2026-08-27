using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectiblesController : Singleton<CollectiblesController>
{
	private enum CollectiblesView
	{
		Owneds = 0,
		Sets = 1,
		Upgradeables = 2
	}

	private const int CollectibleUnlockChapter = 5;

	[SerializeField]
	private CollectiblesSO collectiblesSO;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private GameObject collectibleSlotPrefab;

	[SerializeField]
	private GameObject collectibleSetSlotPrefab;

	[SerializeField]
	private Transform target;

	[SerializeField]
	private Transform targetMythical;

	[SerializeField]
	private Transform targetLegendary;

	[SerializeField]
	private Transform targetEpic;

	[SerializeField]
	private Transform targetRare;

	[SerializeField]
	private Transform targetUncommon;

	[SerializeField]
	private Transform targetCommon;

	[SerializeField]
	private Transform targetSet;

	[SerializeField]
	private Transform targetUpgradeable;

	[SerializeField]
	private GameObject collectibleSlotHolder;

	[SerializeField]
	private GameObject collectibleSlotHolderUpgradeable;

	[SerializeField]
	private GameObject collectibleSetSlotHolder;

	[SerializeField]
	private Button ownedBtn;

	[SerializeField]
	private Button setBtn;

	[SerializeField]
	private Button upgradibleBtn;

	[SerializeField]
	private bool populateOnStart;

	[SerializeField]
	private bool clearTargetBeforePopulate;

	[SerializeField]
	private GameObject upgradeableBtnAllert;

	[SerializeField]
	private GameObject collectibleBtn;

	[SerializeField]
	private GameObject collectibleCounterCurrency;

	[SerializeField]
	private ParticleSystem confettieParticle;

	private readonly List<CollectibleSlot> spawnedSlots;

	private readonly List<CollectibleSlot> spawnedUpgradeableSlots;

	private readonly List<CollectibleSetSlot> spawnedSetSlots;

	private CollectiblesView currentView;

	private Button activeTabButton;

	private bool ownedSlotsPopulated;

	private bool upgradeableSlotsPopulated;

	private bool setSlotsPopulated;

	public static CollectiblesSO ActiveCollectiblesSO { get; private set; }

	public CollectiblesSO Data => null;

	public bool IsPanelOpen => false;

	public bool IsUpgradeablesViewActive => false;

	public Transform CollectibleButtonTransform => null;

	public Transform UpgradeableButtonTransform => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Populate Collectibles")]
	public void Populate()
	{
	}

	[ContextMenu("Populate Collectible Sets")]
	public void PopulateSets()
	{
	}

	public void AddCollectiblePieces(string collectibleId, int amount)
	{
	}

	[ContextMenu("Clear Collectibles")]
	public void Clear()
	{
	}

	private void ClearCollectibles()
	{
	}

	private void ClearOwnedCollectibles()
	{
	}

	private void ClearUpgradeableCollectibles()
	{
	}

	private void ClearSets()
	{
	}

	private void DestroySlotObject(GameObject slotObject)
	{
	}

	private void ClearUntrackedCollectibleSlots(bool upgradeableOnly)
	{
	}

	private void HandleCollectibleStarUpPurchased(string collectibleId)
	{
	}

	public void LoadOwneds()
	{
	}

	public void LoadSets()
	{
	}

	public void LoadUpgradeables()
	{
	}

	private void PopulateUpgradeables()
	{
	}

	private void SelectTab(CollectiblesView view, Button selectedButton)
	{
	}

	private void ResetInactiveTabButtons(Button selectedButton)
	{
	}

	private static void TriggerInactiveTabButton(Button button, Button selectedButton)
	{
	}

	private static void TriggerTabButton(Button button, int triggerHash, int resetHash)
	{
	}

	public void OpenPanel(bool updateMenuState = true)
	{
	}

	public void RefreshCollectibleButtonUnlock()
	{
	}

	public bool HasActivatableCollectible()
	{
		return false;
	}

	public bool HasCollectibleNotification()
	{
		return false;
	}

	public bool HasUpgradeableCollectible()
	{
		return false;
	}

	private void RefreshUpgradeableButtonAlert()
	{
	}

	private static bool CanActivateCollectible(CollectiblesSO.CollectibleData collectible, int levelStar, int pieces, bool isActivated)
	{
		return false;
	}

	private static bool CanUpgradeCollectible(CollectiblesSO.CollectibleData collectible, int levelStar, int pieces, bool isActivated)
	{
		return false;
	}

	public CollectibleSlot GetFirstActivatableSlot()
	{
		return null;
	}

	public void PlayActivateConfettie(Vector3 position)
	{
	}

	private bool IsCollectibleButtonUnlocked()
	{
		return false;
	}

	public static bool IsCollectibleUnlocked()
	{
		return false;
	}

	public void ClosePanel()
	{
	}

	private static void PlayClickFeedback()
	{
	}

	public void RefreshCurrentView()
	{
	}

	private List<CollectiblesSO.CollectibleData> GetSortedCollectibles()
	{
		return null;
	}

	private bool TryRefreshCollectibleSlots(List<CollectibleSlot> slots, bool upgradeableView)
	{
		return false;
	}

	private bool TryRefreshSetSlots()
	{
		return false;
	}

	private static void SetCollectibleSlotData(CollectibleSlot slot, CollectiblesSO.CollectibleData collectibleData)
	{
	}

	private void SetHoldersActive(CollectiblesView view)
	{
	}

	private void SetSpawnedSlotsActive(bool active)
	{
	}

	private void SortSpawnedSlotsByRarity()
	{
	}

	private Transform GetTargetForRarity(CollectiblesRarity rarity)
	{
		return null;
	}

	private List<Transform> GetOwnedCollectibleTargets()
	{
		return null;
	}

	private List<Transform> GetUpgradeableCollectibleTargets()
	{
		return null;
	}

	private static void AddUniqueTarget(List<Transform> targets, Transform targetToAdd)
	{
	}

	private static int CompareSlotsByRarity(CollectibleSlot first, CollectibleSlot second)
	{
		return 0;
	}

	private static int CompareCollectiblesByRarity(CollectiblesSO.CollectibleData first, CollectiblesSO.CollectibleData second)
	{
		return 0;
	}

	private static int CompareRarity(CollectiblesRarity first, CollectiblesRarity second)
	{
		return 0;
	}

	private static int GetRaritySortWeight(CollectiblesRarity rarity)
	{
		return 0;
	}
}
