using UnityEngine;

public class DungeonEnemyCreator : MonoBehaviour
{
	private static DungeonEnemyCreator instance;

	[Header("References")]
	[SerializeField]
	private Transform enemyTarget;

	[SerializeField]
	private DungeonEnemyDB dungeonEnemyDb;

	[Header("Flow")]
	[SerializeField]
	private bool spawnOnStart;

	[SerializeField]
	private float respawnDelay;

	[SerializeField]
	private int startingStep;

	private Coroutine spawnRoutine;

	private EnemyBehaviour currentEnemy;

	private int currentStep;

	private bool isActive;

	private bool currentEnemyUsesPool;

	public static DungeonEnemyCreator Instance => null;

	public int CurrentStep => 0;

	public EnemyBehaviour CurrentEnemy => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static bool TryHandleEnemyDie(EnemyBehaviour enemy)
	{
		return false;
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

	public void SetStep(int step)
	{
	}

	public void SpawnCurrentStepEnemy()
	{
	}

	public void EnemyDie(EnemyBehaviour enemy)
	{
	}

	private bool TracksEnemy(EnemyBehaviour enemy)
	{
		return false;
	}

	private IEnemy SpawnEnemy(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	private int ResolveCurrentDungeonStep()
	{
		return 0;
	}

	private void DespawnCurrentEnemy()
	{
	}
}
