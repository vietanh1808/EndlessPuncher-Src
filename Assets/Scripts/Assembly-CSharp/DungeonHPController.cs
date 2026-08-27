using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DungeonHPController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateEnemyLateSlider_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonHPController _003C_003E4__this;

		public float targetValue;

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
		public _003CAnimateEnemyLateSlider_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CAnimatePlayerLateSlider_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonHPController _003C_003E4__this;

		public float targetValue;

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
		public _003CAnimatePlayerLateSlider_003Ed__25(int _003C_003E1__state)
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

	private static DungeonHPController _instance;

	[SerializeField]
	private GameObject panelObje;

	[SerializeField]
	private Slider playerHP;

	[SerializeField]
	private Slider playerHPLate;

	[SerializeField]
	private Slider enemyHP;

	[SerializeField]
	private Slider enemyHPLate;

	[SerializeField]
	private TextMeshProUGUI playerHPText;

	[SerializeField]
	private TextMeshProUGUI enemyHPText;

	[SerializeField]
	private float lateBarDelay;

	[SerializeField]
	private float lateBarLerpSpeed;

	private Coroutine playerLateRoutine;

	private Coroutine enemyLateRoutine;

	public static DungeonHPController Instance => null;

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

	public void SetPlayerHp(float currentHp, float maxHp)
	{
	}

	public void SetEnemyHp(float currentHp, float maxHp)
	{
	}

	private string FormatHpText(float currentHp, float maxHp)
	{
		return null;
	}

	private string FormatHpValue(float value)
	{
		return null;
	}

	private void RefreshPlayerHpFromScene()
	{
	}

	private void UpdatePlayerLateSlider(float targetValue)
	{
	}

	private void UpdateEnemyLateSlider(float targetValue)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimatePlayerLateSlider_003Ed__25))]
	private IEnumerator AnimatePlayerLateSlider(float targetValue)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateEnemyLateSlider_003Ed__26))]
	private IEnumerator AnimateEnemyLateSlider(float targetValue)
	{
		return null;
	}

	private void HandleDungeonSuccess(DungeonInfo info, int completedLevel)
	{
	}

	private void HandleDungeonFail()
	{
	}

	private void ClosePanel()
	{
	}

	private void StopLateRoutines()
	{
	}
}
