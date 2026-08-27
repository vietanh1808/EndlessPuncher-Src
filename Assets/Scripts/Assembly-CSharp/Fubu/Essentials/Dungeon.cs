using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Essentials
{
	public class Dungeon : MonoBehaviour
	{
		[SerializeField]
		private DungeonInfo dungeonInfo;

		[Header("UI References")]
		[SerializeField]
		private TextMeshProUGUI dungeonNameTxt;

		[SerializeField]
		private Image dungeonIcon;

		[SerializeField]
		private TextMeshProUGUI levelTxt;

		[SerializeField]
		private Image rewardIcon;

		[SerializeField]
		private TextMeshProUGUI rewardTxt;

		[SerializeField]
		private Image ticketIcon;

		[SerializeField]
		private TextMeshProUGUI chancesTxt;

		[SerializeField]
		private Button dungeonButton;

		[SerializeField]
		private GameObject dungeonUnlock;

		[SerializeField]
		private TextMeshProUGUI unlockTxt;

		public DungeonInfo DungeonInfo => null;

		public int TicketCount { get; private set; }

		public int Level { get; private set; }

		private void Start()
		{
		}

		public void CheckDungeonUnlock()
		{
		}

		public void SetDungeonData(int ticketCount, int dungeonLevel)
		{
		}

		public void Setup(DungeonInfo dungeonInfo)
		{
		}

		private void OnDungeonClicked()
		{
		}

		public void UpdateUI()
		{
		}

		public bool CanEnter()
		{
			return false;
		}

		public void SpendTicket()
		{
		}

		public void IncreaseLevel()
		{
		}

		public void ResetTickets()
		{
		}

		public void AddTickets()
		{
		}
	}
}
