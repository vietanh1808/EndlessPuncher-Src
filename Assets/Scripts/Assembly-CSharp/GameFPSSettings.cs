using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameFPSSettings : MonoBehaviour
{
	private const string SliderValueSaveKey = "GameFPSSettings.SliderValue";

	public Slider sliderFps;

	public TextMeshProUGUI fpsText;

	[SerializeField]
	private float defaultSliderValue;

	private static float defaultSliderValueFallback;

	private static int desiredTargetFrameRate;

	private bool isUpdatingSlider;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void ConfigureSlider()
	{
	}

	private void OnSliderValueChanged(float value)
	{
	}

	private void ApplyFromSlider()
	{
	}

	private void ResolveSliderReference()
	{
	}

	private void SetSliderValueWithoutNotify(float value)
	{
	}

	private static float GetSavedSliderValue(float fallbackSliderValue)
	{
		return 0f;
	}

	private static float SnapSliderValue(float value)
	{
		return 0f;
	}

	private static int GetTargetFrameRate(float sliderValue)
	{
		return 0;
	}

	private static void ApplyFrameRateForSliderValue(float sliderValue)
	{
	}

	private void UpdateFpsText(int value)
	{
	}

	public static void ApplySavedFrameRate()
	{
	}
}
