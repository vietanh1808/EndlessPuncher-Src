using UnityEngine;

namespace FOW
{
	[RequireComponent(typeof(Camera))]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public abstract class FowImageEffectBase : MonoBehaviour
	{
		private Camera cam;

		private void Awake()
		{
		}

		private void SetCamera()
		{
		}

		private void OnPreRender()
		{
		}

		protected void RenderImage(RenderTexture src, RenderTexture dest)
		{
		}
	}
}
