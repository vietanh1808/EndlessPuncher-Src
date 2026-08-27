using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FOW;
using TMPro;
using UnityEngine;

public class TalentSlot : MonoBehaviour
{
	private enum FogRevealState
	{
		Unavailable = 0,
		Available = 1,
		Purchased = 2
	}

	public enum PurchaseProgressDestination
	{
		front = 0,
		left = 1,
		right = 2
	}

	[Serializable]
	public class PurchaseProgressDestinationSetter
	{
		public PurchaseProgressDestination destination;

		public Transform targetDestination;
	}

	[Serializable]
	private class FogRevealStateSettings
	{
		public float radius;

		public float softenDistance;
	}

	[Serializable]
	public class SloteConnectPoints
	{
		public connectionTypeWhere nameType;

		public Transform pointConnect;

		public Transform checkNextPoint;

		public List<Transform> targetConnectedSlote;

		public Collider sloteCollider;

		public bool isConnected;

		[NonSerialized]
		public Renderer[] cachedRenderers;

		[NonSerialized]
		public bool hasCurrentColor;

		[NonSerialized]
		public Color currentColor;
	}

	[Serializable]
	public class SloteShapeType
	{
		public int id;

		public GameObject sloteObje;

		public Renderer sloteRender;

		public Renderer sloteRenderClone;

		public Renderer sloteRenderPurchasable;

		public Transform sloteScale;

		public Color selectableColor;

		public Material selected;

		public Material selectable;

		public Material notSelectable;

		public void CheckMaterials(bool isPurchased, bool isReadyForPurchase, bool isAnimBreat = true)
		{
		}
	}

	[Serializable]
	public class IconTypeAndObje
	{
		public GameObject obje;

		public TalentType type;
	}

	[CompilerGenerated]
	private sealed class _003CAnimateFogRevealSettings_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

		public float targetRadius;

		public float targetSoftenDistance;

		private float _003CstartRadius_003E5__2;

		private float _003CstartSoftenDistance_003E5__3;

		private float _003Cspeed_003E5__4;

		private float _003Ct_003E5__5;

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
		public _003CAnimateFogRevealSettings_003Ed__150(int _003C_003E1__state)
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
	private sealed class _003CCheckConnectionsMaterials_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

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
		public _003CCheckConnectionsMaterials_003Ed__84(int _003C_003E1__state)
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
	private sealed class _003CDelayedGlobalPowerRefresh_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CDelayedGlobalPowerRefresh_003Ed__114(int _003C_003E1__state)
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
	private sealed class _003CPopModel_003Ed__124 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

		private Transform _003Cslt_003E5__2;

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
		public _003CPopModel_003Ed__124(int _003C_003E1__state)
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
	private sealed class _003CPurchaseFeedbackRoutine_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

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
		public _003CPurchaseFeedbackRoutine_003Ed__122(int _003C_003E1__state)
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
	private sealed class _003CReSetSloteSelected_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

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
		public _003CReSetSloteSelected_003Ed__133(int _003C_003E1__state)
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
	private sealed class _003CRestoreReadyMaterialAfterBreathStop_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

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
		public _003CRestoreReadyMaterialAfterBreathStop_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CSetSloteSelected_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

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
		public _003CSetSloteSelected_003Ed__131(int _003C_003E1__state)
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
	private sealed class _003CshowBigEyeWithLerp_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

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
		public _003CshowBigEyeWithLerp_003Ed__58(int _003C_003E1__state)
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
	private sealed class _003CshowEyeWithLerp_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int orderPurhcases;

		public TalentSlot _003C_003E4__this;

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
		public _003CshowEyeWithLerp_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CshowNormalEyeWithLerp_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlot _003C_003E4__this;

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
		public _003CshowNormalEyeWithLerp_003Ed__59(int _003C_003E1__state)
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

	private const string RangeConversionKeyPrefix = "PermanentRangeTalentConversion_";

	private const int MaxRepeatableStatTalentLevel = 3;

	private const int SinglePurchaseConnectionThreshold = 3;

	private const CurrencyTypes PurchaseCurrencyType = CurrencyTypes.Gem;

	private const float MaterialRefreshAfterBreathStopDelay = 0.1f;

	private const float GlobalPowerRefreshDelayAfterPurchase = 1f;

	private static Coroutine delayedGlobalPowerRefreshCoroutine;

	private static TalentSlot delayedGlobalPowerRefreshOwner;

	public List<PurchaseProgressDestinationSetter> listdestinations;

	private InGameUI gameUI;

	private Animator anim;

	private bool isPurchased;

	private bool isReadyForPurchase;

	private bool _isSubscribedToPurchaseAction;

	private bool _isSubscribedToCurrencyAction;

	private Coroutine restoreReadyMaterialRoutine;

	private Coroutine connectionMaterialsRoutine;

	public FogOfWarRevealer3D fogOfWarRevealer;

