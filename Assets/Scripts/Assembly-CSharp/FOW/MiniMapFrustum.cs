using UnityEngine;
using UnityEngine.UI;

namespace FOW
{
	public class MiniMapFrustum : MonoBehaviour
	{
		[Header("References")]
		public Collider MapCollider;

		public RawImage RawImageComponent;

		[Header("Raycasting")]
		public bool UseRaycast;

		public LayerMask RaycastLayers;

		public float RayDistance;

		[Header("Fallback Plane")]
		[Tooltip("Offset along the fog-of-war up axis from this transform's position")]
		public Vector3 PlaneCenterOffset;

		public Vector3 PlaneNormal;

		[Header("Line Settings")]
		public Color LineColor;

		[Range(0.5f, 10f)]
		public float LineWidth;

		[Range(0.1f, 5f)]
		public float Softness;

		[SerializeField]
		private bool ClampToBounds;

		[Tooltip("Scale line width with canvas scale factor\nIgnored when Use Render Texture Pixel Size is enabled.")]
		[SerializeField]
		private bool ScaleWithCanvasSize;

		[Tooltip("Use the render textures resolution instead of the UI element's screen size for line width")]
		[SerializeField]
		private bool UseRenderTexturePixelSize;

		private Material material;

		private Vector2[] uvs;

		private Vector2[] clippedUVs;

		private Vector2[] clipA;

		private Vector2[] clipB;

		private int clipCount;

		private RectTransform rectTransform;

		private Canvas canvas;

		private static readonly int LineColorID;

		private static readonly int LineWidthID;

		private static readonly int SoftnessID;

		private static readonly int TexSizeOverrideID;

		private static readonly int InsetXID;

		private static readonly int InsetYID;

		private static readonly int FrustumUV0ID;

		private static readonly int FrustumUV1ID;

		private static readonly int FrustumUV2ID;

		private static readonly int FrustumUV3ID;

		private static readonly int FrustumUV4ID;

		private static readonly int FrustumUV5ID;

		private static readonly int FrustumUV6ID;

		private static readonly int FrustumUV7ID;

		private static int[] FrustumShaderIds;

		private Vector3 PlaneCenter => default;

		private Plane FrustumPlane => default;

		private void Start()
		{
		}

		public void UpdateClampKeyword(bool clamp)
		{
		}

		private void Update()
		{
		}

		private Vector3 GetWorldSpaceFrustumCorner(Vector2 screenPos)
		{
			return default;
		}

		private Vector2 GetPixelSize()
		{
			return default;
		}

		private void ClipPolygonToUnitBox(float insetX, float insetY)
		{
		}

		private void ClipAgainstEdge(float edgeVal, bool isX, bool keepGreater)
		{
		}

		private Vector2 Intersect(Vector2 a, Vector2 b, float edge, bool isX)
		{
			return default;
		}

		private bool IsPointInQuad(Vector2 p, Vector2[] quad)
		{
			return false;
		}
	}
}
