using System;
using Newtonsoft.Json;

namespace ElephantSDK
{
	[Serializable]
	public class MarkPaymentProcessedRequest : BaseData
	{
		[JsonProperty("transaction_id")]
		public string transactionId;

		public static MarkPaymentProcessedRequest Create(string transactionId)
		{
			return null;
		}
	}
}
