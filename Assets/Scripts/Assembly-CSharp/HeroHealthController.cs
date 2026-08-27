using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HeroHealthController : MonoBehaviour, IDamageable, ICombatHealthSource
{
	[SerializeField]
	[Min(1f)]
	private float maxHealth;

	[SerializeField]
	[Min(0f)]
	private float currentHealth;

	[CompilerGenerated]
	private Action<DamageContext> m_DamageTaken;

	[CompilerGenerated]
	private Action<HeroHealthController> m_Died;

	[CompilerGenerated]
	private Action<float> m_Healed;

	public float CurrentHealth => 0f;

	public float MaxHealth => 0f;

	public float HealthRatio => 0f;

	public bool IsAlive => false;

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

	public event Action<HeroHealthController> Died
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

	private void OnValidate()
	{
	}

	public void Initialize(float health)
	{
	}

	public void ReceiveDamage(DamageContext context)
	{
	}

	public void Heal(float amount)
	{
	}
}
