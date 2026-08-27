using UnityEngine;

namespace Helpshift
{
	public class HelpshiftLoginEventProxy : AndroidJavaProxy
	{
		private IHelpshiftUserLoginEventListener helpshiftUserLoginEventListener;

		public HelpshiftLoginEventProxy(IHelpshiftUserLoginEventListener helpshiftUserLoginEventListener)
			: base((string)null)
		{
		}

		private void onLoginSuccess()
		{
		}

		private void onLoginFailure(string reason, string error)
		{
		}
	}
}
