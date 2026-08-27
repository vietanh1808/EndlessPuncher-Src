using System;
using System.Collections.Generic;
using Fubu.Essentials;

[Serializable]
public class DailyRewardList
{
	public string listName;

	public List<RewardEntry> rewards;

	public RewardEntry GetReward(int dayIndex)
	{
		return null;
	}
}
