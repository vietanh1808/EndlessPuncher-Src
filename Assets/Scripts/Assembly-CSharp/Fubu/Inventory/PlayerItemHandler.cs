using System;
using UnityEngine;

namespace Fubu.Inventory
{
	public class PlayerItemHandler : MonoBehaviour
	{
		[Serializable]
		public class ExtraItems
		{
			public GameObject[] itemObjects;

			public void ActivateItems(bool isActive)
			{
			}
		}

		[Serializable]
		public class ItemInfo
		{
			public ItemSlot Slot;

			public ExtraItems[] items;

			public bool hasFakeItem;

			public GameObject[] fakeItems;

			public void OpenItem(int id, ParticleSystem particleSystem, bool isStart)
			{
			}

			public void CloseItem(int id)
			{
			}
		}

		public PlayerCostumeController[] playerCostumes;

		public ItemInfo[] ItemInfos;

		public ParticleSystem equipParticle;

		public static PlayerItemHandler Instance { get; private set; }

		private void Awake()
		{
		}

		public void OpenItem(ItemSlot slot, int id, bool isStart)
		{
		}

		public void CloseItem(ItemSlot slot, int id)
		{
		}

		private void Start()
		{
		}

		public void SetCharacterItems()
		{
		}

		public void SetMaterialsGray()
		{
		}

		public void SetMaterialsRegular()
		{
		}
	}
}
