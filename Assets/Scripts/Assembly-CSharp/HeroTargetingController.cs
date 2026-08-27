using System.Collections.Generic;
using UnityEngine;

public class HeroTargetingController : MonoBehaviour
{
	private static readonly List<Transform> EmptyTargets;

	[SerializeField]
	private HeroCombatController combatController;

	private readonly List<Transform> resolvedTargets;

	private void Awake()
	{
	}

	public Transform FindClosestEnemy()
	{
		return null;
	}

	public Transform FindClosestEnemy(Vector3 origin)
	{
		return null;
	}

	public Transform ResolveSingleTarget(HeroTargetType targetType, HeroAbilityContext context)
	{
		return null;
	}

	public IReadOnlyList<Transform> ResolveTargets(HeroTargetType targetType, HeroAbilityContext context, float range = 0f)
	{
		return null;
	}

	public bool TryResolveTargetPosition(HeroAbilityContext context, out Vector3 targetPosition)
	{
		targetPosition = default;
		return false;
	}

	public bool IsValidEnemyTarget(Transform target)
	{
		return false;
	}

	private Transform GetValidCurrentEnemy(HeroAbilityContext context)
	{
		return null;
	}

	private Transform GetRandomEnemy()
	{
		return null;
	}

	private Transform GetLowestHealthEnemy()
	{
		return null;
	}

	private void AddAllEnemies()
	{
	}

	private void AddNearbyEnemies(Vector3 origin, float range)
	{
	}

	private void AddAllAllies()
	{
	}

	private void AddNearbyAllies(Vector3 origin, float range)
	{
	}

	private void AddResolvedTarget(Transform target)
	{
	}

	private Vector3 GetOrigin(HeroAbilityContext context)
	{
		return default;
	}

	private static float GetPlanarSqrDistance(Vector3 from, Vector3 to)
	{
		return 0f;
	}
}
