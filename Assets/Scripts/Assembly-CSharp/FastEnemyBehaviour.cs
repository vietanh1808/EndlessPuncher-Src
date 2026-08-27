using UnityEngine;

public class FastEnemyBehaviour : EnemyBehaviour
{
	[SerializeField]
	private float moveSpeedMultiplier;

	[SerializeField]
	private Vector2 speedRandomRange;

	protected override float GetConfiguredStartSpeed()
	{
		return 0f;
	}

	protected override float GetRandomizedSpeedMultiplier()
	{
		return 0f;
	}
}
