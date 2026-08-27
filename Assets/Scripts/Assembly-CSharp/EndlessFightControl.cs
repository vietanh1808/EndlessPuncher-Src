using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndlessFightControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CHealthBarBreakBounceRoutine_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndlessFightControl _003C_003E4__this;

		private float _003Celapsed_003E5__2;

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
		public _003CHealthBarBreakBounceRoutine_003Ed__61(int _003C_003E1__state)
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
	private sealed class _003CLateHpSliderRoutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndlessFightControl _003C_003E4__this;

		public float targetProgress;

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
		public _003CLateHpSliderRoutine_003Ed__58(int _003C_003E1__state)
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

	[Header("Data")]
	[SerializeField]
	private EndlessFightSO endlessFightSO;

	[Header("Giant")]
	[SerializeField]
	private EndlessGaintBehaviour gaintPrefab;

	[SerializeField]
	private EndlessGaintBehaviour sceneGaint;

	[SerializeField]
	private Transform gaintSpawnPoint;

	[SerializeField]
	private Transform gaintParent;

	[SerializeField]
	private bool spawnOnStart;

	[Header("UI")]
	[SerializeField]
	private Slider hpSlider;

	[SerializeField]
	private Slider lateHpSlider;

	[SerializeField]
	private TextMeshProUGUI hpText;

	[SerializeField]
	private TextMeshProUGUI barText;

	[SerializeField]
	private Slider rewardSlider;

	[SerializeField]
	private GameObject rewardClaimedDisableObject;

	[SerializeField]
	private Transform rewardSpawnPoint;

	[SerializeField]
	private Image rewardIcon;

	[SerializeField]
	private TextMeshProUGUI rewardAmount;

	[SerializeField]
	private GameObject rewardTick;

	[SerializeField]
	private float lateHpDelay;

	[SerializeField]
	private float lateHpFillSpeed;

	private EndlessGaintBehaviour currentGaint;

	private Coroutine lateHpRoutine;

	private int remainingHealthBars;

	private int currentRewardIndex;

	private float currentHealthBarHp;

	private float giantHealthPerBar;

	private float giantHealthIncreasePerBrokenBar;

	private float giantDamage;

	private float giantDamageIncreasePerBrokenBar;

	private bool currentRewardClaimed;

	private bool isFightFinished;

	private Coroutine healthBarBounceRoutine;

	private Vector3 healthBarBaseScale;

	private bool healthBarBaseScaleCached;

	private const float HealthBarBreakScale = 1.3f;

	private const float HealthBarBreakBounceDuration = 0.3f;

	public float CurrentHealthBarHp => 0f;

	public float HealthPerBar => 0f;

	public int RemainingHealthBars => 0;

	public bool IsFightFinished => false;

	public float CurrentGaintDamageMultiplier => 0f;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void StartFight()
	{
	}

	public EndlessFightDamageResult ApplyDamage(float damage, bool isCrit, EndlessGaintBehaviour source)
	{
		return default;
	}

	public void HandleGaintArrived(EndlessGaintBehaviour gaint)
	{
	}

	public void HandleGaintKilled(EndlessGaintBehaviour gaint)
	{
	}

	private void SpawnGaint()
	{
	}

	private void StartInGameLevel()
	{
	}

	private void TryClaimCurrentReward(float previousHp, float newHp, EndlessGaintBehaviour source)
	{
	}

	private bool GrantReward(RewardEntry rewardEntry, EndlessGaintBehaviour source)
	{
		return false;
	}

	private Vector3 GetRewardSpawnPosition(EndlessGaintBehaviour source)
	{
		return default;
	}

	private void RefreshUI(bool animateLateHp = false)
	{
	}

	private float GetCurrentHealthBarMaxHp()
	{
		return 0f;
	}

	private void RefreshLateHpSlider(float targetProgress, bool animateLateHp)
	{
	}

	[IteratorStateMachine(typeof(_003CLateHpSliderRoutine_003Ed__58))]
	private IEnumerator LateHpSliderRoutine(float targetProgress)
	{
		return null;
	}

	private void StopLateHpRoutine()
	{
	}

	private void PlayHealthBarBreakFeedback(EndlessGaintBehaviour source)
	{
	}

	[IteratorStateMachine(typeof(_003CHealthBarBreakBounceRoutine_003Ed__61))]
	private IEnumerator HealthBarBreakBounceRoutine()
	{
		return null;
	}

	private void StopHealthBarBounce()
	{
	}

	private void RefreshRewardUI()
	{
	}

	private void RefreshRewardInfo(EndlessFightHealthBarReward barReward)
	{
	}
}
