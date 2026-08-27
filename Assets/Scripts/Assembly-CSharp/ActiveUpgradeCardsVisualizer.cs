using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActiveUpgradeCardsVisualizer : MonoBehaviour
{
	[Serializable]
	public class CardVisualizer
	{
		public Coroutine triggerCoroutine;

		public GameObject cardObje;

		public Image icon;

		public Animator animCard;

		public GameObject outlineIcon;

		public GameObject lockObje;

		public TextMeshProUGUI lockChapterText;

		public ActiveUpgradesType typeUpgrade;

		public ParticleSystem unlockedParticle;

		[NonSerialized]
		public Sprite initialIconSprite;

		[NonSerialized]
		public Color initialIconColor;

		[NonSerialized]
		public Color initialBackgroundColor;

		public bool isActive;

		public bool CanActivate()
		{
			return false;
		}

		public void SetLockedState(bool isLocked, int unlockChapter)
		{
		}

		public void ShowPendingUnlockState()
		{
		}

		public void CompletePendingUnlockState(int unlockChapter)
		{
		}

		public void Activate(ActiveUpgradesType type)
		{
		}

		public void SetTriggered(bool isTriggered)
		{
		}

		public Animator GetAnimator()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public Animator animator;

		public bool impactHappened;

		internal void _003CPlayPendingCardUnlocks_003Eb__0()
		{
		}

		internal bool _003CPlayPendingCardUnlocks_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlayPendingCardUnlocks_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<int> cardIndexes;

		public ActiveUpgradeCardsVisualizer _003C_003E4__this;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private int _003Ci_003E5__2;

		private int _003CcardIndex_003E5__3;

		private CardVisualizer _003Ccard_003E5__4;

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
		public _003CPlayPendingCardUnlocks_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CTriggerRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardVisualizer card;

		public float duration;

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
		public _003CTriggerRoutine_003Ed__17(int _003C_003E1__state)
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

	private static readonly int breathHash;

	private static ActiveUpgradeCardsVisualizer _instance;

	public List<CardVisualizer> allCards;

	public static ActiveUpgradeCardsVisualizer Instance => null;

	private void Awake()
	{
	}

	private void CacheInitialCardVisualStates()
	{
	}

	private void Start()
	{
	}

	private int GetUnlockChapterForIndex(int index)
	{
		return 0;
	}

	private bool IsIndexUnlocked(int index)
	{
		return false;
	}

	public void RefreshCardLocks()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayPendingCardUnlocks_003Ed__12))]
	private IEnumerator PlayPendingCardUnlocks(List<int> cardIndexes)
	{
		return null;
	}

	public void SetUpgradeUI(ActiveUpgradesType type)
	{
	}

	public void PlayTrigger(ActiveUpgradesType type)
	{
	}

	public void PlayTrigger(ActiveUpgradesType type, float duration)
	{
	}

	public void SetTriggered(ActiveUpgradesType type, bool isTriggered)
	{
	}

	[IteratorStateMachine(typeof(_003CTriggerRoutine_003Ed__17))]
	private IEnumerator TriggerRoutine(CardVisualizer card, float duration)
	{
		return null;
	}

	public void ShowInfo(int id)
	{
	}

	public void ResetForNewRun()
	{
	}
}
