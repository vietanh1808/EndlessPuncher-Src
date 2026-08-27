using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PreviewSkillCard : MonoBehaviour
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

	[Header("Level Badge")]
	[SerializeField]
	private TextMeshProUGUI levelTxt;

	[Header("Card Count")]
	[SerializeField]
	private TextMeshProUGUI cardCountTxt;

	[SerializeField]
	private Slider cardCountSlider;

	[SerializeField]
	private Sprite defaultSpriteFill;

	[SerializeField]
	private Sprite filledSpriteFill;

	[SerializeField]
	private GameObject upgradeArrow;

	public void Initialize(SkillCard skillCard)
	{
	}
}
