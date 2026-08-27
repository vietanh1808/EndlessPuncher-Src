using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatSelector : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COrderDelay_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StatSelector _003C_003E4__this;

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
		public _003COrderDelay_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003COrderDelayReward_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StatSelector _003C_003E4__this;

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
		public _003COrderDelayReward_003Ed__57(int _003C_003E1__state)
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

	private static StatSelector _instance;

	private GameManager gm;

	private InGameUI ui;

	private readonly int unShownHash;

	private readonly int shownHash;

	private readonly int comeHash;

	private readonly int rerollHash;

	private readonly int goHash;

	public Animator animPanel;

	public GameObject coverObje;

	public StatsSelection[] statSelections;

	public SkillsSelection[] skillSelections;

	public PunchSelection[] punchSelections;

	public ActiveUpgradeSelection[] activeUpgradeSelections;

	private int _counteractiveUpgradeSelection;

	private int _counterpunchSelection;

	private int _countercharacterSelection;

	private int _countercharacterStatSelection;

	public List<StatDB.SelectionReturnValue> retValue;

	[SerializeField]
	private GameObject rewardObje;

	[SerializeField]
	private Button RewardedBtn;

	[SerializeField]
	private Button WeeklyRewardedBtn;

	[SerializeField]
	private TextMeshProUGUI rewardedCounter;

	[SerializeField]
	private GameObject rerollObje;

	[SerializeField]
	private Button rerollButton;

	[SerializeField]
	private TextMeshProUGUI moneyText;

	[SerializeField]
	private int startPrices;

	[SerializeField]
	private int priceIncremental;

	private bool _isRerollActive;

	public static StatSelector instance => null;

	private void StartCommonInit()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void LoadingPanel(bool isReroll = false)
	{
	}

	public void ForceCloseAndClear()
	{
	}

	private void HideAllSelectionsImmediately()
	{
	}

	public void SetPanelUnloaded(GameObject selectedObje)
	{
	}

	public void UnLoadPanel(GameObject selectedObje, bool isExtraPunch = false)
	{
	}

	public void SetRewardedBtn()
	{
	}

	private bool AllClaimCanActivate()
	{
		return false;
	}

	public void PlayRewarded()
	{
	}

	public void WeeklyFreeReward()
	{
	}

	private void DelayActivateRewardedBtn()
	{
	}

	private void DelayActivateWeeklyRewardedBtn()
	{
	}

	public void ClaimAllFromRewarded()
	{
	}

	private void DelayClosePanel()
	{
	}

	public void DelayClosePanelForSkill(bool isUpgrade = false)
	{
	}

	public void DelayClosePanelForActiveUpgrade(bool isUpgrade = false)
	{
	}

	private void DelayClosePanelPunch()
	{
	}

	private void CloseCover()
	{
	}

	public void LoadRaritySkillUpgrade(StatDB.Skill skilll, int rarity)
	{
	}

	public void Reroll()
	{
	}

	private void OpenNoCrystalPanel()
	{
	}

	public void FreeReroll()
	{
	}

	private void RerollButtonSettings(int order)
	{
	}

	[IteratorStateMachine(typeof(_003COrderDelay_003Ed__56))]
	private IEnumerator OrderDelay(int order)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COrderDelayReward_003Ed__57))]
	private IEnumerator OrderDelayReward(int order)
	{
		return null;
	}
}
