using UnityEngine;

public struct HeroProjectileSpawnRequest
{
	public HeroProjectile ProjectilePrefab;

	public HeroProjectileConfig Config;

	public ICombatUnit Source;

	public ICombatUnit Target;

	public bool HasTargetPosition;

	public Vector3 TargetPosition;

	public Vector3 Direction;

	public float DamageMultiplier;

	public float BaseDamage;

	public bool UseBaseDamage;

	public HeroDamageType DamageType;

	public static HeroProjectileSpawnRequest ForTarget(HeroProjectile projectilePrefab, HeroProjectileConfig config, ICombatUnit source, ICombatUnit target, float damageMultiplier, HeroDamageType damageType)
	{
		return default;
	}

	public static HeroProjectileSpawnRequest ForTargetPosition(HeroProjectile projectilePrefab, HeroProjectileConfig config, ICombatUnit source, Vector3 targetPosition, float damageMultiplier, HeroDamageType damageType)
	{
		return default;
	}

	public static HeroProjectileSpawnRequest ForDirection(HeroProjectile projectilePrefab, HeroProjectileConfig config, ICombatUnit source, Vector3 direction, float damageMultiplier, HeroDamageType damageType)
	{
		return default;
	}

	public static HeroProjectileSpawnRequest ForTargetWithBaseDamage(HeroProjectile projectilePrefab, HeroProjectileConfig config, ICombatUnit source, ICombatUnit target, float baseDamage, HeroDamageType damageType)
	{
		return default;
	}
}
