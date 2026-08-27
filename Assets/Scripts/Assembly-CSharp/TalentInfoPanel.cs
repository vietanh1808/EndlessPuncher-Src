using TMPro;
using UnityEngine;

public class TalentInfoPanel : MonoBehaviour
{
	private static TalentInfoPanel _instance;

	private readonly int comeHash;

	private readonly int goHash;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private TextMeshProUGUI title;

	[SerializeField]
	private TextMeshProUGUI description;

	[SerializeField]
	private Transform panelObje;

	public static TalentInfoPanel Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void LoadPanel(CappybaraTalentDB.PrizeTalent prizeTalent, Vector3 point)
	{
	}

	public void ClosePanle()
	{
	}

	private string GetTalentName(PrizeTalentType type)
	{
		return null;
	}
}
