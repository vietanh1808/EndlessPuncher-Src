using System;
using System.Collections.Generic;
using AdjustSdk;

namespace ElephantSDK
{
	public class ElephantAdjustManager : IAdjustElephantAdapter, IElephantAdapter
	{
		public string IronSourceAdRevenueSource => null;

		public string AppLovinMAXRevenueSource => null;

		public void InitAdjust(string adjustAppKey, bool isCvUpdateServiceEnabled, Action<string> deepLinkCallback, bool isLowerThanIos145 = false)
		{
		}

		private void OnAttrChange(AdjustAttribution adjustAttribution)
		{
		}

		public void TrackPurchaseRevenue(string token, double revenue, string currency)
		{
		}

		public void TrackAdjustEvent(string token)
		{
		}

		public void SetTrackThirdPartySharing(bool isEea, bool adPersonalizationStatus, bool adUserDataStatus)
		{
		}

		public void SetTrackThirdPartySharing(bool isEea)
		{
		}

		public void SetTrackThirdPartySharingForCcpa(bool enabled)
		{
		}

		public void TrackAdRevenue(string source, double revenue, string currency, string network, string unit, string placement, string format = null, string adUnitId = null, Dictionary<string, string> extraParams = null)
		{
		}

		public void GetAdid(Action<string> callback)
		{
		}

		public void AddSessionCallbackParameter(string key, string value)
		{
		}
	}
}
