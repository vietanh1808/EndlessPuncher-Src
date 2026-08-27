using System.Collections.Generic;
using UnityEngine;

public class PetProjectilePool : MonoBehaviour
{
	[SerializeField]
	private int initialSize;

	[SerializeField]
	private Transform poolParent;

	private readonly Dictionary<GameObject, List<PetHsProjectile>> pooledProjectilesByPrefab;

	private void Awake()
	{
	}

	public PetHsProjectile Get(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public void ReturnToPool(PetHsProjectile projectile)
	{
	}

	private PetHsProjectile CreateProjectile(GameObject prefab, bool active)
	{
		return null;
	}

	private PetHsProjectile Activate(PetHsProjectile projectile, Vector3 position, Quaternion rotation)
	{
		return null;
	}
}
