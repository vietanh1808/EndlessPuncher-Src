using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillHandler : MonoBehaviour, ISaveable, ITabPanel
{
	[CompilerGenerated]
	private sealed class _003CEquipPendingSkillCardsRoutine_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<SkillCard> pendingCards;

		public SkillHandler _003C_003E4__this;

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
		public _003CEquipPendingSkillCardsRoutine_003Ed__136(int _003C_003E1__state)
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

	[Header("Tab Panel")]
	[SerializeField]
	private GameObject tabPanelObject;

	[Header("Equipment")]
	[SerializeField]
	private GameObject equipmentFrame;

	private List<SkillSlot> equipmentSlots;

	[Header("Skills")]
	[SerializeField]
	private GameObject skillsFrame;

	[SerializeField]
	private Transform skillsContainer;

	private List<SkillCard> skillCards;

	[Header("Card Selection")]
	[SerializeField]
	private GameObject cardSelectionFrame;

	[SerializeField]
	private PreviewSkillCard selectedCard;

	[SerializeField]
	private Button backButton;

	private SkillCard pendingSkillCard;

	[Header("Level")]
	public Action OnLevelUp;

	public Action OnEquippedSkillsChanged;

	[SerializeField]
	private TextMeshProUGUI levelTxt;

	[SerializeField]
	private Slider levelSlider;

	[SerializeField]
	private TextMeshProUGUI cardCountTxt;

	[Header("References")]
	[SerializeField]
	private SkillSettings skillSettings;

	[SerializeField]
	private SkillCard skillCardPrefab;

	[SerializeField]
	private SkillDrawPopup skillDrawPopup;

	[SerializeField]
	private SkillInfoPopup skillInfoPopup;

	[SerializeField]
	private RarityChancePopup rarityChancePopup;

	[Header("Draw Single")]
	[SerializeField]
	private Button drawSingleButton;

	[SerializeField]
	private TextMeshProUGUI drawSingleCostText;

	[SerializeField]
	private Image drawSingleCostIcon;

	[Header("Draw Multiple")]
	[SerializeField]
	private Button drawMultipleButton;

	[SerializeField]
	private TextMeshProUGUI drawMultipleCostText;

	[SerializeField]
	private TextMeshProUGUI drawMultipleCountText;

	[SerializeField]
	private Image drawMultipleCostIcon;

	[Header("Quick Buttons")]
	[SerializeField]
	private Button quickEquipButton;

	[SerializeField]
	private Button upgradeAllButton;

	[Header("ShopGem Buttons")]
	[SerializeField]
	private Button buyShopGemButton;

	[SerializeField]
	private Button buyShopGemButtonMultiple;

	[SerializeField]
	private TextMeshProUGUI rewardedCounterSingle;

	[SerializeField]
	private TextMeshProUGUI rewardedCounterMultiple;

	[SerializeField]
	private Button buyShopGemButtonRew;

	[SerializeField]
	private Button buyShopGemButtonMultipleRew;

	[Header("WeeklyFree Buttons")]
	[SerializeField]
	private Button weeklyFreeButtonSingle;

	[SerializeField]
	private Button weeklyFreeButtonMultiple;

	[SerializeField]
	private TextMeshProUGUI rewardedCounterWeeklySingle;

	[SerializeField]
	private TextMeshProUGUI rewardedCounterWeeklyMultiple;

	private int _singleshopGemAmounth;

	private int _multipleshopGemAmounth;

	[Header("Panel Unlock Btn")]
	public GameObject transitionCover;

	public GameObject[] petGemCounter;

	public static SkillHandler Instance { get; private set; }

	[HideInInspector]
	public List<SkillSlot> GetSkillSlots => null;

	public bool HasPendingSkillCard => false;

	public SkillCard LastDrawnSkillCard { get; private set; }

	public int Level { get; private set; }

	public int TotalCardCount { get; private set; }

	public SkillSettings SkillSettings => null;

	public SkillCard SkillCardPrefab => null;

	public SkillDrawPopup SkillDrawPopup => null;

	public SkillInfoPopup SkillInfoPopup => null;

	public RarityChancePopup RarityChancePopup => null;

	[Header("Getters")]
	public List<Stat> Stats => null;

	public void PanelButtonLocker()
	{
	}

	private void RewardedButtonCheck()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private GameObject GetTabPanelObject()
	{
		return null;
	}

	private void RefreshSingleDrawButtons()
	{
	}

	private void RefreshMultipleDrawButtons()
	{
	}

	public void ClaimRewardSingle()
	{
	}

	public void ClaimRewardMultiple()
	{
	}

	public void ClaimRewardWeeklySingle()
	{
	}

	public void ClaimRewardWeeklyMultiple()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void RefreshQuickButtonsInteractable()
	{
	}

	public float GetRarityChance(Rarity rarity, int level)
	{
		return 0f;
	}

	public void WriteSkillDropChances()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshLevelUI()
	{
	}

	public void CollectCard()
	{
	}

	public void CollectAllSkillCards(int amountPerCard)
	{
	}

	private void TryLevelUp()
	{
	}

	public int NeedCardCountForLevel(int level)
	{
		return 0;
	}

	public void RefreshSkillCards()
	{
	}

	private void NotifyEquippedSkillsChanged()
	{
	}

	private void InitializeEqipmentSlots()
	{
	}

	private void InitializeDrawButtons()
	{
	}

	private void RefreshDrawButtonsInteractable()
	{
	}

	private void SpawnSkillCards()
	{
	}

	private void BackSelectionFrame()
	{
	}

	private void StartSlotsSelectionPulse()
	{
	}

	private void StopSlotsSelectionPulse()
	{
	}

	public void ShowRarityChancePopup()
	{
	}

	public void LevelUpRarityChancePopup()
	{
	}

	private void DrawSingle()
	{
	}

	private void DrawSingleForShopGem()
	{
	}

	private void DrawMultiple()
	{
	}

	private void DrawMultipleForShopGem()
	{
	}

	public SkillCard GetRandomSkillCard()
	{
		return null;
	}

	private Rarity GetRandomRarityByChance()
	{
		return null;
	}

	private bool HasCardWithRarity(Rarity rarity)
	{
		return false;
	}

	public void SelectSkillCard(SkillCard skillCard)
	{
	}

	public SkillCard GetFirstUnlockedUnequippedSkillCard()
	{
		return null;
	}

	public bool HasUnlockedSkillCard()
	{
		return false;
	}

	public void TrackDrawnSkillCard(SkillCard skillCard)
	{
	}

	public SkillSlot GetEmptySkillSlot()
	{
		return null;
	}

	public void EquipSkill(SkillCard skillCard)
	{
	}

	public void EquipPendingToSlot(SkillSlot slot)
	{
	}

	private bool NeedsQuickEquip()
	{
		return false;
	}

	private void EquipToSkill(SkillCard skillCard, SkillSlot slot, bool refreshPower = true, bool playFeedback = true)
	{
	}

	public void UnequipSkill(SkillCard skillCard, bool refreshPower = true, bool playFeedback = true)
	{
	}

	private void QuickEquip()
	{
	}

	private List<SkillCard> GetUpgradeableSkills()
	{
		return null;
	}

	private void UpgradeAll()
	{
	}

	public float GetStatTotalValue(Stat stat)
	{
		return 0f;
	}

	public float GetTotalEquippedSkillPower()
	{
		return 0f;
	}

	private static void PlayClickFeedback()
	{
	}

	private static void PlayEquipFeedback()
	{
	}

	private static void PlayUnequipFeedback()
	{
	}

	private static void PlayUpgradeFeedback()
	{
	}

	public void OnLoad(SaveData data)
	{
	}

	[IteratorStateMachine(typeof(_003CEquipPendingSkillCardsRoutine_003Ed__136))]
	private IEnumerator EquipPendingSkillCardsRoutine(List<SkillCard> pendingCards)
	{
		return null;
	}

	public void OnSave(SaveData data)
	{
	}
}
