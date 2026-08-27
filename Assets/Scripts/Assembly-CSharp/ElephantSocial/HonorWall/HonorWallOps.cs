using System;
using System.Collections;
using ElephantSDK;
using UnityEngine.Networking;

namespace ElephantSocial.HonorWall
{
	public class HonorWallOps : GenericResponseOps
	{
		public IEnumerator GetHonors(Action<GenericResponse<HonorWallResponse>> onResponse, Action<UnityWebRequest> onFailedResponse, Action<string> onError)
		{
			return null;
		}

		public IEnumerator GrantHonor(int honorId, Action<GenericResponse<HonorWallGrantResponse>> onResponse, Action<UnityWebRequest> onFailedResponse, Action<string> onError)
		{
			return null;
		}
	}
}
