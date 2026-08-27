using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MagicLightProbes
{
	[ExecuteInEditMode]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/main-component")]
	public class MagicLightProbes : MonoBehaviour
	{
		public struct VolumeParameters
		{
			public int volumeIndex;

			public Vector3 position;

			public Vector3 demensions;

			public VolumeParameters(int _volumeIndex, Vector3 _position, Vector3 _demensions)
			{
				volumeIndex = 0;
				position = default;
				demensions = default;
			}
		}

		public enum FillingMode
		{
			VerticalDublicating = 0,
			FullFilling = 1,
			SeparateFilling = 2
		}

		public enum ExcludingLightsMode
		{
			AllInList = 0,
			AllExceptInList = 1
		}

		public enum Workflow
		{
			Simple = 0,
			Advanced = 1
		}

		public enum BoundsDisplayMode
		{
			Always = 0,
			OnSelection = 1
		}

		public enum DebugPasses
		{
			MaximumHeight = 0,
			GeometryCollision = 1,
			GeometryIntersections = 2,
			NearGeometry = 3,
			OutOfRange = 4,
			OutOfRangeBorders = 5,
			ShadingBorders = 6,
			ContrastAreas = 7,
			NearLights = 8,
			LightIntensity = 9,
			UnlitProbes = 10,
			EqualProbes = 11,
			GeometryEdges = 12,
			EqualColor = 13
		}

		public enum DrawModes
		{
			Accepted = 0,
			Culled = 1,
			Both = 2
		}

		public enum CalculationTarget
		{
			GeometryEdges = 0,
			GeneralCalculation = 1
		}

		[Serializable]
		private struct TempPointData
		{
			public float xPos;

			public float yPos;

			public float zPos;

			public TempPointData(Vector3 _position)
			{
				xPos = 0f;
				yPos = 0f;
				zPos = 0f;
			}
		}

		[Serializable]
		public class WorkPathFoundEvent : UnityEvent<string>
		{
		}

		private const string COMPUTE_SHADERS_FOLDER = "/Passes/Compute Shaders/";

		public IEnumerator colorThresholdRecalculationRoutine;

		public IEnumerator lightProbesVolumeCalculatingRoutine;

		public IEnumerator lightProbesVolumeCalculatingSubRoutine;

		public IEnumerator executingPassesRoutine;

		public IEnumerator volumeDivideingRoutine;

		public bool autoSaveSettings;

		public MLPSettings lastSettingsAsset;

		public List<string> groundAndFloorObjects;

		public List<string> storedGroundAndFloorKeywords;

		public GameObject probesVolume;

		public bool useDynamicDensity;

		public float volumeSpacing;

		public float volumeSpacingMin;

		public float volumeSpacingMax;

		public float cornersDetectionThreshold;

		public float cornersDetectionThresholdMin;

		public float cornersDetectionThresholdMax;

		public float lastCornersDetectionThreshold;

		public float lastCornersDetectionThresholdMin;

		public float lastCornersDetectionThresholdMax;

		public int lastMaxProbesInVolume;

		public int maxProbesInVolume;

		public int defaultMaxProbesCount;

		public float lastVolumeSpacing;

		public float lastVolumeSpacingMin;

		public float lastVolumeSpacingMax;

		public bool volumeSpacingChanged;

		public bool tooManySubVolumes;

		public FillingMode fillingMode;

		public ExcludingLightsMode excludingLightsMode;

		public MLPSettings settingsAsset;

		public Workflow workflow;

		public float maxHeightAboveGeometry;

		public float lastMaxHeightAboveGeometry;

		public float maxHeightAboveTerrain;

		public bool considerDistanceToLights;

		public float lightIntensityTreshold;

		public float colorTreshold;

		public float collisionDetectionRadius;

		public bool saveProbesNearbyGeometry;

		public float cornerProbesSpacing;

		public float nearbyGeometryDetectionRadius;

		public float nearbyGeometryDetectionRadiusMin;

		public float nearbyGeometryDetectionRadiusMax;

		public float distanceFromNearbyGeometry;

		public bool fillEquivalentVolume;

		public float equivalentVolumeFillingRate;

		public bool fillUnlitVolume;

		public bool fillFreeVolume;

		public float unlitVolumeFillingRate;

		public float freeVolumeFillingRate;

		public bool cullAcceptedVolume;

		public float acceptedVolumeFillingRate;

		public float nearbyGeometryVolumeFillingRate;

		public float verticalDublicatingHeight;

		public float verticalDublicatingStep;

		public LayerMask raycastFilter;

		public List<MLPLight> excludedLights;

		public LayerMask layerMask;

		public int firstCollisionLayer;

		public bool useMultithreading;

		public GameObject previousSelection;

		public bool unloaded;

		public bool sceneChanging;

		public bool waitForPrevious;

		public MagicLightProbes previousVolume;

		public bool optimizeForMixedLighting;

		public bool lastOptimizeForMixedLightingValue;

		public bool lastUseDynamicDensityValue;

		public bool preventLeakageThroughWalls;

		public bool useVolumeBottom;

		public bool placeProbesOnGeometryEdges;

		public float lastColorThreshold;

		public float lastLightIntensityThreshold;

		public float lastEquivalentVolumeFillingRate;

		public float lastUnlitVolumeFillingRate;

		public float lastFreeVolumeFillingRate;

		public float lastCornerProbesSpacing;

		public float lastDistanceFromGeometry;

		public bool debugMode;

		public float debugObjectScale;

		public BoundsDisplayMode boundsDisplayMode;

		public DebugPasses debugPass;

		public DrawModes drawMode;

		public bool debugShowLightIntensity;

		public bool showPreviewGrid;

		public bool nextStep;

		public bool cullByColor;

		public bool forceSaveProbesOnShadingBorders;

		public string dataPath;

		public string workPath;

		public bool workPathFound;

		public List<Vector3> localFinishedPositions;

		public ComputeShader calculateVolumeFilling;

		public ComputeShader calculateProbeSpacing;

		public ComputeShader calculateDistanceFromGeometry;

		public MLPVolume currentVolume;

		public bool recalculationRequired;

		private List<Collider> lightColliders;

		private List<Collider> objectColliders;

		private List<MLPPointData> finalDebugAcceptedPoints;

		private List<MLPPointData> finalDebugCulledPoints;

		private List<GameObject> tempObjects;

		private List<GameObject> temporarilyDisabledDynamicObjects;

		private List<GameObject> staticObjectsWithoutCollider;

		public List<GameObject> finalStaticGameObjectsList;

		private GameObject combinedVolumeObject;

		private VolumeParameters currentEditingVolume;

		private Vector3 currentSelectedObjectLastPosition;

		private GameObject lastSelectedObject;

		public bool cancelCombination;

		public List<IEnumerator> passesToExecute;

		public List<GameObject> staticObjects;

		public List<MLPLight> lights;

		public List<MLPPointData> tmpSharedPointsArray;

		public List<MLPPointData> tmpOutOfRangePoints;

		public List<MLPPointData> tmpOutOfMaxHeightPoints;

		public List<MLPPointData> tmpGeometryCollisionPoints;

		public List<MLPPointData> tmpContrastOnOutOfRangePoints;

		public List<MLPPointData> tmpContrastShadingBordersPoints;

		public List<MLPPointData> tmpUnlitPoints;

		public List<MLPPointData> tmpFreePoints;

		public List<MLPPointData> tmpNearbyGeometryPoints;

		public List<MLPPointData> tmpPointsNearGeometryIntersections;

		public List<MLPPointData> tmpNearbyLightsPoints;

		public List<MLPPointData> tmpEqualPoints;

		public List<MLPPointData> debugCulledPoints;

		public List<MLPPointData> debugAcceptedPoints;

		public List<GameObject> subVolumesDivided;

		public List<Vector3> points;

		public List<VolumeParameters> innerVolumes;

		public List<VolumeParameters> subVolumesParameters;

		public List<MagicLightProbes> innerVolumesObjects;

		public List<LayerMask> layerMasks;

		public List<Vector3> transformedPoints;

		public string assetEditorPath;

		public MagicLightProbes parentVolume;

		public static bool operationalDataLost;

		public bool localOperationalDataLost;

		public bool recombinationNeeded;

		public bool isInBackground;

		public bool realtimeEditing;

		public bool calculated;

		public bool calculatingError;

		public int xPointsCount;

		public int yPointsCount;

		public int zPointsCount;

		public float prevVolumeScaleX;

		public float prevVolumeScaleY;

		public float prevVolumeScaleZ;

		public int totalProbes;

		public int totalProbesInSubVolume;

		public int totalProbesInVolume;

		public bool calculatingVolume;

		public bool calculatingVolumeSubPass;

		public string currentPass;

		public int currentPassProgressCounter;

		public int currentPassProgressFrameSkipper;

		public float totalProgress;

		public float currentPassProgress;

		public int selectedTab;

		public bool showOptionsInManagerWindow;

		public bool restored;

		public int currentVolumePart;

		public float eta;

		public bool changed;

		public bool redivideParts;

		public bool combinedVolumeError;

		public bool isInPrefab;

		public Vector3 prefabPosition;

		public GameObject prefabRoot;

		public MLPPrefab prefabConnectionObject;

		public string prefabRootName;

		public bool calculatedFromPrefab;

		public string prefabUID;

		private bool passesExecuting;

		private int totalProgressCounter;

		private int totalProgressFrameSkipper;

		private float startTime;

		private float endTime;

		private bool scenePreparing;

		public void CheckForNearContrast(MLPPointData pointForCheck)
		{
		}

		public bool UpdateProgress(int count, int period = 100)
		{
			return false;
		}

		private bool UpdateTotalProgress(int count, int period = 100)
		{
			return false;
		}
	}
}
