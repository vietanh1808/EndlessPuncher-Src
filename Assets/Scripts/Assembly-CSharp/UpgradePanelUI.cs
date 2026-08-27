using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanelUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayedClearPanel_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UpgradePanelUI _003C_003E4__this;

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
		public _003CDelayedClearPanel_003Ed__30(int _003C_003E1__state)
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

	[Header("Panel References")]
	[SerializeField]
	private GameObject _panelRoot;

	[SerializeField]
	private Animator _panelAnimator;

	[Header("Area Header UI")]
	[SerializeField]
	private GameObject _headerRoot;

	[SerializeField]
	private TextMeshProUGUI _areaTitleText;

	[SerializeField]
	private Image _areaIconImage;

	[SerializeField]
	private Transform _starsParent;

	[SerializeField]
	private GameObject _starIconPrefab;

	[SerializeField]
	private GameObject _inactiveStarIconPrefab;

	[SerializeField]
	private Slider _starProgressBar;

	[SerializeField]
	private TextMeshProUGUI _progressStartLevelText;

	[SerializeField]
	private TextMeshProUGUI _progressEndLevelText;

	[Header("Content Settings")]
	[SerializeField]
	private Transform _contentParent;

	[SerializeField]
	private GameObject _upgradeCardPrefab;

	private List<UpgradeCardUI> _instantiatedCards;

	private List<GameObject> _instantiatedStars;

	private UpgradeableAreaBase _currentArea;

	private readonly int _openPanel;

	private readonly int _closePanel;

	private int _currentStars;

	private Coroutine clearRoutine;

	public static UpgradePanelUI Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void OpenPanel(UpgradeableAreaBase area)
	{
	}

	public void ClosePanel()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedClearPanel_003Ed__30))]
	private IEnumerator DelayedClearPanel(float delay)
	{
		return null;
	}

	private void UpdateHeaderUI()
	{
	}

	private void PopulateUpgradeCards()
	{
	}

	private void ClearExistingCards()
	{
	}

	private void ClearExistingStars()
	{
	}

	private void UpdateAllCardUI()
	{
	}

	private void OnAnyUpgradePurchased(UpgradeData purchasedData)
	{
	}
}
