using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameSpeedController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDeathSlowMotionRoutine_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSpeedController _003C_003E4__this;

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
		public _003CDeathSlowMotionRoutine_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003CTimeFix_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSpeedController _003C_003E4__this;

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
		public _003CTimeFix_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CTimedSlowMotionRoutine_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool fadeAudio;

		public float timeScale;

		public GameSpeedController _003C_003E4__this;

		public float holdDuration;

		public float restoreDuration;

		private float _003CstartScale_003E5__2;

		private float _003Ct_003E5__3;

		private float _003CsafeRestoreDuration_003E5__4;

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
		public _003CTimedSlowMotionRoutine_003Ed__56(int _003C_003E1__state)
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

	private const float DefaultFixedDeltaTime = 0.02f;

	public const string SpeedUpUnlockSaveKey = "SpeedUpUnlocked";

	[Header("SpeedUp Button")]
	[SerializeField]
	private GameObject speedUpPanel;

	[SerializeField]
	private GameObject speedUpModel;

	[SerializeField]
	private GameObject speedUpTripleModel;

	[Header("Speed")]
	[SerializeField]
	private float doubleSpeedMultiplier;

	[SerializeField]
	private float tripleSpeedMultiplier;

	[Header("Time FX")]
	[SerializeField]
	private float deathSlowMotionScale;

	[SerializeField]
	private float deathSlowMotionHoldDuration;

	[SerializeField]
	private float deathSlowMotionRestoreDuration;

	private static GameSpeedController _instance;

	private float currentBaseTimeScale;

	private float gameplaySpeedMultiplier;

	private Coroutine deathSlowMotionRoutine;

	private bool isSubscribedToWeeklyAdsStatus;

	public static GameSpeedController Instance => null;

	public float GameplaySpeedMultiplier => 0f;

	public bool IsDoubleSpeedActive => false;

	public bool IsTripleSpeedActive => false;

	public bool IsDeathSlowMotionActive => false;

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

	public void ResetTimeScale()
	{
	}

	public void ApplySpeedPreference()
	{
	}

	public void ForceNormalSpeed()
	{
	}

	public void SetDoubleSpeed(bool isEnabled)
	{
	}

	public void ToggleDoubleSpeed()
	{
	}

	public void SetGameplaySpeedMultiplier(float multiplier)
	{
	}

	public void SetBaseTimeScale(float baseTimeScale)
	{
	}

	public void TimeSlowBossDie()
	{
	}

	public void PlayDeathSlowMotion()
	{
	}

	public void PlayTimedSlowMotion(float timeScale, float holdDuration, float restoreDuration = 0f)
	{
	}

	public bool IsSpeedUpUnlocked()
	{
		return false;
	}

	public void UnlockSpeedUpFeature()
	{
	}

	public void RefreshSpeedUpPanelState()
	{
	}

	private void ApplyTimeScale()
	{
	}

	private void RefreshSpeedUpVisualState()
	{
	}

	private float GetActiveSpeedMultiplier()
	{
		return 0f;
	}

	private float GetSavedGameplaySpeedMultiplier()
	{
		return 0f;
	}

	private float GetNextGameplaySpeedMultiplier()
	{
		return 0f;
	}

	private void SetAndSaveGameplaySpeedMultiplier(float multiplier)
	{
	}

	private float ClampGameplaySpeedMultiplier(float multiplier)
	{
		return 0f;
	}

	private bool CanUseTripleSpeed()
	{
		return false;
	}

	private bool IsSameSpeed(float a, float b)
	{
		return false;
	}

	private bool IsFightSpeedAllowed()
	{
		return false;
	}

	private void TrySubscribeToWeeklyAdsStatus()
	{
	}

	private void HandleWeeklyAdsStatusChanged(bool isActive)
	{
	}

	[IteratorStateMachine(typeof(_003CTimeFix_003Ed__54))]
	private IEnumerator TimeFix()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDeathSlowMotionRoutine_003Ed__55))]
	private IEnumerator DeathSlowMotionRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTimedSlowMotionRoutine_003Ed__56))]
	private IEnumerator TimedSlowMotionRoutine(float timeScale, float holdDuration, float restoreDuration, bool fadeAudio)
	{
		return null;
	}
}
