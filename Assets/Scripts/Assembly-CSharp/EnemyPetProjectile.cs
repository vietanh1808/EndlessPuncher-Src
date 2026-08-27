using UnityEngine;

public class EnemyPetProjectile : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float maxLifetime;

	[SerializeField]
	private float hitRadius;

	[SerializeField]
	private ParticleSystem projectileEffect;

	[SerializeField]
	private ParticleSystem hitEffect;

	[SerializeField]
	private ParticleSystem flashEffect;

	private readonly Collider[] hitBuffer;

	private readonly RaycastHit[] castHitBuffer;

	private float damage;

	private float spawnHeight;

	private Vector3 moveDirection;

	private float lifeTimer;

	private bool isFlying;

	private LayerMask playerMask;

	private GameObject owner;

	public void Launch(Vector3 spawnPosition, Vector3 direction, float projectileDamage, LayerMask mask, GameObject projectileOwner)
	{
	}

	private void Update()
	{
	}

	private void TryHitPlayer(Vector3 previousPosition, Vector3 nextPosition)
	{
	}

	private bool TryHitPlayerAtPosition(Vector3 position)
	{
		return false;
	}

	private bool TryDamagePlayer(Collider hit, Vector3 hitPosition)
	{
		return false;
	}

	private void PlayHitEffect(Vector3 hitPosition)
	{
	}

	private void CompleteHit()
	{
	}

	private ParticleSystem FindHitEffect()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
