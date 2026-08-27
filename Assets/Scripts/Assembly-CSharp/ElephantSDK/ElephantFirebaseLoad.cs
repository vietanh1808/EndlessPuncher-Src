using UnityEngine;

namespace ElephantSDK
{
	public class ElephantFirebaseLoad : MonoBehaviour
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void FirstSceneLoading()
		{
		}
	}
}
