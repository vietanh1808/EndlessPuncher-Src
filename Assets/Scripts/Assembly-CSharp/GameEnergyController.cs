using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEnergyController : Singleton<GameEnergyController>
{
	private const int MinEnergyValue = 0;

	private const int MaxEnergyValue = 4;

	[CompilerGenerated]
	private static Action m_IncreaseButtonInteractableChanged;

	[Header("Panels")]
	[SerializeField]
	private GameObject regularStarterParent;

	[SerializeField]
	private GameObject energyMultiplierParent;

	[Header("Energy Slider")]
	[SerializeField]
	private Slider energySlider;

	[SerializeField]
	private Button decreaseButton;

	[SerializeField]
	private Button increaseButton;

	[SerializeField]
	private Button startEnergyBtn;

	[SerializeField]
	private Button energyBtnDeactive;

	[SerializeField]
	private TextMeshProUGUI startEnergy;

	[SerializeField]
	private TextMeshProUGUI needEnergyForDeactifBtn;

	[SerializeField]
	private List<GameEnergySliderStop> sliderStops;

	private bool lastCanIncreaseWithEnoughEnergy;

	public int CurrentEnergyValue { get; private set; }

	public GameEnergySliderStop CurrentStop => null;

	public float CurrentMultiplier => 0f;

	public int CurrentEnergyAmount => 0;

	public Transform IncreaseButtonTransform => null;

	public Transform StartEnergyButtonTransform => null;

	public bool IsStartEnergyButtonActive => false;

	public bool IsIncreaseButtonInteractable => false;

	public bool CanIncreaseWithEnoughEnergy => false;

	public static event Action IncreaseButtonInteractableChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void ConfigureSlider()
	{
	}

	private void AddButtonListeners()
	{
	}

	private void RemoveButtonListeners()
	{
	}

	private void OnSliderValueChanged(float value)
	{
	}

	public void IncreaseEnergyValue()
	{
	}

	public void DecreaseEnergyValue()
	{
	}

	public void SetEnergyValue(int value)
	{
	}

	public void RefreshForSoftRestart()
	{
	}

	public void StartLevelWithSelectedEnergy()
	{
	}

	private int GetSliderValue()
	{
		return 0;
	}

	private int GetAffordableSoftRestartSliderValue(int currentSliderValue)
	{
		return 0;
	}

	private bool CanStartWithSliderValue(int sliderValue)
	{
		return false;
	}

	private void RefreshButtonStates()
	{
	}

	private void RefreshSliderStops()
	{
	}

	private void RefreshEnergyStartState()
	{
	}

	private GameEnergySliderStop GetCurrentStop()
	{
		return null;
	}

	private int GetCurrentEnergy()
	{
		return 0;
	}

	private void RefreshStarterParents()
	{
	}

	private bool IsEnergyUnlocked()
	{
		return false;
	}

	private void SetStartButtonActive(bool isActive)
	{
	}

	private void SetDeactiveButtonActive(bool isActive)
	{
	}

	private void NotifyIncreaseButtonInteractableChangedIfNeeded(bool force = false)
	{
	}
}
