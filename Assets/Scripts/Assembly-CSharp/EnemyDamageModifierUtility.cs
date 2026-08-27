using System.Collections.Generic;

public static class EnemyDamageModifierUtility
{
	private static readonly List<IEnemyDamageModifierProvider> Providers;

	public static void Register(IEnemyDamageModifierProvider provider)
	{
	}

	public static void Unregister(IEnemyDamageModifierProvider provider)
	{
	}

	public static float GetOutgoingDamageMultiplier(EnemyBehaviour sourceEnemy)
	{
		return 0f;
	}
}
