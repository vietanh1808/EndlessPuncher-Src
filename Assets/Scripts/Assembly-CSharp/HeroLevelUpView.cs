using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroLevelUpView : MonoBehaviour
{
	private const string LevelFormat = "LVL-{0}";

	private const string MaxLevelText = "Max";

	[Header("Level")]
	[SerializeField]
	private TMP_Text currentLevelText;

	[SerializeField]
	private TMP_Text nextLevelText;

	[Header("Stats")]
	[SerializeField]
	private HeroStatComparisonRow maxHpRow;

	[SerializeField]
	private HeroStatComparisonRow punchDamageRow;

	[SerializeField]
	private HeroStatComparisonRow defenseRow;

	[Header("Currency")]
	[SerializeField]
	private TMP_Text levelUpCostText;

	[SerializeField]
	private CurrencyTypes levelUpCurrencyType;

	[Header("Button")]
	[SerializeField]
	private Button levelUpButton;

	public void Refresh(HeroDatabaseSO heroDatabase, HeroData heroData, HeroProgressData progressData)
	{
	}

	private void RefreshStatRows(HeroDatabaseSO heroDatabase, HeroData heroData, int currentLevel, int nextLevel, int currentStar, int currentTier)
	{
	}

	private static void RefreshStatRow(HeroStatComparisonRow row, HeroDatabaseSO heroDatabase, HeroData heroData, string statID, int currentLevel, int nextLevel, int currentStar, int currentTier)
	{
	}

	private void RefreshCurrency(HeroDatabaseSO heroDatabase, int currentLevel, bool isMaxLevel)
	{
	}

	private bool HasEnoughLevelUpCurrency(HeroDatabaseSO heroDatabase, int currentLevel)
	{
		return false;
	}
}
