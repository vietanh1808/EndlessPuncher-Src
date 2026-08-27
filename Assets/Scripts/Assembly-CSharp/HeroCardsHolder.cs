using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HeroCardsHolder : MonoBehaviour, ITabPanel
{
	[Header("Panel")]
	[SerializeField]
	private GameObject panelObject;

	[Header("Data")]
	[SerializeField]
	private HeroDatabaseSO heroDatabase;

	[SerializeField]
	private HeroCardsSortMode sortMode;

	[Header("Cards")]
	[SerializeField]
	private HeroCard heroCardPrefab;

	[SerializeField]
	private Transform cardsContainer;

	[Header("Selection")]
	[SerializeField]
	private HeroInfoPanel heroInfoPanel;

	private readonly List<HeroCard> cards;

	private readonly List<HeroData> sortedHeroes;

	[CompilerGenerated]
	private Action<HeroData, HeroProgressData> m_HeroSelected;

	public HeroDatabaseSO HeroDatabase => null;

	public event Action<HeroData, HeroProgressData> HeroSelected
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

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Refresh()
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

	private void BuildSortedHeroes()
	{
	}

	private void EnsureCardCount(int requiredCardCount)
	{
	}

	private void DisableExtraCards(int activeCardCount)
	{
	}

	private GameObject GetPanelObject()
	{
		return null;
	}

	private HeroProgressData GetProgressData(HeroData heroData)
	{
		return null;
	}

	private void HandleCardClicked(HeroCard card)
	{
	}

	private int CompareUnlockedFirst(HeroData left, HeroData right)
	{
		return 0;
	}

	private int CompareRarity(HeroData left, HeroData right)
	{
		return 0;
	}

	private int CompareLevel(HeroData left, HeroData right)
	{
		return 0;
	}

	private int CompareStar(HeroData left, HeroData right)
	{
		return 0;
	}

	private int CompareDatabaseOrder(HeroData left, HeroData right)
	{
		return 0;
	}

	private bool IsUnlocked(HeroData heroData)
	{
		return false;
	}

	private string GetRaritySortValue(HeroData heroData)
	{
		return null;
	}

	private int GetDatabaseIndex(HeroData heroData)
	{
		return 0;
	}

	private static string GetHeroId(HeroData heroData)
	{
		return null;
	}
}
