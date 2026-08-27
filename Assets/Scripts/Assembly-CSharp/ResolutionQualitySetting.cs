using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionQualitySetting : MonoBehaviour
{
	private const string PlayerPrefsKey = "ResolutionQualityStep";

	private const int MinStep = 0;

	private const int MaxStep = 20;

	private const float MinScale = 0.2f;

	private const float MaxScale = 1f;

	private const float DefaultScale = 1f;

	[SerializeField]
	private Slider resolutionQualitySlider;

	[SerializeField]
	private TextMeshProUGUI resolutionQualityText;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ConfigureSlider()
	{
	}

	private void LoadSavedValue()
	{
	}

	private void OnSliderValueChanged(float value)
	{
	}

	private void ApplyStep(int step, bool save)
	{
	}

	private static float StepToScale(int step)
	{
		return 0f;
	}

	private static int ScaleToStep(float scale)
	{
		return 0;
	}

	private static float GetCurrentRenderScale()
	{
		return 0f;
	}

	private static void ApplyRenderScale(float scale)
	{
	}
}
