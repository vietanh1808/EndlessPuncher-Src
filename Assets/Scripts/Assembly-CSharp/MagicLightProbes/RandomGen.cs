using System;

namespace MagicLightProbes
{
	public static class RandomGen
	{
		private static Random _global;

		[ThreadStatic]
		private static Random _local;

		public static int Next(int min, int max)
		{
			return 0;
		}
	}
}
