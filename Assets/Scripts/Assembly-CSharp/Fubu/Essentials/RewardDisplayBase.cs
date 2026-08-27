using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Essentials
{
	public abstract class RewardDisplayBase : MonoBehaviour
	{
		[SerializeField]
		private GameObject panel;

		[SerializeField]
		private Transform rewardsContainer;

		[SerializeField]
		private DungeonReward rewardPrefab;

		[SerializeField]
		private Button claimButton;

		private List<RewardEntry> pendingRewards;

		private DungeonInfo rewardInfo;

		private int rewardLevel;

		[CompilerGenerated]
		private Action m_OnClaimed;

		public event Action OnClaimed
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

		protected virtual void Awake()
		{
		}

		public void Show(Dungeon dungeon)
		{
		}

		public void Show(Dungeon dungeon, int level)
		{
		}

		public void Show(DungeonInfo info, int level)
		{
		}

		private void SpawnRewardDisplays()
		{
		}

		protected virtual void Claim()
		{
		}
	}
}
