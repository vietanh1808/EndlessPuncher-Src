using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestHeroEarnedPanel : MonoBehaviour
{
	private static ChestHeroEarnedPanel _instance;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private Animator panelAnim;

	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private Button closeButton2;

	[SerializeField]
	private ParticleSystem confettie;

	[SerializeField]
	private ChestHeroDrop chestHeroDropPrefab;

	[SerializeField]
	private Transform rewardsHolder;

	private readonly List<ChestHeroDrop> spawnedDrops;

	private bool isPanelActive;

	public static ChestHeroEarnedPanel Instance => null;

	public bool IsPanelActive => false;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void LoadHero(HeroData heroData, int amount, ChestHeroDrop.DropRarity rarity, bool isShard)
	{
	}

	public void LoadCurrency(CurrencyTypes currencyType, int amount)
	{
	}

	public void BeginLoad()
	{
	}

	public void AddHero(HeroData heroData, int amount, ChestHeroDrop.DropRarity rarity, bool isShard)
	{
	}

	public void AddCurrency(CurrencyTypes currencyType, int amount)
	{
	}

	public void ShowLoadedRewards()
	{
	}

	public void ClosePanel()
	{
	}

	private ChestHeroDrop CreateDrop()
	{
		return null;
	}

	private void ClearDrops()
	{
	}

	private void DelayClose()
	{
	}

	private void PlayConfettie()
	{
	}
}
