using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActiveUpgradeSelection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChangeColor_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActiveUpgradeSelection _003C_003E4__this;

		private Color _003CcolorbgStart_003E5__2;

		private Color _003CcolorObligStart_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CChangeColor_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003COrderDelay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActiveUpgradeSelection _003C_003E4__this;

		public int order;

		private Vector3 _003Cstart_003E5__2;

		private Vector3 _003Cend_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003COrderDelay_003Ed__21(int _003C_003E1__state)
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

	private const string DescriptionHighlightOpenTag = "<b><color=#166A2F>";

	private const string DescriptionHighlightCloseTag = "</color></b>";

	private static int popHash;

	public Animator anim;

	public TextMeshProUGUI textUpgradeName;

	public TextMeshProUGUI textUpgradeDescription;

	public TextMeshProUGUI textLevel;

	[SerializeField]
	private Image iconUpgrade;

	[SerializeField]
	private GameObject[] rarityNames;

	[SerializeField]
	private GameObject[] rarityShines;

	[SerializeField]
	private Color[] rarityColorsBg;

	[SerializeField]
	private Color[] rarityColorsOblig;

	[SerializeField]
	private Color[] rarityColorsBorder;

	[SerializeField]
	private Image[] imageBorder;

	[SerializeField]
	private Image imageBg;

	[SerializeField]
	private Image imageOblig;

	[SerializeField]
	private Color bgColor;

	[SerializeField]
	private Color obligColor;

	private StatDB.ActiveUpgrades _activeUpgrades;

	private StatDB.UpgradeRarityHolder _rarityHolder;

	public void SetStat(StatDB.ActiveUpgrades activeUpgrades, StatDB.UpgradeRarityHolder rarityHolder, int order)
	{
	}

	[IteratorStateMachine(typeof(_003COrderDelay_003Ed__21))]
	private IEnumerator OrderDelay(int order)
	{
		return null;
	}

	private string Prefix(ActiveUpgradesType activeType)
	{
		return null;
	}

	private string Suffix(ActiveUpgradesType activeType)
	{
		return null;
	}

	public string ReplaceValueBetweenDollarSigns(string input, string newValue)
	{
		return null;
	}

	public void ActivateSlote()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeColor_003Ed__26))]
	private IEnumerator ChangeColor()
	{
		return null;
	}

	public void CompleteStat()
	{
	}

	public void CompleteStatFromRewarded()
	{
	}

	private void DelayLoadStatUpgraded()
	{
	}
}
