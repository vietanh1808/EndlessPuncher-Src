using UnityEngine;

public interface ICombatUnit
{
	Transform Transform { get; }

	GameObject GameObject { get; }

	bool IsAlive { get; }

	float CurrentHealth { get; }

	float MaxHealth { get; }

	float HealthRatio { get; }
}
