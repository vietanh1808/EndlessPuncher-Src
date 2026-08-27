using UnityEngine;

public abstract class HeroAbilityBase : ScriptableObject, IHeroAbility
{
	[SerializeField]
	private HeroAnimationType animationType;

	[SerializeField]
	private HeroAbilityExecutionMode executionMode;

	[SerializeField]
	private bool blocksCombat;

	[SerializeField]
	private bool blocksMovement;

	[SerializeField]
	private bool faceCurrentTargetOnStart;

	[SerializeField]
	[Min(0f)]
	private float cooldown;

	[SerializeField]
	[Min(0f)]
	private float maxExecutionDuration;

	public HeroAnimationType AnimationType => HeroAnimationType.RegularAttack;

	public HeroAbilityExecutionMode ExecutionMode => HeroAbilityExecutionMode.Immediate;

	public bool BlocksCombat => false;

	public bool BlocksMovement => false;

	public bool FaceCurrentTargetOnStart => false;

	public float Cooldown => 0f;

	public float MaxExecutionDuration => 0f;

	public virtual bool CanUse(HeroAbilityContext context)
	{
		return false;
	}

	public virtual void Execute(HeroAbilityContext context)
	{
	}

	public void TriggerImpact(HeroAbilityContext context)
	{
	}

	public void TriggerComplete(HeroAbilityContext context)
	{
	}

	protected virtual void OnExecute(HeroAbilityContext context)
	{
	}

	protected virtual void OnImpact(HeroAbilityContext context)
	{
	}

	protected virtual void OnComplete(HeroAbilityContext context)
	{
	}

	protected void SetAnimationType(HeroAnimationType value)
	{
	}
}
