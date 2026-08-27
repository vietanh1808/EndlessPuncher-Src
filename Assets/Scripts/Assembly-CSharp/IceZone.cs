using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IceZone : SkillBehaviour
{
	[Serializable]
	public class ZoneModel
	{
		private const int MaxPullForcesPerTick = 16;

		public GameObject fireZoneModel;

		public ParticleSystem particleBlackHole;

		private readonly Collider[] _cols;

		private readonly Dictionary<int, DamagedEnemyModel> _damagedById;

		private readonly List<int> _toRemove;

		private bool isStarted;

		public void CheckEnemyForZoneEffect(float damage, bool isCrit, float dotFreq, float range, LayerMask maskEnemy)
		{
		}

		public void HandleDamagedEnemiesTimer(Vector3 holePos, float dt)
		{
		}

		public void SetZone(float damage, bool isCrit, float dotFreq, float range, LayerMask maskEnemy, float dt)
		{
		}

		public void StartModel(Vector3 pos, float range)
		{
		}

		public void StopModel()
		{
		}
	}

	private class DamagedEnemyModel
	{
		public float tempTimer;

		public float pullTimer;

		public GameObject enemy;

		public IEnemy ienemy;

		public DamagedEnemyModel(float tempTimer, GameObject enemy, IEnemy ienemy)
		{
		}

		public bool TimerPull(float tt)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IceZone _003C_003E4__this;

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
		public _003CCountDown_003Ed__17(int _003C_003E1__state)
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
	private List<ZoneModel> allIceZones;

	private Vector3[] fireZonePoses;

	public float rangeSpawnArea;

	private float _duration;

	private bool canStart;

	public float dotFrequancy;

	private List<DamagedEnemyModel> damagedEnemies;

	private float _playerRange;

	public static IceZone Instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public override void StartAbility()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__17))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public override void ResetForNewRun()
	{
	}

	private Vector3 GetSpawnPoint(int i)
	{
		return default;
	}

	public Vector3 GetAvaliablePos(int currentI, out bool isSelectedpos)
	{
		isSelectedpos = default;
		return default;
	}
}
