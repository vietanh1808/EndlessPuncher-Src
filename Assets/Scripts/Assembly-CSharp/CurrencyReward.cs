using Fubu.Essentials;
using UnityEngine;

[CreateAssetMenu(menuName = "Fubu/Dungeon/Rewards/CurrencyReward")]
public class CurrencyReward : RewardItem
{
	public CurrencyTypes targetCurrency;

	public override void Grant(int amount)
	{
	}
}
