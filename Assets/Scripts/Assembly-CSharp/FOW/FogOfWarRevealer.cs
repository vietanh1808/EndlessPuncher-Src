using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace FOW
{
	public abstract class FogOfWarRevealer : MonoBehaviour
	{
		[Header("Vision Range Settings")]
		[FormerlySerializedAs("ViewRadius")]
		[SerializeField]
		protected float viewRadius;

		[FormerlySerializedAs("SoftenDistance")]
		[SerializeField]
		protected float softenDistance;

		[Range(0f, 60f)]
		[SerializeField]
		private float innerSoftenAngle;

		[Space(2f)]
		[FormerlySerializedAs("UnobscuredRadius")]
		[SerializeField]
		protected float unobscuredRadius;

		[FormerlySerializedAs("UnobscuredSoftenDistance")]
		[SerializeField]
		protected float unobscuredSoftenDistance;

		[Space(2f)]
		[Tooltip("how high should this revealer see?")]
		[FormerlySerializedAs("VisionHeight")]
		[SerializeField]
		protected float visionHeight;

		[FormerlySerializedAs("VisionHeightSoftenDistance")]
		[SerializeField]
		protected float visionHeightSoftenDistance;

		[Header("Customization Settings")]
		[Range(1f, 360f)]
		[FormerlySerializedAs("ViewAngle")]
		[SerializeField]
		protected float viewAngle;

		[Range(0f, 1f)]
		[FormerlySerializedAs("Opacity")]
		[SerializeField]
		protected float opacity;

		[Tooltip("how high above this object should the sight be calculated from")]
		[SerializeField]
		public float EyeOffset;

		[Tooltip("An offset used only in the shader, to determine how high above the revealer vision height should be calculated at")]
		[SerializeField]
		public float ShaderEyeOffset;

		[Tooltip("Static revealers are revealers that need the sight function to be called manually, similar to the 'Called Elsewhere' option on FOW world. To change this at runtime, use the SetRevealerAsStatic(bool IsStatic) Method.")]
		[SerializeField]
		public bool StartRevealerAsStatic;

		[Header("Hider Settings")]
		[Tooltip("If a hider is in the softening zone, we may or may not want it to be revealed. for example, if we only want hiders to be found if they have at least 50% opacity, set this value to 0.5")]
		[Range(0f, 1f)]
		[FormerlySerializedAs("RevealHiderInFadeOutZonePercentage")]
		[SerializeField]
		protected float revealHiderInFadeOutZonePercentage;

		[SerializeField]
		protected int MaxHidersSampledPerFrame;

		[Tooltip("Sets the hider ray origin at the hiders height")]
		[FormerlySerializedAs("CalculateHidersAtHiderHeight")]
		[SerializeField]
		public bool SetHiderRayOriginToHidersHeight;

		[Tooltip("Sets the hider ray destination at this revealers height")]
		[FormerlySerializedAs("SampleHidersAtRevealerHeight")]
		[SerializeField]
		public bool SetHiderRayDestinationToRevealersHeight;

		[Header("Occlusion Settings")]
		[Tooltip("Without occlusion, you can easilly have thousands of revealers with minimal performance cost")]
		[SerializeField]
		protected bool useOcclusion;

		[Tooltip("If you disable this, FOW will skip 'inside' edges of objects, allowing bleeding between the objects visible corners")]
		[FormerlySerializedAs("AddCorners")]
		[SerializeField]
		protected bool addCorners;

		[CompilerGenerated]
		private Action<FogOfWarHider, bool> m_OnHiderVisibilityChanged;

		[NonSerialized]
		public HiderRevealer HiderSeeker;

		[NonSerialized]
		public int RevealerArrayPosition;

		[NonSerialized]
		public int RevealerGPUDataPosition;

		[NonSerialized]
		public bool CurrentlyStaticRevealer;

		protected FogOfWarWorld.RevealerInfoStruct RevealerInfoStruct;

		protected FogOfWarWorld.RevealerDataStruct RevealerDataStruct;

		protected bool IsRegistered;

		[NonSerialized]
		public int NumberOfPoints;

		[NonSerialized]
		public float2[] OutputDirections;

		[NonSerialized]
		public float[] OutputDistances;

		[NonSerialized]
		public List<int> SpatialHashBuckets;

		[NonSerialized]
		public int2 MinBucket;

		[NonSerialized]
		public int2 MaxBucket;

		protected Transform CachedTransform;

		protected float3 EyePosition;

		protected float2 RevealerPosition;

		protected float RevealerHeightPosition;

		protected int lastHiderIndex;

		protected bool CircleIsComplete;

		[NonSerialized]
		public float TotalRevealerRadius;

		protected float currentInnerSoftenAmount;

		protected float hiderSightDist;

		protected float hiderSightDistSq;

		protected float unobscuredHiderSightDist;

		protected float unobscuredHiderSightDistSq;

		protected float hiderHeightSightDist;

		protected float halfViewAngle;

		protected float cosHalfViewAngle;

		[NonSerialized]
		public float3 ForwardVectorCached;

		protected float2 ForwardVectorProjectedCached;

		public float ViewRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SoftenDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float InnerSoftenAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float UnobscuredRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float UnobscuredSoftenDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float VisionHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float VisionHeightSoftenDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ViewAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Opacity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RevealHiderInFadeOutZonePercentage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool UseOcclusion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AddCorners
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<FogOfWarHider, bool> OnHiderVisibilityChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		protected abstract void SetupOnRegister();

		public void RegisterRevealer()
		{
		}

		public void DeregisterRevealer()
		{
		}

		public void SetRevealerAsStatic(bool IsStatic)
		{
		}

		public void ManualCalculateLineOfSight()
		{
		}

		public void RevealHiders()
		{
		}

		protected abstract bool CanSeeHider(FogOfWarHider hider, float2 hiderPosition);

		private void ProcessHidersLegacy()
		{
		}

		private void ProcessHidersSpatialHash()
		{
		}

		public void OnSeenHiderDeactivated(FogOfWarHider hider)
		{
		}

		protected abstract bool _TestPoint(float3 point);

		public bool TestPoint(float3 point)
		{
			return false;
		}

		public virtual void SetCachedRayDistance()
		{
		}

		protected virtual void RevealerValuesChanged()
		{
		}

		protected void ApplyData()
		{
		}

		protected abstract void SetPositionAndHeight();

		protected abstract float GetEyeRotation();

		public abstract float3 GetEyePosition();

		protected abstract void SetCachedForward();

		public abstract float3 DirFromAngle(float angleInDegrees);

		protected abstract float AngleBetweenVector2(float3 _vec1, float3 _vec2);

		protected virtual void CleanupRevealer()
		{
		}

		protected abstract void IterationOne(float firstAngle, float angleStep);

		public static void PrePhaseOne()
		{
		}

		public virtual void LineOfSightPhase1()
		{
		}

		public static void PostPhaseOne()
		{
		}

		public virtual void LineOfSightPhase2()
		{
		}
	}
}
