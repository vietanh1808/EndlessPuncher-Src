using System;
using UnityEngine;

namespace Fubu.Stats
{
	public class StatsHandler : MonoBehaviour
	{
		[Serializable]
		private class StatUnit
		{
			[SerializeField]
			[HideInInspector]
			public int id;

			[SerializeField]
			private StatTypes statType;

			private Stat stat;

			[SerializeField]
			[HideInInspector]
			private int level;

			[SerializeField]
			[Tooltip("Prefix of effect texts.")]
			private string prefix;

			[SerializeField]
			[Tooltip("Suffix of effect texts.")]
			private string suffix;

			[SerializeField]
			[Tooltip("Change this if you have fake stat values. e.g. You have 0.54 damage stat but you want to show it as 54, than set this to 100.")]
			private float UITextMultiplier;

			[SerializeField]
			[Tooltip("Offset of effect texts. Usefull if you want to show 0.01 as 1.01.")]
			private float offset;

			[SerializeField]
			[Tooltip("Is effect texts using unit text? Such as 1.3K, 1.3M etc.")]
			private bool isUsingUnitText;

			[SerializeField]
			private StatUI statUI;

			public float price;

			public bool CanBuy => false;

			public StatTypes StatType => StatTypes.Attack;

			public StatUnit(Stat stat, StatUI statUI)
			{
			}

			public void Init()
			{
			}

			public void UpdatePurchaseUI()
			{
			}

			public void Buy()
			{
			}

			private void UpdateUI()
			{
			}

			public void SetText(Stat stat)
			{
			}

			public float GetEffect()
			{
				return 0f;
			}

			public static implicit operator Stat(StatUnit unit)
			{
				return null;
			}
		}

		private static StatsHandler Instance;

		[SerializeField]
		private StatUnit[] stats;

		[SerializeField]
		private StatsDB statsDB;

		public Action OnStatChanged;

		[field: SerializeField]
		public CurrencyTypes BuyCurrencyType { get; private set; }

		public static StatsHandler GetInstance()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void InitStats()
		{
		}

		public Stat GetStat(StatTypes statType)
		{
			return null;
		}

		public void UpdateStats()
		{
		}

		public float GetStatValue(StatTypes statType)
		{
			return 0f;
		}

		public void UpgradeStat(int i)
		{
		}

		private void UpdatePurchaseUI()
		{
		}
	}
}
