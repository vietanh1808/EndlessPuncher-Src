using System.Collections.Generic;

namespace Helpshift
{
	public interface IHelpshiftProactiveAPIConfigCollector
	{
		Dictionary<string, object> getLocalApiConfig();
	}
}
