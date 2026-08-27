using System;
using System.Collections.Generic;

namespace ElephantSocial.CachingSystem
{
	public class GenericCachingSystem<T>
	{
		private T cachedData;

		private readonly int cachingIntervalSeconds;

		private DateTime lastCachingDateTime;

		private readonly Action<Action<T>, Action<string>> dataRequestAction;

		private readonly List<Action<T>> waitingResponses;

		private bool requestInProgress;

		protected GenericCachingSystem(Action<Action<T>, Action<string>> dataRequestAction, int cachingIntervalSeconds)
		{
		}

		protected GenericCachingSystem(Action<Action<T>, Action<string>> dataRequestAction, int cachingIntervalSeconds, T initValues)
		{
		}

		public void GetData(Action<T> response, Action<string> onError)
		{
		}

		public void ClearCache()
		{
		}
	}
}
