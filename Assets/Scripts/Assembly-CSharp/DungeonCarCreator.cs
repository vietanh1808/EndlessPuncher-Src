using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DungeonCarCreator : MonoBehaviour
{
	private static DungeonCarCreator instance;

	[Header("References")]
	[SerializeField]
	private Transform carTarget;

	[SerializeField]
	private DungeonCardDB dungeonCardDb;

	[Header("Flow")]
	[SerializeField]
	private bool spawnOnStart;

	[SerializeField]
	private int startingStep;

	private DungeonCarBehaviour currentCar;

	private int currentStep;

	private bool isActive;

	private bool wasCurrentCarDestroyed;

	[CompilerGenerated]
	private Action m_OnCurrentCarDestroyed;

	public static DungeonCarCreator Instance => null;

	public int CurrentStep => 0;

	public DungeonCarBehaviour CurrentCar => null;

	public bool HasActiveCar => false;

	public bool WasCurrentCarDestroyed => false;

	public event Action OnCurrentCarDestroyed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static bool TryHandleCarDie(DungeonCarBehaviour car)
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

	public void SpawnCurrentStepCar()
	{
	}

	public void CarDestroyed(DungeonCarBehaviour car)
	{
	}

	private bool TracksCar(DungeonCarBehaviour car)
	{
		return false;
	}

	private DungeonCarBehaviour SpawnCar(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	private int ResolveCurrentDungeonStep()
	{
		return 0;
	}

	private void DespawnCurrentCar()
	{
	}
}
