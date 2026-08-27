using UnityEngine;

namespace ElephantSDK
{
	public class ElephantAdjustLoad : MonoBehaviour
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void FirstSceneLoading()
		{
		}
	}
}
