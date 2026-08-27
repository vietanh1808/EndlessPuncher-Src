using System;
using ElephantSocial.Model;

namespace ElephantSocial
{
	public class SocialInternal : SocialDataStore
	{
		private readonly SocialOps _socialOps;

		private readonly SocialIdPlayerCache _socialIdPlayerCache;

		private bool _isInitialized;

		private const string PlayerDataStoreKey = "PlayerDataStoreKey";

		private bool _isPlayerLoaded;

		private Player _player;

		public SocialConfig SocialConfig { get; private set; }

		private bool IsInitialized => false;

		private Player Player
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Init(SocialConfig socialConfig, Action onSuccess, Action<string> onError)
		{
		}

		private void InitPlayer(Action onResponse, Action<string> onError)
		{
		}

		public Player GetPlayerAsync()
		{
			return null;
		}

		public Player GetPlayer()
		{
			return null;
		}

		public void GetPlayer(string socialId, Action<Player> response, Action<string> onFailed, Action<string> onError, bool forceRefresh = false)
		{
		}

		public void UpdatePlayer(Player newPlayer, Action onSuccess, Action<string> onFailed, Action<string> onError)
		{
		}
	}
}
