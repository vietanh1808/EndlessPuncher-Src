using UnityEngine;

namespace FOW
{
	[RequireComponent(typeof(FogOfWarHider))]
	public abstract class HiderBehavior : MonoBehaviour
	{
		protected bool IsEnabled;

		protected virtual void Awake()
		{
		}

		private void OnStatusChanged(bool isEnabled)
		{
		}

		protected abstract void OnReveal();

		protected abstract void OnHide();
	}
}
