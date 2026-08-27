namespace ElephantSocial.Chat.Model
{
	public class MemberLeftMessage : ChatMessage
	{
		public string SocialId { get; set; }

		public string PlayerName { get; set; }

		public string ProfilePicture { get; set; }

		public string TeamId { get; set; }
	}
}
