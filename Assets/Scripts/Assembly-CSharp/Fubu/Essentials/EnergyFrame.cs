using TMPro;
using UnityEngine;

namespace Fubu.Essentials
{
	public class EnergyFrame : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup energyCanvasGroup;

		[SerializeField]
		private TextMeshProUGUI[] timerTxts;

		[SerializeField]
		private TextMeshProUGUI[] energyTxts;

		[SerializeField]
		private Animator animator;

		public void PlayPopAnimation()
		{
		}

		public void SetTimerText(string text)
		{
		}

		public void SetEnergyText(string text)
		{
		}

		public void HideEnergyUI()
		{
		}

		public void ShowEnergyUI()
		{
		}
	}
}
