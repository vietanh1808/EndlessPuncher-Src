using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(NotificationController))]
public class ForgeProbabilityPanel : MonoBehaviour
{
	private enum UpgradeState
	{
		Idle = 0,
		Upgrading = 1,
		ReadyToComplete = 2
	}

	[CompilerGenerated]
	private sealed class _003CAnimateCardChangesAfterUpgrade_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ForgeProbabilityPanel _003C_003E4__this;

		public List<float> oldChances;

		private int _003Ci_003E5__2;

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
		public _003CAnimateCardChangesAfterUpgrade_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CWaitAndClose_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public ForgeProbabilityPanel _003C_003E4__this;

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
		public _003CWaitAndClose_003Ed__42(int _003C_003E1__state)
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

	[Header("UI Referansları")]
	[SerializeField]
	private GameObject cardPrefab;

	[SerializeField]
	private Transform cardContainer;

	[SerializeField]
	private Button upgradeButton;

	[SerializeField]
	private TextMeshProUGUI upgradeCostText;

	[SerializeField]
	private GameObject OnProgressObject;

	[SerializeField]
	private GameObject UpgradeObject;

	[SerializeField]
	private Slider timerSlider;

	[SerializeField]
	private Animator panelAnim;

	[SerializeField]
	private TextMeshProUGUI currentLevelText;

	[SerializeField]
	private TextMeshProUGUI nextLevelText;

	[SerializeField]
	private GameObject probabilityPanel;

	[SerializeField]
	private Button completeUpgradeButton;

	[SerializeField]
	private GameObject completeUpgradeObject;

	[Header("Upgrade Ayarları")]
	[SerializeField]
	private int upgradeCost;

	[SerializeField]
	private float upgradeDurationInSeconds;

	[SerializeField]
	private CurrencyTypes upgradeCurrency;

	private List<ForgeProbabilityCard> spawnedCards;

	private long upgradeEndTime;

	private NotificationController notificationController;

	private UpgradeState currentState;

	private string lastUpgradeCostText;

	private string lastCurrentLevelText;

	private string lastNextLevelText;

	private const string UPGRADE_END_TIME_KEY = "ForgeUpgradeEndTime";

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void UpdateUI()
	{
	}

	private void PopulateCards()
	{
	}

	private void UpdateCards()
	{
	}

	private void UpdateUpgradeButtonState()
	{
	}

	private static void SetTextIfChanged(TextMeshProUGUI text, ref string cachedValue, string value)
	{
	}

	private void AttemptUpgrade()
	{
	}

	private void StartUpgrade()
	{
	}

	private void CompleteUpgrade()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateCardChangesAfterUpgrade_003Ed__36))]
	private IEnumerator AnimateCardChangesAfterUpgrade(List<float> oldChances)
	{
		return null;
	}

	private void UpdateTimer()
	{
	}

	private void CheckForOfflineProgress()
	{
	}

	private long GetCurrentUnixTimestamp()
	{
		return 0L;
	}

	public void OpenPanel()
	{
	}

	public void ClosePanel()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndClose_003Ed__42))]
	private IEnumerator WaitAndClose(float delay)
	{
		return null;
	}
}
