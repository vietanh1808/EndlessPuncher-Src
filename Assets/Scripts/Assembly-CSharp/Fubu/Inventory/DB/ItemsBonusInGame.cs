using System.Collections.Generic;
using UnityEngine;

namespace Fubu.Inventory.DB
{
	public class ItemsBonusInGame : MonoBehaviour
	{
		private static ItemsBonusInGame _instance;

		public float[] specialEffectFromTestScene;

		private ItemPanelHandler itemDB;

		[SerializeField]
		private RingUpgradeSO ringUpgradeSO;

		[SerializeField]
		private CollectiblesSO collectiblesSO;

		private List<ItemSpecialEffect> allSpecialEffects;

		private float _punchRange;

		private bool _punchRangeIsActive;

		private float _skillDamage;

		private bool _skillDamageIsActive;

		private float _critDamage;

		private bool _critDamageIsActive;

		private float _critChance;

		private bool _critChanceIsActive;

		private float _knockBack;

		private bool _knockBackIsActive;

		private float _shield;

		private bool _shieldIsActive;

		private float _defenceGainAfterKillingenemy;

		private bool _defenceGainAfterKillingenemyIsActive;

		private float _massiveShieldHealDrop;

		private bool _massiveShieldHealDropIsActive;

		private float _damageIncreaseBelowHP;

		private bool _damageIncreaseBelowHPIsActive;

		private float _burnDamageBonus;

		private bool _burnDamageBonusIsActive;

		private float _burnDurationBonus;

		private bool _burnDurationBonusIsActive;

		private float _burnStackLimitIncrease;

		private bool _burnStackLimitIncreaseIsActive;

		private float _freezeDamageBonus;

		private bool _freezeDamageBonusIsActive;

		private float _freezeDurationBonus;

		private bool _freezeDurationBonusIsActive;

		private float _lightningDamageBonus;

		private bool _lightningDamageBonusIsActive;

		private float _lightningDurationBonus;

		private bool _lightningDurationBonusIsActive;

		private float _lightningSkillsDamageBonus;

		private bool _lightningSkillsDamageBonusIsActive;

		private float _lightningStunDuration;

		private bool _lightningStunDurationIsActive;

		private float _damageBossBonus;

		private bool _damageBossBonusIsActive;

		private float _extraArm;

		private bool _extraArmIsActive;

		private float _extraArmIncreasePunchDamage;

		private bool _extraArmIncreasePunchDamageIsActive;

		private float _extraArmIncreaseDefence;

		private bool _extraArmIncreaseDefenceIsActive;

		private float _extraArmIncreaseCritDamage;

		private bool _extraArmIncreaseCritDamageIsActive;

		private float _extraArmIncreasSkillDamage;

		private bool _extraArmIncreasSkillDamageIsActive;

		private float _goldGainFromEnemies;

		private bool _goldGainFromEnemiesIsActive;

		private float _comboMetersDrainRate;

		private bool _comboMetersDrainRateIsActive;

		private float _extraDamageComboMeters;

		private bool _extraDamageComboMetersIsActive;

		private float _punchRateIncreaseComboMeterx5s;

		private bool _punchRateIncreaseComboMeterx5sIsActive;

		private float _gainShieldComboReachedx3;

		private bool _gainShieldComboReachedx3IsActive;

		private float _comboMeterDrainSlower;

		private bool _comboMeterDrainSlowerIsActive;

		private float _receivedDamageReduceBelowHP;

		private bool _receivedDamageReduceBelowHPIsActive;

		private float _freezingEnemiesRestoreHP;

		private bool _freezingEnemiesRestoreHPIsActive;

		private float _reviveWithHpAfterDeath;

		private bool _reviveWithHpAfterDeathIsActive;

		private float _receivedDamageReducer;

		private bool _receivedDamageReducerIsActive;

		private float _levelUpsRestore;

		private bool _levelUpsRestoreIsActive;

		private float _punchCountDecreasedSkillActivation;

		private bool _punchCountDecreasedSkillActivationIsActive;

		private float _instantKillNonElitEnemies;

		private bool _instantKillNonElitEnemiesIsActive;

