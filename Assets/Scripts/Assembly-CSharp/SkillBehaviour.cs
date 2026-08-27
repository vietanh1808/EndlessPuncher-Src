using System.Collections.Generic;
using UnityEngine;

public class SkillBehaviour : MonoBehaviour, IAbility
{
	private static readonly HashSet<SkillBehaviour> ActiveSkills;

	public SkillType typeSkill;

	public EffectType typeEffect;

	[Header("Physics")]
	public LayerMask maskEnemy;

	private static readonly Collider[] _cols;

	private readonly Dictionary<Collider, IEnemy> _enemyCache;

	private float _cachedCooldown;

	public float _cachedDamage;

	public float _cachedCritChance;

	public float _cachedCritDamage;

	private float _cachedKnockback;

	private float _cachedLifeSteal;

	private GameManager gm;

	private InGameUI ui;

	private float _cdCounter;

	private float _duration;

	private float _coolDown;

	private float _inGameCoolDown;

	private float _inGameDamage;

	private float _skillCount;

	private float _inGameSkillCount;

	public float Cooldown => 0f;

	public float Damage => 0f;

	public float CritChance => 0f;

	public float CritDamage => 0f;

	public float Knockback => 0f;

	public float SkillCount => 0f;

	public float Lifesteal => 0f;

	public virtual void StartAbility()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void ResetForNewRun()
	{
	}

	public static void ResetAllForNewRun()
	{
	}

	public void AttackInRange(Transform point, float range)
	{
	}

	public void AttackInRangeAndThrow(Transform point, float range)
	{
	}

	private IEnemy GetEnemy(Collider col)
	{
		return null;
	}

	public static IEnemy ResolveEnemy(Collider col)
	{
		return null;
	}

	public static IEnemy ResolveEnemy(GameObject enemy)
	{
		return null;
	}

	public static T ResolveComponent<T>(GameObject target) where T : class
	{
		return null;
	}

	public void RefreshCachedStats()
	{
	}

	public void StartCommonInit()
	{
	}

	public void CdCounter()
	{
	}

	public float GetSkillDuration()
	{
		return 0f;
	}
}
