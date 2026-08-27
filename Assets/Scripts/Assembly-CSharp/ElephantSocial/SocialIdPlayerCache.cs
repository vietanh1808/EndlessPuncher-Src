using System;
using System.Collections;
using System.Collections.Generic;
using ElephantSDK;
using ElephantSocial.Model;
using UnityEngine.Networking;

namespace ElephantSocial
{
	public class SocialIdPlayerCache : GenericResponseOps
	{
		private readonly Dictionary<string, Player> _cachedPlayers;

		public void GetPlayer(string socialId, Action<Player> onResponse, Action<string> onFailed, Action<string> onError, bool forceRefresh = false)
		{
		}

		private bool IsPlayerCached(string socialId, out Player cachedPlayer)
		{
			cachedPlayer = null;
			return false;
		}

		private void CachePlayer(string socialId, Player player)
		{
		}

		private IEnumerator GetPlayerWithSocialID(string socialId, Action<GenericResponse<Player>> onResponse, Action<UnityWebRequest> onFailedResponse, Action<string> onError)
		{
			return null;
		}
	}
}
