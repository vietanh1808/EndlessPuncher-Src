using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EndlessFightSO", menuName = "Fubu/Endless Fight/Endless Fight")]
public class EndlessFightSO : ScriptableObject
{
	private const int DefaultHealthBarCount = 50;

	[Header("Giant")]
	[SerializeField]
	private float giantHealthPerBar;

	[SerializeField]
	private float giantHealthPerBrokenBarMultiplier;

	[SerializeField]
	private float giantDamage;

	public float giantDamageIncreasePerBrokenBar;

	[Header("Rewards")]
	[SerializeField]
	private List<EndlessFightHealthBarReward> healthBarRewards;

	public float GiantHealthPerBar => 0f;

	public float GiantHealthPerBrokenBarMultiplier => 0f;

	public float GiantTotalHealth => 0f;

	public float GiantDamage => 0f;

	public float GiantDamageIncreasePerBrokenBar => 0f;

	public int HealthBarCount => 0;

	public IReadOnlyList<EndlessFightHealthBarReward> HealthBarRewards => null;

	public float GetGiantHealthForBrokenBarCount(int brokenBarCount)
	{
		return 0f;
	}

	public float GetGiantHealthForBrokenBarCount(int brokenBarCount, float healthPerBar, float increasePerBrokenBar)
	{
		return 0f;
	}

	public EndlessFightHealthBarReward GetHealthBarReward(int barIndex)
	{
		return null;
	}

	private void OnValidate()
	{
	}

	private void Reset()
	{
	}

	private void EnsureRewardCount()
	{
	}
}
