using System;

namespace ElephantSocial.Inbox
{
	public class InboxOperationException : Exception
	{
		public InboxOperationException(string message)
		{
		}

		public InboxOperationException(string message, Exception innerException)
		{
		}
	}
}
