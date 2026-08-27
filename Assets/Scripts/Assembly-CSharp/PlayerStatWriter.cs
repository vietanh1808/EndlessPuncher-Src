using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class PlayerStatWriter : MonoBehaviour
{
	[Serializable]
	public class StatTextBinding
	{
		public PlayerStatType statType;

		public TextMeshProUGUI text;

		public Animator animator;

		public ParticleSystem particle;
	}

	[CompilerGenerated]
	private sealed class _003CRefreshAtStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerStatWriter _003C_003E4__this;

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
		public _003CRefreshAtStart_003Ed__14(int _003C_003E1__state)
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

	private static PlayerStatWriter _instance;

	[SerializeField]
	private GameObject panelObje;

	[SerializeField]
	private TextMeshProUGUI globalPowerText;

	[SerializeField]
	private List<StatTextBinding> statBindings;

	public GameObject maxPermanentRangeUpgradeText;

	private bool _isSubscribedToPowerChanged;

	private InGameUIMenuController menuController;

	public static PlayerStatWriter Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshAtStart_003Ed__14))]
	private IEnumerator RefreshAtStart()
	{
		return null;
	}

	public void RefreshAllStats()
	{
	}

	public void RefreshStat(PlayerStatType statType)
	{
	}

	private void RefreshMaxPermanentRangeUpgradeText()
	{
	}

	public void PlayStatFeedback(PlayerStatType statType)
	{
	}

	private string FormatStatValue(PlayerStatType statType, float value)
	{
		return null;
	}

	private void HandleMenuChanged()
	{
	}

	private void TrySubscribeToPowerChanged()
	{
	}

	private void SyncGlobalPowerText()
	{
	}

	private void RefreshGlobalPowerText()
	{
	}

	private void UpdatePanelVisibility()
	{
	}

	private InGameUIMenuController GetMenuController()
	{
		return null;
	}
}
