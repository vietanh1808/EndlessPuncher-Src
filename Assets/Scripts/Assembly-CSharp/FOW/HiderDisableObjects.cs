using UnityEngine;

namespace FOW
{
	public class HiderDisableObjects : HiderBehavior
	{
		[SerializeField]
		private GameObject[] ObjectsToHide;

		protected override void OnHide()
		{
		}

		protected override void OnReveal()
		{
		}

		public void ModifyHiddenObjects(GameObject[] newObjectsToHide)
		{
		}
	}
}
