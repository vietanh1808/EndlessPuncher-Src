using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TalentEarnedPanelHandler : MonoBehaviour
{
	private struct RankLeaguePrizeRequest
	{
		public string PreviousRankName;

		public string NextRankName;
	}

	[Serializable]
	public class TalenLeagueCompletePrize
	{
		public Animator animPanel;

		public TextMeshProUGUI leagueName1;

		public TextMeshProUGUI leagueName2;

		public TextMeshProUGUI attackStatValue1;

		public TextMeshProUGUI attackStatValue2;

		public TextMeshProUGUI attackStatIncValue;

		public TextMeshProUGUI hpStatValue1;

		public TextMeshProUGUI hpStatValue2;

		public TextMeshProUGUI hpStatIncValue;

		public TextMeshProUGUI defStatValue1;

		public TextMeshProUGUI defStatValue2;

		public TextMeshProUGUI defStatIncValue;
	}

	[Serializable]
	public class TalentEarnedReward
	{
		public Animator animPanel;

		public TextMeshProUGUI description;

		public ParticleSystem confettie;

		public List<TalentPrizeSlot> allTalentPrizes;
	}

	[Serializable]
	public class TraitRing
	{
		public Animator animPanel;

		public ParticleSystem confettie;

		public GameObject ringPrizeObje;
	}

	[Serializable]
	public class TalentPrizeSlot
	{
		public PrizeTalentType type;

		public GameObject talentPrizeObje;

		public TextMeshProUGUI talentText;
	}

	[Serializable]
	public class TotalPower
	{
		public Animator animPanel;

		public Animator animPower;

		public TextMeshProUGUI textPower;

		public AnimationCurve curveSpeed;
	}

	[CompilerGenerated]
	private sealed class _003CEarnedPower_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentEarnedPanelHandler _003C_003E4__this;

		public float valuePower;

		private float _003Ct_003E5__2;

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
		public _003CEarnedPower_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CLoadCoinsInDelay_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentEarnedPanelHandler _003C_003E4__this;

		public float goldValue;

		public TalentPrizeSlot prize;

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
		public _003CLoadCoinsInDelay_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CLoadInDelay_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentEarnedPanelHandler _003C_003E4__this;

		public PrizeTalentType type;

		private bool _003CisSkillPrize_003E5__2;

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
		public _003CLoadInDelay_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CLoadRingUpInDelay_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentEarnedPanelHandler _003C_003E4__this;

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
		public _003CLoadRingUpInDelay_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CProcessRankLeaguePrizeQueue_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentEarnedPanelHandler _003C_003E4__this;

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
		public _003CProcessRankLeaguePrizeQueue_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CShowRankLeagueJump_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentEarnedPanelHandler _003C_003E4__this;

		public RankLeaguePrizeRequest request;

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
		public _003CShowRankLeagueJump_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CWaitClickToComplete_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentEarnedPanelHandler _003C_003E4__this;

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
		public _003CWaitClickToComplete_003Ed__27(int _003C_003E1__state)
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

	private readonly Queue<RankLeaguePrizeRequest> pendingRankLeaguePrizes;

	private Coroutine rankLeaguePrizeRoutine;

	private Coroutine ringUpRoutine;

	private static TalentEarnedPanelHandler _instance;

	private GameManager _gm;

	public TalenLeagueCompletePrize leaguePrize;

	public TalentEarnedReward otherPrize;

	public TraitRing ringUp;

	public TotalPower powerEarned;

	[SerializeField]
	private float rankPowerRefreshDelayAfterPanelClose;

	private bool _isPrizeLeague;

	private bool _isOtherPrizeActive;

	private float _holdedPower;

	public static TalentEarnedPanelHandler Instance => null;

	public bool isLeaguePrizeActive => false;

	private void UnlockSkillForNextFight(SkillType skillType)
	{
	}

	public static TalentEarnedPanelHandler GetInstanceForPrize(PrizeTalentType prizeType)
	{
		return null;
	}

	private void Awake()
	{
	}

	public void LoadLeagueJump(CappybaraTalentDB.CappyTalent talent, CappybaraTalentDB.PrizeTalent prizeTalent, int leagueValue)
	{
	}

	private void GiveTutorialChestIfNeeded(CappybaraTalentDB.CappyTalent talent, int leagueValue)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitClickToComplete_003Ed__27))]
	private IEnumerator WaitClickToComplete()
	{
		return null;
	}

	public void QueueRankLeagueJump(string previousRankName, string nextRankName)
	{
	}

	[IteratorStateMachine(typeof(_003CProcessRankLeaguePrizeQueue_003Ed__29))]
	private IEnumerator ProcessRankLeaguePrizeQueue()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowRankLeagueJump_003Ed__30))]
	private IEnumerator ShowRankLeagueJump(RankLeaguePrizeRequest request)
	{
		return null;
	}

	private void RefreshRankLeagueRewardUi(float previousDamage, float nextDamage, float previousHp, float nextHp, float previousDefence, float nextDefence, float damageReward, float hpReward, float defenceReward)
	{
	}

	private string FormatLeagueRewardStatValue(float value)
	{
		return null;
	}

	private string previousRankNameOrFallback(string rankName)
	{
		return null;
	}

	public void LoadOtherPrize(CappybaraTalentDB.CappyTalent talent, CappybaraTalentDB.PrizeTalent prizeTalent)
	{
	}

	public void LoadOtherPrize(CappybaraTalentDB.PrizeTalent prizeTalent)
	{
	}

	public void LoadRingUp()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadRingUpInDelay_003Ed__37))]
	private IEnumerator LoadRingUpInDelay()
	{
		return null;
	}

	private void CloseOtherPrizeSlots()
	{
	}

	private string GetPrizeDescription(PrizeTalentType prizeType)
	{
		return null;
	}

	private bool TryGetSkillTypeForPrize(PrizeTalentType prizeType, out SkillType skillType)
	{
		skillType = default;
		return false;
	}

	private static TalentEarnedPanelHandler FindBestInstance()
	{
		return null;
	}

	private static TalentEarnedPanelHandler FindBestInstance(PrizeTalentType prizeType)
	{
		return null;
	}

	private bool CanDisplayPrize(PrizeTalentType prizeType)
	{
		return false;
	}

	private float GetPrizeDisplayValueSafe(CappybaraTalentDB.CappyTalent talent, CappybaraTalentDB.PrizeTalent prizeTalent)
	{
		return 0f;
	}

	private void HandlePrizeEffect(PrizeTalentType prizeType)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadCoinsInDelay_003Ed__46))]
	private IEnumerator LoadCoinsInDelay(TalentPrizeSlot prize, float goldValue)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadInDelay_003Ed__47))]
	private IEnumerator LoadInDelay(PrizeTalentType type)
	{
		return null;
	}

	public void LoadEarnedPower()
	{
	}

	[IteratorStateMachine(typeof(_003CEarnedPower_003Ed__50))]
	private IEnumerator EarnedPower(float valuePower)
	{
		return null;
	}
}
