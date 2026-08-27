using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AllertController : MonoBehaviour
{
	public enum typeDot
	{
		chest = 0,
		building = 1,
		inventory = 2,
		mergeDot = 3,
		talentDot = 4,
		questDot = 5,
		petDot = 6,
		dungeonDot = 7,
		shopDot = 8,
		ringDot = 9,
		collectibleDot = 10,
		eventDot = 11,
		dailyDot = 12,
		energyMultipUpDot = 13,
		chainOfferDot = 14
	}

	[CompilerGenerated]
	private sealed class _003CHideDotAfterDelay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public AllertController _003C_003E4__this;

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
		public _003CHideDotAfterDelay_003Ed__41(int _003C_003E1__state)
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

	private const float RefreshDelay = 0.25f;

	public typeDot dotType;

	public float minValueToActivateDot;

	public GameObject dotObje;

	public Animator dotAnimator;

	private TalentUpgradeSystem talentPanelcontroller;

	private SloteHandler talentSlotHandler;

	private bool isDotVisible;

	private Coroutine hideDotRoutine;

	private InGameUIMenuController menuController;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshForSoftRestart()
	{
	}

	public static void RefreshAllForSoftRestart()
	{
	}

	private void RegisterCallbacks()
	{
	}

	private void UnregisterCallbacks()
	{
	}

	private InGameUIMenuController GetMenuController()
	{
		return null;
	}

	private void RefreshAlertStateDelayed()
	{
	}

	public void CheckChest()
	{
	}

	public void CheckBuilding()
	{
	}

	private void DelayBuildin()
	{
	}

	public void CheckInventory()
	{
	}

	public void CheckMergeDotInventory()
	{
	}

	public void CheckTalentDot()
	{
	}

	private void DelayTalentDot()
	{
	}

	public void CheckQuestDot()
	{
	}

	private void CheckPetDot()
	{
	}

	public void CheckDungeonDot()
	{
	}

	private void CheckShopDot()
	{
	}

	private void CheckRingDot()
	{
	}

	private void CheckCollectibleDot()
	{
	}

	private void CheckEventDot()
	{
	}

	private void CheckDailyDot()
	{
	}

	private void CheckEnergyMultipUpDot()
	{
	}

	private void HandleCollectibleChanged(string collectibleId)
	{
	}

	private void HandleEventPassChanged()
	{
	}

	private void HandleQuestClaimed(QuestUISlot claimedSlot)
	{
	}

	public void SetDotState(bool shouldShowDot)
	{
	}

	private void ApplyDotState(bool shouldShowDot)
	{
	}

	[IteratorStateMachine(typeof(_003CHideDotAfterDelay_003Ed__41))]
	private IEnumerator HideDotAfterDelay(float delay)
	{
		return null;
	}
}
