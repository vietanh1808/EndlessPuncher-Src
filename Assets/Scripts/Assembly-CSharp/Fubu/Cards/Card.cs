using System;
using UnityEngine;

namespace Fubu.Cards
{
	[Serializable]
	public class Card : ICloneable
	{
		[Serializable]
		public struct SaveUnit
		{
			[SerializeField]
			private int id;

			[SerializeField]
			public int count;

			[SerializeField]
			public int level;

			public SaveUnit(int id, int count, int level)
			{
				this.id = 0;
				this.count = 0;
				this.level = 0;
			}

			public void Deconstruct(out int count, out int level)
			{
				count = default;
				level = default;
			}
		}

		[SerializeField]
		[HideInInspector]
		private int _id;

		[SerializeField]
		private CardRarity _rarity;

		[SerializeField]
		private CardStatType _statType;

		[SerializeField]
		private string _name;

		[SerializeField]
		private string _description;

		[SerializeField]
		private float[] _damage;

		[SerializeField]
		private float[] _defence;

		[SerializeField]
		private float[] _effect;

		[SerializeField]
		private float _duration;

		[SerializeField]
		private float _coolDown;

		[SerializeField]
		private Sprite _icon;

		private int _level;

		private int _cardCount;

		[NonSerialized]
		public bool IsEquipped;

		public int ID => 0;

		public CardRarity Rarity => CardRarity.Common;

		public CardStatType StatType => (CardStatType)0;

		public string Name => null;

		public string Description => null;

		public float Damage => 0f;

		public float Defence => 0f;

		public float Effect => 0f;

		public float Duration => 0f;

		public float CoolDown => 0f;

		public Sprite Icon => null;

		public int Level => 0;

		public int CardCount => 0;

		public bool IsLocked => false;

		public bool IsReadyToUpgrade => false;

		public SaveUnit GetSaveUnit()
		{
			return default;
		}

		public void Load(SaveUnit? savedValue)
		{
		}

		public Card(Card card)
		{
		}

		public Card(Card card, float[] damage, float[] defence, float[] effect, float duration, float coolDown)
		{
		}

		public Card(string name, string description, CardRarity rarity, CardStatType statType, float[] damage, float[] defence, float[] effect, float duration, float coolDown, Sprite icon)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void AddCard(int amount = 1)
		{
		}

		public void LevelUp()
		{
		}

		public static bool operator ==(Card lhs, Card rhs)
		{
			return false;
		}

		public static bool operator !=(Card lhs, Card rhs)
		{
			return false;
		}
	}
}
