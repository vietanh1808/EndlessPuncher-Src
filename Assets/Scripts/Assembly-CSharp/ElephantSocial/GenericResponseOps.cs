using System;
using ElephantSDK;
using UnityEngine.Networking;

namespace ElephantSocial
{
	public abstract class GenericResponseOps
	{
		private ElephantEnvironment ElephantEnvironment => ElephantEnvironment.Development;

		protected bool IsProductionEnvironment()
		{
			return false;
		}

		protected string PrepareBodyJson<T>(T data)
		{
			return null;
		}

		protected static void HandleResponse<T>(GenericResponse<T> response, Action<T> onResponse, Action<string> onError)
		{
		}

		protected static void HandleErrorResponse(UnityWebRequest request, Action<long, string> error)
		{
		}
	}
}
