using System.Collections.Generic;

namespace Helpshift
{
	public interface IHelpshiftEventsListener
	{
		void HandleHelpshiftEvent(string eventName, Dictionary<string, object> eventData);

		void AuthenticationFailedForUser(HelpshiftAuthenticationFailureReason reason);
	}
}
