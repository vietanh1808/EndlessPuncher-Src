using System;
using System.Runtime.CompilerServices;

public static class HeroDamageService
{
	[CompilerGenerated]
	private static Action<DamageContext> m_DamageDealt;

	[CompilerGenerated]
	private static Action<DamageContext> m_DamageTaken;

	[CompilerGenerated]
	private static Action<ICombatUnit> m_UnitDied;

	public static event Action<DamageContext> DamageDealt
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

	public static event Action<DamageContext> DamageTaken
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

	public static event Action<ICombatUnit> UnitDied
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

	public static DamageContext ApplyHeroDamage(ICombatUnit source, ICombatUnit target, float damageMultiplier, HeroDamageType damageType)
	{
		return default;
	}

	public static DamageContext ApplyDamage(ICombatUnit source, ICombatUnit target, float baseDamage, HeroDamageType damageType)
	{
		return default;
	}

	public static DamageContext CreateDamageContext(ICombatUnit source, ICombatUnit target, float baseDamage, HeroDamageType damageType)
	{
		return default;
	}

	private static float ResolveBaseDamage(float baseDamage)
	{
		return 0f;
	}

	private static bool RollCritical(ICombatUnit source)
	{
		return false;
	}

	private static float GetCriticalDamageMultiplier(ICombatUnit source)
	{
		return 0f;
	}

	private static float ApplyDefense(float damage, ICombatUnit source, ICombatUnit target)
	{
		return 0f;
	}

	private static bool TryGetHeroStat(ICombatUnit unit, string statID, out float value)
	{
		value = default;
		return false;
	}
}
