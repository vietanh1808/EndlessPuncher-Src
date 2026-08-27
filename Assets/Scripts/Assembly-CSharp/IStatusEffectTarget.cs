public interface IStatusEffectTarget
{
	bool IsUnderBurnEffect();

	bool IsUnderFreezEffect();

	bool IsUnderLightningEffect();

	void DeactivateEffect(EffectType type);
}
