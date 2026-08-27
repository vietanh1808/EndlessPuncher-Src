using System;
using ElephantSocial.Model;

namespace ElephantSocial
{
	public class Social
	{
		public Action OnInitializeCallback;

		public Action<string> OnInitializeFailedCallback;

		private static readonly Lazy<Social> _instance;

		private SocialInternal _socialInternal;

		public SocialConfig SocialConfig => null;

		public static Social Instance => null;

		private Social()
		{
		}

		public void Init(SocialConfig socialConfig)
		{
		}

		public void UpdatePlayer(Player newPlayer, Action onSuccess, Action<string> onFailed, Action<string> onError)
		{
		}

		public Player GetPlayer()
		{
			return null;
		}

		public void GetPlayer(string socialId, Action<Player> response, Action<string> onFailed, Action<string> onError, bool forceRefresh = false)
		{
		}
	}
}
