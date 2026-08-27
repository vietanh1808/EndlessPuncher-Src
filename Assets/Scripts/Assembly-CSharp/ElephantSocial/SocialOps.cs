using System;
using System.Collections;
using ElephantSDK;
using ElephantSocial.Model;
using UnityEngine.Networking;

namespace ElephantSocial
{
	public class SocialOps : GenericResponseOps
	{
		public IEnumerator GetPlayer(Action<GenericResponse<Player>> onResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator UpdatePlayer(Player player, Action<GenericResponse<Player>> onResponseSuccess, Action<UnityWebRequest> onFailedResponse, Action<string> onError)
		{
			return null;
		}
	}
}
