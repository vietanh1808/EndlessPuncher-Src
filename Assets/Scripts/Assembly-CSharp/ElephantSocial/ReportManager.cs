namespace ElephantSocial
{
	public static class ReportManager
	{
		private const string ReportPathDev = "https://report-dev.rollic.gs/report_server/report";

		private const string ReportPathProd = "https://report.rollic.gs/report_server/report";

		public static void ReportPlayer(string targetSocialId)
		{
		}

		public static void ReportTeam(string targetTeamId)
		{
		}

		public static void ReportMessage(string messageId, string channel)
		{
		}

		private static string BuildReportUrl(string type, string extraQuery)
		{
			return null;
		}

		private static void OpenReportUrl(string url)
		{
		}
	}
}
