using System;
using System.Collections.Generic;

namespace Helpshift
{
	public class HelpshiftSdk
	{
		private const string PLUGIN_VERSION = "10.4.0";

		public const string ENABLE_LOGGING = "enableLogging";

		public const string ENABLE_INAPP_NOTIFICATION = "enableInAppNotification";

		public const string SCREEN_ORIENTATION = "screenOrientation";

		public const string NOTIFICATION_SOUND_ID = "notificationSoundId";

		public const string NOTIFICATION_CHANNEL_ID = "notificationChannelId";

		public const string NOTIFICATION_ICON = "notificationIcon";

		public const string NOTIFICATION_LARGE_ICON = "notificationLargeIcon";

		private static HelpshiftSdk instance;

		private static HelpshiftXAndroid nativeSdk;

		private HelpshiftSdk()
		{
		}

		public static HelpshiftSdk GetInstance()
		{
			return null;
		}

		public void Install(string appId, string domainName, Dictionary<string, object> config = null)
		{
		}

		public bool Login(Dictionary<string, string> userData)
		{
			return false;
		}

		public void HandleProactiveLink(string proactiveLink)
		{
		}

		public void SetHelpshiftProactiveConfigCollector(IHelpshiftProactiveAPIConfigCollector eventsListener)
		{
		}

		[Obsolete("ClearAnonymousUserOnLogin is deprecated, please use ClearAnonymousUserOnLogin(Boolean clearAnonymousUser) instead.")]
		public void ClearAnonymousUserOnLogin()
		{
		}

		public void ClearAnonymousUserOnLogin(bool shouldClear)
		{
		}

		public void AddUserTrail(string trail)
		{
		}

		public void Logout()
		{
		}

		public void RegisterPushToken(string token)
		{
		}

		public void ShowConversation(Dictionary<string, object> configMap = null)
		{
		}

		public void ShowFAQs(Dictionary<string, object> configMap = null)
		{
		}

		public void ShowSingleFAQ(string faqId, Dictionary<string, object> configMap = null)
		{
		}

		public void ShowFAQSection(string sectionId, Dictionary<string, object> configMap = null)
		{
		}

		public void RequestUnreadMessageCount(bool shouldFetchFromServer)
		{
		}

		public void HandlePushNotification(Dictionary<string, object> pushNotificationData)
		{
		}

		public void SetSDKLanguage(string locale)
		{
		}

		public void UpdateAppAttributes(Dictionary<string, object> attritbutes)
		{
		}

		public void UpdateMasterAttributes(Dictionary<string, object> attritbutes)
		{
		}

		public void AddUserIdentities(string identitiesJwt)
		{
		}

		public void LoginWithIdentity(string identitiesJwt, Dictionary<string, object> loginConfig, IHelpshiftUserLoginEventListener helpshiftUserLoginEventListener)
		{
		}

		public void LeaveBreadcrumb(string breadcrumb)
		{
		}

		public void ClearBreadcrumbs()
		{
		}

		public void SetHelpshiftEventsListener(IHelpshiftEventsListener eventsListener)
		{
		}

		public string SdkVersion()
		{
			return null;
		}

		public void CloseSession()
		{
		}
	}
}
