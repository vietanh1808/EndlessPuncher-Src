public interface ICombatHealthSource
{
	float CurrentHealth { get; }

	float MaxHealth { get; }

	float HealthRatio { get; }

	bool IsAlive { get; }
}
