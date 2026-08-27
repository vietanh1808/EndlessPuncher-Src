using UnityEngine;

public class RangedHeadbuttEnemyBehaviour : EnemyBehaviour
{
	[SerializeField]
	private float minimumAttackDistance;

	[SerializeField]
	private float playerRangeRatio;

	private float GetCombatDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected override float GetPreferredCombatDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected override float GetAttackDistance(float playerRangeValue)
	{
		return 0f;
	}

	protected override float GetConfiguredAttackRange()
	{
		return 0f;
	}

	public override void AttackCompleted()
	{
	}
}
