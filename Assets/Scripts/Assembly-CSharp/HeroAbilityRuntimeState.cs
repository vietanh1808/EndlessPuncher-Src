public class HeroAbilityRuntimeState
{
	public HeroAbilityBase Ability { get; private set; }

	public float CooldownEndTime { get; private set; }

	public HeroAbilityRuntimeState(HeroAbilityBase ability)
	{
	}

	public void SetAbility(HeroAbilityBase ability)
	{
	}

	public bool IsReady(float time)
	{
		return false;
	}

	public float GetRemainingCooldown(float time)
	{
		return 0f;
	}

	public void StartCooldown(float duration, float time)
	{
	}

	public void Reset()
	{
	}
}
