using System.Collections.Generic;

namespace ElephantSocial.Chat.Util
{
	public static class JwtHelper
	{
		public static string GenerateJwtToken(string elephantId, string gameId, string gameSecret, string socialId = null)
		{
			return null;
		}

		private static string SerializeJson(Dictionary<string, object> dict)
		{
			return null;
		}

		private static string SerializeJson(Dictionary<string, string> dict)
		{
			return null;
		}

		private static string Base64UrlEncode(string input)
		{
			return null;
		}

		private static string Base64UrlEncode(byte[] bytes)
		{
			return null;
		}

		private static string CreateSignature(string input, string secret)
		{
			return null;
		}
	}
}
