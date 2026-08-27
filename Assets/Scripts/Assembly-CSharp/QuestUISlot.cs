using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestUISlot : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayClaimPopLoop_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestUISlot _003C_003E4__this;

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
		public _003CPlayClaimPopLoop_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CScaleIn_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestUISlot _003C_003E4__this;

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
		public _003CScaleIn_003Ed__45(int _003C_003E1__state)
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
	private static Action<QuestUISlot> m_QuestClaimed;

	private const float ClaimPopInterval = 2f;

	public ParticleSystem particle;

	public Animator anim;

	public Animator claimAnim;

	public GameObject[] icons;

	public Slider slider;

	public Slider miniQuestSlider;

	public TextMeshProUGUI minisliderText;

	public TextMeshProUGUI miniDescriptionText;

	public TextMeshProUGUI sliderText;

	public TextMeshProUGUI rewardText;

	public TextMeshProUGUI description;

	public GameObject[] claims;

	public GameObject tickCompleted;

	public GameObject goFight;

	public GameObject goChest;

	public GameObject goTalent;

	public GameObject goInventory;

	private bool isAnimCome;

	private Coroutine claimPopRoutine;

	private Button cachedRootButton;

	private QuestDB.Quest _quest;

	private bool _isClaimed;

	public bool IsClaimable => false;

	public bool HasQuest => false;

	public QuestType CurrentQuestType => QuestType.none;

	public static event Action<QuestUISlot> QuestClaimed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void SetQuest(QuestDB.Quest q)
	{
	}

	private void RefreshActionTargets()
	{
	}

	private GameObject GetActionTargetForQuest(QuestType questType)
	{
		return null;
	}

	public void ReSetQuest()
	{
	}

	public string ReplaceValueBetweenDollarSigns(string input, string newValue)
	{
		return null;
	}

	private string GetQuestTargetDisplayText(QuestDB.Quest quest)
	{
		return null;
	}

	private string GetQuestProgressDisplayText(QuestDB.Quest quest)
	{
		return null;
	}

	private float GetQuestProgressRatio(QuestDB.Quest quest)
	{
		return 0f;
	}

	private bool IsQuestCompleted(QuestDB.Quest quest)
	{
		return false;
	}

	private void GetRankQuestStepProgress(QuestDB.Quest quest, out int completedSteps, out int totalSteps)
	{
		completedSteps = default;
		totalSteps = default;
	}

	public Transform GetActiveClaimTarget()
	{
		return null;
	}

	public void CompleteQuest()
	{
	}

	[IteratorStateMachine(typeof(_003CScaleIn_003Ed__45))]
	private IEnumerator ScaleIn()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private GameObject GetRewardIcon(RewardType rewardType)
	{
		return null;
	}

	private Transform GetRewardIconTransform(RewardType rewardType)
	{
		return null;
	}

	private void UpdateClaimAnimationLoop()
	{
	}

	private void StopClaimAnimationLoop()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayClaimPopLoop_003Ed__51))]
	private IEnumerator PlayClaimPopLoop()
	{
		return null;
	}

	private void SetClaimInteractable(bool isInteractable)
	{
	}
}
