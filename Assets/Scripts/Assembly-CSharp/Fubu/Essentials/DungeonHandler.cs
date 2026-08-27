using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Fubu.Essentials
{
	public class DungeonHandler : MonoBehaviour, ISaveable
	{
		private static DungeonHandler instance;

		private static readonly Dictionary<string, DungeonInfo> registry;

		[SerializeField]
		private List<DungeonInfo> dungeonInfos;

		[SerializeField]
		private Dungeon dungeonPrefab;

		[SerializeField]
		private Transform dungeonsContainer;

		[SerializeField]
		private DungeonInfoPopUp infoPopUp;

		[SerializeField]
		private SweepPanel sweepRewardPanel;

		[SerializeField]
		private TextMeshProUGUI[] timerTxt;

		[SerializeField]
		private GameObject dungeonPanel;

		private int lastResetTimerDisplayedSecond;

		private List<Dungeon> dungeons;

		public Action OnDungeonEnter;

		[CompilerGenerated]
		private static Action<DungeonInfo, int> m_OnDungeonSuccess;

		[CompilerGenerated]
		private static Action m_OnDungeonFail;

		[CompilerGenerated]
		private static Action m_OnDungeonExit;

		private static bool hasActiveDungeon;

		private static string activeDungeonName;

		private static int activeDungeonLevel;

		private static string lastTicketResetDate;

		private static bool isFinishedDungeon;

		private DateTime lastRuntimeResetCheckDate;

		private bool isSaveLoaded;

		public bool IsDungeonActivated => false;

		public List<Dungeon> Dungeons => null;

		public Dungeon CurrentDungeon { get; private set; }

		public static event Action<DungeonInfo, int> OnDungeonSuccess
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

		public static event Action OnDungeonFail
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

		public static event Action OnDungeonExit
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

		public static DungeonHandler GetInstance()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateResetTimerText()
		{
		}

		private bool HandleShowPanelOnStart()
		{
			return false;
		}

		public void SelectDungeon(Dungeon dungeon)
		{
		}

		public static bool TrySpendTicket(Dungeon dungeon)
		{
			return false;
		}

		public static void IncreaseLevelStatic(Dungeon dungeon)
		{
		}

		public void Enter()
		{
		}

		public void EnterFromRewarded()
		{
		}

		public static DungeonInfo NotifySuccess()
		{
			return null;
		}

		public static void NotifyFail()
		{
		}

		public static void NotifyExitDungeon()
		{
		}

		private static void ApplyDungeonProgression(string name, int ticketDelta, int levelDelta)
		{
		}

		private static void PersistActiveDungeonState()
		{
		}

		public void Sweep(int level)
		{
		}

		public bool SkipCurrentDungeonWithPower()
		{
			return false;
		}

		public static bool HasActiveDungeon()
		{
			return false;
		}

		public static bool IsActiveDungeonPlayerPunchDisabled()
		{
			return false;
		}

		public static int GetActiveDungeonLevel()
		{
			return 0;
		}

		public static int ScaleAmount(int baseAmount, int level, float multiplier)
		{
			return 0;
		}

		public static int ScaleAmount(DungeonInfo info, int baseAmount, int level)
		{
			return 0;
		}

		private void RefreshDungeonCard(DungeonInfo info)
		{
		}

		public void RefreshDungeonsForSoftRestart()
		{
		}

		private static void GrantRewards(DungeonInfo info, int level)
		{
		}

		private static void SaveActiveDungeon(string name, int level)
		{
		}

		private static void ClearActiveDungeon()
		{
		}

		private void TryDailyTicketReset()
		{
		}

		private void CheckDailyResetDateChanged()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private static void SaveLastResetDate(DateTime date)
		{
		}

		private static DateTime LoadLastResetDate()
		{
			return default;
		}

		public void OnLoad(SaveData data)
		{
		}

		public void OnSave(SaveData data)
		{
		}
	}
}
