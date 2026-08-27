using System;
using System.Collections.Generic;

namespace ElephantSDK
{
	public class ElephantFirebaseManager : IFirebaseElephantAdapter, IElephantAdapter
	{
		private bool _isAvailable;

		public bool IsAvailable => false;

		public void InitializeFirebase(Action onInitialized)
		{
		}

		public void SetAnalyticsCollectionEnabled(bool enabled)
		{
		}

		public void GetAnalyticsInstanceId(Action<string> callback)
		{
		}

		public void LogEvent(string name, IDictionary<string, object> parameters)
		{
		}

		public void SetAnalyticsConsent(bool granted)
		{
		}

		public void SetConsentForCcpa(bool accepted)
		{
		}

		public void SetCrashlyticsUserId(string userId)
		{
		}

		public void SetCrashlyticsCollectionEnabled(bool enabled)
		{
		}

		public void SetCustomKey(string key, string value)
		{
		}

		public void LogMessage(string message)
		{
		}

		public void LogException(Exception exception)
		{
		}
	}
}
