using System;
using Fubu.Essentials;
using UnityEngine;

[Serializable]
public class EventPassRewardEntry
{
	[Min(0f)]
	public int targetCurrencyValue;

	public RewardEntry reward;

	public int GetPassRewardAmount(float rewardPassMultiplier)
	{
		return 0;
	}
}
