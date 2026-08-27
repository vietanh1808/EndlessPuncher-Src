using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillCard : MonoBehaviour
{
	[Header("Locked")]
	[SerializeField]
	private GameObject lockedCard;

	[Header("Skill")]
	[SerializeField]
	private GameObject skillCard;

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

	[SerializeField]
	private ParticleSystem upgradeParticle;

	private Animator animator;

	private Button button;

	public Skill Skill { get; private set; }

	public int Level { get; private set; }

	public bool IsEquipped { get; private set; }

	public bool IsUnlocked => false;

	[Header("Card Count")]
	public int CardCount { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnClick()
	{
	}

	public void PopAnim()
	{
	}

	public void Initialize(Skill skill, int level, int cardCount = 0)
	{
	}

	public void CollectCard()
	{
	}

	public void LevelUp()
	{
	}

	public int GetNeedCardCount()
	{
		return 0;
	}

	public void UpdateUI()
	{
	}

	public void SetEquipped(bool isEquipped)
	{
	}

	public float GetStatValueAtLevel(Stat stat, int level)
	{
		return 0f;
	}

	public float GetSkillPower()
	{
		return 0f;
	}
}
