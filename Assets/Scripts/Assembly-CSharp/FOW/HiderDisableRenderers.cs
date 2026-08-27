using UnityEngine;

namespace FOW
{
	public class HiderDisableRenderers : HiderBehavior
	{
		[SerializeField]
		private Renderer[] ObjectsToHide;

		protected override void OnHide()
		{
		}

		protected override void OnReveal()
		{
		}

		public void ModifyHiddenRenderers(Renderer[] newObjectsToHide)
		{
		}
	}
}
