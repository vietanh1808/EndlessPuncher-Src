using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoomEarnedUIPanel : MonoBehaviour
{
	[Serializable]
	public class StatTypeandValues
	{
		public GameObject statParent;

		public PlayerStatType typeStat;

		public TextMeshProUGUI textCharacterStatValue;
	}

	private static RoomEarnedUIPanel _instance;

	public Animator anim;

	public Image icon;

	public TextMeshProUGUI textName;

	public TextMeshProUGUI textDescript;

	public List<StatTypeandValues> allStats;

	public GameObject statSloteEarned;

	private bool _isRoomCompleted;

	private bool _isCompleted;

	public static RoomEarnedUIPanel Instance => null;

	public bool IsCompleted => false;

	public void RoomCompleted()
	{
	}

	public void LoadPanel(PlayerStatType playerStat, float value)
	{
	}

	public void ComeAnim()
	{
	}

	public void Complete()
	{
	}

	private string GetSymbol(PlayerStatType type)
	{
		return null;
	}

	private string GetSymbolPrefix(PlayerStatType type)
	{
		return null;
	}

	private float StatValueCalculator(float statBaseValue, PlayerStatType typeStat, float valueStat)
	{
		return 0f;
	}
}
