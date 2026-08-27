using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fubu.Inventory;
using UnityEngine;

[RequireComponent(typeof(ChestLevelSettings))]
public class ChestPanelHandler : MonoBehaviour
{
	private class CollectibleChestDisplayReward
	{
		public CollectiblesSO.CollectibleData collectible;

		public CurrencyTypes currencyType;

		public int amount;

		public bool IsCollectible => false;
	}

	private class HeroChestDisplayReward
	{
		public HeroData hero;

		public CurrencyTypes currencyType;

		public int amount;

		public ChestHeroDrop.DropRarity rarity;

		public bool isShard;

		public bool IsCurrency => false;
	}

	private enum HeroRewardKind
	{
		SRShard = 0,
		SSRShard = 1,
		URShard = 2,
		SRFullHero = 3,
		SSRFullHero = 4,
		URFullHero = 5,
		Currency = 6
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public ChestCollectibleEarnedPanel earnedPanel;

		internal bool _003CChestUnlockRator_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public ChestCollectibleEarnedPanel earnedPanel;

		internal bool _003CChestUnlockRatorWShopgem_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CChestUnlockRator_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChestPanelHandler _003C_003E4__this;

		public Transform targetChest;

		private _003C_003Ec__DisplayClass62_0 _003C_003E8__1;

		private ChestItemBehaviour _003CchestItem_003E5__2;

		private int _003CamountToOpen_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CChestUnlockRator_003Ed__62(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CChestUnlockRatorWShopgem_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChestPanelHandler _003C_003E4__this;

		public Transform targetChest;

		private _003C_003Ec__DisplayClass63_0 _003C_003E8__1;

		private ChestItemBehaviour _003CchestItem_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CChestUnlockRatorWShopgem_003Ed__63(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COpenCollectibleChestRewards_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChestPanelHandler _003C_003E4__this;

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
		public _003COpenCollectibleChestRewards_003Ed__70(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COpenHeroChestRewards_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChestPanelHandler _003C_003E4__this;

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
		public _003COpenHeroChestRewards_003Ed__87(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COpenHeroChestRewards_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int amountToOpen;

		public ChestPanelHandler _003C_003E4__this;

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
		public _003COpenHeroChestRewards_003Ed__88(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRefreshChestInfoSizerAfterLoad_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChestPanelHandler _003C_003E4__this;

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
		public _003CRefreshChestInfoSizerAfterLoad_003Ed__64(int _003C_003E1__state)
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

	private const int CollectibleKeyDropAmountFromRegularChest = 1;

	private const int CollectibleUnlockChapter = 5;

	private const int RegularChestCollectibleKeyDropChapter = 5;

	private static ChestPanelHandler instance;

	[Header("Chest UI")]
	public GameObject prefabChest;

	public Transform panelHolder;

	[SerializeField]
	private ChestItemBehaviour[] fixedChestItems;

	public GameObject chestObje;

	public Transform chestMiddlePoint;

	public Animator chestPanelAnim;

	public Animator chestUnlockAnim;

	public ParticleSystem particleChestUnlock;

	public ChestInfoPanel chestInfoPanel;

	[SerializeField]
	private ChestCollectibleEarnedPanel chestCollectibleEarnedPanel;

	[SerializeField]
	private ChestHeroEarnedPanel chestHeroEarnedPanel;

	public Animator[] allChestObjects;

	[SerializeField]
	private CollectiblesSO collectiblesSO;

	[SerializeField]
	private HeroDatabaseSO heroDatabase;

	[SerializeField]
	private Sprite collectibleKeyRewardIcon;

	[SerializeField]
	private ChestLevelSettings chestLevelSettings;

	private const string CollectibleChestOpenedCountKey = "CollectibleChestOpenedCount";

	private const string HeroChestOpenedCountKey = "HeroChestOpenedCount";

	private const int HeroShardRewardAmount = 1;

	private const int MaxHeroChestOpenCount = 10;

	public readonly List<GameObject> allChests;

	private readonly ChestTypes[] supportedChestTypes;

	public GameObject chestPanel;

	public GameObject chestPanelButton;

	private bool _isChestUnlocking;

	private bool _isClaimed;

	public static ChestPanelHandler Instance => null;

	private List<ChestLevelSettings.CommonChestLevelDefinition> commonChestLevels => null;

	private List<ChestLevelSettings.EpicChestLevelDefinition> epicChestLevels => null;

	private ChestLevelSettings.CollectibleChestDefinition collectibleChestDefinition => null;

	private List<ChestLevelSettings.CollectibleChestLevelDefinition> collectibleChestLevels => null;

	private List<ChestLevelSettings.HeroChestLevelDefinition> heroChestLevels => null;

	private bool IsCollectibleRewardPanelActive => false;

	private bool IsHeroRewardPanelActive => false;

	public bool IsChestUnlocking => false;

	public bool IsClaimed => false;

	private ChestLevelSettings GetChestLevelSettings()
	{
		return null;
	}

	private void Start()
	{
	}

	public void AddTestKeysAtStart()
	{
	}

	private void EnsureChestItems()
	{
	}

	private bool IsChestTypeUnlocked(ChestTypes chestType)
	{
		return false;
	}

	private bool IsCollectibleUnlocked()
	{
		return false;
	}

	private void CacheChestObject(GameObject chestObject)
	{
	}

	private ChestItemBehaviour GetChestItem(ChestTypes type)
	{
		return null;
	}

	public void DestroyChestInList(GameObject obje)
	{
	}

	public int GetSizeActiveChests()
	{
		return 0;
	}

	public bool HasAnyActiveChestWithKeys()
	{
		return false;
	}

	public bool HasChestKey(ChestTypes chestType)
	{
		return false;
	}

	public bool HasActiveChestWithKey(ChestTypes chestType)
	{
		return false;
	}

	public Transform GetChestTransform(ChestTypes chestType)
	{
		return null;
	}

	public void ChestPanelActive(bool isActive)
	{
	}

	public void ChestOpenButton()
	{
	}

	public void RefreshChests()
	{
	}

	public void CheatResetStart()
	{
	}

	public void ChestUnlocked(Transform pointarget)
	{
	}

	public void ChestUnlockWShopgem(Transform pointarget)
	{
	}

	[IteratorStateMachine(typeof(_003CChestUnlockRator_003Ed__62))]
	private IEnumerator ChestUnlockRator(Transform targetChest)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChestUnlockRatorWShopgem_003Ed__63))]
	private IEnumerator ChestUnlockRatorWShopgem(Transform targetChest)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRefreshChestInfoSizerAfterLoad_003Ed__64))]
	private IEnumerator RefreshChestInfoSizerAfterLoad()
	{
		return null;
	}

