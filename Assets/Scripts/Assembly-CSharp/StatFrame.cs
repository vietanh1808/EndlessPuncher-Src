using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatFrame : MonoBehaviour
{
	[SerializeField]
	private Image statIcon;

	[SerializeField]
	private TextMeshProUGUI statName;

	[SerializeField]
	private TextMeshProUGUI statValueText;

	private float currentValue;

	private Tween animationTween;

	private Color defaultColor;

	public Stat Stat { get; private set; }

	public void InitializeStat(Stat stat)
	{
	}

	protected string FormatStatNumber(float value)
	{
		return null;
	}

	private string FormatStatCore(string core)
	{
		return null;
	}

	public void SetStatValue(float value, bool animate = false)
	{
	}

	public void SetStatValue(string value)
	{
	}
}
