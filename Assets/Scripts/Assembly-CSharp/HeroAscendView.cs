using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroAscendView : MonoBehaviour
{
	private const string StarTierFormat = "{0}   / T{1}";

	private const string MaxAscendText = "Max";

	private const string ShardFormat = "{0} / {1} Shards";

	[Header("Progress")]
	[SerializeField]
	private TMP_Text currentStarTierText;

	[SerializeField]
	private TMP_Text nextStarTierText;

	[SerializeField]
	private HeroCardStar[] stars;

	[Header("Stats")]
	[SerializeField]
	private HeroStatComparisonRow maxHpRow;

	[SerializeField]
	private HeroStatComparisonRow punchDamageRow;

	[SerializeField]
	private HeroStatComparisonRow defenseRow;

	[Header("Global Traits")]
	[SerializeField]
	private HeroGlobalTraitRow[] globalTraitRowSlots;

	[Header("Cost")]
	[SerializeField]
	private TMP_Text requiredHeroShardsText;

	[Header("Button")]
	[SerializeField]
	private Button ascendButton;

	public void Refresh(HeroDatabaseSO heroDatabase, HeroData heroData, HeroProgressData progressData)
	{
	}

	private void RefreshStars(int currentStar, int currentTier)
	{
	}

	private void RefreshStatRows(HeroDatabaseSO heroDatabase, HeroData heroData, int currentLevel, int currentStar, int currentTier, int nextStar, int nextTier)
	{
	}

	private static void RefreshStatRow(HeroStatComparisonRow row, HeroDatabaseSO heroDatabase, HeroData heroData, string statID, int currentLevel, int currentStar, int currentTier, int nextStar, int nextTier)
	{
	}

	private void RefreshGlobalTraitRows(HeroDatabaseSO heroDatabase, HeroData heroData, int currentStar)
	{
	}

	private void RefreshCost(HeroAscendConfigData ascendConfig, HeroProgressData progressData, int currentStar, bool hasNext)
	{
	}

	private static string FormatStarTier(HeroAscendConfigData ascendConfig, int star, int tier)
	{
		return null;
	}
}
