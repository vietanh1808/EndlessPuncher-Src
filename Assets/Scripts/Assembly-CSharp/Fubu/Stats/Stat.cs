using System;
using UnityEngine;

namespace Fubu.Stats
{
	[Serializable]
	public class Stat
	{
		[SerializeField]
		[Tooltip("Must be unique.")]
		private StatTypes statType;

		[SerializeField]
		private float baseValue;

		[SerializeField]
		private float ceilValue;

		[SerializeField]
		[HideInInspector]
		private float effectMagnitude;

		[SerializeField]
		[HideInInspector]
		private int level;

		[SerializeField]
		private int maxLevel;

		[SerializeField]
		private string name;

		[SerializeField]
		private string description;

		[SerializeField]
		private Sprite icon;

		public StatTypes StatType => StatTypes.Attack;

		public int MaxLevel => 0;

		public int Level => 0;

		public string Name => null;

		public string Description => null;

		public Sprite Icon => null;

		public int ID { get; private set; }

		public Stat(string name, string description, Sprite icon, int maxLevel, float baseValue, float ceilValue, StatTypes statType)
		{
		}

		public void Assign(int id)
		{
		}

		public void Init()
		{
		}

		public float GetEffect()
		{
			return 0f;
		}

		public void GetEffectValues(out float from, out float to)
		{
			from = default;
			to = default;
		}

		public void Upgrade()
		{
		}

		private void Save()
		{
		}

		private void Load()
		{
		}
	}
}
