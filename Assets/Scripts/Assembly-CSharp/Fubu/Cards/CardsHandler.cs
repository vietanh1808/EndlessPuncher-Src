using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Helpers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Cards
{
	public class CardsHandler : MonoBehaviour
	{
		[Serializable]
		private class EquipSlot
		{
			[SerializeField]
			private Image icon;

			[SerializeField]
			private Sprite emptySlotIcon;

			[SerializeField]
			private GameObject lockCover;

			[SerializeField]
			private Animator anim;

			[SerializeField]
			private GameObject[] bgs;

			[SerializeField]
			private TMP_Text lockedText;

			[SerializeField]
			private TMP_Text levelText;

			[SerializeField]
			private int unlockStage;

			private bool isLocked;

			private bool isEmpty;

			private Card _card;

			private CardsHandler _cardHandler;

			private bool isShaking;

			public bool IsLocked => false;

			public bool IsEmpty => false;

			public int CardID => 0;

			public void SetLocked()
			{
			}

			public void UnequipCard()
			{
			}

			public void TriggerRemind()
			{
			}

			public void EquipCard(Card card, CardsHandler cardsHandler, bool fromStart = false, bool ignoreAnim = false)
			{
			}

			public void UpdateUI()
			{
			}

			public void Shake(bool enable)
			{
			}

			public static implicit operator Card(EquipSlot slot)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CBuyingCardEnum_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CardsHandler _003C_003E4__this;

			public int count;

			private float _003CnewCardPosition_003E5__2;

			private float _003ColdCardPosition_003E5__3;

			private int _003CboughtCardCount_003E5__4;

			private Card[] _003CboughtCards_003E5__5;

			private int _003Ci_003E5__6;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CBuyingCardEnum_003Ed__53(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CEquippingItem_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CardsHandler _003C_003E4__this;

			public Card card;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEquippingItem_003Ed__57(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static CardsHandler _instance;

		[SerializeField]
		[Tooltip("Number of cards required to level up cards each rarity and each level.")]
		private SerializedArray<int>[] neededCardCountsPerRarity;

		[SerializeField]
		[Tooltip("Number of cards required to make the purchased card has more rarity.")]
		private int[] buyUpgradeNeeededCardCount;

		public static bool IsEquipping;

		[SerializeField]
		private CardDB cards;

		[SerializeField]
		private CardBehaviour cardPrefab;

		[SerializeField]
		private Transform spawnedCardHolderOnUI;

		[SerializeField]
		private Transform boughtCardHolder;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("A different rarity drop chance range from the current rarity position on all cards. For example, if the current rarity position is 0.25 in the range 0-1, there are 100 cards in the database and randomRange is 0, then the 25th card is always dropped, if the range is 0.1, the drop range is 20-30.")]
		private float randomRange;

		[SerializeField]
		[Tooltip("With (0,0) being current drop position, x is a random value in interval (-1, 1) and y is offset amount from drop position in range of randomRange")]
		private AnimationCurve randomCurve;

		[SerializeField]
		private Animator cardBuyAnim;

		[SerializeField]
		private GameObject boughtCardPanel;

		[SerializeField]
		private GameObject boughtCardButton;

		[SerializeField]
		private ParticleSystem boughtCardPanelLevelUpFx;

		[SerializeField]
		private Slider boughtCardPanelSlider;

		[SerializeField]
		private TMP_Text boughtCardPanelText;

		[SerializeField]
		private TMP_Text boughtCardLevelText;

		[SerializeField]
		private TMP_Text levelText;

		[SerializeField]
		private TMP_Text boughtCardCounterText;

		[SerializeField]
		private Slider boughtCardCounterSlider;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Maximum card rarity position, If randomRange is 0.2 and maxBoughtCardPosition is 0.75 then the last 0.05/1 of cards drop chance will be 0.")]
		private float maxBoughtCardPosition;

		[SerializeField]
		private EquipSlot[] equipSlots;

		[SerializeField]
		private Image equippingCardImage;

		[SerializeField]
		private GameObject equippingCardHolder;

		[SerializeField]
		private Animator equippingCardAnim;

		[SerializeField]
		private ScrollRect cardsScrollBar;

		public Action OnCardChanged;

		private int watchedRewardedCount;

		private float boughtCardPosition;

		private int boughtCardCounter;

		private int boughtCardLevel;

		private CardBehaviour[] spawnedCards;

		private bool boughtCardPanelActive;

		private Card equippedCard;

		private int equippedSlotIndex;

		[SerializeField]
		private CurrencyTypes buyCurrencyType;

		[SerializeField]
		private int buyAmount1;

		[SerializeField]
		private int buyAmount2;

		[SerializeField]
		private long buyPrice1;

		[SerializeField]
		private long buyPrice2;

		[SerializeField]
		private TMP_Text priceText1;

		[SerializeField]
		private TMP_Text priceText2;

		[SerializeField]
		private Button purchaseButton1;

		[SerializeField]
		private Button purchaseButton2;

		[SerializeField]
		private GameObject purchaseCover1;

		[SerializeField]
		private GameObject purchaseCover2;

		private bool IsBoughtCardLevelMaxedOut => false;

		public bool IsRemindable => false;

		public static CardsHandler GetInstance()
		{
			return null;
		}

		public bool IsCardMaxedOut(Card card)
		{
			return false;
		}

		public int GetNeededCard(Card card)
		{
			return 0;
		}

		public Card GetCard(int i)
		{
			return null;
		}

		public Card[] GetEquippedCards()
		{
			return null;
		}

		public bool IsEquippedSlotFull(int i)
		{
			return false;
		}

		public void TriggerSlotRemind()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void CheckUnlockedSlots()
		{
		}

		public int GetNeededCardCount()
		{
			return 0;
		}

		public void CloseBoughtCardPanel()
		{
		}

		private void SetUI()
		{
		}

		public void UpdateUI()
		{
		}

		private void BuyCards(int count)
		{
		}

		[IteratorStateMachine(typeof(_003CBuyingCardEnum_003Ed__53))]
		private IEnumerator BuyingCardEnum(int count)
		{
			return null;
		}

		public void EquipItem(Card card)
		{
		}

		public void UnquipItem(Card card)
		{
		}

		[IteratorStateMachine(typeof(_003CEquippingItem_003Ed__57))]
		private IEnumerator EquippingItem(Card card)
		{
			return null;
		}

		public void OnCardPurchased(int index)
		{
		}

		public void AddCard(params Card[] cards)
		{
		}

		public void EquippedItemSlot(int i)
		{
		}

		public void InterruptEquipping()
		{
		}

		public void SlotButton(int index)
		{
		}

		public void Save()
		{
		}

		private void Load()
		{
		}

		private void UpdateLevel()
		{
		}

		private float CardPosition(int countForward)
		{
			return 0f;
		}

		public bool IsThereSpace()
		{
			return false;
		}

		private int GetRandomCardIndex()
		{
			return 0;
		}

		private void UpdatePurchaseUI()
		{
		}

		public void Purchase(int id)
		{
		}
	}
}
