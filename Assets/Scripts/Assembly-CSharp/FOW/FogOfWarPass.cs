using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

namespace FOW
{
	public class FogOfWarPass : ScriptableRenderPass
	{
		public static FogOfWarPass instance;

		public bool EffectEnabled;

		private string m_ProfilerTag;

		private RenderTargetIdentifier source;

		private RenderTargetIdentifier destination;

		private static readonly int temporaryRTId;

		private static readonly int kBlitTexturePropertyId;

		private static readonly int kBlitScaleBiasPropertyId;

		private const string m_PassName = "FOW_Pass";

		public FogOfWarPass(string tag)
		{
		}

		private void SetShaderProperties(Camera camera)
		{
		}

		[Obsolete]
		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		public void SetupRenderGraph()
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}
	}
}
