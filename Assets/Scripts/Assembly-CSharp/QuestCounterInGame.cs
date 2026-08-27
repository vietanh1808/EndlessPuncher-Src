using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestCounterInGame : MonoBehaviour
{
	[CompilerGenerated]
	private static Action m_QuestProgressUpdated;

	private static QuestCounterInGame _instance;

	public QuestType questType;

	public QuestDB questDB;

	public static QuestCounterInGame Instance => null;

	public static event Action QuestProgressUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public static void NotifyQuestProgressUpdated()
	{
	}

	public void QuestUpdate(QuestType type, float value, bool isAdding = true)
	{
	}

	private void Update()
	{
	}
}
