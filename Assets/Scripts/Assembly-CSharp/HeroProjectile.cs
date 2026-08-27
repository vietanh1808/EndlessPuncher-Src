using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class HeroProjectile : MonoBehaviour
{
	private ICombatUnit source;

	private ICombatUnit target;

	private HeroProjectileConfig config;

	private Vector3 direction;

	private Vector3 targetPosition;

	private bool hasTargetPosition;

	private float damageMultiplier;

	private float baseDamage;

	private bool useBaseDamage;

	private HeroDamageType damageType;

	private float elapsedLifetime;

	private bool isInitialized;

	private bool hasHit;

	[CompilerGenerated]
	private Action<HeroProjectile> m_DespawnRequested;

	public event Action<HeroProjectile> DespawnRequested
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

	public void Initialize(HeroProjectileSpawnRequest request, Vector3 spawnPosition)
	{
	}

	private void Update()
	{
	}

	public void Despawn()
	{
	}

	private Vector3 ResolveInitialDirection(Vector3 requestedDirection)
	{
		return default;
	}

	private Vector3 ResolveDirectionTo(Vector3 position)
	{
		return default;
	}

	private void MoveProjectile()
	{
	}

	private void TryHitTarget()
	{
	}

	private void TryCompleteTargetPositionProjectile()
	{
	}

	private void ApplyRotation(Vector3 lookDirection)
	{
	}

	private void RequestDespawn()
	{
	}

	private void ResetRuntimeState()
	{
	}

	private static bool IsValidTarget(ICombatUnit unit)
	{
		return false;
	}

	private static Vector3 Flatten(Vector3 value)
	{
		return default;
	}

	private static float GetPlanarSqrDistance(Vector3 from, Vector3 to)
	{
		return 0f;
	}
}
