using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroStageNode : MonoBehaviour
{
	[Header("Text")]
	[SerializeField]
	private TextMeshProUGUI stageNumberText;

	[Header("Visuals")]
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private GameObject completedIndicator;

	[SerializeField]
	private GameObject currentIndicator;

	[SerializeField]
	private GameObject lockedIndicator;

	[SerializeField]
	private GameObject specialIndicator;

	[Header("Background Colors")]
	[SerializeField]
	private Color completedColor;

	[SerializeField]
	private Color currentColor;

	[SerializeField]
	private Color lockedColor;

	[SerializeField]
	private Color specialColor;

	public int StageNumber { get; private set; }

	public HeroStageNodeState State { get; private set; }

	public bool IsSpecial { get; private set; }

	public void Refresh(int stageNumber, HeroStageNodeState state, bool isSpecial)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStateVisuals()
	{
	}

	private void RefreshBackground()
	{
	}
}
