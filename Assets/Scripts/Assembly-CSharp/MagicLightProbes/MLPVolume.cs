using System.Collections.Generic;
using UnityEngine;

namespace MagicLightProbes
{
	[ExecuteInEditMode]
	public class MLPVolume : MonoBehaviour
	{
		[HideInInspector]
		public MagicLightProbes parentRootComponent;

		[HideInInspector]
		public MeshRenderer selfRenderer;

		[HideInInspector]
		public bool showGizmo;

		public bool showGizmoSelected;

		public bool isPartVolume;

		public bool isSubdividedPart;

		public bool isCalculated;

		public bool isInProcess;

		public bool skipped;

		public int id;

		public Color colorOnSelection;

		public List<MLPPointData> localAcceptedPoints;

		public List<MLPPointData> localNearbyGeometryPoints;

		public List<MLPPointData> localContrastPoints;

		public List<MLPPointData> localCornerPoints;

		public List<Vector3> localNearbyGeometryPointsPositions;

		public List<Vector3> resultNearbyGeometryPointsPositions;

		public List<Vector3> localCornerPointsPositions;

		public List<Vector3> resultLocalCornerPointsPositions;

		public List<Vector3> localEquivalentPointsPositions;

		public List<Vector3> resultLocalEquivalentPointsPositions;

		public List<Vector3> resultLocalFreePointsPositions;

		public List<Vector3> localUnlitPointsPositions;

		public List<Vector3> localFreePointsPositions;

		public List<Vector3> resultLocalUnlitPointsPositions;

		public List<Vector3> localDirections;

		public List<Vector3> localAvaragedDirections;

		public List<MLPPointData> localColorThresholdEditingPoints;

		public int objectsInside;
	}
}
