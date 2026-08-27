using Fubu.Inventory.DB;
using UnityEngine;

namespace Fubu.Inventory
{
	public class DBManager : MonoBehaviour
	{
		private static DBManager instance;

		public ItemDB itemDB;

		[SerializeField]
		private int rarityMultiple;

		public static DBManager Instance => null;

		public void AddAllItems()
		{
		}

		public void AddRandomItemTest()
		{
		}

		public void AddRandomScroll()
		{
		}

		public ItemDB.Reward CreateItemReward()
		{
			return null;
		}

		public ItemCard AddItem(ItemDB.Reward reward, bool isMerged, int level = 0, bool isUsing = false)
		{
			return null;
		}

		private int GetRandomItemRarity(ItemSlot slot, int currentWave)
		{
			return 0;
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
