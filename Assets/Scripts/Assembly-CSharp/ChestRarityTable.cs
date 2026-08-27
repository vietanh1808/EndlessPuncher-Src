using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChestRarityTable : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForCloseInputRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChestRarityTable _003C_003E4__this;

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
		public _003CWaitForCloseInputRoutine_003Ed__39(int _003C_003E1__state)
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

	public Animator animPanel;

	public Image bgImage;

	public Image scroolImage;

	public Color bgCommon;

	public Color scroolCommon;

	public Color bgEpic;

	public Color scroolEpic;

	public GameObject commonArrow;

	public GameObject epicArrow;

	public GameObject colelctibleArrow;

	public ChestProbabilityCard collectibleRatio;

	public ChestProbabilityCard collectibleKeyChance;

	public List<ChestProbabilityCard> chestProbabilityCards;

	public TextMeshProUGUI currentLevel;

	public TextMeshProUGUI nextLevel;

	public GameObject titleRegular;

	public GameObject titleCollectible;

	public UISizer[] uiSizers;

	private Coroutine waitForCloseInputRoutine;

	public void LoadChestRarityTable(ChestTypes chestType)
	{
	}

	private void EnsureCollectibleMythicalCard(ChestTypes chestType)
	{
	}

	private void EnsureProbabilityCardCount(int cardCount)
	{
	}

	private void ApplyChestVisualState(ChestTypes chestType)
	{
	}

	private void SetCollectibleRatio(ChestTypes chestType)
	{
	}

	private void SetCollectibleKeyChance(ChestTypes chestType)
	{
	}

	private float GetCurrencyDropChancePercent((float collectibleChance, float currencyChance) dropOdds)
	{
		return 0f;
	}

	private Dictionary<CardRarity, (float, float)> GetRarityChances(ChestTypes chestType)
	{
		return null;
	}

	private void AddChance(Dictionary<CardRarity, (float currentChance, float nextChance)> chances, CardRarity rarity, float currentChance, float nextChance)
	{
	}

	private bool HasVisibleChance((float currentChance, float nextChance) chanceInfo)
	{
		return false;
	}

	private float GetDisplayedChance(float chance)
	{
		return 0f;
	}

	private void RefreshUISizers()
	{
	}

	private void SetLevelTexts(ChestTypes chestType)
	{
	}

	public void ClosePanel()
	{
	}

	private void OnDisable()
	{
	}

	private bool ShouldShowRarity(ChestTypes chestType, CardRarity rarity)
	{
		return false;
	}

	private void LoadHeroChestRarityRows()
	{
	}

	private void SetHeroChestRow(int index, string displayName, float currentChance, float nextChance)
	{
	}

	private void StartWaitingForCloseInput()
	{
	}

	private void StopWaitingForCloseInput()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForCloseInputRoutine_003Ed__39))]
	private IEnumerator WaitForCloseInputRoutine()
	{
		return null;
	}

	private bool IsPointerPressed()
	{
		return false;
	}

	private bool IsPointerPressedDown()
	{
		return false;
	}
}
