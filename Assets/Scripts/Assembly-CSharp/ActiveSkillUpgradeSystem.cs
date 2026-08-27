using System.Collections.Generic;
using UnityEngine;

public class ActiveSkillUpgradeSystem : MonoBehaviour
{
	private static ActiveSkillUpgradeSystem _instance;

	private GameManager _gm;

	private HpBehaviour _hpPlayer;

	public bool isTestScene;

	public List<StatDB.ActiveUpgrades> savedlist;

	private bool _burnDurationIsActive;

	private float _burnDuration;

	private bool _lightningDurationIsActive;

	private float _lightningDuration;

	private bool _freezeDurationIsActive;

	private float _freezeDuration;

	private bool _burnExpoPunchIsActive;

	private float _burnExpoPunch;

	private bool _iceShardIsActive;

	private float _iceShard;

	private bool _electrocutedJumpIsActive;

	private float _electrocutedJump;

	private bool _lightningAllDamageIsActive;

	private float _lightningAllDamage;

	private bool _burnAllDamageIsActive;

	private float _burnAllDamage;

	private bool _freezeAllDamageIsActive;

	private float _freezeAllDamage;

	private bool _lightningCanBurnIsActive;

	private float _lightningCanBurn;

	private bool _freezeCanBurnIsActive;

	private float _freezeCanBurn;

	private int _counterChargedFocus;

	private bool _lightning5EnemyIncCritChanceIsActive;

	private float _lightning5EnemyIncCritChance;

	private int _counterHearSiphon;

	private bool _burn10EnemyIncHpRecoveryIsActive;

	private float _burn10EnemyIncHpRecovery;

	private int _counterColdRush;

	private bool _freeze10EnemyIncRateIsActive;

	private float _freeze10EnemyIncRate;

	private bool _burnCanstackIsActive;

	private float _burnCanstack;

	public static ActiveSkillUpgradeSystem Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void AddTestActiveUpgrade(StatDB.ActiveUpgrades item)
	{
	}

	public void ResetForNewRun()
	{
	}

	public void GetActiveUpgradesInLevel()
	{
	}

	public float GetBurnDuration(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetLightningDuration(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetFreezeDuration(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetBurnExpoPunch(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetIceShard(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetElectrocutedJump(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetLightningAllDamage(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetBurnAllDamage(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetFreezeAllDamage(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetLightningCanBurn(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetFreezeCanBurn(out bool value)
	{
		value = default;
		return 0f;
	}

	public void ChargedFocusIncrease()
	{
	}

	public float GetLightning5EnemyIncCrit(out bool value)
	{
		value = default;
		return 0f;
	}

	public void HearSiphonIncrease()
	{
	}

	public float GetBurn10EnemyHpReco(out bool value)
	{
		value = default;
		return 0f;
	}

	public void ColdRushIncrease()
	{
	}

	public float GetFreeze10EnemyIncRate(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetBurnCanStack(out bool value)
	{
		value = default;
		return 0f;
	}

	public float GetSkillDuration(SkillType skillType)
	{
		return 0f;
	}

	public float GetSkillEffectDuration(SkillType skillType)
	{
		return 0f;
	}

	public float GetEffectDamages(EffectType typeEffect)
	{
		return 0f;
	}
}
