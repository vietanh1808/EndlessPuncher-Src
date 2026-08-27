using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStageProgress : MonoBehaviour
{
	[Header("Nodes")]
	[SerializeField]
	private HeroStageNode nodePrefab;

	[SerializeField]
	private Transform nodeContainer;

	[Min(0f)]
	[SerializeField]
	private int stagesBeforeCurrent;

	[Min(0f)]
	[SerializeField]
	private int stagesAfterCurrent;

	[Header("Special Stages")]
	[SerializeField]
	private List<int> specialStages;

	[SerializeField]
	private bool useRecurringSpecialStage;

	[Min(1f)]
	[SerializeField]
	private int recurringSpecialStageInterval;

	[Header("Optional Scroll")]
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private bool centerOnRefresh;

	private readonly List<HeroStageNode> nodes;

	public void Refresh(int currentStage)
	{
	}

	private void EnsureNodeCount(int requiredNodeCount)
	{
	}

	private void RefreshVisibleNodes(int firstVisibleStage, int requiredNodeCount, int currentStage)
	{
	}

	private void DisableExtraNodes(int requiredNodeCount)
	{
	}

	private HeroStageNodeState GetNodeState(int stageNumber, int currentStage)
	{
		return HeroStageNodeState.Completed;
	}

	private bool IsSpecialStage(int stageNumber)
	{
		return false;
	}

	private void RefreshScrollPosition()
	{
	}
}
