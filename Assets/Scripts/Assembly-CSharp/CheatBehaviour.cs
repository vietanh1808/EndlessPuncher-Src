using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Essentials;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheatBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCompleteRunAsBossKilledRoutine_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameUI inGameUI;

		public Vector3 rewardPosition;

		public CheatBehaviour _003C_003E4__this;

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
		public _003CCompleteRunAsBossKilledRoutine_003Ed__73(int _003C_003E1__state)
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

	private const float CombatCheatDamageMultiplier = 20f;

	private const float CheatPlayerMaxHp = 2000000f;

	private static bool combatCheatActive;

	private bool playerHpCheatActive;

	private const string CheatTimeScaleKey = "Cheat_TimeScale";

	private const float DefaultCheatTimeScale = 1f;

	public GameObject panel;

	public GameObject fpsPanel;

	public TextMeshProUGUI fpsText;

	private bool isPanelOpen;

	public Slider slider;

	public TextMeshProUGUI sliderText;

	public Button unlockSkillSlotButton;

	[Header("Combat Cheats")]
	[SerializeField]
	private Button combatCheatButton;

	[SerializeField]
	private Button unlockAllActiveSkillsButton;

	private bool isCheatCompleteRunning;

	private bool wasLevelStarted;

	[Header("Delete Save Cheat")]
	[SerializeField]
	private Button deleteSaveButton;

	[SerializeField]
	private GameObject deleteSaveConfirmationPopup;

	[SerializeField]
	private Button confirmDeleteSaveButton;

	[SerializeField]
	private Button cancelDeleteSaveButton;

	private bool deleteSaveInProgress;

	[Header("Currency")]
	[SerializeField]
	private TMP_InputField currencyAmountInput;

	[Header("Collectibles")]
	[SerializeField]
	private CollectiblesSO collectiblesSO;

	[SerializeField]
	private int collectibleCheatPieceAmount;

	private int fps;

	private int minFps;

	private int maxFps;

	private string fpsColor;

	private bool isFpsCounterOpen;

	public static bool IsCombatCheatActive => false;

	public static float PlayerDamageMultiplier => 0f;

	private void Start()
	{
	}

	public void ToggleCombatCheat()
	{
	}

	public void TogglePlayerHpCheat()
	{
	}

	public void UnlockAndActivateAllActiveSkills()
	{
	}

	public void OpenDeleteSaveConfirmation()
	{
	}

	public void CancelDeleteSave()
	{
	}

	public void ConfirmDeleteSaveAndQuit()
	{
	}

	private void Update()
	{
	}

	private void LoadSavedTimeScale()
	{
	}

	private void SetCheatTimeScale(float timeScale, bool save)
	{
	}

	private void ApplySavedTimeScaleOnNewRun()
	{
	}

	public void StatSelectorLoadingPanel()
	{
	}

	private int GetInputAmount()
	{
		return 0;
	}

	public void ChangeCurrency(int currencyData)
	{
	}

	public void ChangeDungeonTickets(int dungeonIndex)
	{
	}

	public void ChangeDungeonTickets(DungeonInfo dungeonInfo)
	{
	}

	private void AddTicketsToDungeon(Dungeon dungeon)
	{
	}

	public void AddEnergy()
	{
	}

	public void AddGiantEntry()
	{
	}

	public void AddGiantEntry(int amount)
	{
	}

	public void AllPetUnlock()
	{
	}

	public void AddPet()
	{
	}

	public void AddPet(int amount)
	{
	}

	public void AddChestKey(int keyID)
	{
	}

	public void AddItem()
	{
	}

	public void UnlockPets()
	{
	}

	public void UnlockShopPanel()
	{
	}

	public void UnlockDungeon()
	{
	}

	public void OpenFPSCounter()
	{
	}

	public void OpenPanel()
	{
	}

	public void AddAllItems()
	{
	}

	public void ActivateSkill(int skillID)
	{
	}

	public void IncreaseSkillSlot()
	{
	}

	public void SkillSceneLoad()
	{
	}

	public void TriggerSkillSlotUnlock()
	{
	}

	public void CompleteQuest()
	{
	}

	public void CompleteChapter()
	{
	}

	public void CompleteWave()
	{
	}

	public void CompleteRunAsBossKilled()
	{
	}

	[IteratorStateMachine(typeof(_003CCompleteRunAsBossKilledRoutine_003Ed__73))]
	private IEnumerator CompleteRunAsBossKilledRoutine(InGameUI inGameUI, Vector3 rewardPosition)
	{
		return null;
	}

	public void UnlockChestFeature()
	{
	}

	public void UnlockInventoryFeature()
	{
	}

	public void UnlockTalentFeature()
	{
	}

	public void UnlockQuestFeature()
	{
	}

	public void UnlockSpeedUp()
	{
	}

	public void AddCommonhestKeys()
	{
	}

	public void AddEpicChestKeys()
	{
	}

	public void AddCollectibleChestKeys()
	{
	}

	public void AddFivePiecesToAllCollectibles()
	{
	}

	private CollectiblesSO GetCheatCollectiblesSO()
	{
		return null;
	}
}
