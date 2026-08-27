using System;

namespace ElephantSocial.HonorWall
{
	public class HonorWall
	{
		private static readonly Lazy<HonorWall> _instance;

		private readonly HonorWallInternal _honorWallInternal;

		public static HonorWall Instance => null;

		private HonorWall()
		{
		}

		public void GetHonors(Action<HonorWallResponse> onSuccess, Action<string> onError)
		{
		}

		public void GrantHonor(int honorId, Action onSuccess, Action<string> onError)
		{
		}
	}
}
