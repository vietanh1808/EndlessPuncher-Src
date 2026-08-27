using System;
using System.Collections.Generic;
using UnityEngine;

namespace Fubu.Helpers
{
	public class Pool<T> : IDisposable where T : UnityEngine.Object
	{
		private struct PoolItem
		{
			public T value;

			public bool isInUse;

			public float lastUseTime;

			public PoolItem(PoolItem poolItem, bool isInUse)
			{
				value = null;
				this.isInUse = false;
				lastUseTime = 0f;
			}

			public void UpdateTime()
			{
			}
		}

		private readonly List<PoolItem> _list;

		private UnityEngine.Object _prefab;

		private bool workAccordingToTime;

		private float busyDuration;

		public UnityEngine.Object Prefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Pool()
		{
		}

		public Pool(UnityEngine.Object prefab, bool workAccordingToTime = false, float duration = 0f)
		{
		}

		public T GetAvailableObject()
		{
			return null;
		}

		private void CheckNull()
		{
		}

		public void SetObjectAvailable(T obj)
		{
		}

		public void ForEachObject(Action<T, bool> action)
		{
		}

		~Pool()
		{
		}

		public void Dispose()
		{
		}
	}
}
