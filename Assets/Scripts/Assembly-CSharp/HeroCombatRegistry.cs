using System.Collections.Generic;

public static class HeroCombatRegistry
{
	private static readonly List<ICombatUnit> enemies;

	private static readonly List<ICombatUnit> allies;

	public static IReadOnlyList<ICombatUnit> Enemies => null;

	public static IReadOnlyList<ICombatUnit> Allies => null;

	public static void RegisterEnemy(ICombatUnit enemy)
	{
	}

	public static void UnregisterEnemy(ICombatUnit enemy)
	{
	}

	public static void RegisterAlly(ICombatUnit ally)
	{
	}

	public static void UnregisterAlly(ICombatUnit ally)
	{
	}

	public static bool IsValidEnemy(ICombatUnit enemy)
	{
		return false;
	}

	public static bool IsValidAlly(ICombatUnit ally)
	{
		return false;
	}
}
