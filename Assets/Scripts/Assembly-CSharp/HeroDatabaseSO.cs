using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroDatabaseSO", menuName = "Fubu/Hero/Hero Database")]
public class HeroDatabaseSO : ScriptableObject
{
	[Header("Hero Level Up Config")]
	[SerializeField]
	private HeroLevelUpConfigData heroLevelUpConfig;

	[Header("Hero Ascend Config")]
	[SerializeField]
	private HeroAscendConfigData heroAscendConfig;

	[Header("Hero Global Trait Config")]
	[SerializeField]
	private HeroGlobalTraitConfigData heroGlobalTraitConfig;

	[Header("Heroes")]
	[SerializeField]
	private List<HeroData> heroes;

	public HeroLevelUpConfigData HeroLevelUpConfig => null;

	public HeroAscendConfigData HeroAscendConfig => null;

	public HeroGlobalTraitConfigData HeroGlobalTraitConfig => null;

	public IReadOnlyList<HeroData> Heroes => null;

	public HeroData GetHero(string heroId)
	{
		return null;
	}

	public bool TryGetHero(string heroId, out HeroData hero)
	{
		hero = null;
		return false;
	}

	private void OnValidate()
	{
	}
}
