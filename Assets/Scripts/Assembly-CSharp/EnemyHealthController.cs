using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour, ICombatUnit, IDamageable
{
	[SerializeField]
	[Min(1f)]
	private float maxHealth;

	[SerializeField]
	[Min(0f)]
	private float currentHealth;

	[SerializeField]
	private EnemyCombatController combatController;

	[SerializeField]
	private EnemyMovementController movementController;

	[CompilerGenerated]
	private Action<DamageContext> m_DamageTaken;

	[CompilerGenerated]
	private Action<EnemyHealthController> m_Died;

	[CompilerGenerated]
	private Action<float> m_Healed;

	public Transform Transform => null;

	public GameObject GameObject => null;

	public bool IsAlive => false;

	public float CurrentHealth => 0f;

	public float MaxHealth => 0f;

	public float HealthRatio => 0f;

	public event Action<DamageContext> DamageTaken
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

	public event Action<EnemyHealthController> Died
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

	public event Action<float> Healed
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

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}

	public void ReceiveDamage(DamageContext context)
	{
	}

	public void Heal(float amount)
	{
	}

	private void Die()
	{
	}
}
