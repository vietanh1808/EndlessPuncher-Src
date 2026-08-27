public interface IEnemyHealth
{
	int MaxHp { get; }

	float CurrentHp { get; }

	bool IsLastHit(float value);

	void TakeDamageFromEffect(float damage);

	void SetIceEffectActive(bool isActive);
}
