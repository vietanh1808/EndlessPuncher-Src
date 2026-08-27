using System.Collections.Generic;

namespace ElephantSocial.Chat.Model
{
	public class RewardMessage : ChatMessage
	{
		public string RewardId { get; set; }

		public int MaxReceiver { get; set; }

		public List<string> Receivers { get; set; }

		public bool IsClaimedByMe { get; private set; }

		public void Claim()
		{
		}
	}
}
