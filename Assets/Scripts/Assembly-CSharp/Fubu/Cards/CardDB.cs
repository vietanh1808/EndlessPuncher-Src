using UnityEngine;

namespace Fubu.Cards
{
	[CreateAssetMenu(fileName = "CardDB", menuName = "Fubu/DBs/CardDB")]
	public class CardDB : ScriptableObject
	{
		[SerializeField]
		private Card[] cards;

		[SerializeField]
		private string _name;

		public string Name => null;

		public int CardCount => 0;

		public Card GetCard(int id)
		{
			return null;
		}

		public void SetCard(int id, Card card)
		{
		}
	}
}
