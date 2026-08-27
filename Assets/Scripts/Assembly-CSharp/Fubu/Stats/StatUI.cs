using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Stats
{
	public class StatUI : MonoBehaviour
	{
		[SerializeField]
		private GameObject levelMaxedOut;

		[SerializeField]
		private Image icon;

		[SerializeField]
		private TMP_Text nameText;

		[SerializeField]
		private TMP_Text descriptionText;

		[SerializeField]
		private TMP_Text levelText;

		[SerializeField]
		private TMP_Text priceText;

		[SerializeField]
		private TMP_Text from;

		[SerializeField]
		private TMP_Text to;

		[Header("Normal Button")]
		[SerializeField]
		private Button buyButton;

		[Header("Hold Button")]
		[SerializeField]
		private HoldButton holdButton;

		[Header("Purchase")]
		[SerializeField]
		private ParticleSystem[] onPurchaseFXs;

		[SerializeField]
		[Tooltip("\"purchase\" named trigger will be triggered on purchase.")]
		private Animator[] onPurchaseAnimators;

		public Action onPurchased;

		private Stat stat;

		public void Init(Stat stat)
		{
		}

		public void UpdateUI(float price, bool canBuy)
		{
		}

		public void SetFromToTexts(string from, string to)
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void Buy()
		{
		}

		public void OnPurchasedSucceeded()
		{
		}
	}
}
