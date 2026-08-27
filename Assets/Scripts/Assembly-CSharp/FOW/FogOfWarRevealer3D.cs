using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace FOW
{
	public class FogOfWarRevealer3D : RaycastRevealer
	{
		public readonly struct PlaneProjection
		{
			public readonly int Axis0;

			public readonly int Axis1;

			public readonly int HeightAxis;

			public readonly float3 UpVector;

			public PlaneProjection(FogOfWarWorld.GamePlane plane)
			{
				Axis0 = 0;
				Axis1 = 0;
				HeightAxis = 0;
				UpVector = default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float2 Project(float3 v)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float GetHeight(float3 v)
			{
				return 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float3 To3D(float2 v, float height)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float3 DirectionFromAngle(float angleDeg)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float DistanceSq2D(float3 a, float3 b)
			{
				return 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float Distance2D(float3 a, float3 b)
			{
				return 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float HeightDifference(float3 a, float3 b)
			{
				return 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float3 SetHeight(float3 v, float newHeight)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public float GetRotationAngle(quaternion rot)
			{
				return 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static float3 ToEuler(quaternion q)
			{
				return default;
			}
		}

		[BurstCompile(FloatMode = FloatMode.Fast, FloatPrecision = FloatPrecision.Low, OptimizeFor = OptimizeFor.Performance)]
		private struct Phase1SetupJob : IJobFor
		{
			public PlaneProjection Proj;

			public float FirstAngle;

			public float AngleStep;

			public float RayDistance;

			public float3 EyePosition;

			public QueryParameters Parameters;

			public PhysicsScene PhysicsScene;

			[WriteOnly]
			[NoAlias]
			public NativeArray<float> RayAngles;

			[WriteOnly]
			[NoAlias]
			public NativeArray<float2> Vector2Directions;

			[WriteOnly]
			[NoAlias]
			public NativeArray<RaycastCommand> RaycastCommandsNative;

			public void Execute(int id)
			{
			}
		}

		[BurstCompile(FloatMode = FloatMode.Fast, FloatPrecision = FloatPrecision.Low, OptimizeFor = OptimizeFor.Performance)]
		private struct GetVector2Data : IJobFor
		{
			public PlaneProjection Proj;

			public float RayDistance;

			public float2 ProjectedEyePosition;

			[ReadOnly]
			public NativeArray<RaycastHit> RaycastHits;

			[ReadOnly]
			public NativeArray<float2> RayDirections;

			[WriteOnly]
			[NoAlias]
			public NativeArray<bool> Hits;

			[WriteOnly]
			[NoAlias]
			public NativeArray<float> Distances;

			[WriteOnly]
			[NoAlias]
			public NativeArray<float2> OutPoints;

			[WriteOnly]
			[NoAlias]
			public NativeArray<float2> OutNormals;

			public void Execute(int id)
			{
			}
		}

		private NativeArray<RaycastCommand> RaycastCommandsNative;

		private NativeArray<RaycastHit> RaycastHits;

		private JobHandle IterationOneRaycastJobHandle;

		private Phase1SetupJob SetupJob;

		private JobHandle SetupJobJobHandle;

		private GetVector2Data Vector2DataJob;

		private JobHandle Vector2NormalJobHandle;

		private PhysicsScene physicsScene;

		public static PlaneProjection Projection;

		public QueryParameters RayQueryParameters;

		private RaycastHit RayHit;

		private float3 hiderPosition;

		private float3 revealerOrigin;

		protected override void _InitRevealer(int StepCount)
		{
		}

		protected override void _CleanupRaycastRevealer()
		{
		}

		protected override void IterationOne(float firstAngle, float angleStep)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected override void RayCast(float angle, ref SightRay ray)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 GetVector2D(float3 v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected override float GetEyeRotation()
		{
			return 0f;
		}

		public override float3 GetEyePosition()
		{
			return default;
		}

		protected override bool CanSeeHider(FogOfWarHider hiderInQuestion, float2 hiderPosition)
		{
			return false;
		}

		private bool CanSeeHiderExtraSamplePoint(Transform samplePoint)
		{
			return false;
		}

		private bool CanSeeWorldPosition(float3 samplePointPosition)
		{
			return false;
		}

		private bool CanSeeWorldPositionPartTwo(float sqDistToPoint, float3 samplePointPosition)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool IsInFOV(float3 dirToTarget, float2 forwardProjected)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetHiderPositionToMyHeight(float3 point, float3 eyePosition)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void SetRevealerOrigin(float3 point, float3 _hiderPosition)
		{
		}

		protected override bool _TestPoint(float3 point)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected override void SetPositionAndHeight()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected override float AngleBetweenVector2(float3 _vec1, float3 _vec2)
		{
			return 0f;
		}

		protected override void SetCachedForward()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override float3 DirFromAngle(float angleInDegrees)
		{
			return default;
		}

		protected override float3 _Get3DPositionfrom2D(float2 pos)
		{
			return default;
		}
	}
}
