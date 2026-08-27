using System;

namespace ElephantSocial.Core
{
	public class TeamOperationException : ElephantSocialException
	{
		public long ErrorCode { get; }

		public long HttpStatus { get; }

		public string Body { get; }

		public TeamOperationException(string message)
			: base(null)
		{
		}

		public TeamOperationException(string message, Exception inner)
			: base(null)
		{
		}

		public TeamOperationException(string message, long errorCode, long httpStatus, string body)
			: base(null)
		{
		}
	}
}
