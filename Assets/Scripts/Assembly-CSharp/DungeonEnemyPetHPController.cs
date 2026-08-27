using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DungeonEnemyPetHPController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateEnemyLateSlider_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonEnemyPetHPController _003C_003E4__this;

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
		public _003CAnimateEnemyLateSlider_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CAnimatePlayerLateSlider_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonEnemyPetHPController _003C_003E4__this;

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
		public _003CAnimatePlayerLateSlider_003Ed__30(int _003C_003E1__state)
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

	private static DungeonEnemyPetHPController instance;

	[SerializeField]
	private GameObject panelObje;

	[SerializeField]
	private Slider playerHP;

	[SerializeField]
	private Slider playerHPLate;

	[SerializeField]
	private Slider enemyPetHP;

	[SerializeField]
	private Slider enemyPetHPLate;

	[SerializeField]
	private TextMeshProUGUI playerHPText;

	[SerializeField]
	private TextMeshProUGUI enemyPetHPText;

	[SerializeField]
	private float lateBarDelay;

	[SerializeField]
	private float lateBarLerpSpeed;

	private Coroutine playerLateRoutine;

	private Coroutine enemyLateRoutine;

	private float totalHp;

	private float currentHp;

	public static DungeonEnemyPetHPController Instance => null;

	public float TotalHp => 0f;

	public float CurrentHp => 0f;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void SetPlayerHp(float currentPlayerHp, float maxPlayerHp)
	{
	}

	public void InitializeEnemyPetHp(float maxHp)
	{
	}

	public void ApplyEnemyPetDamage(float damage)
	{
	}

	public void SetEnemyPetHp(float hp, float maxHp, bool instantLateBar = false)
	{
	}

	private void UpdateEnemyLateSlider(float targetValue)
	{
	}

	private void UpdatePlayerLateSlider(float targetValue)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimatePlayerLateSlider_003Ed__30))]
	private IEnumerator AnimatePlayerLateSlider(float targetValue)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateEnemyLateSlider_003Ed__31))]
	private IEnumerator AnimateEnemyLateSlider(float targetValue)
	{
		return null;
	}

	private string FormatHpText(float hp, float maxHp)
	{
		return null;
	}

	private string FormatHpValue(float value)
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

	private void RefreshPlayerHpFromScene()
	{
	}

	private void StopLateRoutines()
	{
	}

	private void StopPlayerLateRoutine()
	{
	}

	private void StopEnemyLateRoutine()
	{
	}
}
