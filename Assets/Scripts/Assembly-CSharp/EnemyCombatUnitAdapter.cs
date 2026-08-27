using UnityEngine;

[DisallowMultipleComponent]
public class EnemyCombatUnitAdapter : MonoBehaviour, ICombatUnit, IDamageable
{
	private IEnemy enemy;

	private ICombatHealthSource healthSource;

	public Transform Transform => null;

	public GameObject GameObject => null;

	public bool IsAlive => false;

	public float CurrentHealth => 0f;

	public float MaxHealth => 0f;

	public float HealthRatio => 0f;

	private void Awake()
	{
	}

	public void CacheReferences()
	{
	}

	public void ReceiveDamage(DamageContext context)
	{
	}

	public void Heal(float amount)
	{
	}
}
