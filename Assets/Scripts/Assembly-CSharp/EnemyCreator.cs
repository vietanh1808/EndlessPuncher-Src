using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
	[Serializable]
	public class AreaPoses
	{
		public Transform rightTop;

		public Transform leftButtom;
	}

	[CompilerGenerated]
	private sealed class _003CMatChange_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyCreator _003C_003E4__this;

		private int _003CchapterValue_003E5__2;

		private int _003Csize_003E5__3;

		private int _003CstageSize_003E5__4;

		private float _003ClastSpawnedNormalEnemyBaseHp_003E5__5;

		private int _003Ck_003E5__6;

		private bool _003CgoldEnemySpawnedThisWave_003E5__7;

		private int _003Ci_003E5__8;

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
		public _003CMatChange_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CWaitForStageCompletion_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyCreator _003C_003E4__this;

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
		public _003CWaitForStageCompletion_003Ed__49(int _003C_003E1__state)
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

	private static EnemyCreator _instance;

	public PoolingSystem enemyPool;

	[SerializeField]
	private int nextWaveSpawnRemainingEnemyThreshold;

	[SerializeField]
	private bool debugColorChange;

	[SerializeField]
	[Min(1f)]
	private float bossHpMultiplierFromLastEnemy;

	private GameManager _gm;

	private Coroutine stageLoopRoutine;

	private bool isStopped;

	private readonly WaitForSeconds _stageCompletionPollDelay;

	public float randomRange;

	public List<AreaPoses> allAreas;

	public Transform rightTop;

	public Transform leftButtom;

	private int _currentStage;

	private int _displayStage;

	private bool _bossstageCanCompleted;

	private bool _stageCompleted;

	private int _deadEnemyCount;

	private int _resolvedEnemyCount;

	private int _onStageEnemyCount;

	private int _displayDeadEnemyCount;

	private int _displayStageEnemyCount;

	private bool _forceCompleteCurrentWaveRequested;

	private HashSet<EnemyBehaviour> _currentWaveEnemies;

	private int _killingCounterForGetDefenceGain;

	private bool _getDefenceGainAfterKillingIsActive;

	private float _getDefenceGainAfterKillingValue;

	private bool _isDecatingHealIsActive;

	public static EnemyCreator instance => null;

	public int GetCurrentWave => 0;

	public int DisplayStage => 0;

	public int DisplayDeadEnemyCount => 0;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void CheckGameStop()
	{
	}

	public void ResetForNewRun()
	{
	}

	[IteratorStateMachine(typeof(_003CMatChange_003Ed__22))]
	private IEnumerator MatChange()
	{
		return null;
	}

	private void DespawnAllEnemies()
	{
	}

	public bool IsPointInAreas(Vector3 point1)
	{
		return false;
	}

	public Vector3 GetRandomPointOutInRing()
	{
		return default;
	}

	public void CompleteCurrentWave()
	{
	}

	public void EnemyDie(EnemyBehaviour enemy)
	{
	}

	public void EnemyRemoved(EnemyBehaviour enemy)
	{
	}

	private bool ResolveEnemyForStage(EnemyBehaviour enemy)
	{
		return false;
	}

	private void ResolveSkippedEnemyForStage()
	{
	}

	private void AdvanceDisplayedStageProgress()
	{
	}

	private int GetDisplayEnemyCountForStage(int chapterValue, int stageIndex, int totalRegularStageCount)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CWaitForStageCompletion_003Ed__49))]
	private IEnumerator WaitForStageCompletion()
	{
		return null;
	}

	private int GetAliveRegularEnemyCount()
	{
		return 0;
	}

	private bool ShouldCompleteCurrentStage()
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}

	private void CheckItemBonuses()
	{
	}

	public void TotalEnemyKillingCounter()
	{
	}

	public float GetPlayerDPS()
	{
		return 0f;
	}
}
