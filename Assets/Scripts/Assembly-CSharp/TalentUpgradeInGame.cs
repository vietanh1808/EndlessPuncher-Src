using System.Collections.Generic;
using UnityEngine;

public class TalentUpgradeInGame : MonoBehaviour
{
	private static TalentUpgradeInGame _instance;

	private GameManager _gm;

	public List<PrizeTalentType> allprizes;

	[SerializeField]
	private bool _isAdventurerActive;

	[SerializeField]
	private float _selfTreatment;

	[SerializeField]
	private float _wildSurvival;

	[SerializeField]
	private bool _skillRerolling;

	[SerializeField]
	private float _prospector;

	[SerializeField]
	private float _curiousNature;

	[SerializeField]
	private float _comboHunter;

	[SerializeField]
	private float _freeReroll;

	[SerializeField]
	private float _freeRerollCounter;

	private int _skillCount;

	public static TalentUpgradeInGame Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UpdateTalents()
	{
	}

	public void FreeRerollPushed(int value)
	{
	}

	public bool IsTypeEarned(PrizeTalentType type, out float value)
	{
		value = default;
		return false;
	}

	public void AddTalentFromTest(PrizeTalentType tt)
	{
	}
}
