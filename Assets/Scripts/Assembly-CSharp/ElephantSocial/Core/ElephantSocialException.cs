using System;

namespace ElephantSocial.Core
{
	public class ElephantSocialException : Exception
	{
		public ElephantSocialException(string message)
		{
		}

		public ElephantSocialException(string message, Exception inner)
		{
		}
	}
}
