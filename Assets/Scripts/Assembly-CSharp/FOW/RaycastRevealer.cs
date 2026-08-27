using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace FOW
{
	public abstract class RaycastRevealer : FogOfWarRevealer
	{
		public enum RaycastRevealerOcclusionQualityPreset
		{
			Custom = 0,
			ExtraLargeScaleRTS = 1,
			LargeScaleRTS = 2,
			MediumScaleRTS = 3,
			SmallScaleRTS = 4,
			HighResolution = 5,
			OverkillResolution = 6
		}

		public struct SightRay
		{
			public float2 point;

			public float2 normal;

			public float2 direction;

			public float distance;

			public float angle;

			public bool hit;

			public void SetData(bool _hit, float2 _point, float _distance, float2 _normal, float2 _direction)
			{
			}
		}

		public struct SightSegment
		{
			public float2 Point;

			public float2 Direction;

			public float Radius;

			public float Angle;

			public bool DidHit;

			public SightSegment(float rad, float ang, bool hit, float2 point, float2 dir)
			{
				Point = default;
				Direction = default;
				Radius = 0f;
				Angle = 0f;
				DidHit = false;
			}
		}

		public class SightIteration
		{
			public NativeArray<float> RayAngles;

			public NativeArray<bool> Hits;

			public NativeArray<float> Distances;

			public NativeArray<float2> Points;

			public NativeArray<float2> Directions;

			public NativeArray<float2> Normals;

			public NativeArray<float2> NextPoints;

			public void InitializeStruct(int NumSteps)
			{
			}

			public void DisposeStruct()
			{
			}
		}

		[BurstCompile(FloatMode = FloatMode.Fast, FloatPrecision = FloatPrecision.Low, OptimizeFor = OptimizeFor.Performance)]
		public struct CalculateNextPointsAndAngleConditions : IJobFor
		{
			public float AngleStep;

			public float SStep;

			public float CStep;

			public float CosDoubleHit;

			public float SignEps;

			public float EdgeDstThresholdSq;

			public bool AddCorners;

			[ReadOnly]
			public NativeArray<float> Distances;

			[ReadOnly]
			public NativeArray<float2> Points;

			[ReadOnly]
			public NativeArray<float2> Normals;

			[ReadOnly]
			public NativeArray<float2> Directions;

			[ReadOnly]
			[NativeDisableParallelForRestriction]
			public NativeArray<bool> Hits;

			[WriteOnly]
			public NativeArray<float2> ExpectedNextPoints;

			[WriteOnly]
			[NativeDisableParallelForRestriction]
			public NativeArray<bool> IterateConditions;

			public void Execute(int id)
			{
			}
		}

		[SerializeField]
		protected LayerMask ObstacleMask;

		[FormerlySerializedAs("QualityPreset")]
		[SerializeField]
		public RaycastRevealerOcclusionQualityPreset OcclusionQuality;

		[FormerlySerializedAs("RaycastResolution")]
		[SerializeField]
		protected float raycastResolution;

		[Range(0f, 10f)]
		[SerializeField]
		public int NumExtraIterations;

		[Range(1f, 5f)]
		[FormerlySerializedAs("NumExtraRaysOnIteration")]
		[SerializeField]
		protected int numExtraRaysOnIteration;

		[Tooltip("Should this revealer find the edges of objects?.")]
		[SerializeField]
		public bool ResolveEdge;

		[Range(1f, 30f)]
		[Tooltip("Higher values will lead to more accurate edge detection, especially at higher distances. however, this will also result in more raycasts.")]
		[SerializeField]
		public int MaxEdgeResolveIterations;

		[Space(5f)]
		[Range(0.001f, 1f)]
		[Tooltip("Lower values will lead to more accurate edge detection, especially at higher distances. however, this will also result in more raycasts.")]
		[SerializeField]
		protected float MaxAcceptableEdgeAngleDifference;

		[Range(0.001f, 1f)]
		[FormerlySerializedAs("EdgeDstThreshold")]
		[SerializeField]
		protected float edgeDstThreshold;

		[FormerlySerializedAs("DoubleHitMaxAngleDelta")]
		[SerializeField]
		protected float doubleHitMaxAngleDelta;

		private static SightIteration[] _iterationPool;

		private static int _sightIterationPoolIndex;

		[NonSerialized]
		public SightSegment[] ViewPoints;

		protected float[] EdgeAngles;

		protected float2[] EdgeNormals;

		private static bool quitSubscribed;

		protected bool Initialized;

		protected SightIteration FirstIteration;

		protected int CommandsPerJob;

		public NativeArray<bool> FirstIterationConditions;

		protected JobHandle PreReqJobHandle;

		protected CalculateNextPointsAndAngleConditions FirstIterationPointsAndConditionsJob;

		protected JobHandle FirstIterationPointsAndConditionsJobHandle;

		protected int IterationRayCount;

		protected int PreviousFirstIterationStepCount;

		protected int FirstIterationStepCount;

		private float FirstIterationAngleStep;

		protected float FirstIterationAngleStepRadians;

		protected float SinStep;

		protected float CosStep;

		private float cosDouble;

		protected float edgeDstThresholdSq;

		private float invIterationRayCountMinusOne;

		private float[] iterationAngleSteps;

		private float[] iterationSinSteps;

		private float[] iterationCosSteps;

		private float lastAddedRayAngle;

		protected SightRay currentRay;

		protected float FirstRayAngle;

		private float MaxSegmentDeltaAngle;

		protected bool AnyHits;

		public float RaycastResolution
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int NumExtraRaysOnIteration
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float EdgeDstThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float DoubleHitMaxAngleDelta
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private static SightIteration CreateNewExtraIteration()
		{
			return null;
		}

		private static void DoublePoolSize()
		{
		}

		private static SightIteration GetSubIteration()
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void OnLoad()
		{
		}

		public static void OnShutDown()
		{
		}

		private static void InitializeIterationPool()
		{
		}

		private static void CleanupIterationPool()
		{
		}

		protected override void SetupOnRegister()
		{
		}

		protected abstract void _CleanupRaycastRevealer();

		private void CleanupRaycastRevealer()
		{
		}

		protected override void CleanupRevealer()
		{
		}

		protected abstract void _InitRevealer(int StepCount);

		private void InitRaycastRevealer(int StepCount, float AngleStep)
		{
		}

		public override void SetCachedRayDistance()
		{
		}

		protected override void RevealerValuesChanged()
		{
		}

		protected void AddViewPoint(bool hit, float distance, float angle, float step, float2 normal, float2 point, float2 dir)
		{
		}

		private void SetData()
		{
		}

		protected static int ComputeBatchSize(int count)
		{
			return 0;
		}

		private void CalculateRevealerInitialValues()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected abstract void RayCast(float angle, ref SightRay ray);

		public override void LineOfSightPhase1()
		{
		}

		public override void LineOfSightPhase2()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool CheckIterateCondition(float2 currentPoint, float2 expectedPoint, float2 currentNormal, float2 previousNormal, bool currentHit, bool previousHit)
		{
			return false;
		}

		private void SortData(ref SightIteration iteration, float angleStep, int iterationSteps, int iterationNumber, bool isFirstIteration)
		{
		}

		private SightIteration Iterate(int iterNumber, float initialAngle, float angleStep, ref SightIteration PreviousIteration, int PrevIterStartIndex)
		{
			return null;
		}

		private void FindEdges()
		{
		}

		protected abstract float3 _Get3DPositionfrom2D(float2 twoD);

		private float3 Get3Dfrom2D(float2 twoD)
		{
			return default;
		}
	}
}
