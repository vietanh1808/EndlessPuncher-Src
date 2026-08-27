using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Essentials
{
	public class DungeonInfoPopUp : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayUISize_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonInfoPopUp _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelayUISize_003Ed__32(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private Dungeon currentDungeon;

		private int displayedLevel;

		[Header("UI References")]
		[SerializeField]
		private TextMeshProUGUI dungeonNameTxt;

		[SerializeField]
		private Image dungeonIcon;

		[SerializeField]
		private TextMeshProUGUI levelTxt;

		[SerializeField]
		private Image ticketIcon;

		[SerializeField]
		private TextMeshProUGUI chancesTxt;

		[SerializeField]
		private Button nextButton;

		[SerializeField]
		private Button previousButton;

		[SerializeField]
		private Button playButton;

		[SerializeField]
		private Button skipButton;

		[SerializeField]
		private TextMeshProUGUI skipButtonText;

		[SerializeField]
		private Button sweepButton;

		[SerializeField]
		private Button sweepPrevButton;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button rewardedDungeonPlayWeekly;

		[SerializeField]
		private Button rewardedDungeonPlay;

		[SerializeField]
		private TextMeshProUGUI rewardedCounter;

		[SerializeField]
		private Image rewardedCounterIcon;

		[SerializeField]
		private Image weeklyRewardedCounterIcon;

		[SerializeField]
		private UISizer[] uISizer;

		[Header("Rewards")]
		[SerializeField]
		private Transform rewardsContainer;

		[SerializeField]
		private DungeonReward rewardPrefab;

		private List<DungeonReward> rewards;

		private Coroutine delayUiSizeRoutine;

		private void Start()
		{
		}

		private void EnsureSkipButton()
		{
		}

		public void OpenPopUp(Dungeon dungeon)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleDailyReset()
		{
		}

		public void RefreshForDailyReset()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayUISize_003Ed__32))]
		private IEnumerator DelayUISize()
		{
			return null;
		}

		public void ClosePopUp()
		{
		}

		private void NextLevel()
		{
		}

		private void PreviousLevel()
		{
		}

		private void Play()
		{
		}

		private void SkipWithPower()
		{
		}

		private void CheckRewardedButton()
		{
		}

		private void RewardedPlay()
		{
		}

		private void RewardedPlayWeekly()
		{
		}

		private void Sweep()
		{
		}

		private void SpawnRewards()
		{
		}

		private void UpdateUI()
		{
		}

		private void RefreshSkipButton()
		{
		}

		private float GetPlayerGlobalPower()
		{
			return 0f;
		}
	}
}
