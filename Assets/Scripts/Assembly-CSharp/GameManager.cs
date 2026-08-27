using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fubu.Inventory;
using Fubu.Inventory.DB;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[Serializable]
	public class BossChestRewardConfig
	{
		[Min(1f)]
		public int stage;

		public ChestTypes chestType;

		[Min(0f)]
		public int amount;

		public bool isEnabled;
	}

	[CompilerGenerated]
	private static Action m_OnDailyReset;

	[Header("Run Limits")]
	[SerializeField]
	private int maxTalentGemDropsPerRun;

	[SerializeField]
	private int maxInventoryGemDropsPerRun;

	[SerializeField]
	private int maxPetGemDropsPerRun;

	[SerializeField]
	private int maxNonBossChestKeysPerRun;

	[SerializeField]
	private int maxCollectibleChestKeysPerRun;

	[SerializeField]
	private int maxShopGemDropsPerRun;

	[SerializeField]
	private int maxEventCurrencyDropsPerRun;

	[SerializeField]
	private int maxRingGemDropsPerRun;

	[Header("Boss Chest Rewards")]
	[SerializeField]
	private ChestTypes defaultBossChestType;

	[SerializeField]
	[Min(0f)]
	private int defaultBossChestAmount;

	[SerializeField]
	private List<BossChestRewardConfig> bossChestRewardsByStage;

	[HideInInspector]
	public readonly string UnlockPetKey;

	[HideInInspector]
	public readonly string EnergyPanelUnlockKey;

	[HideInInspector]
	public readonly string ShopPanelUnlockKey;

	[Range(0f, 100f)]
	public float TalentGemDropChance;

	[Range(0f, 100f)]
	public float InventoryGemDropChance;

	[Range(0f, 100f)]
	public float PetGemDropChance;

	[Range(0f, 100f)]
	public float ShopGemDropChance;

	[Range(0f, 100f)]
	public float EventCurrencyDropChance;

	[Range(0f, 100f)]
	public float RingGemDropChance;

	[Range(0f, 100f)]
	public float CommonChestKeyDropChance;

	[Range(0f, 100f)]
	public float CollectibleChestKeyDropChance;

	private static GameManager _instance;

	public Action punchCounterAction;

	public Action stopAction;

	private bool _isGameStopped;

	public bool isDungeonScene;

	[SerializeField]
	private InGameUI gameUI;

	public RingCameraController ringCameraController;

	public ItemDB itemDB;

	public StatDB statDB;

	public WaveDB waveDB;

	public EnemyDB enemyDB;

	public PlayerDB playerDB;

	public RoomPurchaseDB roomDB;

	public CappybaraTalentDB cappyTalentDB;

	public QuestDB questDB;

	public TalentDB talentDB;

	public AudioManager audioManager;

	public PlayerItemHandler playerCostume;

	private int runCollectedNonBossChestKeyCount;

	private int runCollectedCollectibleChestKeyCount;

	private int runCollectedTalentGemCount;

	private int runCollectedInventoryGemCount;

	private int runCollectedPetGemCount;

	private int runCollectedShopGemCount;

	private int runCollectedEventCurrencyCount;

	private int runCollectedRingGemCount;

	public LayerMask maskEnemy;

	public float rangeCheckEnemy;

	private readonly Collider[] enemiesInRing;

	[SerializeField]
	private SceneLightController lightController;

	[SerializeField]
	private int MaxRewardedClaimX2Fail;

	[SerializeField]
	private int MaxRewardedClaimAllSkillStatSelection;

	[SerializeField]
	private int MaxRewardedFreeShopGem;

	[SerializeField]
	private int MaxRewardedPetClaimBtn1;

	[SerializeField]
	private int MaxRewardedPetClaimBtn2;

	[SerializeField]
	private int MaxRewardedDungeon1;

	[SerializeField]
	private int MaxRewardedDungeon2;

	[SerializeField]
	private int MaxRewardedDungeon3;

	[SerializeField]
	private int MaxRewardedDungeon4;

	[SerializeField]
	private int MaxClaimGemRingStar;

	[SerializeField]
	private int MaxRewardedNoEnergyReward;

	public static GameManager Instance => null;

	public bool IsGameStopped => false;

	public InGameUI GetInGameUI => null;

	public int MaxNonBossChestKeysPerRun => 0;

	public int MaxCollectibleChestKeysPerRun => 0;

	public int MaxTalentGemDropsPerRun => 0;

	public int MaxInventoryGemDropsPerRun => 0;

	public int MaxPetGemDropsPerRun => 0;

	public int MaxShopGemDropsPerRun => 0;

	public int MaxEventCurrencyDropsPerRun => 0;

	public int MaxRingGemDropsPerRun => 0;

	public static event Action OnDailyReset
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

	public void StopGame()
	{
	}

	public void StartGame()
	{
	}

	public void ResetRunStateForSoftRestart()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleRemoteConfigLoaded()
	{
	}

	public void AddSkillToTheList(SkillType skillType, CardRarity rarity, SkillUpgradeType skillUpgradeStat)
	{
	}

	public void AddSkillToTheList(SkillType skillType, StatDB.SkillUpgradeStatSaver skillUpgradeStat)
	{
	}

	public void EarnChest(ChestTypes chestType, int amount = 1)
	{
	}

	public void ApplyRunDropLimits(int nonBossChestKeysLimit, int collectibleChestKeysLimit, int talentGemLimit, int inventoryGemLimit, int petGemLimit, int shopGemLimit, int eventCurrencyLimit, int ringGemLimit)
	{
	}

	public bool CanDropNonBossChestKeyThisRun()
	{
		return false;
	}

	public bool TryConsumeNonBossChestKeyDropQuota()
	{
		return false;
	}

	public bool CanDropCollectibleChestKeyThisRun()
	{
		return false;
	}

	public bool TryConsumeCollectibleChestKeyDropQuota()
	{
		return false;
	}

	public bool CanDropCollectibleChestKey()
	{
		return false;
	}

	public bool CanDropTalentGemThisRun()
	{
		return false;
	}

	public bool TryConsumeTalentGemDropQuota()
	{
		return false;
	}

	public bool CanDropInventoryGemThisRun()
	{
		return false;
	}

	public bool TryConsumeInventoryGemDropQuota()
	{
		return false;
	}

	public bool CanDropPetGemThisRun()
	{
		return false;
	}

	public bool TryConsumePetGemDropQuota()
	{
		return false;
	}

	public bool CanDropShopGemThisRun()
	{
		return false;
	}

	public bool TryConsumeShopGemDropQuota()
	{
		return false;
	}

	public bool CanDropEventCurrencyThisRun()
	{
		return false;
	}

	public bool TryConsumeEventCurrencyDropQuota()
	{
		return false;
	}

	public bool CanDropRingGemThisRun()
	{
		return false;
	}

	public bool TryConsumeRingGemDropQuota()
	{
		return false;
	}

	public bool TryGetBossChestReward(out ChestTypes chestType, out int amount)
	{
		chestType = default;
		amount = default;
		return false;
	}

	public bool TryGetBossChestReward(int completedStage, out ChestTypes chestType, out int amount)
	{
		chestType = default;
		amount = default;
		return false;
	}

	public Collider[] GetEnemiesInRing(out int value, float range = 10f)
	{
		value = default;
		return null;
	}

	public void LightsActivity(bool isActive)
	{
	}

	public void SetTalentMenuLight(bool isActive)
	{
	}

	public void SetBossLight(bool isActive)
	{
	}

	public void LoadDungeon(string nameDungeon)
	{
	}

	public void ResetAllRewardsPerDay()
	{
	}

	public void RewardedClaimed(RewardedType typeRewarded)
	{
	}

	public bool CanRewardedActive(RewardedType typeRewarded)
	{
		return false;
	}

	public int GetRewardedMaxValues(RewardedType typeRewarded)
	{
		return 0;
	}

	private void OnDrawGizmos()
	{
	}
}
