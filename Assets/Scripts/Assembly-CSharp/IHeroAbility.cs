public interface IHeroAbility
{
	bool CanUse(HeroAbilityContext context);

	void Execute(HeroAbilityContext context);
}
