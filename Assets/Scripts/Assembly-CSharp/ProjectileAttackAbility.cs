using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileAttackAbility", menuName = "Hero/Combat/Abilities/Projectile Attack")]
public class ProjectileAttackAbility : HeroAbilityBase
{
	[SerializeField]
	private HeroProjectile projectilePrefab;

	[SerializeField]
	private HeroProjectileConfig projectileConfig;

	[SerializeField]
	[Min(0f)]
	private float damageMultiplier;

	public HeroProjectile ProjectilePrefab => null;

	public HeroProjectileConfig ProjectileConfig => null;

	public float DamageMultiplier => 0f;

	private void OnValidate()
	{
	}

	public override bool CanUse(HeroAbilityContext context)
	{
		return false;
	}

	protected override void OnImpact(HeroAbilityContext context)
	{
	}

	private static bool TryGetValidCurrentTarget(HeroAbilityContext context, out ICombatUnit target)
	{
		target = null;
		return false;
	}

	private static bool IsValidTarget(ICombatUnit target)
	{
		return false;
	}
}
