using System;
using UnityEngine;

public class PlayerMergeArmItem : MonoBehaviour
{
	[Serializable]
	public class MergeUpItem
	{
		public GameObject[] armMergeItems;

		public Animator[] armMergeAnimators;

		public void SetItemsVisibility(int level)
		{
		}

		public void ReSetItemsVisibility()
		{
		}
	}

	private static PlayerMergeArmItem _instance;

	public MergeUpItem[] regularArms;

	public static PlayerMergeArmItem Instance => null;

	private void Awake()
	{
	}

	public void MergeCompleted()
	{
	}

	private void Start()
	{
	}
}
