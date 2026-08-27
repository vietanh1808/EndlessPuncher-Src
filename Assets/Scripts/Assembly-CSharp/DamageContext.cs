public struct DamageContext
{
	public ICombatUnit Source;

	public ICombatUnit Target;

	public float BaseDamage;

	public float FinalDamage;

	public bool IsCritical;

	public HeroDamageType DamageType;

	public DamageContext(ICombatUnit source, ICombatUnit target, float baseDamage, float finalDamage, bool isCritical, HeroDamageType damageType)
	{
		Source = null;
		Target = null;
		BaseDamage = 0f;
		FinalDamage = 0f;
		IsCritical = false;
		DamageType = HeroDamageType.RegularAttack;
	}
}
