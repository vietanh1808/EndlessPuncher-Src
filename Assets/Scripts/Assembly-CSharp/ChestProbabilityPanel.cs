using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ChestProbabilityPanel : MonoBehaviour
{
	[Serializable]
	public class TierWLevel
	{
		public List<StatDB.RarityRatios> tierChanceChest;
	}

	[CompilerGenerated]
	private sealed class _003CWaitAndClose_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public ChestProbabilityPanel _003C_003E4__this;

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
		public _003CWaitAndClose_003Ed__19(int _003C_003E1__state)
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

	private static ChestProbabilityPanel _instance;

	[SerializeField]
	private Animator panelAnim;

	[SerializeField]
	private TextMeshProUGUI textChapterFirst;

	[SerializeField]
	private TextMeshProUGUI textChapterSecond;

	[SerializeField]
	private GameObject probabilityPanel;

	[SerializeField]
	private ChestProbabilityCard[] allCards;

	public List<TierWLevel> alltierWLevel;

	public static ChestProbabilityPanel Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void RefreshProbabilities()
	{
	}

	private void RefreshForCommonChestLevels()
	{
	}

	private void SetCardProbability(int cardIndex, CardRarity rarity, float currentChance, float nextChance)
	{
	}

	private bool HasVisibleChance(float chance)
	{
		return false;
	}

	public List<StatDB.RarityRatios> GetTierWlevel()
	{
		return null;
	}

	public void OpenPanel()
	{
	}

	public void ClosePanel()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndClose_003Ed__19))]
	private IEnumerator WaitAndClose(float delay)
	{
		return null;
	}
}
