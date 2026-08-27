using UnityEngine;

[CreateAssetMenu(fileName = "HeroProjectileConfig", menuName = "Hero/Combat/Projectile Config")]
public class HeroProjectileConfig : ScriptableObject
{
	[SerializeField]
	[Min(0.01f)]
	private float speed;

	[SerializeField]
	[Min(0.01f)]
	private float lifetime;

	[SerializeField]
	[Min(0.01f)]
	private float hitRadius;

	[SerializeField]
	private bool rotateTowardsDirection;

	[SerializeField]
	private bool homing;

	[SerializeField]
	private bool despawnOnHit;

	[SerializeField]
	private Vector3 rotationOffset;

	public float Speed => 0f;

	public float Lifetime => 0f;

	public float HitRadius => 0f;

	public bool RotateTowardsDirection => false;

	public bool Homing => false;

	public bool DespawnOnHit => false;

	public Vector3 RotationOffset => default;

	private void OnValidate()
	{
	}
}
