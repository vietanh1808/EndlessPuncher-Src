using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace FOW
{
	public class FogOfWarRevealer2D : RaycastRevealer
	{
		private RaycastHit2D[] InitialRayResults;

		private PhysicsScene2D physicsScene2D;

		private RaycastHit2D RayHit;

		private float2 pos2d;

		private float3 hiderPosition;

		private Vector3 direction;

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

		private float2 GetPositionxy(Vector3 pos)
		{
			return default;
		}

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

		private void SetHiderPosition(float3 point)
		{
		}

		protected override bool _TestPoint(float3 point)
		{
			return false;
		}

		protected override void SetPositionAndHeight()
		{
		}

		protected override float AngleBetweenVector2(float3 _vec1, float3 _vec2)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DistanceSq(float3 a, float3 b)
		{
			return 0f;
		}

		protected override void SetCachedForward()
		{
		}

		private Vector2 DirectionFromAngle(float angleInDegrees, bool angleIsGlobal)
		{
			return default;
		}

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
