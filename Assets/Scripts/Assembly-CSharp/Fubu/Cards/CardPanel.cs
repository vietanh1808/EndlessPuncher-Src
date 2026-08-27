using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Cards
{
	public class CardPanel : MonoBehaviour
	{
		[Serializable]
		private struct Stat
		{
			[SerializeField]
			private CardStatType type;

			[SerializeField]
			private TMP_Text valueText;

			[SerializeField]
			private GameObject gameObject;

			[SerializeField]
			private bool isUsingUnitText;

			public void Set(Card card)
			{
			}

			public void Hide()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetPanelActiveEnum_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool value;

			public CardPanel _003C_003E4__this;

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
			public _003CSetPanelActiveEnum_003Ed__30(int _003C_003E1__state)
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

		private static CardPanel Instance;

		[SerializeField]
		private Stat[] stats;

		[SerializeField]
		private TMP_Text nameText;

		[SerializeField]
		private TMP_Text descriptionText;

		[SerializeField]
		private TMP_Text levelText;

		[SerializeField]
		private Image icon;

		[SerializeField]
		private GameObject[] iconBGs;

		[SerializeField]
		private GameObject[] nameBGs;

		[SerializeField]
		private Button equipButton;

		[SerializeField]
		private GameObject unequipButton;

		[SerializeField]
		private Button enhanceButton;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private TMP_Text upgradeCardCountText;

		[SerializeField]
		private Slider upgradeCardSlider;

		[SerializeField]
		private GameObject upgradeFullHolder;

		[SerializeField]
		private GameObject upgradeNormalHolder;

		[SerializeField]
		private GameObject upgradeHolder;

		[SerializeField]
		private GameObject frame;

		[SerializeField]
		private ParticleSystem upgradeFX;

		[SerializeField]
		private ContentSizeFitter panelSizeFitter;

		private Card _card;

		private CardsHandler _cardsHandler;

		public bool IsActive { get; private set; }

		public static CardPanel GetInstance()
		{
			return null;
		}

		public void ShowPanel(Card card, CardsHandler cardsHandler)
		{
		}

		private void UpdateUI()
		{
		}

		[IteratorStateMachine(typeof(_003CSetPanelActiveEnum_003Ed__30))]
		private IEnumerator SetPanelActiveEnum(bool value)
		{
			return null;
		}

		public void Enhance()
		{
		}

		public void Equip()
		{
		}

		public void Unequip()
		{
		}

		public void CloseButton()
		{
		}

		private void Close()
		{
		}
	}
}
