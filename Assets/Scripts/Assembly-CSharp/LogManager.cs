public static class LogManager
{
	public enum LogType
	{
		Normal = 0,
		Warning = 1,
		Error = 2,
		Success = 3,
		Info = 4,
		Debug = 5,
		Custom = 6
	}

	public static void LogNormal(string message)
	{
	}

	public static void LogWarning(string message)
	{
	}

	public static void LogError(string message)
	{
	}

	public static void LogSuccess(string message)
	{
	}

	public static void LogInfo(string message)
	{
	}

	public static void LogDebug(string message)
	{
	}

	public static void LogCustom(string message, string hexColor)
	{
	}

	private static void LogMessage(string message, LogType type, string customColor = "#FFFFFF")
	{
	}

	private static string GetColorByLogType(LogType type, string customColor)
	{
		return null;
	}
}
