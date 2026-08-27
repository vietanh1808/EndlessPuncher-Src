using Fubu.Essentials;
using UnityEngine;

[CreateAssetMenu(menuName = "Fubu/Dungeon/Rewards/KeyReward")]
public class KeyReward : RewardItem
{
	public ChestTypes chestType;

	public override void Grant(int amount)
	{
	}
}
