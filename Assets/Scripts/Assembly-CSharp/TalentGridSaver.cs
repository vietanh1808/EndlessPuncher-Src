using System;
using System.Collections.Generic;
using UnityEngine;

public class TalentGridSaver : MonoBehaviour
{
	[Serializable]
	public class SlotProperties
	{
		public Vector3Int slotPos;

		public List<Connection> connections;

		public SlotProperties(Vector3Int slotPos, List<Connection> connections)
		{
		}
	}

	[Serializable]
	public struct Connection
	{
		public connectionTypeWhere pointWhere;

		public Vector3Int pointStart;

		public Vector3Int pointEnd;
	}

	public class PlacementDate
	{
		public List<Vector3Int> occupiedPositions;

		public PlacementDate(List<Vector3Int> occupiedPositions)
		{
		}
	}

	public List<SlotProperties> allSlotesAndRoads;

	[SerializeField]
	public List<Vector3Int> allSlotesInScnee;

	public void AddObjectAtTalentTree(Vector3Int gridPos, List<Connection> connections)
	{
	}

	public void AddObjectAtTalentTree(Vector3Int gridPos)
	{
	}

	public bool CanPlaceObjectAt(Vector3Int gridPos)
	{
		return false;
	}

	private bool ThereAreMoreSameSlote(Vector3Int gridPos)
	{
		return false;
	}

	private bool isInsideOfGrid(Vector3Int pointForGrid)
	{
		return false;
	}

	public void AddEmptySlote(Vector3Int gridPos)
	{
	}

	public Vector3Int GetAvaliablePoint(Vector3Int gridPoint)
	{
		return default;
	}
}
