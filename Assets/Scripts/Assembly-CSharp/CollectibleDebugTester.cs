using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleDebugTester : MonoBehaviour
{
	[SerializeField]
	private CollectiblesSO collectiblesSO;

	[SerializeField]
	private TMP_Dropdown collectibleDropdown;

	[SerializeField]
	private TMP_InputField amountInput;

	[SerializeField]
	private TextMeshProUGUI infoText;

	[SerializeField]
	private Button addPiecesButton;

	[SerializeField]
	private int defaultAmount;

	private readonly List<CollectiblesSO.CollectibleData> selectableCollectibles;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void PopulateDropdown()
	{
	}

	public void AddPiecesFromInput()
	{
	}

	public void AddOnePiece()
	{
	}

	public void AddTenPieces()
	{
	}

	public void AddRequiredPiecesForNextLevel()
	{
	}

	public void AddPieces(int amount)
	{
	}

	public void SetCollectiblesSO(CollectiblesSO value)
	{
	}

	private void HandleDropdownChanged(int index)
	{
	}

	private CollectiblesSO.CollectibleData GetSelectedCollectible()
	{
		return null;
	}

	private void RefreshInfo()
	{
	}
}
