using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DrawSkillCard : MonoBehaviour
{
	[Header("Skill")]
	[SerializeField]
	private Image icon;

	[SerializeField]
	private TextMeshProUGUI nameTxt;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image topGradient;

	[SerializeField]
	private Image bottomGradient;

	public void Initialize(SkillCard skillCard)
	{
	}
}