		private float _reflectReceivedDamageToAttacker;

		private bool _reflectReceivedDamageToAttackerIsActive;

		private float _decatingHealthInsteadofDying;

		private bool _decatingHealthInsteadofDyingIsActive;

		public static ItemsBonusInGame Instance => null;

		private void Awake()
		{
		}

		public void AddSpecialEffectForTest(ItemSpecialEffect item, float amouth)
		{
		}

		private void Start()
		{
		}

		public void GetAllBonuses()
		{
		}

		private float GetAllActiveBonus(ItemSpecialEffect item)
		{
			return 0f;
		}

		private float GetRingUpgradeBonus(ItemSpecialEffect item)
		{
			return 0f;
		}

		private float GetCollectibleBonus(ItemSpecialEffect item)
		{
			return 0f;
		}

		public bool GetPunchRange(out float value)
		{
			value = default;
			return false;
		}

		public bool GetSkillDamage(out float value)
		{
			value = default;
			return false;
		}

		public bool GetCritDamage(out float value)
		{
			value = default;
			return false;
		}

		public bool GetCritChance(out float value)
		{
			value = default;
			return false;
		}

		public bool GetKnockBack(out float value)
		{
			value = default;
			return false;
		}

		public bool GetShield(out float value)
		{
			value = default;
			return false;
		}

		public bool GetDefenceGainAfterKilling(out float value)
		{
			value = default;
			return false;
		}

		public bool GetMassivetShield(out float value)
		{
			value = default;
			return false;
		}

		public bool GetDamageIncreaaseBelowHP(out float value)
		{
			value = default;
			return false;
		}

		public bool GetBurnDamageBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetBurnDurationBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetBurnStackLimitBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetFreezeDamageBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetFreezeDurationBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetLightningDamageBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetLightningDurationBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetLightningSkillsDamageBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetLightningStunDuration(out float value)
		{
			value = default;
			return false;
		}

		public bool GetDamageBossBonus(out float value)
		{
			value = default;
			return false;
		}

		public bool GetExtraArm(out float value)
		{
			value = default;
			return false;
		}

		public bool GetExtraArmIncreasePunchDamage(out float value)
		{
			value = default;
			return false;
		}

		public bool GetExtraArmIncreaseDefence(out float value)
		{
			value = default;
			return false;
		}

		public bool GetExtraArmIncreaseCritDamage(out float value)
		{
			value = default;
			return false;
		}

		public bool GetExtraArmIncreaseSkillDamage(out float value)
		{
			value = default;
			return false;
		}

		public bool GetGoldGainFromEnemies(out float value)
		{
			value = default;
			return false;
		}

		public bool GetComboMetersDrainRate(out float value)
		{
			value = default;
			return false;
		}

		public bool GetExtraDamageComboMeters(out float value)
		{
			value = default;
			return false;
		}

		public bool GetPunchRateIncreaseComboMeterx5s(out float value)
		{
			value = default;
			return false;
		}

		public bool GetGainShieldComboReachedx3(out float value)
		{
			value = default;
			return false;
		}

		public bool GetComboMeterDrainSlower(out float value)
		{
			value = default;
			return false;
		}

		public bool GetReceivedDamageReduceBelowHP(out float value)
		{
			value = default;
			return false;
		}

		public bool GetFreezingEnemiesRestoreHP(out float value)
		{
			value = default;
			return false;
		}

		public bool GetReviveWithHpAfterDeath(out float value)
		{
			value = default;
			return false;
		}

		public bool GetReceivedDamageReducer(out float value)
		{
			value = default;
			return false;
		}

		public bool GetLevelUpsRestore(out float value)
		{
			value = default;
			return false;
		}

		public bool GetPunchCountDecreasedSkillActivation(out float value)
		{
			value = default;
			return false;
		}

		public bool GetInstantKillNonElitEnemies(out float value)
		{
			value = default;
			return false;
		}

		public bool GetReflectReceivedDamageToAttacker(out float value)
		{
			value = default;
			return false;
		}

		public bool GetDecatingHealthInsteadofDying(out float value)
		{
			value = default;
			return false;
		}
	}
}
