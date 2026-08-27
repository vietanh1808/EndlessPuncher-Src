namespace ElephantSocial
{
	public class SocialDataStore : GenericResponseOps
	{
		private const string MainKey = "SocialDataStore";

		private string GenerateKey(string val)
		{
			return null;
		}

		protected void Save<T>(string key, T data)
		{
		}

		protected T Load<T>(string key)
		{
			return default;
		}
	}
}
