using System;

namespace Fubu.Helpers
{
	[Serializable]
	public class SerializedArray<T>
	{
		public T[] array;

		public int Length => 0;

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

		public SerializedArray(int length)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator T[](SerializedArray<T> array)
		{
			return null;
		}
	}
}
