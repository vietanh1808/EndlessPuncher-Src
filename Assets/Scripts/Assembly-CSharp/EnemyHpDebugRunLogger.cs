public static class EnemyHpDebugRunLogger
{
	private const bool IsEnabled = true;

	private const string Prefix = "[EnemyHpDebug]";

	public static void LogRunSummary(int chapter)
	{
	}

	public static void LogStageEndpointSpawn(int chapter, int stage, int spawnIndex, int enemyCount, enemyType typeEnemy, float hpBeforeEnemyTypeMultiplier, float hpAfterEnemyTypeMultiplier)
	{
	}

	private static string FormatHp(float value)
	{
		return null;
	}

	private static string FormatMultiplier(float value)
	{
		return null;
	}
}
