using UnityEngine;

internal interface IDummyBox
{
	void TakeDamage(float damageValue, Vector3 damagePoint);

	void ResetStatValue(float value, PlayerStatType typ);
}
