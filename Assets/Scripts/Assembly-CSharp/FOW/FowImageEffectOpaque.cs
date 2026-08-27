using UnityEngine;

namespace FOW
{
	public class FowImageEffectOpaque : FowImageEffectBase
	{
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}
	}
}
