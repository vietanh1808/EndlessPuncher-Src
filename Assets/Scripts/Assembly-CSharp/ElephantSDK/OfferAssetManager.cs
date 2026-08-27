using System.Collections.Generic;

namespace ElephantSDK
{
	public class OfferAssetManager
	{
		private static OfferAssetManager _instance;

		public OfferUIData offerUIData;

		public Dictionary<string, string> localPricingCache;

		public Dictionary<string, string> templateFieldsCache;

		public OfferData currentOffer;

		public OfferMetaData offerMetaData;

		public Offer currentOfferResponse;

		public List<PurchaseOption> purchaseOptions;

		public string iapNames;

		public List<string> offerUrls;

		public static OfferAssetManager GetInstance()
		{
			return null;
		}

		public void SetTemplateFields(Pair[] templateFields, string offerName)
		{
		}
	}
}
