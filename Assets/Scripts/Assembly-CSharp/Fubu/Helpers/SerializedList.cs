using System;
using System.Collections.Generic;

namespace Fubu.Helpers
{
	[Serializable]
	public class SerializedList<T>
	{
		public List<T> list;

		public int Count => 0;

		public T this[int index]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public SerializedList()
		{
		}

		public SerializedList(List<T> _list)
		{
		}

		public static void SaveStatic(SerializedList<T> list, string keyword)
		{
		}

		public static void LoadStatic(out SerializedList<T> list, string keyword)
		{
			list = null;
		}

		public void Save(string keyword)
		{
		}

		public void Load(string keyword)
		{
		}

		public void Add(T item)
		{
		}

		public static implicit operator List<T>(SerializedList<T> list)
		{
			return null;
		}
	}
}
