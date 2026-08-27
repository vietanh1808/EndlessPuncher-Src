using System;
using System.Collections.Generic;
using Fubu.Inventory.DB;
using TMPro;
using UnityEngine;

public class EnemyEffectHolder : MonoBehaviour
{
	[Serializable]
	public class EffectIconControl
	{
		public bool isActive;

		public EffectType type;

		public TextMeshProUGUI textEffect;

		public GameObject icon;

		private int effectCounter;

		public int EffectCounter => 0;

		public void ActivateIcon()
		{
		}

		public void DeActivateIcon()
		{
		}

		public void Reset()
		{
		}

		private void TextStackingEffect()
		{
		}
	}

	[Serializable]
	private class EffectHolder
	{
		private EffectType _typeEffect;

		private IEnemyHealth _enemyHP;

		private IEnemy _ienemy;

		private float _duration;

		private float _damage;

		private bool _isEffectActive;

		private float _givenDamage;

		private float timeHolder;

		public EffectType TypeEffect => EffectType.none;

		public bool IsEffectActive => false;

		public EffectHolder(IEnemy ienemy, IEnemyHealth enemyHP, EffectType typeEffect, float duration, float damage)
		{
		}

		public void UseEffect(float timer)
		{
		}
	}

	[SerializeField]
	private float effectTickInterval;

	public ParticleSystem fireEffectParticle;

	public ParticleSystem IceEffectParticle;

	public ParticleSystem lightningEffectParticle;

	public List<EffectIconControl> effectControl;

	private List<EffectHolder> allEffects;

	private IEnemyHealth _enemyHP;

	private ItemsBonusInGame itemBonus;

	private PlayerActiveUpgradeVisualizer _playerActiveVisualizer;

	private IEnemy _ienemy;

	private PlayerStatController _playerStatC;

	private float effectTickTimer;

	[SerializeField]
	private bool isFirePlaying;

	[SerializeField]
	private bool isIcePlaying;

	[SerializeField]
	private bool isLightningPlaying;

	public void ActivateEffect(EffectType type, bool isActive = true)
	{
	}

	private void Start()
	{
	}

	public void ResetAllEffects()
	{
	}

	private void Update()
	{
	}

	private void ControlAllEffects(float tickDelta)
	{
	}

	public void DieEffects()
	{
	}

	private void EffectParticleController()
	{
	}

	public void AddEffect(EffectTypeDuration effectTypeDuration)
	{
	}

	private void EnsureReferences()
	{
	}

	private void SetFreeze(bool isActive)
	{
	}

	private void SetStunEnemy()
	{
	}

	public bool IsUnderBurnEffect()
	{
		return false;
	}

	public bool IsUnderFreezEffect()
	{
		return false;
	}

	public bool IsUnderLightningEffect()
	{
		return false;
	}

	public void DeDeactivateFreezEffect()
	{
	}

	public void DeDeactivateFireEffect()
	{
	}

	public void DeDeactivateLightningEffect()
	{
	}
}
