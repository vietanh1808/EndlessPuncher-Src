using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StageInducator : MonoBehaviour
{
	private struct UnlockPresentation
	{
		public float ProgressRatio;

		public IEnumerator Routine;

		public UnlockPresentation(float progressRatio, IEnumerator routine)
		{
			ProgressRatio = 0f;
			Routine = null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateHighScoreMarkerRoutine_003Ed__123 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

		public float startProgress;

		public float targetProgress;

		private float _003Ct_003E5__2;

		private float _003Cduration_003E5__3;

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
		public _003CAnimateHighScoreMarkerRoutine_003Ed__123(int _003C_003E1__state)
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
	private sealed class _003CAnimateSlider_003Ed__230 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

		public float targetValue;

		private float _003CstartValue_003E5__2;

		private float _003Ct_003E5__3;

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
		public _003CAnimateSlider_003Ed__230(int _003C_003E1__state)
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
	private sealed class _003CAnimateUnlockMessage_003Ed__216 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CAnimateUnlockMessage_003Ed__216(int _003C_003E1__state)
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
	private sealed class _003CHideChainUnlockMarkerAfterFail_003Ed__222 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHideChainUnlockMarkerAfterFail_003Ed__222(int _003C_003E1__state)
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
	private sealed class _003CHideDungeonUnlockMarkerAfterFail_003Ed__219 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHideDungeonUnlockMarkerAfterFail_003Ed__219(int _003C_003E1__state)
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
	private sealed class _003CHideEventPassUnlockMarkerAfterFail_003Ed__221 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHideEventPassUnlockMarkerAfterFail_003Ed__221(int _003C_003E1__state)
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
	private sealed class _003CHideGiantUnlockMarkerAfterFail_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHideGiantUnlockMarkerAfterFail_003Ed__223(int _003C_003E1__state)
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
	private sealed class _003CHidePetEquipmentSlot2UnlockMarkerAfterFail_003Ed__224 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHidePetEquipmentSlot2UnlockMarkerAfterFail_003Ed__224(int _003C_003E1__state)
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
	private sealed class _003CHidePetEquipmentSlot3UnlockMarkerAfterFail_003Ed__225 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHidePetEquipmentSlot3UnlockMarkerAfterFail_003Ed__225(int _003C_003E1__state)
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
	private sealed class _003CHidePiggyUnlockMarkerAfterFail_003Ed__220 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHidePiggyUnlockMarkerAfterFail_003Ed__220(int _003C_003E1__state)
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
	private sealed class _003CHideSpeedUpUnlockMarkerAfterFail_003Ed__218 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHideSpeedUpUnlockMarkerAfterFail_003Ed__218(int _003C_003E1__state)
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
	private sealed class _003CHideTalentUnlockMarkerAfterFail_003Ed__217 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CHideTalentUnlockMarkerAfterFail_003Ed__217(int _003C_003E1__state)
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
	private sealed class _003CPanelComeDownRoutine_003Ed__238 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

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
		public _003CPanelComeDownRoutine_003Ed__238(int _003C_003E1__state)
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
	private sealed class _003CPlayUnlockPresentation_003Ed__226 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform marker;

		public ParticleSystem markerParticle;

		public Animator markerAnimator;

		public StageInducator _003C_003E4__this;

		public string message;

		public float messageDelay;

		public Action onComplete;

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
		public _003CPlayUnlockPresentation_003Ed__226(int _003C_003E1__state)
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
	private sealed class _003CPlayUnlockPresentationSequence_003Ed__228 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageInducator _003C_003E4__this;

		private List<UnlockPresentation> _003CunlockRoutines_003E5__2;

		private float _003CstartOffset_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CPlayUnlockPresentationSequence_003Ed__228(int _003C_003E1__state)
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

	public const string PetEquipmentSlot2UnlockSaveKey = "petEquipmentSlot2UnlockKey";

	public const string PetEquipmentSlot3UnlockSaveKey = "petEquipmentSlot3UnlockKey";

	private const int DefaultEventPassUnlockStage = 3;

	private static StageInducator _instance;

	[Header("UI")]
	[SerializeField]
	private GameObject rootPanel;

	[SerializeField]
	private Slider stageSlider;

	[SerializeField]
	private TextMeshProUGUI waveText;

	[SerializeField]
	private TextMeshProUGUI enemyCountText;

	[SerializeField]
	private Animator waveAnimator;

	[SerializeField]
	private Transform highScoreMarker;

	[SerializeField]
	private Animator highScoreAnimator;

	[SerializeField]
	private Transform progressPin;

	[SerializeField]
	private TextMeshProUGUI completeUnlockedText;

	[Header("Item Unlock")]
	[SerializeField]
	private Transform itemUnlockedMarker;

	[SerializeField]
	[Range(0f, 1f)]
	private float itemUnlockProgressRatio;

	[SerializeField]
	private int itemUnlockStage;

	[Header("Pet Unlock")]
	[SerializeField]
	private Transform petUnlockedMarker;

	[SerializeField]
	[Range(0f, 1f)]
	private float petUnlockProgressRatio;

	[SerializeField]
	private int petUnlockStage;

	[Header("Speed Up Unlock")]
	[SerializeField]
	private Transform speedUpUnlockedMarker;

	[SerializeField]
	private ParticleSystem speedUUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float speedUpUnlockProgressRatio;

	[SerializeField]
	private int SpeedupUnlockStage;

	[Header("The Ring Unlock")]
	[SerializeField]
	[Range(0f, 1f)]
	private float ringUnlockProgressRatio;

	[SerializeField]
	private Transform ringUnlockedMarker;

	[SerializeField]
	private ParticleSystem ringUnlockedMarkerParticle;

	[SerializeField]
	private int RingUnlockStage;

	[Header("The Collectibles Unlock")]
	[SerializeField]
	private Transform collectibleUnlockedMarker;

	[SerializeField]
	private ParticleSystem collectibleUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float collectibleUnlockProgressRatio;

	[SerializeField]
	private const int CollectibleUnlockMarkerStage = 4;

	[Header("Talent Unlock")]
	[SerializeField]
	private Transform talentUnlockedMarker;

	[SerializeField]
	private TextMeshProUGUI talentUnlockedText;

	[SerializeField]
	private ParticleSystem talentUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float talentUnlockProgressRatio;

	[SerializeField]
	private float talentUnlockProgressStage;

	[Header("Dungeon Unlock")]
	[SerializeField]
	private Transform dungeonUnlockedMarker;

	[SerializeField]
	private ParticleSystem dungeonUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float dungeonUnlockProgressRatio;

	[SerializeField]
	private float dungeonUnlockProgressStage;

	[Header("PiggyBank Unlock")]
	[SerializeField]
	private Transform piggyUnlockedMarker;

	[SerializeField]
	private ParticleSystem piggyUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float piggyUnlockProgressRatio;

	[SerializeField]
	private float piggyUnlockProgressStage;

	[Header("Event Unlock")]
	[SerializeField]
	private Transform eventPassUnlockedMarker;

	[SerializeField]
	private ParticleSystem eventPassUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float eventPassUnlockProgressRatio;

	[SerializeField]
	private float eventPassUnlockProgressStage;

	[Header("Chain Unlock")]
	[SerializeField]
	private Transform chainUnlockedMarker;

	[SerializeField]
	private ParticleSystem chainUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float chainUnlockProgressRatio;

	[SerializeField]
	private float chainUnlockProgressStage;

	[Header("Giant Unlock")]
	[SerializeField]
	private Transform giantUnlockedMarker;

	[SerializeField]
	private ParticleSystem giantUnlockedMarkerParticle;

	[SerializeField]
	[Range(0f, 1f)]
	private float giantUnlockProgressRatio;

	[SerializeField]
	private float giantUnlockProgressStage;

	[Header("PetEquipment Unlock")]
	[SerializeField]
	private Transform petEquipmenUnlockedMarker2;

	[SerializeField]
	private ParticleSystem petEquipmenUnlockedMarkerParticle2;

	[SerializeField]
	[Range(0f, 1f)]
	private float petEquipmenUnlockProgressRatio2;

	[SerializeField]
	private float petEquipmenUnlockProgressStage2;

	[SerializeField]
	private Transform petEquipmenUnlockedMarker3;

	[SerializeField]
	private ParticleSystem petEquipmenUnlockedMarkerParticle3;

	[SerializeField]
	[Range(0f, 1f)]
	private float petEquipmenUnlockProgressRatio3;

	[SerializeField]
	private float petEquipmenUnlockProgressStage3;

	[Header("Others ")]
	[SerializeField]
	private Canvas parentCanvas;

	[SerializeField]
	private int defaultSortingOrder;

	[SerializeField]
	private int failSortingOrder;

	private int _currentDisplayedStage;

	private int _totalKilledInRun;

	private Coroutine sliderRoutine;

	private Coroutine highScoreMarkerRoutine;

	private bool _isPanelUp;

	private Vector3 highScoreMarkerLocalPosition;

	private Vector3 talentUnlockedMarkerLocalPosition;

	private TextMeshProUGUI talentUnlockLabel;

	private Animator talentUnlockMarkerAnimator;

	private Animator speedUpUnlockMarkerAnimator;

	private Animator dungeonUnlockMarkerAnimator;

	private Animator piggyUnlockMarkerAnimator;

	private Animator eventPassUnlockMarkerAnimator;

	private Animator chainUnlockMarkerAnimator;

	private Animator giantUnlockMarkerAnimator;

	private Animator petEquipmentUnlockMarkerAnimator2;

	private Animator petEquipmentUnlockMarkerAnimator3;

	[SerializeField]
	private float failHighScoreMarkerDuration;

	[SerializeField]
	private float panelComeDownDelay;

	[SerializeField]
	private float panelComeDownAnimatorSpeed;

	[SerializeField]
	private float panelComeDownAnimatorResetDelay;

	[SerializeField]
	private float unlockPresentationStartOffset;

	private Coroutine panelComeDownRoutine;

	private Coroutine talentUnlockMarkerHideRoutine;

	private Coroutine speedUpUnlockMarkerHideRoutine;

	private Coroutine dungeonUnlockMarkerHideRoutine;

	private Coroutine piggyUnlockMarkerHideRoutine;

	private Coroutine eventPassUnlockMarkerHideRoutine;

	private Coroutine chainUnlockMarkerHideRoutine;

	private Coroutine giantUnlockMarkerHideRoutine;

	private Coroutine petEquipmentUnlockMarkerHideRoutine2;

	private Coroutine petEquipmentUnlockMarkerHideRoutine3;

	private Coroutine unlockSequenceRoutine;

	private bool keepTalentUnlockMarkerVisibleUntilFail;

	private bool keepSpeedUpUnlockMarkerVisibleUntilFail;

	private bool keepDungeonUnlockMarkerVisibleUntilFail;

	private bool keepPiggyUnlockMarkerVisibleUntilFail;

	private bool keepEventPassUnlockMarkerVisibleUntilFail;

	private bool keepChainUnlockMarkerVisibleUntilFail;

	private bool keepGiantUnlockMarkerVisibleUntilFail;

	private bool keepPetEquipmentSlot2UnlockMarkerVisibleUntilFail;

	private bool keepPetEquipmentSlot3UnlockMarkerVisibleUntilFail;

	private static readonly int PopHash;

	private static readonly int FailComeHash;

	private static readonly int FailGoHash;

	public Animator anim;

	public static StageInducator instance => null;

	public void RefreshCompleteUnlockedText(int completedStage)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetStageSliderVisible(bool isVisible)
	{
	}

	public void ResetForNewRun()
	{
	}

	public void ReportEndOfRun(int deadEnemyCount, int currentStage)
	{
	}

	public void PlayFailState(int deadEnemyCount, int currentStage)
	{
	}

	private void UpdateHighScoreMarkerVisual(float normalizedScore)
	{
	}

	private float GetRunProgress(int deadEnemyCount, int currentStage)
	{
		return 0f;
	}

	private float UpdateSavedHighScore(float currentProgress, bool updateVisual = true)
	{
		return 0f;
	}

	private void AnimateHighScoreMarker(float startProgress, float targetProgress)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateHighScoreMarkerRoutine_003Ed__123))]
	private IEnumerator AnimateHighScoreMarkerRoutine(float startProgress, float targetProgress)
	{
		return null;
	}

	private void SetCanvasSortingOrder(int sortingOrder)
	{
	}

	public void IncrementTotalKills()
	{
	}

	public void StageInducatorHandler(int deadEnemyCount, int currentStage)
	{
	}

	private void RefreshForCurrentState(int deadEnemyCount, int currentStage)
	{
	}

	private void UpdateItemUnlockedMarker(int currentStage)
	{
	}

	private void UpdatePetUnlockedMarker(int currentStage)
	{
	}

	public int GetItemUnlockStage()
	{
		return 0;
	}

	public int GetPetUnlockStage()
	{
		return 0;
	}

	public int GetSpeedUpUnlockStage()
	{
		return 0;
	}

	public int GetTalentUnlockStage()
	{
		return 0;
	}

	public int GetDungeonUnlockStage()
	{
		return 0;
	}

	public int GetGiantUnlockStage()
	{
		return 0;
	}

	public int GetEventPassUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredItemUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredPetUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredSpeedUpUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredTalentUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredDungeonUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredGiantUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredEventPassUnlockStage()
	{
		return 0;
	}

	public static bool EnsureSpeedUpUnlockedByChapter()
	{
		return false;
	}

	public static bool EnsureTalentUnlockedByChapter()
	{
		return false;
	}

	public static bool EnsureDungeonUnlockedByChapter()
	{
		return false;
	}

	public static bool EnsureGiantUnlockedByChapter()
	{
		return false;
	}

	private void UpdateUnlockMarkerPosition(Transform marker, float progressRatio)
	{
	}

	private void UpdateRingUnlockedMarker(int currentStage, bool isBossWave)
	{
	}

	private void UpdateCollectibleUnlockedMarker(int currentStage, bool isBossWave)
	{
	}

	private int GetDisplayedEnemyCount(WaveDB waveDb, int chapter, int currentStage, bool isBossWave)
	{
		return 0;
	}

	private void UpdateWaveText()
	{
	}

	private void UpdateEnemyCount(int deadEnemyCount, int currentWaveEnemyCount)
	{
	}

	private void UpdateStageSlider(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void UpdateHighScoreMarker(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void UpdateTalentUnlockMarker()
	{
	}

	private void UpdateSpeedUpUnlockMarker()
	{
	}

	private void UpdateDungeonUnlockMarker()
	{
	}

	private void UpdatePiggyUnlockMarker(int currentStage, bool isBossWave)
	{
	}

	private void UpdateEventPassUnlockMarker(int currentStage, bool isBossWave)
	{
	}

	private void UpdateChainUnlockMarker(int currentStage, bool isBossWave)
	{
	}

	private void UpdateGiantUnlockMarker(int currentStage, bool isBossWave)
	{
	}

	private void UpdatePetEquipmentUnlockMarker2(int currentStage, bool isBossWave)
	{
	}

	private void UpdatePetEquipmentUnlockMarker3(int currentStage, bool isBossWave)
	{
	}

	private void UpdatePetEquipmentUnlockMarkers(bool isBossWave)
	{
	}

	private bool ShouldShowPetEquipmentUnlockMarker(float progressStage, string unlockKey, bool keepVisibleUntilFail, bool isBossWave)
	{
		return false;
	}

	private void UpdatePetEquipmentUnlockMarker(Transform marker, float progressRatio, bool shouldShow)
	{
	}

	private void QueueUnlocksFromProgress(float currentProgress)
	{
	}

	private void QueueUnlocksForCompletedStage(int completedStage)
	{
	}

	private void CommitDeferredUnlocks()
	{
	}

	private void ClearDeferredUnlockPresentationFlags()
	{
	}

	private void QueueSpeedUpUnlock()
	{
	}

	private void QueueTalentMenuUnlock()
	{
	}

	private void QueueDungeonUnlock()
	{
	}

	private void QueuePiggyBankUnlock()
	{
	}

	private void QueueEventPassUnlock()
	{
	}

	private void QueueChainOfferUnlock()
	{
	}

	private void QueueGiantUnlock()
	{
	}

	private void QueuePetEquipmentSlotUnlock(int slotIndex)
	{
	}

	private void CommitPetEquipmentSlotUnlock(int slotIndex)
	{
	}

	private void TryUnlockSpeedUp(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void UnlockSpeedUp()
	{
	}

	private void TryUnlockDungeon(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void UnlockDungeon()
	{
	}

	private void TryUnlockPiggyBank(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void TryUnlockPiggyBankFromProgress(float currentProgress)
	{
	}

	private void UnlockPiggyBank()
	{
	}

	private bool IsCurrentPiggyUnlockStage()
	{
		return false;
	}

	public int GetPiggyUnlockStage()
	{
		return 0;
	}

	public static int GetConfiguredPiggyUnlockStage()
	{
		return 0;
	}

	private void TryUnlockEventPass(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void TryUnlockEventPassFromProgress(float currentProgress)
	{
	}

	private void UnlockEventPass()
	{
	}

	private bool IsCurrentEventPassUnlockStage()
	{
		return false;
	}

	private void TryUnlockChainOffer(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void TryUnlockChainOfferFromProgress(float currentProgress)
	{
	}

	private void UnlockChainOffer()
	{
	}

	private bool IsCurrentChainUnlockStage()
	{
		return false;
	}

	private void TryUnlockGiant(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void TryUnlockGiantFromProgress(float currentProgress)
	{
	}

	private void UnlockGiant()
	{
	}

	private bool IsCurrentGiantUnlockStage()
	{
		return false;
	}

	private void TryUnlockPetEquipmentSlot(int slotIndex, int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	private void TryUnlockPetEquipmentSlotFromProgress(int slotIndex, float currentProgress)
	{
	}

	private float GetPetEquipmentSlotUnlockProgressRatio(int slotIndex)
	{
		return 0f;
	}

	private bool IsCurrentPetEquipmentSlotUnlockStage(int slotIndex)
	{
		return false;
	}

	public static bool IsPetEquipmentSlotUnlocked(int slotIndex)
	{
		return false;
	}

	private static int GetConfiguredPetEquipmentSlotUnlockStage(int slotIndex)
	{
		return 0;
	}

	private string GetPetEquipmentSlotUnlockKey(int slotIndex)
	{
		return null;
	}

	private static string GetPetEquipmentSlotUnlockKeyStatic(int slotIndex)
	{
		return null;
	}

	private void TryUnlockTalentMenu(int deadEnemyCount, int currentStage, int currentWaveEnemyCount, int totalRegularWaveCount, bool isBossWave)
	{
	}

	public void UnlockTalentMenuFromThreshold()
	{
	}

	private void UnlockTalentMenu()
	{
	}

	private void HideUnlockMessage()
	{
	}

	private void ShowUnlockMessage(string message)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateUnlockMessage_003Ed__216))]
	private IEnumerator AnimateUnlockMessage()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideTalentUnlockMarkerAfterFail_003Ed__217))]
	private IEnumerator HideTalentUnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideSpeedUpUnlockMarkerAfterFail_003Ed__218))]
	private IEnumerator HideSpeedUpUnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideDungeonUnlockMarkerAfterFail_003Ed__219))]
	private IEnumerator HideDungeonUnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHidePiggyUnlockMarkerAfterFail_003Ed__220))]
	private IEnumerator HidePiggyUnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideEventPassUnlockMarkerAfterFail_003Ed__221))]
	private IEnumerator HideEventPassUnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideChainUnlockMarkerAfterFail_003Ed__222))]
	private IEnumerator HideChainUnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideGiantUnlockMarkerAfterFail_003Ed__223))]
	private IEnumerator HideGiantUnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHidePetEquipmentSlot2UnlockMarkerAfterFail_003Ed__224))]
	private IEnumerator HidePetEquipmentSlot2UnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHidePetEquipmentSlot3UnlockMarkerAfterFail_003Ed__225))]
	private IEnumerator HidePetEquipmentSlot3UnlockMarkerAfterFail()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayUnlockPresentation_003Ed__226))]
	private IEnumerator PlayUnlockPresentation(Transform marker, Animator markerAnimator, ParticleSystem markerParticle, string message, Action onComplete, bool hideFirstChildBeforeMessage = false, float messageDelay = 0f)
	{
		return null;
	}

	private void StartUnlockPresentationSequence()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayUnlockPresentationSequence_003Ed__228))]
	private IEnumerator PlayUnlockPresentationSequence()
	{
		return null;
	}

	private void StopUnlockPresentationRoutines()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateSlider_003Ed__230))]
	private IEnumerator AnimateSlider(float targetValue)
	{
		return null;
	}

	public void StageStartPop(int stageValue)
	{
	}

	public void PanelGoUp()
	{
	}

	public void PanelComeDown()
	{
	}

	[IteratorStateMachine(typeof(_003CPanelComeDownRoutine_003Ed__238))]
	private IEnumerator PanelComeDownRoutine()
	{
		return null;
	}

	public void BossArrived()
	{
	}

	public void BossReset()
	{
	}
}
