using System;

namespace ElephantSocial.Core
{
	public class ChatOperationException : ElephantSocialException
	{
		public ChatOperationException(string message)
			: base(null)
		{
		}

		public ChatOperationException(string message, Exception inner)
			: base(null)
		{
		}
	}
}
