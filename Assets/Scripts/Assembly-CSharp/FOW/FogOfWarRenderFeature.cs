using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace FOW
{
	public class FogOfWarRenderFeature : ScriptableRendererFeature
	{
		public RenderPassEvent renderPassEvent;

		[Tooltip("This is required for 'Texture Color' fog, but can increase gpu usage on mobile.")]
		public bool EnableNormals;

		private FogOfWarPass fowPass;

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}
	}
}
