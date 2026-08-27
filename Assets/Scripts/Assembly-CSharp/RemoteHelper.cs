using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class RemoteHelper
{
	private static RemoteHelper instance;

	private const string DefaultChancesJson = "\n            {\n              \"talentGemDropChance\": { \"chance\": 1.5, \"limits\": \"nolimit\" },\n              \"inventoryGemDropChance\": { \"chance\": 0.1, \"limits\": \"nolimit\" },\n              \"petGemDropChance\": { \"chance\": 1, \"limits\": \"nolimit\" },\n              \"shopGemDropChance\": { \"chance\": 0.1, \"limits\": 20 },\n              \"eventCurrencyDropChance\": { \"chance\": 3, \"limits\": 200 },\n              \"ringGemDropChance\": { \"chance\": 1, \"limits\": 20 },\n              \"commonChestKeyDropChance\": { \"chance\": 0.3, \"limits\": 4 },\n              \"collectibleChestKeyDropChance\": { \"chance\": 0.1, \"limits\": 3 }\n            }";

	private const string DefaultShopProductPricesJson = "\n            {\n                \"products\": {\n                    \"endlesspuncher_no_ads_pack\": 6.99,\n                    \"endlesspuncher_weekly_boost_pack\": 9.99,\n                    \"endlesspuncher_piggybank_offer\": 31.99,\n                    \"endlesspuncher_eventpass_pack\": 9.99,\n                    \"endlesspuncher_energy_pack_5\": 2.99,\n                    \"endlesspuncher_energy_pack_15\": 7.99,\n                    \"endlesspuncher_energy_pack_40\": 19.99,\n                    \"endlesspuncher_energy_pack_100\": 49.99,\n                    \"endlesspuncher_energy_pack_250\": 99.99,\n                    \"endlesspuncher_energy_pack_500\": 179.99,\n                    \"endlesspuncher_shopgem_pack_1000\": 2.99,\n                    \"endlesspuncher_shopgem_pack_3300\": 8.99,\n                    \"endlesspuncher_shopgem_pack_10000\": 24.99,\n                    \"endlesspuncher_chain_offer_1\": 4.99,\n                    \"endlesspuncher_chain_offer_2\": 9.99,\n                    \"endlesspuncher_chain_offer_3\": 14.99,\n                    \"endlesspuncher_chain_offer_4\": 19.99,\n                    \"endlesspuncher_chain_offer_5\": 24.99,\n                    \"endlesspuncher_chain_offer_6\": 29.99,\n                    \"endlesspuncher_chain_offer_7\": 34.99,\n                    \"endlesspuncher_chain_offer_8\": 39.99,\n                    \"endlesspuncher_chain_offer_9\": 44.99,\n                    \"endlesspuncher_chain_offer_10\": 49.99\n                }\n            }";

	private const string DefaultDailyRewardsJson = "\n            {\n              \"lists\": [\n                {\n                  \"name\": \"Week 1\",\n                  \"rewards\": [\n                    { \"id\": \"Energy\", \"amount\": 15 },\n                    { \"id\": \"Gem\", \"amount\": 75 },\n                    { \"id\": \"CommonKey\", \"amount\": 5 },\n                    { \"id\": \"EpicKey\", \"amount\": 3 },\n                    { \"id\": \"Gem\", \"amount\": 100 },\n                    { \"id\": \"Energy\", \"amount\": 30 },\n                    {\"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 5 }, { \"id\": \"CommonKey\", \"amount\": 15 } ] }\n                  ]\n                },\n                {\n                  \"name\": \"Week 2\",\n                  \"rewards\": [\n                    { \"id\": \"Gem\", \"amount\": 50 },\n                    { \"id\": \"CommonKey\", \"amount\": 5 },\n                    { \"id\": \"Energy\", \"amount\": 40 },\n                    { \"id\": \"EpicKey\", \"amount\": 3 },\n                    { \"id\": \"Gem\", \"amount\": 100 },\n                    { \"id\": \"CommonKey\", \"amount\": 10 },\n                    {\"rewards\": [ { \"id\": \"Energy\", \"amount\": 50 }, { \"id\": \"EpicKey\", \"amount\": 5 } ] }\n                  ]\n                }\n              ]\n            }";

	private const string DefaultChainOfferRewardsJson = "\n            {\n  \"rewards\": [\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 5 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 20 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_1\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 5} ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"CommonKey\", \"amount\": 3 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 30 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_2\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 10 }, { \"id\": \"Energy\", \"amount\": 10 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 40 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 15 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_3\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 10 },{ \"id\": \"PetGem\", \"amount\": 50 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"CommonKey\", \"amount\": 5 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 15 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_4\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 15 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 20 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 50 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_5\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 15 }, { \"id\": \"CommonKey\", \"amount\": 20 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"CommonKey\", \"amount\": 5 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"CommonKey\", \"amount\": 5 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_6\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 15 }, { \"id\": \"Energy\", \"amount\": 50 }  ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 50 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 50 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_7\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 15 }, { \"id\": \"CommonKey\", \"amount\": 20 }, { \"id\": \"Energy\", \"amount\": 50 }  ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 2 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 20 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_8\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 20 }, { \"id\": \"PetGem\", \"amount\": 100 }, { \"id\": \"Energy\", \"amount\": 50 }   ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 20 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"CommonKey\", \"amount\": 10 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_9\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 20 }, { \"id\": \"CommonKey\", \"amount\": 20 }, { \"id\": \"PetGem\", \"amount\": 150 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 25 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 60 } ] },\n    { \"purchaseType\": \"Paid\", \"shopProductId\": \"endlesspuncher_chain_offer_10\", \"rewards\": [ { \"id\": \"EpicKey\", \"amount\": 20 }, { \"id\": \"Energy\", \"amount\": 75 } , { \"id\": \"CommonKey\", \"amount\": 30 } , { \"id\": \"PetGem\", \"amount\": 150 }  ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"Energy\", \"amount\": 30 } ] },\n    { \"purchaseType\": \"Free\", \"rewards\": [ { \"id\": \"PetGem\", \"amount\": 70 } ] }\n  ]\n}";

	private static string dailyRewardsJson;

	private static JObject cachedDailyRewards;

	private static string cachedDailyRewardsJson;

	private static string chainOfferRewardsJson;

	private static string cachedChainOfferRewardsJson;

	private static ChainOfferSO cachedChainOfferSource;

	private static List<ChainOfferReward> cachedChainOfferRewards;

	private static string giantScalingJson;

	private static string armIncKey;

	private static string enemySpawnrPerID;

	private static string incPricePerid;

	private static string enemyHpMultip;

	private static string ringUpgradeStatIncreasePerLevel;

	private static string cachedRingUpgradeStatIncreasePerLevelJson;

	private static Dictionary<PlayerStatType, float> cachedRingUpgradeStatIncreasePerLevelValues;

	public static RemoteHelper GetInstance()
	{
		return null;
	}

	private RemoteHelper()
	{
	}

	public bool TryGetDailyReward(int listIndex, int dayIndex, out string rewardId, out int amount)
	{
		rewardId = null;
		amount = default;
		return false;
	}

	public bool TryGetDailyRewards(int listIndex, int dayIndex, out List<DailyRemoteReward> dailyRewards)
	{
		dailyRewards = null;
		return false;
	}

	private void ParseDailyRewardToken(JToken rewardToken, List<DailyRemoteReward> parsedRewards)
	{
	}

	private JObject GetDailyRewardsJson()
	{
		return null;
	}

	private string GetDailyRewardsJsonString()
	{
		return null;
	}

	public IReadOnlyList<ChainOfferReward> GetChainOfferRewards(ChainOfferSO chainOfferSO)
	{
		return null;
	}

	public void InvalidateChainOfferRewardsCache()
	{
	}

	private string GetChainOfferRewardsJsonString()
	{
		return null;
	}

	private bool TryParseChainOfferRewards(ChainOfferSO chainOfferSO, string rewardsJson, out List<ChainOfferReward> rewards)
	{
		rewards = null;
		return false;
	}

	private ChainOfferReward ParseChainOfferReward(ChainOfferSO chainOfferSO, ChainOfferReward localReward, JObject slotJson, int slotIndex)
	{
		return null;
	}

	private ChainOfferPurchaseType ParseChainOfferPurchaseType(JObject slotJson, ChainOfferReward localReward)
	{
		return ChainOfferPurchaseType.Free;
	}

	private ShopProductDataSO ResolveChainOfferProduct(ChainOfferSO chainOfferSO, ChainOfferReward localReward, JObject slotJson, int slotIndex)
	{
		return null;
	}

	public float GetCrystalValueForClaimAll()
	{
		return 0f;
	}

	public float GetCrystalValueForEndGameX2()
	{
		return 0f;
	}

	public int GetWeeklyAdsDurationMinutes()
	{
		return 0;
	}

	public void ApplyShopProductPrices(IEnumerable<ShopProductDataSO> products)
	{
	}

	private static JObject GetObject(JObject json, params string[] keys)
	{
		return null;
	}

	private static bool TryGetRemoteShopPrice(JObject pricesJson, string key, out float priceUsd, out string fallbackPriceText)
	{
		priceUsd = default;
		fallbackPriceText = null;
		return false;
	}

	private static JToken GetTokenIgnoreCase(JObject json, string key)
	{
		return null;
	}

	private static bool TryReadFloat(JToken token, out float value)
	{
		value = default;
		return false;
	}

	public void ApplyDropChances(GameManager gameManager)
	{
	}

	private static float GetDropChance(JObject json, string propertyName, float fallback)
	{
		return 0f;
	}

	private static int GetDropLimit(JObject json, string propertyName, int fallback)
	{
		return 0;
	}

	public float EnemyCountStart()
	{
		return 0f;
	}

	public float EnemyCountPerChapter()
	{
		return 0f;
	}

	public float EnemyCountStageMultiplier()
	{
		return 0f;
	}

	public float EnemyCountMax()
	{
		return 0f;
	}

	public float EnemyHPStart()
	{
		return 0f;
	}

	public float EnemyBaseDamage()
	{
		return 0f;
	}

	public float EnemyHPIncreasePerChapters()
	{
		return 0f;
	}

	public float EnemyDamageIncreasePerChapter()
	{
		return 0f;
	}

	public float EnemyDamageIncreasePerStage()
	{
		return 0f;
	}

	public float EnemyDamageIncreasePerWave()
	{
		return 0f;
	}

	public float BossHPStart()
	{
		return 0f;
	}

	public float BossBaseDamage()
	{
		return 0f;
	}

	public float BossHPIncreasePerChapters()
	{
		return 0f;
	}

	public float BossDamageIncreasePerChapter()
	{
		return 0f;
	}

	public float BossHpMultiplierFromLastEnemy(float fallback)
	{
		return 0f;
	}

	public void GetTalentSlotPricing(int priceStartFallback, int priceIncreaseFallback, out int priceStart, out int priceIncrease)
	{
		priceStart = default;
		priceIncrease = default;
	}

	public void GetGiantScaling(float healthStartFallback, float healthIncreaseFallback, float damageStartFallback, float damageIncreaseFallback, out float healthStart, out float healthIncrease, out float damageStart, out float damageIncrease)
	{
		healthStart = default;
		healthIncrease = default;
		damageStart = default;
		damageIncrease = default;
	}

	private float ReadGiantScalingValue(JObject json, string key, float fallback)
	{
		return 0f;
	}

	public float GoldAmountPerEnemy()
	{
		return 0f;
	}

	public float EnemyGoldIncreaseAmountPerChapter()
	{
		return 0f;
	}

	public float GoldAmountBossComplete()
	{
		return 0f;
	}

	public float GoldAmountBossCompletePerChapter()
	{
		return 0f;
	}

	public float GemAmountBossComplete()
	{
		return 0f;
	}

	public float GemAmountBossCompletePerChapter()
	{
		return 0f;
	}

	public int EnergyAmountBossComplete()
	{
		return 0;
	}

	public int GetInrementalArmPrice(string id)
	{
		return 0;
	}

	private string GetExtraArmPrices()
	{
		return null;
	}

	public float GetEnemySpawnWaveIndexandSpawnOrder(string waveIndex, int spawnOrder)
	{
		return 0f;
	}

	public float GetEnemyCountInWave(JToken jsonToken, string id)
	{
		return 0f;
	}

	private string getEnemySpawnID()
	{
		return null;
	}

	public float GetIncPriceWID(int incID, int idOrder)
	{
		return 0f;
	}

	public float GetIncPriceWID(JToken jsonToken, string id)
	{
		return 0f;
	}

	private string getIncSpawnID()
	{
		return null;
	}

	public float GetEnemyHPMultiplier(string chapterStageWaveID, string multiplierKey)
	{
		return 0f;
	}

	public float GetEnemyHPMultipWID(JToken jsonToken, string multiplierKey)
	{
		return 0f;
	}

	private string GetEnemyHPMultipID()
	{
		return null;
	}

	public float GetRingUpgradeStatIncreasePerLevel(PlayerStatType statType, float defaultValue)
	{
		return 0f;
	}

	private Dictionary<PlayerStatType, float> GetRingUpgradeStatIncreasePerLevelValues()
	{
		return null;
	}

	private string GetRingUpgradeStatRemoteKey(PlayerStatType statType)
	{
		return null;
	}

	private string GetRingUpgradeStatIncreasePerLevelJson()
	{
		return null;
	}
}
