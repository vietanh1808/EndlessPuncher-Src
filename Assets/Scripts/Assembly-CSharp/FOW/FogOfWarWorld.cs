using System;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace FOW
{
	[DefaultExecutionOrder(-100)]
	public class FogOfWarWorld : MonoBehaviour
	{
		public struct RevealerInfoStruct
		{
			public int StartIndex;

			public float RevealerVisionRadius;

			public float RevealerVisionRadiusFade;

			public float innerSoftenThreshold;

			public float invInnerSoftenThreshold;

			public float UnobscuredRadius;

			public float UnobscuredSoftenRadius;

			public float VisionHeight;

			public float VisionHeightFade;

			public float Opacity;

			public int UseOcclusion;
		}

		public struct RevealerDataStruct
		{
			public float RevealerTotalVisionRadius;

			public Vector2 RevealerPosition;

			public float RevealerHeight;

			public int NumSegments;
		}

		public struct GpuSightSegment
		{
			public float2 direction;

			public float length;
		}

		public enum FowUpdateMethod
		{
			Update = 0,
			LateUpdate = 1,
			StartInUpdateFinishInLateUpdate = 2
		}

		public enum RevealerUpdateMethod
		{
			Every_Frame = 0,
			N_Per_Frame = 1,
			Controlled_ElseWhere = 2
		}

		public enum FogSampleMode
		{
			Pixel_Perfect = 0,
			Texture = 1,
			Both = 2
		}

		public enum FogOfWarType
		{
			Hard = 0,
			Soft = 1
		}

		public enum FogOfWarFadeType
		{
			Linear = 0,
			Exponential = 1,
			Smooth = 2,
			Smoother = 3,
			Smoothstep = 4
		}

		public enum FogOfWarBlendMode
		{
			Max = 0,
			Additive = 1
		}

		public enum FogOfWarAppearance
		{
			Solid_Color = 0,
			GrayScale = 1,
			Blur = 2,
			Texture_Sample = 3,
			Outline = 4,
			None = 5
		}

		public enum GamePlane
		{
			XZ = 0,
			XY = 1,
			ZY = 2
		}

		[BurstCompile(CompileSynchronously = true)]
		private struct SetAnglesBuffersJob : IJobParallelFor
		{
			[ReadOnly]
			public NativeArray<GpuSightSegment> Angles;

			[WriteOnly]
			public NativeArray<GpuSightSegment> AnglesArray;

			public void Execute(int index)
			{
			}
		}

		public FogOfWarType FogType;

		public FogOfWarFadeType FogFade;

		public float FogFadePower;

		public FogOfWarBlendMode BlendType;

		[Tooltip("Uses dithering instead of true opacity.")]
		public bool UseDithering;

		public float DitherSize;

		[Tooltip("Prevents Z-Fighting by allowing fog to slightly expand past its actual vision radius.\n\nYou can also use negative values to prevent unwanted bleeding, in the case you use pixelated fog, or texture fog with a low resolution.")]
		public float SightExtraAmount;

		[Tooltip("Controls softening for Revealer Extra Sight Distance")]
		public float EdgeSoftenDistance;

		[Tooltip("Controls the maximum distance FOW is rendered")]
		public float MaxFogDistance;

		[SerializeField]
		private FogOfWarAppearance FogAppearance;

		[Tooltip("The color of the fog")]
		public Color UnknownColor;

		public float SaturationStrength;

		public float BlurStrength;

		[Range(0f, 2f)]
		public float BlurDistanceScreenPercentMin;

		[Range(0f, 2f)]
		public float BlurDistanceScreenPercentMax;

		public int BlurSamples;

		public Texture2D FogTexture;

		public bool UseTriplanar;

		public Vector2 FogTextureTiling;

		public Vector2 FogScrollSpeed;

		public float OutlineThickness;

		public bool PixelateFog;

		public bool WorldSpacePixelate;

		public float PixelDensity;

		public bool RoundRevealerPosition;

		public Vector2 PixelGridOffset;

		public bool UseWorldBounds;

		public float WorldBoundsSoftenDistance;

		public float WorldBoundsInfluence;

		public bool InvertFowEffect;

		[Tooltip("Allows fog to slightly bleed past obstacle edges in an arc shape")]
		public bool AllowBleeding;

		[Tooltip("Controls how fog is sampled in the fullscreen shader\n\nPixel-Perfect- Fog is calculated per-pixel in screen space.\n  Pros:\n    -This mode allows for unlimited world sized with full resolution fog.\n  Cons:\n    -Cannot use temporal based effects, like fog memory/regrow/retention.\n\nTexture Storage- This mode uses a more traditional method of rendering FOW. It first does the fog calculations on a Render Texture, then samples that render texture in the fullscreen shader.\n  Pros:\n    -Can use extra fog effects, such as fog memory/regrow/retention.\n  Cons:\n    -Requires rendering to a render texture, which uses gpu memory.\n    -Resolution bound, large worlds requires rendering the fog texture at higher resolutions to avoid seeing noticeable grids.")]
		public FogSampleMode FOWSamplingMode;

		[Tooltip("When true, hiders will sample the Texture Storage fog, instead of using a revealers direct line of sight")]
		public bool HidersUseFogTexture;

		[Tooltip("The threshold at which hiders are seen with the fog texture.")]
		[Range(0f, 1f)]
		public float HiderSeenThreshold;

		[Tooltip("When true, sampling the fog texture on the CPU will be much faster, but will calculate it even when its not needed.\n\nYou should definitely keep this true if you need to sample the fog texture from code frequently.\n\nIf Hiders Use Fog Texture is true, then this is also true.")]
		public bool AsyncReadbackFogDataToCpu;

		public bool UseConstantBlur;

		public int ConstantTextureBlurQuality;

		public float ConstantTextureBlurAmount;

		public bool UseMiniMap;

		public int FowResX;

		public int FowResY;

		public bool UseRegrow;

		public bool RevealerFadeIn;

		public float RevealerFadeInSpeed;

		public bool RevealerFadeOut;

		[FormerlySerializedAs("FogRegrowSpeed")]
		public float RevealerFadeOutSpeed;

		public float InitialFogExplorationValue;

		public float MaxFogRegrowAmount;

		public Bounds WorldBounds;

		[Tooltip("Changes where Fog of War updates revealers, calculates hiders, and updates the fog texture.\n\nUpdate: Updates happen in update\n\nLate Update: Updates happen in Late Update\n\nStart in update, Finish in late update: Since revealers use the c# jobs system, we can use this option to let the job run for as long as possible before completing the job manually.")]
		public FowUpdateMethod UpdateMethod;

		[Tooltip("Controls how revealers are calculated\n\nEvery Frame- Every revealer is calculated every frame\n\nTime Spliced- Revealers take turns being calculated. You can choose how many are calculated per-frame.\n\nManual Updates- Revealers will not be automatically updated. Instead, you can update them manually in code.")]
		[FormerlySerializedAs("revealerMode")]
		public RevealerUpdateMethod RevealerUpdateMode;

		[Tooltip("The number of revealers to update each frame. Only used when Revealer Mode is set to 'Time Spliced'")]
		public int MaxNumRevealersPerFrame;

		[SerializeField]
		public bool UseSpatialAcceleration;

		[Tooltip("The cell size used for the spatial hash grid. The best value to use for this will be your average revealers radius (including soften distance) times two.")]
		[SerializeField]
		private int SpatialHashGridSize;

		[Tooltip("How many buckets to use when spatial hashing. more buckets = less collision")]
		[SerializeField]
		private int NumSpatialHashBuckets;

		[Tooltip("The Max possible number of revealers. Keep this as low as possible to use less GPU memory")]
		public int MaxPossibleRevealers;

		[Tooltip("The Max possible number of segments per revealer. Keep this as low as possible to use less GPU memory")]
		public int MaxPossibleSegmentsPerRevealer;

		[Tooltip("The Max possible number of Hiders. Keep this as low as possible to use less memory. It will automatically resize if you add too many hiders, but that can cause a hitch!")]
		public int MaxPossibleHiders;

		public bool is2D;

		[FormerlySerializedAs("gamePlane")]
		public GamePlane GamePlaneOrientation;

		public static FogOfWarWorld instance;

		public static bool UsingSoftening;

		public Material FogOfWarMaterial;

		public Material FowTextureMaterial;

		private static RenderTexture FOW_RT;

		private static RenderTexture FOW_TEMP_RT;

		private static int TotalMaximumSightSegments;

		public static ComputeBuffer ActiveRevealerIndicesBuffer;

		public static ComputeBuffer RevealerInfoBuffer;

		public static ComputeBuffer RevealerDataBuffer;

		public static ComputeBuffer AnglesBuffer;

		public static FogOfWarRevealer[] ActiveRevealers;

		public static FogOfWarRevealer[] UnsortedRevealers;

		public static int NumActiveRevealers;

		public static int numDynamicRevealers;

		public static List<int> DeregisteredRevealerIDs;

		private static int numDeregisteredRevealers;

		public static List<FogOfWarRevealer> RevealersToRegister;

		public static FogOfWarHider[] ActiveHiders;

		public static FogOfWarHider[] UnsortedHiders;

		public static int[] ActiveHiderIndices;

		public static int NumActiveHiders;

		public static List<PartialHider> PartialHiders;

		public static List<int> DeregisteredHiderIDs;

		private static int numDeregisteredHiders;

		public static List<FogOfWarHider> HidersToRegister;

		private static int[] indiciesDataToSet;

		private static bool UsingFowTexture;

		private AsyncFogTextureReader _asyncFogTextureReader;

		private static bool revealerSeesHiders;

		private int activeRevealerIndicesID;

		private int revealerInfoID;

		private int revealerDataID;

		private int sightSegmentBufferID;

		private static int FowEffectStrengthID;

		private int numRevealersID;

		private int materialColorID;

		private int extraRadiusID;

		private int maxDistanceID;

		private int fadePowerID;

		private int saturationStrengthID;

		private int blurStrengthID;

		private int blurPixelOffsetMinID;

		private int blurPixelOffsetMaxID;

		private int blurSamplesID;

		private int blurPeriodID;

		private int fowTetureID;

		private int fowTilingID;

		private int fowSpeedID;

		private int currentIndex;

		public static float3 UpVector;

		public static float3 ForwardVector;

		public const RenderTextureFormat renderTextureFormat = RenderTextureFormat.RHalf;

		public const TextureFormat saveTextureFormat = TextureFormat.RHalf;

		public static Vector4 CachedFowShaderBounds;

		private RevealerInfoStruct[] _revealerInfoToSet;

		private GpuSightSegment[] SightSegmentsUploadData;

		private RevealerDataStruct[] _revealerDataToSet;

		private static Texture2D sampleTex;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void OnLoad()
		{
		}

		private static void ResetStatics()
		{
		}

		private void Awake()
		{
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

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void CalculateFOWPhaseOne()
		{
		}

		private void CalculateFOWPhaseTwo()
		{
		}

		public void RenderFogTexture()
		{
		}

		private void Cleanup()
		{
		}

		public void Initialize()
		{
		}

		public void SwitchSpatialAccelerationMode(bool useSpatial)
		{
		}

		public void SwitchHidersUseFogTextureMode(bool useFogTextureToSeeHiders)
		{
		}

		public void ToggleFogTextureAsyncReadbackToCpu(bool useAsyncReadback)
		{
		}

		public void UpdateHiderSeenThresholdForFogTexture()
		{
		}

		public void SetFogShader()
		{
		}

		public void InitializeFogProperties(Material material)
		{
		}

		public void BindComputeBuffersToMaterial(Material material)
		{
		}

		public void BindSpatialHashComputeBuffersToAllMaterials()
		{
		}

		public void BindSpatialHashComputeBuffersToMaterial(Material material)
		{
		}

		public void UpdateAllMaterialProperties()
		{
		}

		public void UpdateMaterialProperties(Material material)
		{
		}

		public void EnableKeywordOnAllMaterials(string keyword, bool enabled)
		{
		}

		public void EnableKeywordOnMaterial(Material material, string keyword, bool enabled)
		{
		}

		public void InitFOWRT()
		{
		}

		public RenderTexture GetFOWRT()
		{
			return null;
		}

		[Obsolete("Please use ClearFowTexture() instead")]
		public void ClearRegrowTexture()
		{
		}

		public void ClearFowTexture()
		{
		}

		public void UpdateWorldBounds(Vector3 center, Vector3 extent)
		{
		}

		public void UpdateWorldBounds(Bounds newBounds)
		{
		}

		private void FowBoundsUpdated()
		{
		}

		private void SetAllMaterialBounds()
		{
		}

		private void SetMaterialBounds(Material mat)
		{
		}

		public Vector4 GetBoundsVectorForShader()
		{
			return default;
		}

		public Vector2 GetFowBoundsPositionFromWorldPosition(Vector3 WorldPosition)
		{
			return default;
		}

		private void SetNumRevealers()
		{
		}

		public void SetNumRevealers(Material material)
		{
		}

		public int RegisterRevealer(FogOfWarRevealer newRevealer)
		{
			return 0;
		}

		public void DeRegisterRevealer(FogOfWarRevealer toRemove)
		{
		}

		public int RegisterHider(FogOfWarHider newHider)
		{
			return 0;
		}

		public void DeRegisterHider(FogOfWarHider toRemove)
		{
		}

		public void UpdateRevealerInfo(int id, RevealerInfoStruct info)
		{
		}

		public void UpdateRevealerData(int gpuPositionId, in RevealerDataStruct data, int numHits, float2[] directions, float[] distances)
		{
		}

		private void UpdateRevealerDataLegacy(int gpuPositionId, in RevealerDataStruct data, int numHits, float2[] directions, float[] distances)
		{
		}

		private void UpdateRevealerDataCompute()
		{
		}

		public static void OnPreRenderFog()
		{
		}

		public static void SetFowEffectStrength(float strength)
		{
		}

		public static float2 GetFowTextureUVFromWorldPosition(Vector3 WorldPosition)
		{
			return default;
		}

		public static bool SampleFogTextureAtPoint(Vector3 WorldPosition)
		{
			return false;
		}

		public static float SampleFogTextureColorAtPoint(Vector3 WorldPosition)
		{
			return 0f;
		}

		private static Color SamplePixelSlow(RenderTexture rt, Vector2 uv)
		{
			return default;
		}

		public static bool TestPointVisibility(Vector3 point)
		{
			return false;
		}

		public void SetFowAppearance(FogOfWarAppearance AppearanceMode)
		{
		}

		public FogOfWarAppearance GetFowAppearance()
		{
			return FogOfWarAppearance.Solid_Color;
		}

		public byte[] GetFowTextureSaveData()
		{
			return null;
		}

		public void LoadFowTextureData(byte[] save)
		{
		}
	}
}