	[Header("Fog Reveal Settings")]
	[SerializeField]
	private FogRevealStateSettings unavailableFogSettings;

	[SerializeField]
	private FogRevealStateSettings availableFogSettings;

	[SerializeField]
	private FogRevealStateSettings purchasedFogSettings;

	[SerializeField]
	private float fogTransitionSpeed;

	public LayerMask layerConnections;

	public LayerMask maskSlote;

	public Color roadMatActiveColor;

	public Color roadMatDeactiveColor;

	[SerializeField]
	private GameObject purchaseProgressPanel;

	[SerializeField]
	private TextMeshProUGUI purchaseProgressText;

	[SerializeField]
	private GameObject shineObje;

	private GameObject objeNod;

	private Vector3 nodLocalScale;

	private bool hasNodeBaseScale;

	public List<SloteConnectPoints> sloteConnectPoints;

	private int _id;

	private TalentType typeTalent;

	private bool miniEyeWasOpened;

	private bool _isFirstOpen;

	private bool _isOpenedBigEye;

	private bool elitItemShowActive;

	public ParticleSystem purhcasParticle;

	public AnimationCurve curvePop;

	private Coroutine corPurchaseFeedback;

	[SerializeField]
	private bool _isActiveSelected;

	public AnimationCurve curvePopScale;

	private Coroutine corSetSelected;

	public Material greenSelectedNod;

	private Coroutine corResetSelected;

	private SloteShapeType selectedShape;

	public List<SloteShapeType> allRaritySlotes;

	public List<IconTypeAndObje> talenticons;

	public GameObject talentIconParent;

	public GameObject talentHolder;

	private bool _isEyeForcedActive;

	private FogRevealState _currentFogState;

	private float _targetFogRadius;

	private float _targetFogSoftenDistance;

	private Coroutine _fogTransitionCoroutine;

	private bool _fogRevealActiveInitialized;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void SubscribeToPurchaseAction()
	{
	}

	private void UnsubscribeFromPurchaseAction()
	{
	}

	private void SubscribeToCurrencyChanges()
	{
	}

	private void UnsubscribeFromCurrencyChanges()
	{
	}

	public void SetIconObje()
	{
	}

	public Transform GetConnectablePoint(Transform pointTargets)
	{
		return null;
	}

	public void ConnectedWith(Transform pointConnect, Transform targetConnectedPoint)
	{
	}

	public int GetID()
	{
		return 0;
	}

	public TalentType GetTalentType()
	{
		return TalentType.none;
	}

	public TalentType GetEffectiveTalentType()
	{
		return TalentType.none;
	}

	private bool IsPermanentRangeCapped()
	{
		return false;
	}

	public void GiveThemID(int id, TalentDB.Talent tlnt)
	{
	}

	public void SetTalentTypeNewVersion(TalentType type, int orderPurhcases)
	{
	}

