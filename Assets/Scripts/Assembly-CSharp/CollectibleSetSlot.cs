using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleSetSlot : MonoBehaviour
{
	[Serializable]
	public class BasicEffectSlot
	{
		[SerializeField]
		private GameObject root;

		[SerializeField]
		private GameObject lockedObject;

		[SerializeField]
		private GameObject unlockedObject;

		[SerializeField]
		private TextMeshProUGUI requirementText;

		[SerializeField]
		private TextMeshProUGUI effectText;

		[SerializeField]
		private Image[] colorImages;

		[SerializeField]
		private TextMeshProUGUI[] colorTexts;

		[SerializeField]
		private Color lockedColor;

		[SerializeField]
		private Color unlockedColor;

		public void SetData(CollectiblesSO.CollectibleSetBonus bonus, bool unlocked, bool visible)
		{
		}

		public void Clear()
		{
		}

		private void ApplyColor(Color color)
		{
		}
	}

	private const int CollectibleCountPerSet = 4;

	[Header("Data")]
	[SerializeField]
	private CollectiblesSO collectiblesSO;

	[SerializeField]
	private string setId;

	[SerializeField]
	private bool refreshOnEnable;

	[Header("Set Info")]
	[SerializeField]
	private TextMeshProUGUI setNameText;

	[SerializeField]
	private TextMeshProUGUI descriptionText;

	[SerializeField]
	private TextMeshProUGUI starProgressText;

	[Header("Collectibles")]
	[SerializeField]
	private CollectibleSlot[] collectibleSlots;

	[Header("Basic Effects")]
	[SerializeField]
	private BasicEffectSlot[] basicEffects;

	private readonly Dictionary<string, int> collectibleStarLevels;

	private readonly Dictionary<string, bool> collectibleActivationStates;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetData(CollectiblesSO so, string id)
	{
	}

	[ContextMenu("Refresh Set Slot")]
	public void Refresh()
	{
	}

	private CollectiblesSO.CollectibleSetData GetSetData()
	{
		return null;
	}

	private void BuildStarLevelMap(CollectiblesSO.CollectibleSetData setData)
	{
	}

	private int GetDefaultCollectibleStar(string collectibleId)
	{
		return 0;
	}

	private void SetHeader(CollectiblesSO.CollectibleSetData setData)
	{
	}

	private void SetCollectibleSlots(CollectiblesSO.CollectibleSetData setData)
	{
	}

	private void SetBasicEffects(CollectiblesSO.CollectibleSetData setData)
	{
	}

	private int GetHighestSetStarLevel(CollectiblesSO.CollectibleSetData setData)
	{
		return 0;
	}

	private void Clear()
	{
	}

	private void HandleStarUpPurchased(string collectibleId)
	{
	}

	private static string GetRequirementText(CollectiblesSO.CollectibleSetBonusRequirement requirement)
	{
		return null;
	}

	private static string FormatEffect(CollectiblesSO.CollectibleSetBonus bonus)
	{
		return null;
	}
}
