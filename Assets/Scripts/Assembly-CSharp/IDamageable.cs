public interface IDamageable
{
	void ReceiveDamage(DamageContext context);

	void Heal(float amount);
}
