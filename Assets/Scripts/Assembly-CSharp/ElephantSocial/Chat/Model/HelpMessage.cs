using System.Collections.Generic;

namespace ElephantSocial.Chat.Model
{
	public class HelpMessage : ChatMessage
	{
		public int Max { get; set; }

		public int Received { get; set; }

		public List<string> Senders { get; set; }

		public bool IsHelpedByMe { get; private set; }

		public HelpMessage(int requestedAmount)
		{
		}

		public void Help()
		{
		}
	}
}
