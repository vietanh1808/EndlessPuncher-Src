using System;
using Fubu.Essentials;
using UnityEngine;

[Serializable]
public class EndlessFightHealthBarReward
{
	[Range(0.2f, 0.8f)]
	public float rewardClaimNormalized;

	public RewardEntry reward;

	public float RewardClaimNormalized => 0f;
}
