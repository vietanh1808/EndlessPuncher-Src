using System.Collections.Generic;
using Fubu.Essentials;
using UnityEngine;

[CreateAssetMenu(fileName = "ChainOfferSO", menuName = "Fubu/Offers/Chain Offer")]
public class ChainOfferSO : ScriptableObject
{
	[SerializeField]
	private List<ChainOfferReward> rewards;

	[SerializeField]
	private List<CurrencyReward> currencyRewards;

	public IReadOnlyList<ChainOfferReward> Rewards => null;

	public IReadOnlyList<ChainOfferReward> LocalRewards => null;

	public RewardItem GetRewardItemByRemoteId(string rewardId)
	{
		return null;
	}

	public ShopProductDataSO GetShopProductByRemoteId(string productId)
	{
		return null;
	}

	public ChainOfferReward GetLocalReward(int index)
	{
		return null;
	}

	public string GetRewardRemoteId(RewardItem item)
	{
		return null;
	}

	private string NormalizeRemoteId(string value)
	{
		return null;
	}
}
