using UnityEngine;

public class HeroAbilityContext
{
	public GameObject Owner { get; }

	public Transform OwnerTransform { get; }

	public GameObject CurrentTarget { get; }

	public Transform TargetTransform { get; }

	public HeroCombatController CombatController { get; }

	public HeroAnimationController AnimationController { get; }

	public HeroTargetingController Targeting { get; }

	public HeroProjectileSpawner ProjectileSpawner { get; }

	public Transform ProjectileSpawnPoint { get; }

	public bool HasTargetPosition { get; }

	public Vector3 TargetPosition { get; }

	public HeroAbilityContext(GameObject owner, Transform ownerTransform, Transform currentTarget, HeroCombatController combatController, HeroAnimationController animationController, HeroTargetingController targeting, HeroProjectileSpawner projectileSpawner, Transform projectileSpawnPoint, bool hasTargetPosition, Vector3 targetPosition)
	{
	}
}
