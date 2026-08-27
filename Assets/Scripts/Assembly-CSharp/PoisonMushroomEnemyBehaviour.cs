using UnityEngine;

public class PoisonMushroomEnemyBehaviour : ExplosiveEnemyBehaviour
{
	[SerializeField]
	private float poisonTickDamageMultiplier;

	[SerializeField]
	private float poisonDuration;

	[SerializeField]
	private float poisonTickInterval;

	protected override void PlayDeathExplosionFx()
	{
	}

	protected override void Explode()
	{
	}
}
