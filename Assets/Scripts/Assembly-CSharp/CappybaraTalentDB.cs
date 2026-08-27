using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CappybaraTalentDB", menuName = "DBs/CappybaraTalentDB")]
public class CappybaraTalentDB : ScriptableObject
{
	[Serializable]
	public class CappyTalent
	{
		public string nameStage;

		public int levelLength;

		public LeaguePrizeMoneyAmount[] leaguePrizeMoneyAmount;

		public TalentLeaguesType typeMileStone;

		public PrizeTalent[] prizeTalents;

		public float goldRewardMultiplier;

		public float moneyStart;

		public float moneyIncrease;
	}

	[Serializable]
	public class LeaguePrizeMoneyAmount
	{
		public int priceStart;

		public int[] prizeIncrease;
	}

	[Serializable]
	public class PrizeTalent
	{
		public PrizeTalentType type;

		public float value;

		public PrizeTalent()
		{
		}

		public PrizeTalent(PrizeTalent pp)
		{
		}
	}

	[Serializable]
	public class PrizeTalentDescript
	{
		public PrizeTalentType type;

		public string description;
	}

	[Serializable]
	public class SerializableList<T>
	{
		public List<T> list;
	}

	public List<CappyTalent> allTalentReview;

	public List<PrizeTalentDescript> prizeTalentDescript;

	public List<PrizeTalent> collectedTalentReview;

	public int GetIncreaseValue(int lvl, int iorder)
	{
		return 0;
	}

	public int GetPriceValue(int lvl)
	{
		return 0;
	}

	public int[] GetAllReward(CappyTalent talent, int prizeOrder)
	{
		return null;
	}

	public int[] GetAllRewardsUntil(CappyTalent talent)
	{
		return null;
	}

	public float GetAllEarnedWType(PrizeTalentType type)
	{
		return 0f;
	}

	public string GetPreviousLeague(TalentLeaguesType type, int order)
	{
		return null;
	}

	public TalentLeaguesType GetPreviousLeague(TalentLeaguesType type, int order, out int retOut)
	{
		retOut = default;
		return TalentLeaguesType.Rookie;
	}

	public string FormatLeagueLabel(TalentLeaguesType type, int zeroBasedOrder)
	{
		return null;
	}

	public float GetPrizeDisplayValue(CappyTalent talent, PrizeTalent prizeTalent)
	{
		return 0f;
	}

	public float GetGoldRewardValue(CappyTalent talent, int prizeIndex)
	{
		return 0f;
	}

	private int GetPrizeIndex(CappyTalent talent, PrizeTalent prizeTalent)
	{
		return 0;
	}

	private int GetGlobalPrizeOrder(CappyTalent talent, int prizeIndex)
	{
		return 0;
	}

	public void RefreshGoldPrizeValues()
	{
	}

	public void CollectTalent(CappyTalent talent, PrizeTalent prize)
	{
	}

	public void CollectTalent(PrizeTalent prize)
	{
	}

	public float GetTalentPrizes(PrizeTalentType prizeType)
	{
		return 0f;
	}

	public void SaveOwnedItems()
	{
	}

	public void GetSavedPrizes()
	{
	}

	public List<PrizeTalent> GetSavedItems()
	{
		return null;
	}
}
