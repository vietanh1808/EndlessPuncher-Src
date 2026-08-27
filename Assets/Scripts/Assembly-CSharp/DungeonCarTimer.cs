using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DungeonCarTimer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateCarLateSlider_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonCarTimer _003C_003E4__this;

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
		public _003CAnimateCarLateSlider_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CStartCountdownWhenLevelBegins_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonCarTimer _003C_003E4__this;

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
		public _003CStartCountdownWhenLevelBegins_003Ed__21(int _003C_003E1__state)
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

	[SerializeField]
	private GameObject panelObje;

	[SerializeField]
	private Slider carHPSlider;

	[SerializeField]
	private Slider carHPSliderLate;

	[SerializeField]
	private TextMeshProUGUI carHPText;

	[SerializeField]
	private float lateBarDelay;

	[SerializeField]
	private float lateBarLerpSpeed;

	[SerializeField]
	private Slider timerSlider;

	[SerializeField]
	private TextMeshProUGUI timerText;

	[SerializeField]
	private float duration;

	private float remainingTime;

	private bool isTimerRunning;

	private bool isOutcomeTriggered;

	private Coroutine carLateRoutine;

	private Coroutine countdownStartRoutine;

	private DungeonCarBehaviour boundCar;

	private float lastKnownCarMaxHp;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void StartCountdown()
	{
	}

	[IteratorStateMachine(typeof(_003CStartCountdownWhenLevelBegins_003Ed__21))]
	private IEnumerator StartCountdownWhenLevelBegins()
	{
		return null;
	}

	public void StopCountdown()
	{
	}

	private void HandleCarDestroyed()
	{
	}

	private void HandleDungeonSuccess(DungeonInfo info, int completedLevel)
	{
	}

	private void HandleDungeonFail()
	{
	}

	private void SetPanelActive(bool isActive)
	{
	}

	private void TriggerSuccess()
	{
	}

	private void TriggerFail()
	{
	}

	private void UpdateSlider()
	{
	}

	private void UpdateTimerText()
	{
	}

	private void UpdateCarHpUI()
	{
	}

	private void UpdateCarHpUI(float currentHp, float maxHp)
	{
	}

	private void UpdateCarLateSlider(float targetValue)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateCarLateSlider_003Ed__34))]
	private IEnumerator AnimateCarLateSlider(float targetValue)
	{
		return null;
	}

	private void BindCreatorEvents()
	{
	}

	private void UnbindCreatorEvents()
	{
	}

	private void RebindCurrentCar()
	{
	}

	private void UnbindCurrentCar()
	{
	}

	private void HandleCarHpChanged(float currentHp, float maxHp)
	{
	}

	private void EnsureCurrentCarBinding()
	{
	}
}
