using System.Collections.Generic;
using UnityEngine;

namespace Helpshift
{
	public class HelpshiftXAndroid
	{
		private AndroidJavaClass jc;

		private AndroidJavaObject currentActivity;

		private AndroidJavaObject application;

		private AndroidJavaClass hsUnityApiClass;

		public void Install(string appId, string domain, Dictionary<string, object> configMap)
		{
		}

		public void RegisterPushToken(string deviceToken)
		{
		}

		public bool Login(Dictionary<string, string> userData)
		{
			return false;
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

		public void HandleProactiveLink(string proactiveLink)
		{
		}

		public void SetHelpshiftProactiveConfigCollector(IHelpshiftProactiveAPIConfigCollector eventsListener)
		{
		}

		private string SerializeMap(Dictionary<string, object> configMap)
		{
			return null;
		}

		public void ShowConversation(Dictionary<string, object> configMap)
		{
		}

		public void ShowFAQs(Dictionary<string, object> configMap)
		{
		}

		public void ShowSingleFAQ(string faqId, Dictionary<string, object> configMap)
		{
		}

		public void ShowFAQSection(string sectionId, Dictionary<string, object> configMap)
		{
		}

		public void RequestUnreadMessageCount(bool shouldFetchFromServer)
		{
		}

		public void HandlePushNotification(Dictionary<string, object> pushNotificationData)
		{
		}

		public void SetHelpshiftEventsListener(IHelpshiftEventsListener eventsListener)
		{
		}

		public void SetSDKLanguage(string locale)
		{
		}

		public void LeaveBreadcrumb(string breadcrumb)
		{
		}

		public void ClearBreadcrumbs()
		{
		}

		public void CloseSession()
		{
		}

		public void LoginWithIdentities(string identitiesJwt, Dictionary<string, object> loginConfigMap, IHelpshiftUserLoginEventListener helpshiftUserLoginEventListener)
		{
		}

		public void UpdateAppAttributes(Dictionary<string, object> appAttributesConfigMap)
		{
		}

		public void UpdateMasterAttributes(Dictionary<string, object> masterAttributesConfigMap)
		{
		}

		public void AddUserIdentities(string identitiesJwt)
		{
		}
	}
}
