using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatSkillUIControl : MonoBehaviour
{
	[Serializable]
	public class SkillUIBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CReverseStarter_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public SkillUIBehaviour _003C_003E4__this;

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
			public _003CReverseStarter_003Ed__33(int _003C_003E1__state)
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

		public int id;

		public Animator animSkill;

		public GameObject lockObje;

		public SkillType typeSkill;

		public Image icon;

		public GameObject[] effectIcons;

		public Image fillIcon;

		public Image reverseFillIcon;

		public GameObject outline;

		public TextMeshProUGUI textLevel;

		public TextMeshProUGUI cdText;

		public TextMeshProUGUI unlockText;

		public ParticleSystem unlockedParticle;

		private float durationIngame;

		private float _duration;

		private bool _isOnCooldown;

		private bool _isPendingActivation;

		[HideInInspector]
		public bool isSelected;

		private bool _isSkillUsable;

		[HideInInspector]
		public bool IsSkillUsable => false;

		public bool IsReadyToAutoUse => false;

		public void StartSlote()
		{
		}

		public void ShowPendingUnlockState()
		{
		}

		public void CompletePendingUnlockState()
		{
		}

		public void StartSkill(StatDB.Skill skill)
		{
		}

		private void RefreshCooldownProgress(float oldDurationIngame)
		{
		}

		public bool SetDuration(float deltaTime)
		{
			return false;
		}

		private void SkillUsable()
		{
		}

		public void BeginAutoActivation()
		{
		}

		public void SkillUsed()
		{
		}

		public void ReverseFillStart(MonoBehaviour mb, float time)
		{
		}

		[IteratorStateMachine(typeof(_003CReverseStarter_003Ed__33))]
		private IEnumerator ReverseStarter(float time)
		{
			return null;
		}

		public void SlotUnlocked()
		{
		}

		public void ResetForNewRun()
		{
		}
	}

	[Serializable]
	public class StatSlotBehaviour
	{
		public PlayerStatType typeStat;

		public TextMeshProUGUI statText;

		public string statBeginValue;

		public string statEndValue;

		public ParticleSystem ps;

		public void Upgrade(float valueStat)
		{
		}

		private string FormatStatValue(float valueStat)
		{
			return null;
		}

		private string FormatDamageValue(float valueStat)
		{
			return null;
		}

		private bool ShouldShowDecimal()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public SkillUIBehaviour slot;

		public bool impactHappened;

		internal void _003CPlayPendingSkillSlotUnlock_003Eb__1()
		{
		}

		internal bool _003CPlayPendingSkillSlotUnlock_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlayPendingSkillSlotUnlock_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStatSkillUIControl _003C_003E4__this;

		public int slotIndex;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

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
		public _003CPlayPendingSkillSlotUnlock_003Ed__11(int _003C_003E1__state)
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
	private sealed class _003CStartLevelRefixPosition_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStatSkillUIControl _003C_003E4__this;

		private Vector3 _003CstrtPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

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
		public _003CStartLevelRefixPosition_003Ed__43(int _003C_003E1__state)
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

	private const float SkillAutoActivationRangeRatio = 1.1f;

	private static PlayerStatSkillUIControl _instance;

	public GameObject panelObje;

	public GameObject hideShowButton;

	public List<SkillUIBehaviour> allSkillUi;

	public List<StatSlotBehaviour> allStatSlotes;

	private bool _isGameStopped;

	private bool _isShowingPanel;

	public GameObject[] showObjects;

	public GameObject showIcon;

	public GameObject hideIcon;

	public GameObject miniquestPanel;

	private Vector3 _resetPosition;

	public static PlayerStatSkillUIControl Instance => null;

	private void Awake()
	{
	}

	public void StartReverseFill(SkillType typeSkill, float time)
	{
	}

	public void GetSelectedSkills()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayPendingSkillSlotUnlock_003Ed__11))]
	public IEnumerator PlayPendingSkillSlotUnlock(int slotIndex)
	{
		return null;
	}

	private bool IsDungeonScene()
	{
		return false;
	}

	public void StartSkills()
	{
	}

	public void AutoUseReadySkills()
	{
	}

	private bool HasEnemyForSkillAutoActivation()
	{
		return false;
	}

	public void SkillUsed(SkillType typeSkill)
	{
	}

	private void ActivateSkill(SkillType type)
	{
	}

	public void ShowInfo(int id)
	{
	}

	public void SetStatValue(PlayerStatType typeStat)
	{
	}

	public void RefreshAllStatValues()
	{
	}

	private void Start()
	{
	}

	private void DelayStart()
	{
	}

	private void CheckIsGameStopped()
	{
	}

	private bool CanStart()
	{
		return false;
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void RefreshMenuVisibility()
	{
	}

	public void SetPanelRootVisible(bool isVisible)
	{
	}

	private void SetExpandedContentVisible(bool isVisible)
	{
	}

	public void ShowHideSetter()
	{
	}

	private void RefreshMiniQuestPanelVisibility(bool isPanelRootVisible)
	{
	}

	public void ResetForNewRun()
	{
	}

	public void LevelStartedForSkillUI()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLevelRefixPosition_003Ed__43))]
	private IEnumerator StartLevelRefixPosition()
	{
		return null;
	}
}
