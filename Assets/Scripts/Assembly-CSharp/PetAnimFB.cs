using UnityEngine;

public class PetAnimFB : MonoBehaviour
{
	[SerializeField]
	private Transform projectileSpawnPoint;

	[SerializeField]
	private float projectileSize;

	private PetBehaviour petBehaviour;

	private EnemyPetBehaviour enemyPetBehaviour;

	public Transform ProjectileSpawnPoint => null;

	public float ProjectileSize => 0f;

	private void Awake()
	{
	}

	public void HandleAttackShootEvent()
	{
	}

	public void DeathFinished()
	{
	}
}
