using UnityEngine;

namespace Helpshift
{
	public class HelpshiftAndroidProactiveCollectorListener : AndroidJavaProxy
	{
		private IHelpshiftProactiveAPIConfigCollector externalHelpshiftEventsListener;

		public HelpshiftAndroidProactiveCollectorListener(IHelpshiftProactiveAPIConfigCollector externalEventsListener)
			: base((string)null)
		{
		}

		private string getApiConfigString()
		{
			return null;
		}
	}
}