	private bool ShouldGiveCollectibleKeyFromRegularChest(ChestTypes chestType)
	{
		return false;
	}

	private bool CanDropCollectibleKeyFromRegularChest()
	{
		return false;
	}

	private void GrantCollectibleChestKeyReward(int amount)
	{
	}

	private ChestCollectibleEarnedPanel ShowCollectibleKeyRewardPanel(int amount)
	{
		return null;
	}

	private Sprite GetCollectibleKeyRewardIcon()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenCollectibleChestRewards_003Ed__70))]
	private IEnumerator OpenCollectibleChestRewards()
	{
		return null;
	}

	private bool TryAddTutorialGuaranteedCollectibleReward(List<CollectibleChestDisplayReward> displayRewards)
	{
		return false;
	}

	private bool ShouldGiveCollectibleReward()
	{
		return false;
	}

	private CollectiblesSO.CollectibleData GetRandomCollectibleReward()
	{
		return null;
	}

	private CollectiblesSO.CollectibleData GetRandomCollectibleReward(CollectiblesRarity rarity)
	{
		return null;
	}

	private CollectiblesRarity GetCollectibleRewardRarity()
	{
		return CollectiblesRarity.Common;
	}

	private int GetCollectiblePieceAmount()
	{
		return 0;
	}

	private void AddCollectibleDisplayReward(List<CollectibleChestDisplayReward> displayRewards, CollectiblesSO.CollectibleData collectible, int pieces)
	{
	}

	private void AddCurrencyDisplayReward(List<CollectibleChestDisplayReward> displayRewards)
	{
	}

	private void WriteDisplayRewardsToPanel(ChestCollectibleEarnedPanel earnedPanel, List<CollectibleChestDisplayReward> displayRewards)
	{
	}

	private void GrantCurrencyDisplayRewardsImmediately(List<CollectibleChestDisplayReward> displayRewards)
	{
	}

	private ChestCollectibleEarnedPanel GetCollectibleEarnedPanel()
	{
		return null;
	}

	private ChestLevelSettings.CurrencyRewardDefinition GetCurrencyRewardDefinition()
	{
		return null;
	}

	private bool IsCollectibleCurrencyReward(ChestLevelSettings.CurrencyRewardDefinition reward)
	{
		return false;
	}

	private ChestLevelSettings.CurrencyRewardDefinition CreateDefaultCollectibleCurrencyReward()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenHeroChestRewards_003Ed__87))]
	private IEnumerator OpenHeroChestRewards()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenHeroChestRewards_003Ed__88))]
	private IEnumerator OpenHeroChestRewards(int amountToOpen)
	{
		return null;
	}

	private HeroChestDisplayReward CreateHeroChestDisplayReward()
	{
		return null;
	}

	private HeroChestDisplayReward CreateHeroCurrencyFallback(ChestLevelSettings.HeroChestLevelDefinition definition)
	{
		return null;
	}

	private void GrantHeroReward(HeroData hero, int amount, bool isShard)
	{
	}

	private void GrantHeroCurrencyReward(CurrencyTypes currencyType, int amount)
	{
	}

	private ChestHeroEarnedPanel GetHeroEarnedPanel()
	{
		return null;
	}

	private HeroRewardKind GetHeroRewardKind(ChestLevelSettings.HeroChestLevelDefinition definition)
	{
		return HeroRewardKind.SRShard;
	}

	private HeroData GetRandomHeroReward(ChestHeroDrop.DropRarity rarity)
	{
		return null;
	}

	private HeroDatabaseSO GetHeroDatabase()
	{
		return null;
	}

	private ChestHeroDrop.DropRarity GetHeroDropRarity(HeroData hero)
	{
		return ChestHeroDrop.DropRarity.SR;
	}

	private string NormalizeRarityName(string rarityName)
	{
		return null;
	}

	private ChestHeroDrop.DropRarity GetRarityForHeroRewardKind(HeroRewardKind rewardKind)
	{
		return ChestHeroDrop.DropRarity.SR;
	}

	private bool IsShardHeroRewardKind(HeroRewardKind rewardKind)
	{
		return false;
	}

	private string GetHeroId(HeroData hero)
	{
		return null;
	}

	private ItemRarity GetRewardRarityForChest(ChestTypes chestType)
	{
		return ItemRarity.Common;
	}

	private ChestLevelSettings.CommonChestLevelDefinition GetCurrentCommonChestDefinition()
	{
		return null;
	}

	private ChestLevelSettings.EpicChestLevelDefinition GetCurrentEpicChestDefinition()
	{
		return null;
	}

	private ChestLevelSettings.CollectibleChestLevelDefinition GetCurrentCollectibleChestDefinition()
	{
		return null;
	}

	private ChestLevelSettings.HeroChestLevelDefinition GetCurrentHeroChestDefinition()
	{
		return null;
	}

	private int GetCurrentCommonChestLevelIndex()
	{
		return 0;
	}

	private int GetCurrentEpicChestLevelIndex()
	{
		return 0;
	}

	private int GetCurrentCollectibleChestLevelIndex()
	{
		return 0;
	}

	private int GetCurrentHeroChestLevelIndex()
	{
		return 0;
	}

	public int GetCommonChestLevelDisplay()
	{
		return 0;
	}

	public int GetEpicChestLevelDisplay()
	{
		return 0;
	}

	public int GetCollectibleChestLevelDisplay()
	{
		return 0;
	}

	public int GetHeroChestLevelDisplay()
	{
		return 0;
	}

	public float GetCommonChestLevelProgress01()
	{
		return 0f;
	}

	public int GetCommonChestLevelCurrentProgress()
	{
		return 0;
	}

	public int GetCommonChestLevelRequiredProgress()
	{
		return 0;
	}

	public float GetEpicChestLevelProgress01()
	{
		return 0f;
	}

	public int GetEpicChestLevelCurrentProgress()
	{
		return 0;
	}

	public int GetEpicChestLevelRequiredProgress()
	{
		return 0;
	}

	public float GetCollectibleChestLevelProgress01()
	{
		return 0f;
	}

	public int GetCollectibleChestLevelCurrentProgress()
	{
		return 0;
	}

	public int GetCollectibleChestLevelRequiredProgress()
	{
		return 0;
	}

	public float GetHeroChestLevelProgress01()
	{
		return 0f;
	}

	public int GetHeroChestLevelCurrentProgress()
	{
		return 0;
	}

	public int GetHeroChestLevelRequiredProgress()
	{
		return 0;
	}

	public (float, float) GetCurrentCommonChestOdds()
	{
		return default;
	}

	public (float, float) GetNextCommonChestOdds()
	{
		return default;
	}

	public (float, float, float, float) GetCurrentEpicChestOdds()
	{
		return default;
	}

	public (float, float, float, float) GetNextEpicChestOdds()
	{
		return default;
	}

	private (float, float) GetCommonChestOdds(ChestLevelSettings.CommonChestLevelDefinition definition)
	{
		return default;
	}

	private (float, float, float, float) GetEpicChestOdds(ChestLevelSettings.EpicChestLevelDefinition definition)
	{
		return default;
	}

	private float GetCollectibleKeyChance(ChestLevelSettings.CommonChestLevelDefinition definition)
	{
		return 0f;
	}

	private float GetCollectibleKeyChance(ChestLevelSettings.EpicChestLevelDefinition definition)
	{
		return 0f;
	}

	public float GetCurrentCollectibleKeyChanceFromRegularChest(ChestTypes chestType)
	{
		return 0f;
	}

	public float GetNextCollectibleKeyChanceFromRegularChest(ChestTypes chestType)
	{
		return 0f;
	}

	public (float, float, float, float, float, float) GetCollectibleChestOdds()
	{
		return default;
	}

	public (float, float, float, float, float, float) GetCurrentCollectibleChestOdds()
	{
		return default;
	}

	public (float, float, float, float, float, float) GetNextCollectibleChestOdds()
	{
		return default;
	}

	public (float, float) GetCurrentCollectibleChestDropOdds()
	{
		return default;
	}

	public (float, float) GetNextCollectibleChestDropOdds()
	{
		return default;
	}

	public (float, float, float, float, float, float, float) GetCurrentHeroChestOdds()
	{
		return default;
	}

	public (float, float, float, float, float, float, float) GetNextHeroChestOdds()
	{
		return default;
	}

	private (float, float) GetCollectibleChestDropOdds(ChestLevelSettings.CollectibleChestDefinition definition)
	{
		return default;
	}

	private (float, float, float, float, float, float, float) GetHeroChestOdds(ChestLevelSettings.HeroChestLevelDefinition definition)
	{
		return default;
	}

	private (float, float, float, float, float, float) GetCollectibleChestOdds(ChestLevelSettings.CollectibleChestDefinition definition)
	{
		return default;
	}

	private ChestLevelSettings.CollectibleChestLevelDefinition CreateCollectibleChestLevelDefinition(ChestLevelSettings.CollectibleChestDefinition definition)
	{
		return null;
	}

	private int GetCollectibleChestOpenedCount()
	{
		return 0;
	}

	private void IncreaseCollectibleChestOpenedCount(int amount)
	{
	}

	private int GetHeroChestOpenedCount()
	{
		return 0;
	}

	private void IncreaseHeroChestOpenedCount(int amount)
	{
	}

	public void ClosePanel()
	{
	}

	private void SetChestUnlockTrigger(string triggerName)
	{
	}

	private void SetChestObjectsActive(bool isActive)
	{
	}
}
