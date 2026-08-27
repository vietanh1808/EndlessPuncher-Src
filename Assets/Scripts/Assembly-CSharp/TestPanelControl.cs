using System;
using TMPro;
using UnityEngine;

public class TestPanelControl : MonoBehaviour
{
	public Animator animPanel;

	public TMP_Dropdown dropdownActiveUpgrade;

	public TMP_Dropdown dropdownForSkills;

	public TMP_Dropdown dropdownForTalents;

	public TMP_Dropdown dropdownForItemSpecial;

	public TMP_Dropdown dropdownForItemSpecialValue;

	private void Start()
	{
	}

	public void ActivatePanel()
	{
	}

	public void DeactivatePanel()
	{
	}

	private void SetDropdownWithEnum<T>(TMP_Dropdown targetDropdown) where T : Enum
	{
	}

	public void SelectedActiveUpgrade()
	{
	}

	public void SelectedActiateSkills()
	{
	}

	public void SelectedActiateTalent()
	{
	}

	public void SelectedActiateItemBonuses()
	{
	}

	private float GetEnumValue(itemBonusAmouth bb)
	{
		return 0f;
	}
}
