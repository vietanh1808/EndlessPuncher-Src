using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomDB", menuName = "DBs/RoomDB")]
public class RoomPurchaseDB : ScriptableObject
{
	[Serializable]
	public class Room
	{
		public string name;

		public string description;

		public Sprite icon;

		public int maxPurhcaseableCount;

		public int priceStart;

		public int priceIncrease;

		public Prize[] prizes;
	}

	[Serializable]
	public class Prize
	{
		[Range(0f, 1f)]
		public float mileStone;

		public PrizeType typePrize;

		public float prizeAmount;
	}

	public List<Room> allRooms;

	public Room GetRoomFromDB(int levelRoom)
	{
		return null;
	}
}
