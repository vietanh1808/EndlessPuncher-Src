using System;
using ElephantSocial.Inbox.Model.Response;
using ElephantUniTask.Threading.Tasks;

namespace ElephantSocial.Inbox
{
	public class InboxApi
	{
		private static readonly Lazy<InboxApi> _instance;

		private readonly InboxOps _inboxOps;

		public static InboxApi Instance => null;

		public UniTask<InboxResponse> GetInboxAsync()
		{
			return default;
		}

		public UniTask MarkAsReadAsync(int inboxItemId)
		{
			return default;
		}
	}
}
