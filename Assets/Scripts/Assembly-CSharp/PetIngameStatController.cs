using UnityEngine;

public class PetIngameStatController : MonoBehaviour
{
	private bool isSubscribed;

	private float _playerDamage;

	private float _playerRange;

	private float _playerRate;

	private float _playerDefence;

	private float _playerHP;

	private float _playerCritChance;

	private float _playerCritDmg;

	public static PetIngameStatController Instance { get; private set; }

	public float GetDamage => 0f;

	public float GetRange => 0f;

	public float GetRate => 0f;

	public float GetDefence => 0f;

	public float GetHp => 0f;

	public float GetCritChance => 0f;

	public float GetCritDamage => 0f;

	private void ResetPetStatsInGame()
	{
	}

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

	private void HandleEquippedSkillsChanged()
	{
	}

	public void PetsStartForPlayer()
	{
	}

	public void RebuildPetStats()
	{
	}

	private void RefreshAffectedPlayerStats()
	{
	}

	public float GetStatFromPet(PlayerBonusStatTypes stat)
	{
		return 0f;
	}
}
