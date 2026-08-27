using System;

namespace ElephantSocial.HonorWall
{
	internal class HonorWallInternal : SocialDataStore
	{
		private static HonorWallInternal _instance;

		private readonly HonorWallOps _honorWallOps;

		internal static HonorWallInternal GetInstance()
		{
			return null;
		}

		private HonorWallInternal()
		{
		}

		public void GetHonors(Action<HonorWallResponse> onSuccess, Action<string> onFailed, Action<string> onError)
		{
		}

		public void GrantHonor(int honorId, Action onSuccess, Action<string> onFailed, Action<string> onError)
		{
		}
	}
}
