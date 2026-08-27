using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Inventory
{
	public class ItemCard : MonoBehaviour
	{
		[Serializable]
		public class RarityBorderBG
		{
			public ItemRarity itemRarity;

			public GameObject[] rareObjects;
		}

		public List<RarityBorderBG> rarityBorders;

		[Header("Fill")]
		[SerializeField]
		private Slider slider;

		[SerializeField]
		private Image fill;

		[SerializeField]
		private GameObject sliderObject;

		[SerializeField]
		private GameObject highLight;

		public GameObject focus;

		public TextMeshProUGUI countText;

		public TextMeshProUGUI levelText;

		public Image icon;

		[SerializeField]
		private Image[] backGrounds;

		[SerializeField]
		private Animator cannotMergeAnimator;

		[SerializeField]
		private ParticleSystem cardUpgradeFX;

		public int count;

		public int level;

		public Button upgradePanelButton;

		public ItemDB.Item itemData;

		[SerializeField]
		private GameObject notificationDot;

		[SerializeField]
		private GameObject notificationUpgrade;

		public void SetCard(ItemDB.Item itemData, Color bgColor, bool stack)
		{
		}

		public bool HasUpgrade(bool stack)
		{
			return false;
		}

		public bool HasAnyUpgrade(bool stack)
		{
			return false;
		}

		public void SetFocus(bool isOpen)
		{
		}

		public void SetValues(bool stack)
		{
		}

		public bool IsMaxLevel()
		{
			return false;
		}

		public void ShowCantMerge()
		{
		}

		public void PlayQuickMergeEffect()
		{
		}

		public void CheckCanMergable()
		{
		}

		public bool IsUpgradable()
		{
			return false;
		}
	}
}
