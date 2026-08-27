using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TalentTreeCreator : MonoBehaviour, ITabPanel
{
	[Serializable]
	public class OtherTalentTrees
	{
		public string nameRank;

		public GameObject rankObject;

		public TalentSlot startNod;

		public List<TalentSlot> rankSlots;

		public List<TalentSlot> rankSlotsStart;

		public List<TalentSlot> rankSlotsEnd;

		public List<TalentSlot> rankSlotsAll;

		public Animator animRankText;
	}

	[Serializable]
	public class TalentRarityWeight
	{
		public TalentRarity rarity;

		public int weight;
	}

	private class TraversalLayoutData
	{
		public readonly List<TalentSlot> order;

		public readonly Dictionary<TalentSlot, TalentSlot> parentBySlot;
	}

	private struct BranchProgressState
	{
		public bool hasSeenSpecial;

		public int statsSinceLastSpecial;

		public static BranchProgressState Initial()
		{
			return default;
		}

		public static BranchProgressState AfterSpecial()
		{
			return default;
		}

		public BranchProgressState WithAddedStat()
		{
			return default;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimateReturnButtonScale_003Ed__164 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentTreeCreator _003C_003E4__this;

		public bool show;

		private Transform _003CbuttonTransform_003E5__2;

		private Vector3 _003CstartScale_003E5__3;

		private Vector3 _003CendScale_003E5__4;

		private float _003Cduration_003E5__5;

		private float _003Ct_003E5__6;

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
		public _003CAnimateReturnButtonScale_003Ed__164(int _003C_003E1__state)
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
	private sealed class _003CApplyInitialRankTreeStateDelayed_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentTreeCreator _003C_003E4__this;

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
		public _003CApplyInitialRankTreeStateDelayed_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CFocusCameraPreviewRoutine_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentTreeCreator _003C_003E4__this;

		public Vector3 previewPosition;

		public Vector3 returnPosition;

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
		public _003CFocusCameraPreviewRoutine_003Ed__136(int _003C_003E1__state)
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
	private sealed class _003CFocusCameraRoutine_003Ed__135 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentTreeCreator _003C_003E4__this;

		public Vector3 targetPosition;

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
		public _003CFocusCameraRoutine_003Ed__135(int _003C_003E1__state)
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
	private sealed class _003CMoveCameraToPositionRoutine_003Ed__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentTreeCreator _003C_003E4__this;

		public Vector3 targetPosition;

		private Vector3 _003CstartPosition_003E5__2;

		private float _003Cduration_003E5__3;

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
		public _003CMoveCameraToPositionRoutine_003Ed__137(int _003C_003E1__state)
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
	private sealed class _003CPlayQueuedSkillPreviewAfterPrizeRoutine_003Ed__134 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentTreeCreator _003C_003E4__this;

		private TalentSlot _003CpreviewSlot_003E5__2;

		private TalentSlot _003CreturnSlot_003E5__3;

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
		public _003CPlayQueuedSkillPreviewAfterPrizeRoutine_003Ed__134(int _003C_003E1__state)
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

	private const string LastPurchasedTalentSlotIdKey = "LastPurchasedTalentSlotId";

	private const string LastFocusedTalentSlotIdKey = "LastFocusedTalentSlotId";

	private static TalentTreeCreator _instance;

	private InGameUI inGameUI;

	[Header("Tab Panel")]
	[SerializeField]
	private GameObject tabPanelObject;

	public GameObject camMove;

	public Action purhcaseAction;

	[Header("Settings")]
	public TalentSlot questTarget;

	public List<OtherTalentTrees> allRankTalentTrees;

	public Camera camera;

	public List<TalentSlot> allSloteInScene;

	public LayerMask maskGround;

	public LayerMask maskSlote;

	[Header("Rarity Distribution")]
	[SerializeField]
	private TalentRarityWeight[] rarityWeights;

	[Header("Talent Path Layout")]
	[SerializeField]
	private int firstSkillStatCount;

	[SerializeField]
	private int openingStatCountBeforeFirstSpecial;

	[SerializeField]
	private int repeatedSkillStatCount;

	[SerializeField]
	private int firstSpecialCount;

	[SerializeField]
	private int repeatedSpecialCount;

	[SerializeField]
	private List<TalentType> specialTalentPlacementOrder;

	[Header("Camera Bounds")]
	[SerializeField]
	private float cameraBottomPadding;

	[SerializeField]
	private float cameraTopPadding;

	[SerializeField]
	private float cameraHorizontalPadding;

	[SerializeField]
	private float rankCameraBackwardLimit;

	[SerializeField]
	private float rankCameraForwardLimit;

	[Header("Camera Focus")]
	[SerializeField]
	private float cameraFocusDuration;

	[SerializeField]
	private float skillSlotPreviewReturnDelay;

	[SerializeField]
	private float skillPrizePreviewStartDelay;

	[SerializeField]
	private float skillPrizePreviewHoldDelay;

	[SerializeField]
	private float postSkillSlotPreviewDelay;

	[SerializeField]
	private Vector2 cameraFocusOffset;

	[SerializeField]
	private float cameraFocusZOffset;

	[SerializeField]
	private float slotLevelTolerance;

	[SerializeField]
	private AnimationCurve cameraFocusEaseCurve;

	[SerializeField]
	private float cameraDragSmoothTime;

	[SerializeField]
	private float cameraDragMaxSpeed;

	[SerializeField]
	private float cameraDragResponseMultiplier;

	[SerializeField]
	private float cameraDragThresholdPixels;

	[Header("Return Button")]
	[SerializeField]
	private GameObject returnToLastPurchasedButton;

	[SerializeField]
	private float returnButtonShowDistance;

	[SerializeField]
	private float returnButtonScaleDuration;

	[SerializeField]
	private AnimationCurve returnButtonScaleCurve;

	private int currentReachedRankIndex;

	private const string RankTextPopTrigger = "pop";

	private bool inputLocked;

	private int counterValueOrder;

	private int clickedCounter;

	private SloteHandler sloteHandler;

	private bool isMovingAround;

	private float timeTravel;

	private Vector3 startFirst;

	private Vector3 cameraPointerDownPosition;

	private Vector3 desiredCameraPosition;

	private Vector3 pointerDownScreenPosition;

	private Vector3 pointerDownGroundPosition;

	private bool hasPointerDownGroundPosition;

	private TalentSlot oldSlote;

	private Transform slote;

	private bool _isSloteDataOpened;

	private Coroutine cameraFocusCoroutine;

	private TalentSlot lastFocusedSlot;

	private TalentSlot pendingSkillPreviewSlot;

	private TalentSlot pendingSkillPreviewReturnSlot;

	private float lastCameraInteractionTime;

	private bool autoReturnedToLastFocusedSlot;

	private Vector3 cameraDragVelocity;

	private Vector3 cameraDragTargetPosition;

	private bool wasTalentMenuRuntimeActive;

	private bool hasPendingCameraSavePosition;

	private Vector3 pendingCameraSavePosition;

	[HideInInspector]
	public float minBackDistancePos;

	[HideInInspector]
	public float maxFrontDistancePos;

	[HideInInspector]
	public float minXPosDistance;

	[HideInInspector]
	public float maxXPosDistance;

	private Coroutine returnButtonScaleCoroutine;

	private bool isReturnButtonVisible;

	public static TalentTreeCreator Instance => null;

	private void Awake()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private GameObject GetTabPanelObject()
	{
		return null;
	}

	private void Start()
	{
	}

	private void EnsureCameraCurves()
	{
	}

	[IteratorStateMachine(typeof(_003CApplyInitialRankTreeStateDelayed_003Ed__54))]
	private IEnumerator ApplyInitialRankTreeStateDelayed()
	{
		return null;
	}

	private bool TryGetTalentsForScene(out List<TalentDB.Talent> talents)
	{
		talents = null;
		return false;
	}

	private void AlignmentSlotes()
	{
	}

	private List<TalentDB.Talent> BuildProgressiveTalentLayout(TalentDB talentDb)
	{
		return null;
	}

	private Dictionary<TalentSlot, TalentDB.Talent> BuildSpecialTalentAssignments(List<TalentDB.Talent> specialTalents)
	{
		return null;
	}

	private bool IsCommonTalent(TalentType type)
	{
		return false;
	}

	private bool IsEarlySkillTalent(TalentType type)
	{
		return false;
	}

	private bool IsLateSkillTalent(TalentType type)
	{
		return false;
	}

	private bool CanPlaceSpecialOnBranch(BranchProgressState branchState)
	{
		return false;
	}

	private BranchProgressState GetParentBranchState(TalentSlot slot, Dictionary<TalentSlot, TalentSlot> parentBySlot, Dictionary<TalentSlot, BranchProgressState> branchStates)
	{
		return default;
	}

	private TraversalLayoutData BuildSlotTraversalData()
	{
		return null;
	}

	private Dictionary<TalentSlot, List<TalentSlot>> BuildSlotGraph(List<TalentSlot> validSlots)
	{
		return null;
	}

	private TalentSlot FindConnectedSlotForTraversal(TalentSlot sourceSlot, Vector3 probePosition)
	{
		return null;
	}

	private void AddGraphConnection(Dictionary<TalentSlot, List<TalentSlot>> graph, TalentSlot from, TalentSlot to)
	{
	}

	private void SortSlotsByProgress(List<TalentSlot> slots)
	{
	}

	private List<TalentDB.Talent> BuildSpecialTalentSequence(TalentDB talentDb)
	{
		return null;
	}

	private TalentDB.Talent GetSpecificTalent(List<TalentDB.Talent> statTalents, TalentDB talentDb, TalentType targetType)
	{
		return null;
	}

	private List<TalentType> GetResolvedSpecialTalentOrder()
	{
		return null;
	}

	private TalentDB.Talent GetRandomStatTalent(List<TalentDB.Talent> statTalents, TalentDB talentDb, TalentType excludedType)
	{
		return null;
	}

	private TalentDB.Talent GetWeightedRandomStatTalent(List<TalentDB.Talent> statTalents)
	{
		return null;
	}

	private int GetStatTalentWeight(TalentDB.Talent talent)
	{
		return 0;
	}

	public void GetClotestNotPurchasedTalentSloteAndChangeItWithType(TalentType typeTalent)
	{
	}

	public void SlotePurchased(TalentSlot purchasedSlot = null)
	{
	}

	public void RefreshPermanentRangeTalentConversions()
	{
	}

	private bool HasReachedRankChanged()
	{
		return false;
	}

	private void UpdateRankTreeState(bool playRankAnimation)
	{
	}

	private int GetReachedRankIndex()
	{
		return 0;
	}

	public int GetCurrentReachedRankIndex()
	{
		return 0;
	}

	public int GetCurrentReachedRankQuestOrder()
	{
		return 0;
	}

	public string GetRankNameForQuestOrder(int rankQuestOrder)
	{
		return null;
	}

	private void SyncReachRankQuestProgress()
	{
	}

	private void QueueRankLeaguePrize(int previousRankIndex, int nextRankIndex)
	{
	}

	private void InitializeRankRewardCount()
	{
	}

	private string GetRankName(int rankIndex)
	{
		return null;
	}

	private void PlayRankReachedAnimation(int rankIndex)
	{
	}

	private Transform GetCurrentRankAnchorTransform()
	{
		return null;
	}

	private bool IsAnyRankSlotUnlocked(OtherTalentTrees rankTree)
	{
		return false;
	}

	private void ClampCameraToCurrentBounds()
	{
	}

	public TalentSlot GetFirstPurchasableSlot()
	{
		return null;
	}

	private void Update()
	{
	}

	private bool IsTalentMenuRuntimeActive()
	{
		return false;
	}

	private void HandleTalentMenuBecameActive()
	{
	}

	private void HandleTalentMenuBecameInactive()
	{
	}

	private void PurchaseSystemInput()
	{
	}

	public void SetInputLocked(bool isLocked)
	{
	}

	private void UpdateCameraMotion()
	{
	}

	private bool HasExceededDragThreshold()
	{
		return false;
	}

	private bool TryGetGroundPoint(Vector3 screenPosition, out Vector3 groundPoint)
	{
		groundPoint = default;
		return false;
	}

	private void FocusCameraOnSlot(TalentSlot targetSlot, bool isAutoFocus)
	{
	}

	private void PreviewCameraOnSlotThenReturn(TalentSlot previewSlot, TalentSlot returnSlot)
	{
	}

	public void QueueSkillPreviewAfterPrize(TalentSlot previewSlot, TalentSlot returnSlot)
	{
	}

	public void PlayQueuedSkillPreviewAfterPrize()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayQueuedSkillPreviewAfterPrizeRoutine_003Ed__134))]
	public IEnumerator PlayQueuedSkillPreviewAfterPrizeRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFocusCameraRoutine_003Ed__135))]
	private IEnumerator FocusCameraRoutine(Vector3 targetPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFocusCameraPreviewRoutine_003Ed__136))]
	private IEnumerator FocusCameraPreviewRoutine(Vector3 previewPosition, Vector3 returnPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveCameraToPositionRoutine_003Ed__137))]
	private IEnumerator MoveCameraToPositionRoutine(Vector3 targetPosition)
	{
		return null;
	}

	private void StopCameraFocus()
	{
	}

	private void RegisterCameraInteraction()
	{
	}

	private void SaveLastFocusedSlot()
	{
	}

	private TalentSlot GetSavedFocusedSlot()
	{
		return null;
	}

	private void SnapCameraToSavedFocusedSlot()
	{
	}

	private Vector3 GetClampedCameraPositionForSlot(TalentSlot targetSlot)
	{
		return default;
	}

	private Vector3 GetClampedCameraPosition(Vector3 targetPosition)
	{
		return default;
	}

	private void RestoreInitialFocusedSlot()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void RegisterPurchasedSlotFocus(TalentSlot purchasedSlot)
	{
	}

	private TalentSlot GetPostPurchaseFocusSlot(TalentSlot purchasedSlot)
	{
		return null;
	}

	private bool HasPurchasableSlotAtOrBelowLevel(TalentSlot referenceSlot)
	{
		return false;
	}

	private TalentSlot FindNearestPurchasableSlotAboveLevel(TalentSlot referenceSlot)
	{
		return null;
	}

	private TalentSlot FindNextSkillSlot(TalentSlot referenceSlot)
	{
		return null;
	}

	private bool IsSlotPurchasableForCameraProgression(TalentSlot slot)
	{
		return false;
	}

	private TalentSlot GetFirstRankSlot(OtherTalentTrees rankTree)
	{
		return null;
	}

	private TalentSlot GetFirstSlotFromList(List<TalentSlot> slots)
	{
		return null;
	}

	private bool HasAnySlot(List<TalentSlot> slots)
	{
		return false;
	}

	private void SetRankTreeVisible(OtherTalentTrees rankTree, bool isVisible)
	{
	}

	private void SetRankSlotsActive(List<TalentSlot> slots, bool isActive)
	{
	}

	private void InitializeReturnButton()
	{
	}

	private void RefreshReturnButtonVisibility()
	{
	}

	public void ReturnToLastPurchasedSlot()
	{
	}

	private void SetReturnButtonVisible(bool isVisible, bool instant = false)
	{
	}

	private void SetReturnButtonVisibleImmediate(bool isVisible)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateReturnButtonScale_003Ed__164))]
	private IEnumerator AnimateReturnButtonScale(bool show)
	{
		return null;
	}

	private void RecalculateCameraBounds()
	{
	}

	private bool isPointerUI()
	{
		return false;
	}
}
