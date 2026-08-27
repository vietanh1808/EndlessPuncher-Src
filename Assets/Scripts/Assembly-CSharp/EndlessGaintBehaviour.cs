using UnityEngine;

public class EndlessGaintBehaviour : BossEnemyBehaviour
{
	private static readonly int IsWalkingHash;

	private static readonly int OnRingHash;

	private static readonly int HitEndHash;

	[SerializeField]
	private float endlessIntroDelay;

	[SerializeField]
	private string[] attackTriggersToReset;

	[SerializeField]
	private ParticleSystem healthBarBreakParticle;

	private EndlessFightControl endlessFightControl;

	private bool isLethalHitIdle;

	protected override bool UseBossHpControl => false;

	protected override void OnStartInternal()
	{
	}

	private void LateUpdate()
	{
	}

	public void StartEndlessGaint(EndlessFightControl fightControl, float hpPerBar, float damage)
	{
	}

	public void PlayHealthBarBreakParticle()
	{
	}

	public override void TakeDamage(float damage, bool isCrit, EffectTypeDuration typeEffect)
	{
	}

	public override void TakeDamage(float damage, bool isCrit, bool playregularhit = false)
	{
	}

	public override void TakeDamage(Vector3 directionKnockback, float damage)
	{
	}

	public override void Die()
	{
	}

	public void PlayLethalHitIdle()
	{
	}

	private EndlessFightDamageResult ApplyDamageToEndlessFight(float damage, bool isCrit)
	{
		return default;
	}

	private float GetEndlessGaintDamage(float damage)
	{
		return 0f;
	}

	private void ResetVisualHealthBar()
	{
	}

	private void NotifyEndlessGaintArrived()
	{
	}

	protected override float GetDamageToPlayer()
	{
		return 0f;
	}

	private void PlayEndlessGaintHitSound()
	{
	}
}
