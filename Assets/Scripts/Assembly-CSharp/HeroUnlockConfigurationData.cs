using System;
using UnityEngine;

[Serializable]
public class HeroUnlockConfigurationData
{
	[Min(0f)]
	public int unlockShardRequirement;
}
