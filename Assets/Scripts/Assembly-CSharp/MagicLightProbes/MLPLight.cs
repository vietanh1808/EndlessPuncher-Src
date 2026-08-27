using System.Collections.Generic;
using UnityEngine;

namespace MagicLightProbes
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://motion-games-studio.gitbook.io/magic-light-probes/system-components/mlp-light")]
	public class MLPLight : MonoBehaviour
	{
		public enum CalculationMode
		{
			AccurateShadows = 0,
			LightIntensity = 1
		}

		public enum MLPLightType
		{
			Spot = 0,
			Directional = 1,
			Point = 2,
			Area = 3,
			Mesh = 4
		}

		public enum MLPLightTypeMA
		{
			Area = 3,
			Mesh = 4
		}

		public enum TracePointSettingMode
		{
			Auto = 0,
			Custom = 1
		}

		public enum ShadowmaskMode
		{
			Shadowmask = 0,
			DistanceShadowmask = 1
		}

		public MLPLightType lightType;

		public MLPLightType lastLightType;

		public MLPLightTypeMA lightTypeMA;

		public CalculationMode calculationMode;

		public TracePointSettingMode tracePointSettingType;

		public LightmapBakeType lightMode;

		public ShadowmaskMode shadowmaskMode;

		public Light targetLight;

		public GameObject parentGameObject;

		public Vector3 position;

		public Vector3 forward;

		public bool saveNearbyProbes;

		public float saveRadius;

		public float range;

		public bool useSourceParameters;

		public bool reverseDirection;

		public float angle;

		public bool customTracePoints;

		public bool accurateTrace;

		public int accuracy;

		public int lastAccuracy;

		public bool isDirectional;

		public float tracePointSize;

		public float lastTracePointSize;

		public MeshFilter lastMesh;

		public List<GameObject> tracePoints;

		public List<MLPTracePoint> tracePointsData;

		public MLPTracePoint mainTracePoint;

		public MagicLightProbes parentVolume;

		public bool showOptionsInManagerWindow;

		public float intensity;

		public bool resetEditor;

		public bool showLightOnScene;

		public bool saveOnOutOfRange;

		public bool isHDRP;

		public Vector2 hdrpAreaSize;
	}
}
