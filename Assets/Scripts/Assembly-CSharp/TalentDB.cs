using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TalentDB", menuName = "DBs/TalentDB", order = 0)]
public class TalentDB : ScriptableObject
{
	[Serializable]
	public class Talent
	{
		public string name;

		public string description;

		public TalentType typeOfTalent;

		public TalentRarity rare;

		public bool isActivated;

		public float effetValue;

		public string prefix;

		public string suffix;

		public Sprite icon;
	}

	public List<Talent> allTalents;

	public TalentTierDB talentTierDB;

	public Talent GetTalentOwn(TalentType type)
	{
		return null;
	}

	public Sprite GetTalentIcon(TalentType type)
	{
		return null;
	}

	public Talent GetRandomTalentType(TalentRarity rare)
	{
		return null;
	}

	public List<Talent> GetRandomTalents(int amount)
	{
		return null;
	}

	private bool IsRarityNotHave(TalentRarity rare)
	{
		return false;
	}

	private List<Talent> GetAvailableTalents(TalentRarity rare)
	{
		return null;
	}

	private TalentRarity GetRandomRarity(int totalChance)
	{
		return TalentRarity.Common;
	}

	public TalentType GetTalentWID(int id)
	{
		return TalentType.none;
	}
}
