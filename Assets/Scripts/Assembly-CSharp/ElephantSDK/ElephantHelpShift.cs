using System.Collections.Generic;
using Helpshift;

namespace ElephantSDK
{
	public class ElephantHelpShift : IHelpShiftElephantAdapter, IElephantAdapter
	{
		private static ElephantHelpShift _instance;

		private bool _intialized;

		private HelpshiftSdk help;

		public static bool IsActive => false;

		public void Init(string domainName, string appId)
		{
		}

		public void ShowConversation()
		{
		}

		public void ShowFAQs()
		{
		}

		public void ShowConversationWithInitialMessage(string initialMessage, Dictionary<string, object> additionalCifs = null)
		{
		}

		private Dictionary<string, object> GetConfigMap()
		{
			return null;
		}

		private Dictionary<string, string> ConvertStringDataSingleLine(string value)
		{
			return null;
		}

		private Dictionary<string, string> ConvertBooleanData(bool value)
		{
			return null;
		}

		private Dictionary<string, string> ConvertNumberData(int value)
		{
			return null;
		}

		private Dictionary<string, string> ConvertNumberData(float value)
		{
			return null;
		}

		private Dictionary<string, string> ConvertData(string dataType, string value)
		{
			return null;
		}
	}
}
