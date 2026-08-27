using UnityEngine;

public interface IHPControl
{
	void SetHpValue(float damage, GameObject owner);

	void SetTotalHp(float totalHp);

	Transform GetTarget();
}