	[IteratorStateMachine(typeof(_003CshowEyeWithLerp_003Ed__57))]
	private IEnumerator showEyeWithLerp(int orderPurhcases)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CshowBigEyeWithLerp_003Ed__58))]
	private IEnumerator showBigEyeWithLerp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CshowNormalEyeWithLerp_003Ed__59))]
	private IEnumerator showNormalEyeWithLerp()
	{
		return null;
	}

	private void CheckSmallEyeOpener(int id)
	{
	}

	private TalentType GetTalent(int id)
	{
		return TalentType.none;
	}

	public int GetTalenRare()
	{
		return 0;
	}

	public int GetTalenRareForIcon()
	{
		return 0;
	}

	private int GetVisualRarityIndex(TalentType talentType)
	{
		return 0;
	}

	private void RefreshSelectedShape(TalentType talentType)
	{
	}

	public bool IsTypeChanged()
	{
		return false;
	}

	public void SetConnections()
	{
	}

	private Transform FindConnectedSlotFromMaskSlot(Vector3 position, Collider ownSlotCollider)
	{
		return null;
	}

	private bool HasMaskSlotConnectionAtPoint(Vector3 position, Collider ownSlotCollider)
	{
		return false;
	}

	private List<Transform> FindConnectedSlotsFromLayerConnections(Vector3 position)
	{
		return null;
	}

	private bool IsOwnSlotConnectionCollider(Collider connectionCollider)
	{
		return false;
	}

	public void CheckConnections()
	{
	}

	private void EnsureAnimator()
	{
	}

	private void QueueRestoreReadyMaterial()
	{
	}

	private void StopRestoreReadyMaterialRoutine()
	{
	}

	[IteratorStateMachine(typeof(_003CRestoreReadyMaterialAfterBreathStop_003Ed__79))]
	private IEnumerator RestoreReadyMaterialAfterBreathStop()
	{
		return null;
	}

	private bool HasPurchaseCurrencyForBreathing()
	{
		return false;
	}

	private void ApplyConnectionMaterialsImmediately()
	{
	}

	private bool isNeighboorIsPurchased()
	{
		return false;
	}

	private void CheckMaterials()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckConnectionsMaterials_003Ed__84))]
	private IEnumerator CheckConnectionsMaterials()
	{
		return null;
	}

	private void SetConnectionColor(SloteConnectPoints connectPoint, Color color)
	{
	}

	private Renderer[] GetConnectionRenderers(SloteConnectPoints connectPoint)
	{
		return null;
	}

	private void ApplyRendererColor(Renderer renderer, Color color)
	{
	}

	private static void ClearRendererColorOverride(Renderer renderer)
	{
	}

	private static void ApplyRendererMaterialInstance(Renderer renderer, Material material)
	{
	}

	private static void ApplyRendererColorOverride(Renderer renderer, Color color)
	{
	}

	private bool ShouldUsePurchasedRoadVisual(SloteConnectPoints connectPoint)
	{
		return false;
	}

	public bool CanSlotePurchasable()
	{
		return false;
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void OpenSloteDatas()
	{
	}

	public void CloseSloteDatas()
	{
	}

	public void PurchaseSlote()
	{
	}

	public bool IsRepeatableStatTalent()
	{
		return false;
	}

	public void RefreshPermanentRangeConversionVisuals()
	{
	}

	public bool IsSkillTalent()
	{
		return false;
	}

	public int GetCurrentTalentPurchaseCount()
	{
		return 0;
	}

	public int GetMaxTalentPurchaseCount()
	{
		return 0;
	}

	public bool IsTalentMaxed()
	{
		return false;
	}

	private int GetMaxRepeatableStatTalentPurchaseCount()
	{
		return 0;
	}

	private int GetDistinctConnectedNodeCount()
	{
		return 0;
	}

	private void RefreshPurchaseProgressDisplay()
	{
	}

	private void RefreshPurchaseProgressPanelPosition()
	{
	}

	private Transform GetPurchaseProgressTargetDestination()
	{
		return null;
	}

	private bool HasConnectedTarget(connectionTypeWhere connectionType)
	{
		return false;
	}

	private Transform GetPurchaseProgressDestination(PurchaseProgressDestination destination)
	{
		return null;
	}

	private void ApplyPurchasedTalentRewards(TalentType effectiveTalentType)
	{
	}

	private void QueueGlobalPowerRefresh()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedGlobalPowerRefresh_003Ed__114))]
	private IEnumerator DelayedGlobalPowerRefresh()
	{
		return null;
	}

	private void ShowTalentEarnedRewardIfNeeded()
	{
	}

	private bool TryGetTalentEarnedPrizeType(TalentType talentType, out PrizeTalentType prizeType)
	{
		prizeType = default;
		return false;
	}

	private bool TryGetSkillType(TalentType talentType, out SkillType skillType)
	{
		skillType = default;
		return false;
	}

	private bool TryGetPlayerStatType(TalentType talentType, out PlayerStatType playerStatType)
	{
		playerStatType = default;
		return false;
	}

	private void PlayPurchaseFeedback()
	{
	}

	[IteratorStateMachine(typeof(_003CPurchaseFeedbackRoutine_003Ed__122))]
	private IEnumerator PurchaseFeedbackRoutine()
	{
		return null;
	}

	private void PlayPurchaseParticle()
	{
	}

	[IteratorStateMachine(typeof(_003CPopModel_003Ed__124))]
	private IEnumerator PopModel()
	{
		return null;
	}

	private void ResetSelectionVisualImmediate()
	{
	}

	public void SelectSlote(bool isSelected)
	{
	}

	[IteratorStateMachine(typeof(_003CSetSloteSelected_003Ed__131))]
	private IEnumerator SetSloteSelected()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CReSetSloteSelected_003Ed__133))]
	private IEnumerator ReSetSloteSelected()
	{
		return null;
	}

	private void RestoreSlotVisualAfterSelection()
	{
	}

	private void RefreshEyeVisuals()
	{
	}

	private void RefreshShineVisual()
	{
	}

	private void RefreshEyeRadius()
	{
	}

	private FogRevealState GetFogRevealState()
	{
		return FogRevealState.Unavailable;
	}

	private TalentRarity GetCurrentTalentRarity()
	{
		return TalentRarity.Common;
	}

	private FogRevealStateSettings GetFogRevealSettings(FogRevealState state)
	{
		return null;
	}

	private void SetEyeActive(bool isActive)
	{
	}

	private void UpdateFogRevealVisuals()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateFogRevealSettings_003Ed__150))]
	private IEnumerator AnimateFogRevealSettings(float targetRadius, float targetSoftenDistance)
	{
		return null;
	}

	private bool ShouldKeepEyeActive()
	{
		return false;
	}

	private bool HasAlwaysVisibleEye()
	{
		return false;
	}

	private bool IsStarterSlot()
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
