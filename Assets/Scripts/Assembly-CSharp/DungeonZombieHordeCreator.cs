using System.Collections.Generic;
using UnityEngine;

public class DungeonZombieHordeCreator : MonoBehaviour
{
	private static DungeonZombieHordeCreator instance;

	[Header("References")]
	[SerializeField]
	private Transform[] targetPoints;

	[SerializeField]
	private DungeonZombieHordeDB dungeonZombieHordeDb;

	[Header("Flow")]
	[SerializeField]
	private bool spawnOnStart;

	[SerializeField]
	private int startingWave;

	[Header("Spawn")]
	[SerializeField]
	private float spawnRange;

	[SerializeField]
	private bool randomYaw;

	private readonly List<IEnemy> activeEnemies;

	private int currentWave;

	private bool isActive;

	private bool successTriggered;

	public static DungeonZombieHordeCreator Instance => null;

	public int CurrentWave => 0;

	public int ActiveEnemyCount => 0;

	public IReadOnlyList<IEnemy> ActiveEnemies => null;

	public bool AreAllEnemiesDefeated => false;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void StartEncounter()
	{
	}

	public void StopEncounter()
	{
	}

	public void ResetEncounter()
	{
	}

	public void SetWave(int waveIndex)
	{
	}

	public void SpawnCurrentWave()
	{
	}

	public static bool TryHandleEnemyDie(IEnemy enemy)
	{
		return false;
	}

	private Vector3 GetSpawnAnchorPosition(int enemyIndex)
	{
		return default;
	}

	private Transform GetTargetPoint(int enemyIndex)
	{
		return null;
	}

	private Vector3 GetSpawnPosition(Vector3 anchorPosition)
	{
		return default;
	}

	private IEnemy SpawnEnemy(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	private int ResolveCurrentDungeonStep()
	{
		return 0;
	}

	private void DespawnAllEnemies()
	{
	}

	private bool HandleEnemyDie(IEnemy enemy)
	{
		return false;
	}

	private void PruneInactiveEnemies()
	{
	}
}
