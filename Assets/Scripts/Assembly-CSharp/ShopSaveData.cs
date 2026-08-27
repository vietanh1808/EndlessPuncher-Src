using System;
using System.Collections.Generic;

[Serializable]
public class ShopSaveData
{
	public bool noAdsActive;

	public bool weeklyAdsActive;

	public string weeklyAdsExpireUtcTicks;

	public int totalIapCount;

	public string lastPurchasedProductId;

	public List<string> processedTransactionIds;
}
