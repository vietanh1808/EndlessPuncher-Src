using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Forge
{
	public class ForgeCardInfoPanel : MonoBehaviour
	{
		[Serializable]
		public class CardInfo
		{
			[SerializeField]
			private Image icon;

			[SerializeField]
			private TextMeshProUGUI slotNameText;

			[SerializeField]
			private TextMeshProUGUI nameText;

			[SerializeField]
			private GameObject[] rarityBGs;

			[SerializeField]
			private GameObject[] iconRarityBGs;

			[SerializeField]
			private Stat[] stats;

			public void SetCard(SlotItem item, bool isComparison, SlotItem oldItem)
			{
			}

			public void CloseIcon()
			{
			}
		}

		[Serializable]
		public class Stat
		{
			[SerializeField]
			private StatType statType;

			[SerializeField]
			private TextMeshProUGUI valueText;

			[SerializeField]
			private GameObject statHolder;

			[SerializeField]
			private GameObject upArrow;

			[SerializeField]
			private GameObject downArrow;

			public void SetStat(SlotItem item, bool isComparison, SlotItem oldItem)
			{
			}

			private void UpdateStatComparisonArrows(SlotItem currentItem, bool isComparison, SlotItem oldItem)
			{
			}

			private void UpdateStatValueText(SlotItem item)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CClosePanelAfterDelay_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public ForgeCardInfoPanel _003C_003E4__this;

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
			public _003CClosePanelAfterDelay_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CResetUILayout_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ForgeCardInfoPanel _003C_003E4__this;

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
			public _003CResetUILayout_003Ed__24(int _003C_003E1__state)
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

		[Header("UI Panels")]
		[SerializeField]
		private GameObject panel;

		[SerializeField]
		private GameObject equippedCardPanel;

		[SerializeField]
		private GameObject fakePanel;

		[Header("Card Displays")]
		[SerializeField]
		private CardInfo[] infoCards;

		[SerializeField]
		private CardInfo equippedCardInfo;

		[SerializeField]
		private GameObject equippedCard;

		[SerializeField]
		private GameObject newCard;

		[Header("Buttons & Interaction")]
		[SerializeField]
		private Button sellButton;

		[SerializeField]
		private GameObject sellCover;

		[Header("Effects & Animations")]
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private GameObject sellParticle;

		[SerializeField]
		private Transform sellPoint;

		[Header("Layout Control")]
		[SerializeField]
		private VerticalLayoutGroup verticalLayoutGroup;

		private SlotItem _currentItem;

		private SlotItem _newItem;

		private bool isEquipped;

		private ForgeSlot savedSlot;

		public static ForgeCardInfoPanel Instance { get; private set; }

		private void Awake()
		{
		}

		public void SetCards(SlotItem currentItem, SlotItem newItem, bool resetEquipState)
		{
		}

		private void UpdatePanelStateForComparison(bool hasCurrentItem)
		{
		}

		[IteratorStateMachine(typeof(_003CResetUILayout_003Ed__24))]
		private IEnumerator ResetUILayout()
		{
			return null;
		}

		public void EquipCard()
		{
		}

		public void SellCard()
		{
		}

		private void UpdatePanelStateForSell()
		{
		}

		[IteratorStateMachine(typeof(_003CClosePanelAfterDelay_003Ed__28))]
		private IEnumerator ClosePanelAfterDelay(float delay)
		{
			return null;
		}

		public void ActivatePanel(bool isActive)
		{
		}

		public void ActivateEquipmentPanel(SlotItem slotItem)
		{
		}
	}
}
