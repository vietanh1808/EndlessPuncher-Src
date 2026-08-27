using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestPanelHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRefreshClaimedSlotWithDelay_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public QuestUISlot claimedSlot;

		public QuestPanelHandler _003C_003E4__this;

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
		public _003CRefreshClaimedSlotWithDelay_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CWaitClickScreen_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestPanelHandler _003C_003E4__this;

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
		public _003CWaitClickScreen_003Ed__29(int _003C_003E1__state)
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

	private static QuestPanelHandler _instance;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private GameObject miniFightScenePanel;

	[SerializeField]
	private GameObject questActivatorButton;

	[SerializeField]
	private GameObject questActivatorButtonCloser;

	[SerializeField]
	private Animator panelAnimator;

	[SerializeField]
	private QuestUISlot[] slots;

	public Animator animChestEarned;

	private bool _isActivatedQuestpanel;

	public static QuestPanelHandler Instance => null;

	public bool IsQuestPanelVisible => false;

	public bool IsQuestPanelOpen => false;

	public Transform QuestActivatorTransform => null;

	private void Awake()
	{
	}

	private bool IsQuestUnlocked()
	{
		return false;
	}

	private void Start()
	{
	}

	public void SetQuestPanelActive()
	{
	}

	public void SetMenuPanelVisible(bool isVisible)
	{
	}

	public QuestUISlot GetFirstClaimableSlot()
	{
		return null;
	}

	public bool CompleteActiveQuests()
	{
		return false;
	}

	public void GetReward(Vector3 pos, QuestDB.RewardQuest rewardQuest, int level)
	{
	}

	public void ChestEarned()
	{
	}

	private void SetQuests()
	{
	}

	public void ResetQuestUIs()
	{
	}

	public void HandleQuestClaimed(QuestUISlot claimedSlot)
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshClaimedSlotWithDelay_003Ed__28))]
	private IEnumerator RefreshClaimedSlotWithDelay(QuestUISlot claimedSlot, float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitClickScreen_003Ed__29))]
	private IEnumerator WaitClickScreen()
	{
		return null;
	}

	public void ShowQuestPanel()
	{
	}

	private void SetQuestPanelOpen(bool isOpen)
	{
	}

	private void HidePiggyBankPanelForOverlay()
	{
	}

	private void RefreshPiggyBankPanelAfterOverlayClosed()
	{
	}
}
