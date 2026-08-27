using System.Collections.Generic;
using UnityEngine;

namespace FOW.Demos
{
	public class DrawLineToHiderOnReveal : MonoBehaviour
	{
		[Header("This example script subscribes to FogOfWarRevealer.OnHiderVisibilityChanged, \nwhich is a callback that can be used to detect when a revealer sees or loses sight of a hider.")]
		public FogOfWarRevealer MyRevealer;

		public LineRenderer TemplateLineRenderer;

		private Dictionary<FogOfWarHider, LineRenderer> HidersLineRenderers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnHiderVisibilityChanged(FogOfWarHider hider, bool seen)
		{
		}

		private void Update()
		{
		}

		private void UpdateLineRendererPosition(FogOfWarHider Hider, LineRenderer renderer)
		{
		}
	}
}
