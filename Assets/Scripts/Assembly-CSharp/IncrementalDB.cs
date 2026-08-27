using System;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "IncrementalDB", menuName = "DBs/IncrementalDB")]
public class IncrementalDB : ScriptableObject
{
	public enum IncrementalType
	{
		ExtraArm = 0,
		MaxHP = 1,
		Income = 2
	}

	[Serializable]
	public class IncrementalDefinition
	{
		public int id;

		public IncrementalType type;

		public string displayName;

		public float baseValue;

		public CurrencyTypes currencyType;

		public float startPrice;

		public float priceIncreasePercentage;

		public int progressPerPurchase;

		public int progressRequiredForMajor;

		[FormerlySerializedAs("minorIncreaseAmount")]
		public float minorIncreaseMultiplier;

		[FormerlySerializedAs("majorIncreaseAmount")]
		public float majorIncreaseMultiplier;

		public float GetPrice(int totalPurchaseCount)
		{
			return 0f;
		}
	}

	[Serializable]
	public class ExtraArmProgressionDefinition
	{
		public int id;

		public string displayName;

		public CurrencyTypes currencyType;

		public int maxExtraArmCount;

		public float[] priceList;

		public int armCountPerPurchase;

		public int powerGainPerMergedArm;

		public float armScalePerPowerLevel;

		public float mergeDamageIncrease;

		public float mergeDamageMultiplier;

		public float GetPrice(int totalPurchaseCount)
		{
			return 0f;
		}

		public float GetMergeDamageBonus(int mergeLevel)
		{
			return 0f;
		}
	}

	[SerializeField]
	private ExtraArmProgressionDefinition extraArmProgression;

	[SerializeField]
	private IncrementalDefinition[] incrementals;

	public int Count => 0;

	public ExtraArmProgressionDefinition ExtraArmProgression => null;

	public IncrementalDefinition[] GetAllDefinitions()
	{
		return null;
	}

	public IncrementalDefinition GetDefinition(int id)
	{
		return null;
	}

	public IncrementalDefinition GetDefinition(IncrementalType type)
	{
		return null;
	}
}
