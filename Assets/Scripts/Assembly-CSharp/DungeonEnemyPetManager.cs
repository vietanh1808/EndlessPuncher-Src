using System.Collections.Generic;
using UnityEngine;

public class DungeonEnemyPetManager : MonoBehaviour
{
	private static DungeonEnemyPetManager instance;

	[Header("References")]
	[SerializeField]
	private EnemyPetBehaviour enemyPetBehaviourPrefab;

	[SerializeField]
	private Transform[] spawnPoints;

	[SerializeField]
	private DungeonPetDB dungeonPetDb;

	[Header("Flow")]
	[SerializeField]
	private bool spawnOnStart;

	[SerializeField]
	private bool onlySpawnInDungeonScene;

	[SerializeField]
	private int startingStep;

	private readonly List<EnemyPetBehaviour> activeEnemyPets;

	private bool isActive;

	private bool successTriggered;

	private int currentStep;

	public static DungeonEnemyPetManager Instance => null;

	public IReadOnlyList<EnemyPetBehaviour> ActiveEnemyPets => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static bool TryHandleEnemyPetDie(EnemyPetBehaviour enemyPet)
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

	public void SpawnEnemyPets()
	{
	}

	private int GetValidSpawnPointCount()
	{
		return 0;
	}

	private int ResolveCurrentDungeonStep()
	{
		return 0;
	}

	private bool HandleEnemyPetDie(EnemyPetBehaviour enemyPet)
	{
		return false;
	}

	private void DespawnAllEnemyPets()
	{
	}

	private void PruneInactiveEnemyPets()
	{
	}
}
