using TMPro;
using UnityEngine;

public class ActiveUpgradeInfoPanel : MonoBehaviour
{
	private static ActiveUpgradeInfoPanel _instance;

	public Animator anim;

	public GameObject panelObje;

	public TextMeshProUGUI title;

	public TextMeshProUGUI description;

	private bool _isActive;

	public static ActiveUpgradeInfoPanel Instance => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void LoadActiveUpgradeCard(ActiveUpgradesType typCard, Vector3 point)
	{
	}

	private string Prefix(ActiveUpgradesType activeType)
	{
		return null;
	}

	private string Suffix(ActiveUpgradesType activeType)
	{
		return null;
	}

	private string ReplaceValueBetweenDollarSigns(string input, string newValue)
	{
		return null;
	}

	private void HandleGameStopChanged()
	{
	}

	public void ClosePanel()
	{
	}
}
