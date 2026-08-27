using TMPro;
using UnityEngine;

namespace Fubu.Forge
{
	public class StatDetailBehaviour : MonoBehaviour
	{
		[SerializeField]
		private StatType statType;

		[SerializeField]
		private TextMeshProUGUI valueText;

		[SerializeField]
		private GameObject upArrow;

		[SerializeField]
		private GameObject downArrow;

		public void SetStat(SlotItem card, bool newCard, SlotItem oldCard)
		{
		}
	}
}
