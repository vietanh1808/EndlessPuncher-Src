using System;
using System.Collections.Generic;
using Fubu.Essentials;

[Serializable]
public class ChainOfferReward
{
	public List<RewardEntry> rewards;

	public ChainOfferPurchaseType purchaseType;

	public ShopProductDataSO shopProduct;

	public bool IsFree => false;

	public float UsdPrice => 0f;

	public string GetPriceText()
	{
		return null;
	}
}
