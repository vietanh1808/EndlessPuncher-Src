using UnityEngine;

namespace Fubu.Forge
{
	public class TurretButtonHandler : MonoBehaviour
	{
		[SerializeField]
		private TurretButtonControl[] turretButtons;

		public static TurretButtonHandler Instance { get; private set; }

		private void Awake()
		{
		}

		public TurretButtonControl GetButton(int index)
		{
			return null;
		}

		public void SetButtonActive(int index, bool active)
		{
		}
	}
}
