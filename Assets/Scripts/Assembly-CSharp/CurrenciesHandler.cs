using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Helpers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrenciesHandler : MonoBehaviour
{
	[Serializable]
	public class Currency
	{
		public string name;

		public Vector3 iconScale;

		public CurrencyTypes type;

		public Action OnChanged;

		[SerializeField]
		private TMP_Text amountText;

		[SerializeField]
		private TMP_Text[] amountText2;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		[Tooltip("Assign this if you want to spawn 3D objects of this currency.")]
		private Rigidbody prefab;

		[SerializeField]
		private Transform iconTarget;

		private Pool<Rigidbody> spawnedObjs;

		private string lastDisplayedAmount;

		public float amount { get; private set; }

		public Vector3 GetTargetPos => default;

		public Sprite Icon => null;

		public void Init()
		{
		}

		public Rigidbody Get3DObj()
		{
			return null;
		}

		public void ResetSpawnedObjects()
		{
		}

		public void Update(float amount, bool playAnim = false, bool fromStart = false)
		{
		}

		private void RefreshAmountTexts()
		{
		}

		public void Save()
		{
		}

		private void Load()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public Action onIconArrived;

		public int activeIcons;

		public int emittedIcons;

		public int count;

		public bool allIconsFinished;

		internal void _003CSpawnPooled2DCurrencyVisualStreamRoutine_003Eb__0()
		{
		}

		internal bool _003CSpawnPooled2DCurrencyVisualStreamRoutine_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CChestMovement_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject chest;

		public Vector3 startPos;

		public CurrenciesHandler _003C_003E4__this;

		public Vector3 targetPos;

		private float _003Ct_003E5__2;

		private Vector3 _003ClocalPos_003E5__3;

		private Vector3 _003Ctarget_003E5__4;

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
		public _003CChestMovement_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CCurrencyMovement_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform curr3D;

		public CurrenciesHandler _003C_003E4__this;

		public Currency curr;

		public Vector3? startPos;

		public bool useTrail;

		public float scatterRadius;

		public float scatterDuration;

		public float scatterPause;

		public float movementSpeed;

		public Vector3 targetPos;

		public long amount;

		public bool canPlaySoung;

		public bool trackWorldCollection;

		public Action onComplete;

		private bool _003Cis3D_003E5__2;

		private Image _003Cicon_003E5__3;

		private TrailRenderer _003Ctrail_003E5__4;

		private float _003Ct_003E5__5;

		private Vector3 _003ClocalPos_003E5__6;

		private Vector3 _003Ctarget_003E5__7;

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
		public _003CCurrencyMovement_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CCurrencyMovementBall_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Rigidbody curr3D;

		public Transform targetPos;

		public CurrenciesHandler _003C_003E4__this;

		public float amount;

		private float _003Ct_003E5__2;

		private Vector3 _003ClocalPos_003E5__3;

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
		public _003CCurrencyMovementBall_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CCurrencyMovementToPlayer_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrenciesHandler _003C_003E4__this;

		public Rigidbody curr3D;

		public Transform targetPos;

		public Currency curr;

		public float amount;

		private int _003CresetVersion_003E5__2;

		private float _003Ct_003E5__3;

		private Vector3 _003ClocalPos_003E5__4;

		private Vector3 _003CbackPos_003E5__5;

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
		public _003CCurrencyMovementToPlayer_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CEnergyMovement_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CurrenciesHandler _003C_003E4__this;

		public Vector3 startPos;

		public bool useTrail;

		public Vector3 targetPos;

		public int amount;

		private Image _003Cicon_003E5__2;

		private TrailRenderer _003Ctrail_003E5__3;

		private float _003Ct_003E5__4;

		private Vector3 _003ClocalPos_003E5__5;

		private Vector3 _003Ctarget_003E5__6;

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
		public _003CEnergyMovement_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CSpawnPooled2DCurrencyVisualStreamRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action onIconArrived;

		public int count;

		public Action onComplete;

		public float emissionDuration;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		public CurrenciesHandler _003C_003E4__this;

		public CurrencyTypes type;

		public Vector3 sourcePosition;

		public Vector3 targetPosition;

		public bool isUI;

		public bool useTrail;

		public float scatterDuration;

		public float scatterRadius;

		public float scatterPause;

		public Action onIconEmitted;

		private Action _003ConIconComplete_003E5__2;

		private float _003Cinterval_003E5__3;

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
		public _003CSpawnPooled2DCurrencyVisualStreamRoutine_003Ed__41(int _003C_003E1__state)
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

	private static CurrenciesHandler Instance;

	[SerializeField]
	private Currency[] currencies;

	[SerializeField]
	private Image floatingIcon;

	[SerializeField]
	private Camera cam;

	[SerializeField]
	private Camera canvasCam;

	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private AnimationCurve outBack;

	[SerializeField]
	private AnimationCurve inSine;

	[SerializeField]
	private Vector3 min3DCurrencyExplosionForce;

	[SerializeField]
	private Vector3 max3DCurrencyExplosionForce;

	[Header("Energy Fly Visual")]
	[SerializeField]
	private Sprite energyIcon;

	[SerializeField]
	private Vector3 energyIconScale;

	[SerializeField]
	private Transform energyIconTarget;

	private Pool<Image> icons;

	private int pendingWorldCurrencyCollectionCount;

	private int worldCurrencyResetVersion;

	public Action OnCurrencyChanged;

	public Transform targetPosTowerKing;

	public AnimationCurve curveLerpYPos;

	public AnimationCurve curveLerpXZPos;

	public Transform chestObje;

	public List<GameObject> chestObjePool;

	public Transform chestTargetObje;

	public bool HasPendingWorldCurrencyCollections => false;

	public static CurrenciesHandler GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	public void UpdateCurrency(long amount, CurrencyTypes type, bool fromStart = false, bool playAnim = false)
	{
	}

	public void UpdateCurrency(float amount, CurrencyTypes type, bool fromStart = false, bool playAnim = false)
	{
	}

	public void AddCurrencyOnChangedAction(CurrencyTypes type, Action act)
	{
	}

	public void RemoveCurrencyOnChangedAction(CurrencyTypes type, Action act)
	{
	}

	public float GetAmount(CurrencyTypes type)
	{
		return 0f;
	}

	public bool CanBuy(float amount, CurrencyTypes type)
	{
		return false;
	}

	public Sprite GetCurrencyIcon(CurrencyTypes type)
	{
		return null;
	}

	public string GetCurrencyName(CurrencyTypes type)
	{
		return null;
	}

	public void Spawn3DCurrency(long amount, CurrencyTypes type, Vector3 worldPos, bool isFake = false)
	{
	}

	public void Spawn3DCurrencyBossDie(long amount, CurrencyTypes type, Vector3 worldPos, bool isFake = false)
	{
	}

	private static long GetCurrencySpawnAmount(long amount, int spawnCount, int spawnIndex)
	{
		return 0L;
	}

	public void Spawn3DCurrencyFor5(float amount, CurrencyTypes type, Vector3 worldPos, int maxAmount = 5, bool isFake = false)
	{
	}

	public void Spawn3DCurrencyForPunchBag(float amount, CurrencyTypes type, Vector3 worldPos, int maxAmount = 5, bool isFake = false)
	{
	}

	public void Spawn2DCurrency(long amount, CurrencyTypes type, Vector3 pos, bool isUI = false, bool isFake = false, bool useTrail = true)
	{
	}

	public void Spawn2DCurrencyToTarget(long amount, CurrencyTypes type, Vector3 pos, Transform target, bool isUI = false, bool isFake = false, bool useTrail = true, int maxIconCount = -1)
	{
	}

	private void SpawnLimited2DCurrencyToTarget(long amount, CurrencyTypes type, Vector3 pos, Transform target, bool isUI, bool isFake, bool useTrail, int maxIconCount)
	{
	}

	public void SpawnPooled2DCurrencyVisual(int count, CurrencyTypes type, Vector3 sourcePosition, Vector3 targetPosition, bool isUI = false, bool useTrail = true, Action onComplete = null, float scatterDuration = 0.45f, float scatterRadius = 350f, float scatterPause = 0.1f, float movementSpeed = 3f, Action onIconArrived = null)
	{
	}

	public void SpawnPooled2DCurrencyVisualStream(int count, CurrencyTypes type, Vector3 sourcePosition, Vector3 targetPosition, float emissionDuration, bool isUI = false, bool useTrail = true, Action onIconArrived = null, Action onComplete = null, float scatterDuration = 0.45f, float scatterRadius = 350f, float scatterPause = 0.1f, Action onIconEmitted = null)
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnPooled2DCurrencyVisualStreamRoutine_003Ed__41))]
	private IEnumerator SpawnPooled2DCurrencyVisualStreamRoutine(int count, CurrencyTypes type, Vector3 sourcePosition, Vector3 targetPosition, float emissionDuration, bool isUI, bool useTrail, Action onIconArrived, Action onComplete, float scatterDuration, float scatterRadius, float scatterPause, Action onIconEmitted)
	{
		return null;
	}

	public void Spawn2DEnergy(int amount, Vector3 pos, bool isUI = false, bool isFake = false, bool useTrail = true)
	{
	}

	private void StartTrackedWorldCurrencyCollection()
	{
	}

	private void CompleteTrackedWorldCurrencyCollection()
	{
	}

	public void ResetWorldCurrencyVisuals()
	{
	}

	[IteratorStateMachine(typeof(_003CCurrencyMovement_003Ed__46))]
	private IEnumerator CurrencyMovement(Currency curr, Vector3 targetPos, long amount, Transform curr3D = null, Vector3? startPos = null, bool canPlaySoung = false, bool trackWorldCollection = false, bool useTrail = true, Action onComplete = null, float scatterDuration = 0f, float scatterRadius = 500f, float scatterPause = 0f, float movementSpeed = 3f)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEnergyMovement_003Ed__47))]
	private IEnumerator EnergyMovement(Vector3 targetPos, int amount, Vector3 startPos, bool useTrail = true)
	{
		return null;
	}

	private void ResetTrail(TrailRenderer trail, bool emit)
	{
	}

	public void Spawn3DCurrencyBall(float amount, CurrencyTypes type, Vector3 worldPos, bool isFake = false)
	{
	}

	[IteratorStateMachine(typeof(_003CCurrencyMovementBall_003Ed__53))]
	private IEnumerator CurrencyMovementBall(Currency curr, Transform targetPos, float amount, Rigidbody curr3D = null, Vector3? startPos = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCurrencyMovementToPlayer_003Ed__54))]
	private IEnumerator CurrencyMovementToPlayer(Currency curr, Transform targetPos, float amount, Rigidbody curr3D = null, Vector3? startPos = null)
	{
		return null;
	}

	public void SpawnChestToSlote(long amount, Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CChestMovement_003Ed__59))]
	private IEnumerator ChestMovement(GameObject chest, Vector3 targetPos, Vector3 startPos)
	{
		return null;
	}
}
