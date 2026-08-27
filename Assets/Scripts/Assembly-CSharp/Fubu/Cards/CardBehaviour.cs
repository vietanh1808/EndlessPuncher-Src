using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Cards
{
	public class CardBehaviour : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private TMP_Text levelText;

		[SerializeField]
		private GameObject[] rarenesses;

		[SerializeField]
		private GameObject lockCover;

		[SerializeField]
		private GameObject equippedCover;

		[SerializeField]
		private GameObject readyToUpgrade;

		[SerializeField]
		private GameObject normalUpgrade;

		[SerializeField]
		private GameObject upgradeHodler;

		[SerializeField]
		private GameObject[] hideObjectsWhenItsBought;

		[SerializeField]
		private Slider upgradeSlider;

		[SerializeField]
		private TMP_Text upgradeText;

		[SerializeField]
		private Animator anim;

		private Card _card;

		private CardsHandler _cardsHandler;

		private void Start()
		{
		}

		public void SetCard(Card card, CardsHandler cardsHandler)
		{
		}

		public void UpdateUI()
		{
		}

		public void SetAsBought()
		{
		}

		public void SetLocked(bool value)
		{
		}

		public void AddCard(int amount)
		{
		}

		private void SetRareness(CardRarity rarity)
		{
		}

		public void OnClicked()
		{
		}

		public Card.SaveUnit GetSaveUnit()
		{
			return default;
		}

		public void Load(Card.SaveUnit? saveUnit)
		{
		}
	}
}
