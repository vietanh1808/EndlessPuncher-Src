using ElephantSocial.Team;

namespace ElephantSocial.Chat.Model
{
	public abstract class ChatMessage
	{
		public string ID { get; set; }

		public string Channel { get; set; }

		public TeamMember Sender { get; set; }

		public ChatMessageType Type { get; set; }

		public long CreatedAt { get; set; }

		public long UpdatedAt { get; set; }
	}
}
