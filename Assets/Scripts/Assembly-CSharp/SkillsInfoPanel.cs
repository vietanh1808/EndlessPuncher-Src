using TMPro;
using UnityEngine;

public class SkillsInfoPanel : MonoBehaviour
{
	private static SkillsInfoPanel _instance;

	public Animator anim;

	public GameObject panelObje;

	public TextMeshProUGUI title;

	public TextMeshProUGUI description;

	public TextMeshProUGUI statAttack;

	public TextMeshProUGUI statCooldown;

	public TextMeshProUGUI statCount;

	private bool _isActive;

	public static SkillsInfoPanel Instance => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void LoadSkill(SkillType skilltype, Vector3 point)
	{
	}

	private StatDB.Skill GetRuntimeSkill(SkillType skillType)
	{
		return null;
	}

	private float GetDisplayDamage(StatDB.Skill skill)
	{
		return 0f;
	}

	private string FormatDamageValue(float value)
	{
		return null;
	}

	private string FormatCooldownValue(float value)
	{
		return null;
	}

	private float GetDisplayCooldown(StatDB.Skill skill)
	{
		return 0f;
	}

	private void HandleGameStopChanged()
	{
	}

	public void ClosePanel()
	{
	}
}
