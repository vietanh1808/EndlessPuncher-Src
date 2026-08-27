using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlot : MonoBehaviour
{
	[Header("Locked Card")]
	[SerializeField]
	private int unlockLevel;

	[SerializeField]
	private GameObject lockedCard;

	[SerializeField]
	private TextMeshProUGUI unlockLevelTxt;

	[Header("Empty Card")]
	[SerializeField]
	private GameObject emptyCard;

	private Animator emptyCardAnimator;

	private static readonly int BreathParameter;

	[Header("Equipped Card")]
	[SerializeField]
	private PreviewSkillCard previewSkillCard;

	[Header("Selection Pulse")]
	[SerializeField]
	private float pulseScale;

	[SerializeField]
	private float pulseDuration;

	private Button button;

	private Tween pulseTween;

	private Vector3 baseScale;

	public SkillCard CurrentSkillCard { get; private set; }

	public int UnlockLevel => 0;

	public bool IsLocked { get; private set; }

	private int SlotIndex => 0;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void CheckLock()
	{
	}

	public void Refresh()
	{
	}

	private void OnClick()
	{
	}

	public void InitializeCard(SkillCard skillCard)
	{
	}

	public void Clear()
	{
	}

	public void Lock()
	{
	}

	public void Unlock()
	{
	}

	private void SetEmptyCardBreath(bool enabled)
	{
	}

	private int GetDisplayUnlockLevel()
	{
		return 0;
	}

	public void StartSelectionPulse(float delay)
	{
	}

	public void StopSelectionPulse()
	{
	}
}
