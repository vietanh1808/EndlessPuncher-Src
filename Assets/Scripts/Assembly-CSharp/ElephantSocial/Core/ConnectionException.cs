using System;

namespace ElephantSocial.Core
{
	public class ConnectionException : ElephantSocialException
	{
		public ConnectionException(string message)
			: base(null)
		{
		}

		public ConnectionException(string message, Exception inner)
			: base(null)
		{
		}
	}
}
