using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace FOW
{
	public static class SparseRevealerGrid
	{
		public static bool SpatialAccelerationActive;

		public static List<int>[] RevealerBuckets;

		public static int[] RevealerBucketCounts;

		public static List<int>[] HiderBuckets;

		public static int[] HiderBucketCounts;

		public static bool Dirty;

		private static int _totalEntries;

		private static HashSet<int> _tempHashes;

		private static int _tableSize;

		private static int _cellSize;

		private static ComputeBuffer _gridRangesBuffer;

		private static ComputeBuffer _revealerGridIdsBuffer;

		private static int2[] _ranges;

		private static int[] _revealerGridIds;

		private static int _maxGridIds;

		public static void Initialize(int tableSize, int cellSize)
		{
		}

		public static void Cleanup()
		{
		}

		public static int2 GetCell(float2 position)
		{
			return default;
		}

		public static int GetCellHash(int2 cell)
		{
			return 0;
		}

		public static int GetCellHash(float2 position)
		{
			return 0;
		}

		private static void SwapRemove(List<int> list, int item)
		{
		}

		public static void UpdateRevealerBuckets(FogOfWarRevealer revealer, float2 position)
		{
		}

		public static void RemoveRevealer(FogOfWarRevealer revealer)
		{
		}

		public static void UpdatHiderBuckets(FogOfWarHider hider, float2 position)
		{
		}

		public static void RemoveHider(FogOfWarHider hider)
		{
		}

		public static void FlattenAndUpload()
		{
		}

		private static void InsertionSort(List<int> list)
		{
		}

		public static bool CheckIntersection(int2 minBucket1, int2 maxBucket1, int2 minBucket2, int2 maxBucket2)
		{
			return false;
		}

		public static void BindPropertiesToMaterial(Material material)
		{
		}
	}
}
