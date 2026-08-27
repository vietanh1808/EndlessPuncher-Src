using UnityEngine;

namespace Helpshift
{
	public class HelpshiftAndroidEventsListener : AndroidJavaProxy
	{
		private IHelpshiftEventsListener externalHelpshiftEventsListener;

		public HelpshiftAndroidEventsListener(IHelpshiftEventsListener externalEventsListener)
			: base((string)null)
		{
		}

		private void onEventOccurred(string eventName, string eventDataJson)
		{
		}

		private void onUserAuthenticationFailure(int reason)
		{
		}
	}
}
