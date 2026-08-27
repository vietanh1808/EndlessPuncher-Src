using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventPassSO", menuName = "Fubu/Event Pass/Event Pass")]
public class EventPassSO : ScriptableObject
{
	[SerializeField]
	private CurrencyTypes targetCurrencyType;

	[SerializeField]
	[Min(1f)]
	private float rewardPassMultiplier;

	[SerializeField]
	private List<string> battlePassNames;

	[SerializeField]
	private List<EventPassRewardEntry> rewards;

	public CurrencyTypes TargetCurrencyType => CurrencyTypes.Coins;

	public float RewardPassMultiplier => 0f;

	public IReadOnlyList<string> BattlePassNames => null;

	public IReadOnlyList<EventPassRewardEntry> Rewards => null;

	public EventPassRewardEntry GetReward(int index)
	{
		return null;
	}

	public string GetBattlePassName(int index)
	{
		return null;
	}
}
