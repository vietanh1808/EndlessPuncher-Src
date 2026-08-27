public static class HeroProgressionMath
{
	public static int GetTotalTierUps(HeroDatabaseSO database, HeroProgressData progressData)
	{
		return 0;
	}

	public static int GetUpgradeCost(HeroDatabaseSO database, int currentLevel)
	{
		return 0;
	}

	public static bool TryGetStatValue(HeroDatabaseSO database, HeroData hero, string statID, HeroProgressData progressData, out float value)
	{
		value = default;
		return false;
	}

	public static bool TryGetStatValue(HeroData hero, HeroLevelUpConfigData levelUpConfig, string statID, HeroProgressData progressData, out float value)
	{
		value = default;
		return false;
	}

	public static bool TryGetStatValue(HeroData hero, HeroLevelUpConfigData levelUpConfig, HeroAscendConfigData ascendConfig, string statID, HeroProgressData progressData, out float value)
	{
		value = default;
		return false;
	}

	public static float GetStatValue(HeroDatabaseSO database, HeroData hero, string statID, HeroProgressData progressData)
	{
		return 0f;
	}

	public static float GetStatValue(HeroDatabaseSO database, HeroData hero, string statID, int currentLevel, int currentStar, int currentTier)
	{
		return 0f;
	}

	public static float GetStatValue(HeroData hero, HeroLevelUpConfigData levelUpConfig, string statID, HeroProgressData progressData)
	{
		return 0f;
	}

	public static float GetStatValue(HeroData hero, HeroLevelUpConfigData levelUpConfig, HeroAscendConfigData ascendConfig, string statID, HeroProgressData progressData)
	{
		return 0f;
	}

	public static float GetStatValue(HeroDatabaseSO database, HeroData hero, HeroStatData statData, HeroProgressData progressData)
	{
		return 0f;
	}

	public static float GetStatValue(HeroDatabaseSO database, HeroData hero, HeroStatData statData, int currentLevel, int currentStar, int currentTier)
	{
		return 0f;
	}

	public static float GetStatValue(HeroData hero, HeroLevelUpConfigData levelUpConfig, HeroStatData statData, HeroProgressData progressData)
	{
		return 0f;
	}

	public static float GetStatValue(HeroData hero, HeroLevelUpConfigData levelUpConfig, HeroAscendConfigData ascendConfig, HeroStatData statData, HeroProgressData progressData)
	{
		return 0f;
	}

	public static float GetStatValue(HeroData hero, HeroLevelUpConfigData levelUpConfig, HeroAscendConfigData ascendConfig, HeroStatData statData, int currentLevel, int currentStar, int currentTier)
	{
		return 0f;
	}
}
