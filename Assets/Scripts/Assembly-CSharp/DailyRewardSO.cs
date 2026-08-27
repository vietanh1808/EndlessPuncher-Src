using System.Collections.Generic;
using Fubu.Essentials;
using UnityEngine;

[CreateAssetMenu(fileName = "DailyRewardSO", menuName = "Fubu/Rewards/Daily Reward")]
public class DailyRewardSO : ScriptableObject
{
	[SerializeField]
	private List<RewardItem> remoteRewardItems;

	[SerializeField]
	private List<DailyRewardList> rewardLists;

	public IReadOnlyList<DailyRewardList> RewardLists => null;

	public DailyRewardList GetRewardList(int listIndex)
	{
		return null;
	}

	public RewardEntry GetReward(int listIndex, int dayIndex)
	{
		return null;
	}

	public List<RewardEntry> GetRewards(int listIndex, int dayIndex)
	{
		return null;
	}

	private RewardItem GetRewardItemByRemoteId(string rewardId)
	{
		return null;
	}

	private RewardItem GetRewardItemFromList(List<RewardItem> items, string rewardId)
	{
		return null;
	}

	private RewardItem GetRewardItemFromRewards(List<RewardEntry> rewards, string rewardId)
	{
		return null;
	}

	private bool IsRewardIdMatch(RewardItem item, string rewardId)
	{
		return false;
	}

	private bool IsCurrencyAliasMatch(CurrencyTypes currencyType, string normalizedRewardId)
	{
		return false;
	}

	private string GetRewardRemoteId(RewardItem item)
	{
		return null;
	}

	private string NormalizeRewardId(string rewardId)
	{
		return null;
	}
}
