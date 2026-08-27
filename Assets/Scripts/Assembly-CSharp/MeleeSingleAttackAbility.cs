using UnityEngine;

[CreateAssetMenu(fileName = "MeleeSingleAttackAbility", menuName = "Hero/Combat/Abilities/Melee Single Attack")]
public class MeleeSingleAttackAbility : HeroAbilityBase
{
	[SerializeField]
	[Min(0f)]
	private float damageMultiplier;

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
