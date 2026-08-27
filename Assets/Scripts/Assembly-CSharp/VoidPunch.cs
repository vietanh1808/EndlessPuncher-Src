using System;
using System.Collections.Generic;
using UnityEngine;

public class VoidPunch : SkillBehaviour
{
	[Serializable]
	public class VoidModel
	{
		private const int MaxPullForcesPerTick = 16;

		public GameObject blackHoleModel;

		public ParticleSystem particleBlackHole;

		private readonly Collider[] _cols;

		private readonly Dictionary<int, DamagedEnemyModel> _damagedById;

		private readonly List<int> _toRemove;

		private bool isStarted;

		public void CheckEnemyForPull(float damage, bool isCrit, float dotFreq, float range, LayerMask maskEnemy)
		{
		}

		public void HandleDamagedEnemiesTimer(Vector3 holePos, float dt, float pullForce)
		{
		}

		public void SetHole(float damage, bool isCrit, float dotFreq, float range, LayerMask maskEnemy, float dt, float pullForce)
		{
		}

		public void StartModel(Vector3 pos)
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

	public float rangeSpawnArea;

	public float rangePunchesHit;

	public float duration;

	public float pullForce;

	public List<VoidModel> allBlackHoles;

	public ParticleSystem particleBlackHole;

	private float _duration;

	private bool canStart;

	public float dotFrequancy;

	private List<DamagedEnemyModel> damagedEnemies;

	private Vector3[] blackHolePoses;

	public static VoidPunch Instance { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public override void StartAbility()
	{
	}

	private void SkillStartedDelay()
	{
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
