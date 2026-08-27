using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Mathematics;

namespace FOW
{
	[BurstCompile]
	internal static class FogMath2D
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void PredictNextPoint_00002AD2_0024PostfixBurstDelegate(in float2 point, in float2 normalUnit, in float2 dirUnit, float distance, float sStep, float cStep, out float2 result);

		internal static class PredictNextPoint_00002AD2_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(in float2 point, in float2 normalUnit, in float2 dirUnit, float distance, float sStep, float cStep, out float2 result)
			{
				result = default;
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CheckIterateCondition_00002AD3_0024PostfixBurstDelegate(in float2 currentPoint, in float2 expectedPoint, in float2 currentNormal, in float2 previousNormal, bool currentHit, bool previousHit, float cosDouble, float edgeDstThresholdSq, bool addCorners, out bool shouldIterate);

		internal static class CheckIterateCondition_00002AD3_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(in float2 currentPoint, in float2 expectedPoint, in float2 currentNormal, in float2 previousNormal, bool currentHit, bool previousHit, float cosDouble, float edgeDstThresholdSq, bool addCorners, out bool shouldIterate)
			{
				shouldIterate = default;
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CheckEdgeMismatch_00002AD4_0024PostfixBurstDelegate(in float2 segmentPoint, in float2 segmentDirection, in float2 edgeNormal, float segmentRadius, float segmentAngle, bool segmentDidHit, float currentAngle, in float2 rayPoint, in float2 rayNormal, bool rayHit, float cosDouble, float edgeDstThresholdSq, out bool mismatch, out float2 nextPoint);

		internal static class CheckEdgeMismatch_00002AD4_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Invoke(in float2 segmentPoint, in float2 segmentDirection, in float2 edgeNormal, float segmentRadius, float segmentAngle, bool segmentDidHit, float currentAngle, in float2 rayPoint, in float2 rayNormal, bool rayHit, float cosDouble, float edgeDstThresholdSq, out bool mismatch, out float2 nextPoint)
			{
				mismatch = default;
				nextPoint = default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DistanceSq(float2 a, float2 b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SignedAngleDeg(float2 a, float2 b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 NormalRotate90(float2 v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Approximately(float a, float b)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SinAngleC(float2 rotatedNormalUnit, float2 dirUnit, float sStep, float cStep)
		{
			return 0f;
		}

		[BurstCompile(FloatMode = FloatMode.Fast, FloatPrecision = FloatPrecision.Low, OptimizeFor = OptimizeFor.Performance)]
		[MonoPInvokeCallback(typeof(PredictNextPoint_00002AD2_0024PostfixBurstDelegate))]
		public static void PredictNextPoint(in float2 point, in float2 normalUnit, in float2 dirUnit, float distance, float sStep, float cStep, out float2 result)
		{
			result = default;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CheckIterateCondition_00002AD3_0024PostfixBurstDelegate))]
		public static void CheckIterateCondition(in float2 currentPoint, in float2 expectedPoint, in float2 currentNormal, in float2 previousNormal, bool currentHit, bool previousHit, float cosDouble, float edgeDstThresholdSq, bool addCorners, out bool shouldIterate)
		{
			shouldIterate = default;
		}

		[BurstCompile]
		[MonoPInvokeCallback(typeof(CheckEdgeMismatch_00002AD4_0024PostfixBurstDelegate))]
		public static void CheckEdgeMismatch(in float2 segmentPoint, in float2 segmentDirection, in float2 edgeNormal, float segmentRadius, float segmentAngle, bool segmentDidHit, float currentAngle, in float2 rayPoint, in float2 rayNormal, bool rayHit, float cosDouble, float edgeDstThresholdSq, out bool mismatch, out float2 nextPoint)
		{
			mismatch = default;
			nextPoint = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(FloatMode = FloatMode.Fast, FloatPrecision = FloatPrecision.Low, OptimizeFor = OptimizeFor.Performance)]
		internal static void PredictNextPoint_0024BurstManaged(in float2 point, in float2 normalUnit, in float2 dirUnit, float distance, float sStep, float cStep, out float2 result)
		{
			result = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CheckIterateCondition_0024BurstManaged(in float2 currentPoint, in float2 expectedPoint, in float2 currentNormal, in float2 previousNormal, bool currentHit, bool previousHit, float cosDouble, float edgeDstThresholdSq, bool addCorners, out bool shouldIterate)
		{
			shouldIterate = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CheckEdgeMismatch_0024BurstManaged(in float2 segmentPoint, in float2 segmentDirection, in float2 edgeNormal, float segmentRadius, float segmentAngle, bool segmentDidHit, float currentAngle, in float2 rayPoint, in float2 rayNormal, bool rayHit, float cosDouble, float edgeDstThresholdSq, out bool mismatch, out float2 nextPoint)
		{
			mismatch = default;
			nextPoint = default;
		}
	}
}
