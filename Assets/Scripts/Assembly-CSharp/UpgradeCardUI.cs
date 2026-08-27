using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCardUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPurchaseContinuouslyRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UpgradeCardUI _003C_003E4__this;

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
		public _003CPurchaseContinuouslyRoutine_003Ed__28(int _003C_003E1__state)
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

	[Header("UI References")]
	[SerializeField]
	private TextMeshProUGUI _nameText;

	[SerializeField]
	private TextMeshProUGUI _levelText;

	[SerializeField]
	private TextMeshProUGUI _descriptionText;

	[SerializeField]
	private TextMeshProUGUI _valueText;

	[SerializeField]
	private TextMeshProUGUI _costText;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Button _purchaseButton;

	[SerializeField]
	private GameObject _lockedIcon;

	[SerializeField]
	private Color _descriptionColor;

	[Header("Hold Purchase Settings")]
	[SerializeField]
	private float _baseRepeatDelay;

	[SerializeField]
	private float _minRepeatDelay;

	[SerializeField]
	private float _acceleration;

	[SerializeField]
	private ParticleSystem[] _onPurchaseFXs;

	[SerializeField]
	private Animator[] _onPurchaseAnimators;

	private readonly int _purchaseTrigger;

	private UpgradeableAreaBase _area;

	private Coroutine _purchaseCoroutine;

	private float _currentRepeatDelay;

	public UpgradeData CardData { get; private set; }

	private void Awake()
	{
	}

	public void Setup(UpgradeData data, UpgradeableAreaBase area)
	{
	}

	public void UpdateUI()
	{
	}

	private void AttemptPurchase()
	{
	}

	public void StartContinuousPurchase()
	{
	}

	public void StopContinuousPurchase()
	{
	}

	[IteratorStateMachine(typeof(_003CPurchaseContinuouslyRoutine_003Ed__28))]
	private IEnumerator PurchaseContinuouslyRoutine()
	{
		return null;
	}

	public void OnPurchasedSucceeded()
	{
	}

	private void OnDestroy()
	{
	}
}
