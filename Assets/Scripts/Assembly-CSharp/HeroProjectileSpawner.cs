using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class HeroProjectileSpawner : MonoBehaviour
{
	[SerializeField]
	private Transform defaultSpawnPoint;

	[SerializeField]
	private Transform poolParent;

	[SerializeField]
	[Min(0f)]
	private int prewarmCount;

	private readonly Dictionary<HeroProjectile, List<HeroProjectile>> pooledProjectilesByPrefab;

	public Transform DefaultSpawnPoint => null;

	private void Awake()
	{
	}

	public HeroProjectile Spawn(HeroProjectileSpawnRequest request)
	{
		return null;
	}

	public HeroProjectile Spawn(HeroProjectileSpawnRequest request, Transform spawnPoint)
	{
		return null;
	}

	public HeroProjectile Spawn(HeroProjectileSpawnRequest request, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	private HeroProjectile GetProjectile(HeroProjectile prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	private void Prewarm(HeroProjectile prefab, List<HeroProjectile> pool)
	{
	}

	private HeroProjectile CreateProjectile(HeroProjectile prefab, List<HeroProjectile> pool)
	{
		return null;
	}

	private HeroProjectile Activate(HeroProjectile projectile, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	private void ReturnToPool(HeroProjectile projectile)
	{
	}
}
