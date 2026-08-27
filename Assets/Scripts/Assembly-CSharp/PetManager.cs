using System.Collections.Generic;
using UnityEngine;

public class PetManager : MonoBehaviour
{
	[Header("Setup")]
	[SerializeField]
	private Transform[] petTargetSlotes;

	[SerializeField]
	private Transform petParent;

	[SerializeField]
	private bool enableDebugLogs;

	private readonly Dictionary<SkillCard, PetBehaviour> activePets;

	private readonly List<SkillCard> removalBuffer;

	public GameObject petBehaviour;

	private bool isSubscribed;

	private bool isOwnerDead;

	public static PetManager Instance { get; private set; }

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void TrySubscribeToSkillHandler()
	{
	}

	private void RefreshPets()
	{
	}

	private bool IsSkillStillEquipped(SkillCard skillCard, List<SkillSlot> slots)
	{
		return false;
	}

	private PetBehaviour SpawnPet(SkillCard skillCard, int slotIndex)
	{
		return null;
	}

	private void SetPetPosition(Transform petTransform, int slotIndex)
	{
	}

	private void RemovePet(SkillCard skillCard)
	{
	}

	private void KillActivePets()
	{
	}

	public void HandleOwnerDeath()
	{
	}

	public void ResetForNewRun()
	{
	}

	private bool IsRunFinished()
	{
		return false;
	}

	private float GetDamage(SkillCard skillCard)
	{
		return 0f;
	}

	private float GetRate(SkillCard skillCard)
	{
		return 0f;
	}

	private float GetStatValue(SkillCard skillCard, string statName)
	{
		return 0f;
	}

	private void Log(string message)
	{
	}
}
