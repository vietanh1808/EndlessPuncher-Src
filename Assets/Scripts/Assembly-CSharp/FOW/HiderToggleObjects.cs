using UnityEngine;

namespace FOW
{
	public class HiderToggleObjects : HiderBehavior
	{
		[Tooltip("Objects that will be visible when in Line Of Sight")]
		public GameObject[] RevealedObjects;

		[Tooltip("Objects that will be visible when out of Line Of Sight")]
		public GameObject[] HiddenObjects;

		protected override void OnHide()
		{
		}

		protected override void OnReveal()
		{
		}
	}
}
