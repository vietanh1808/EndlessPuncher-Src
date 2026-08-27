using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HeroConquestPanel : MonoBehaviour, ITabPanel
{
	[Header("Panel")]
	[SerializeField]
	private GameObject panelObject;

	[SerializeField]
	private GameObject heroCurrency;

	[SerializeField]
	private GameObject heroButtoninTabToStarPanel;

	[Header("Progress")]
	[SerializeField]
	private HeroStageProgress heroStageProgress;

	[SerializeField]
	private TextMeshProUGUI currentStageText;

	[Header("Collection")]
	[SerializeField]
	private HeroCardsHolder heroCardsHolder;

	[Header("Buttons")]
	[SerializeField]
	private Button fightButton;

	[SerializeField]
	private Button chestButton;

	[SerializeField]
	private Button heroCollectionButton;

	[Header("Navigation Events")]
	[SerializeField]
	private UnityEvent fightButtonClicked;

	[SerializeField]
	private UnityEvent chestButtonClicked;

	[SerializeField]
	private UnityEvent heroCollectionButtonClicked;

	private int currentHeroStage;

	private bool listenersRegistered;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Refresh()
	{
	}

	public void OnFightButtonClicked()
	{
	}

	public void OnChestButtonClicked()
	{
	}

	public void OnHeroCollectionButtonClicked()
	{
	}

	private void RegisterButtonListeners()
	{
	}

	private void UnregisterButtonListeners()
	{
	}

	private GameObject GetPanelObject()
	{
		return null;
	}

	private void RefreshCurrentStageText()
	{
	}

	private void RefreshHeroStageProgress()
	{
	}

	private void RefreshButtonStates()
	{
	}
}
