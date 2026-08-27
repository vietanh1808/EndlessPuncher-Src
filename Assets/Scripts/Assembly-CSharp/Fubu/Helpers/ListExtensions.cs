using System.Collections.Generic;

namespace Fubu.Helpers
{
	public static class ListExtensions
	{
		public static T GetRandomElement<T>(this List<T> array, int from = 0, int to = -1)
		{
			return default;
		}

		public static bool ContainsReference<T>(this List<T> list, T value) where T : class
		{
			return false;
		}
	}
}
