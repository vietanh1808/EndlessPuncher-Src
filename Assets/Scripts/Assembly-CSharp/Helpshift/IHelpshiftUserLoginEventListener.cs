using System.Collections.Generic;

namespace Helpshift
{
	public interface IHelpshiftUserLoginEventListener
	{
		void OnLoginSuccess();

		void OnLoginFailure(string reason, Dictionary<string, string> errorMap);
	}
}
