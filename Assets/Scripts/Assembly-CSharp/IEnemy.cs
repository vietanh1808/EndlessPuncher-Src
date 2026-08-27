using UnityEngine;

public interface IEnemy
{
	void AttackCompleted();

	void TakeDamage(float damage, bool isCrit, EffectTypeDuration type);

	void TakeDamageOnlyEffect(EffectTypeDuration type);

	void TakeDamage(float damage, bool isCrit, bool isOnlyTDHit = false);

	void TakeDamage(Vector3 directionKnockback, float damage);

	void AddForce(Vector3 directionKnockback, float force);

	void VoidEffect();

	void Die();

	bool IsAlive();

	bool IsLifeStealActive(float value);

	GameObject GetGameObject();

	void StartEnemy(float hpValue, float damage);

	void StartEnemyForSkillTestScene(float hpValue, float damage, bool isCanMove);

	Transform GetTDPos();

	void Freeze(bool slowStarted);

	void StunActive();

	bool IsElitEnemy();
}
