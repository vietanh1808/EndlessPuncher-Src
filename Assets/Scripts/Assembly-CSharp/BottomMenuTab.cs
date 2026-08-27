using UnityEngine;
using UnityEngine.UI;

public class BottomMenuTab : MonoBehaviour
{
	private enum TabState
	{
		Normal = 0,
		Selected = 1,
		Locked = 2
	}

	private TabState currentState;

	[Header("Settings")]
	[SerializeField]
	private MonoBehaviour targetPanelObject;

	private ITabPanel targetPanel;

	private ITabUnlockCondition unlockCondition;

	[Header("UI Referances")]
	[SerializeField]
	private GameObject normalBG;

	[SerializeField]
	private GameObject selectedBG;

	[SerializeField]
	private GameObject lockedBG;

	[SerializeField]
	private GameObject notificationIcon;

	[SerializeField]
	private Animator animator;

	private Button button;

	public RectTransform RectTransform => null;

	public Button Button => null;

	public bool IsUnlocked => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void OnClick()
	{
	}

	public void ShowNotification()
	{
	}

	public void HideNotification()
	{
	}

	private void CheckUnlockState()
	{
	}

	private void ShowPanel()
	{
	}

	private void HidePanel()
	{
	}

	public void SelectTab()
	{
	}

	public void DeselectTab()
	{
	}

	private void LockTab()
	{
	}

	private void UnlockTab()
	{
	}

	private void UpdateUI()
	{
	}
}
