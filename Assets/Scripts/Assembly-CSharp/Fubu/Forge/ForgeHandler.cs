using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Fubu.Forge
{
	public class ForgeHandler : MonoBehaviour
	{
		public enum ItemRarity
		{
			Common = 0,
			Uncommon = 1,
			Rare = 2,
			Epic = 3,
			Legendary = 4
		}

		[CompilerGenerated]
		private sealed class _003CForgeAnim_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ForgeHandler _003C_003E4__this;

			private SlotItem _003CnewItem_003E5__2;

			private ForgeSlot _003CforgeSlot_003E5__3;

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
			public _003CForgeAnim_003Ed__50(int _003C_003E1__state)
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

		[Header("Configuration")]
		[SerializeField]
		private float sourceGiveFrequency;

		[SerializeField]
		private int maxEmberCapacity;

		[Header("Item Databases")]
		[SerializeField]
		private ForgeDB ItemDB;

		[SerializeField]
		private ForgeDB equippedItemDB;

		[Header("Slots & Stats")]
		[SerializeField]
		private ForgeSlot[] forgeSlots;

		[SerializeField]
		private SlotStat[] baseStats;

		[Header("Forge UI")]
		[SerializeField]
		private Transform sourceGivePoint;

		[SerializeField]
		private ParticleSystem forgeParticle;

		[SerializeField]
		private GameObject forgeIconHolder;

		[SerializeField]
		private GameObject[] forgeRarityShines;

		[SerializeField]
		private Image forgeIcon;

		[SerializeField]
		private Button forgeButton;

		[SerializeField]
		private GameObject forgeButtonCover;

		[Header("Source UI")]
		[SerializeField]
		private Slider sourceSlider;

		[SerializeField]
		private Animator sourceAnimator;

		[SerializeField]
		private TextMeshProUGUI newSourceText;

		[Header("Tutorial")]
		[SerializeField]
		private Animator forgeTutAnim;

		[Header("Power UI")]
		[SerializeField]
		private GameObject powerTextPanel;

		[SerializeField]
		private TextMeshProUGUI powerText;

		[SerializeField]
		private CurrencyTypes forgeCurrency;

		[Header("Test Rarity")]
		[SerializeField]
		private int selectedRarity;

		private float sourceGiveTimer;

		private int level;

		private bool isForging;

		private string lastNewSourceText;

		private const string FORGE_LEVEL_KEY = "FORGE_LEVEL";

		private const string EMBER_GIVEN_KEY = "EMBER_GIVEN";

		private const string LAST_CLOSED_KEY = "LastClosedTime";

		private static readonly int PopTrigger;

		private static readonly int OpenBool;

		private const int INITIAL_EMBER_GIFT = 70;

		private const float FORGE_ANIMATION_DURATION = 1f;

		public static ForgeHandler Instance { get; private set; }

		public SlotStat[] BaseStats => null;

		public int CurrentLevel => 0;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void HandleFirstTimeEmberGift()
		{
		}

		private void SetForgeButton()
		{
		}

		public void LevelUp()
		{
		}

		private void GiveSource()
		{
		}

		private static void SetTextIfChanged(TextMeshProUGUI text, ref string cachedValue, string value)
		{
		}

		public void Forge()
		{
		}

		[IteratorStateMachine(typeof(_003CForgeAnim_003Ed__50))]
		private IEnumerator ForgeAnim()
		{
			return null;
		}

		private SlotItem CreateNewForgedItem(int itemRarity, bool isTutorialItem)
		{
			return null;
		}

		public void ActivateTutPanel(bool isActive)
		{
		}

		private float[] CalculateRarityChances(int currentLevel)
		{
			return null;
		}

		private int GetRarityByLevel()
		{
			return 0;
		}

		private int GetLastRarity()
		{
			return 0;
		}

		public (float, float) GetChance(ItemRarity itemRarity)
		{
			return default;
		}

		private float GetRarityPercentage(float[] chances, int rarity)
		{
			return 0f;
		}

		public ForgeSlot GetSlot(ForgeItemSlot slot)
		{
			return null;
		}

		public void SetSlot(SlotItem item, ref ForgeSlot savedSlot)
		{
		}

		public float GetStatValue(StatType statType)
		{
			return 0f;
		}

		private void OnApplicationQuit()
		{
		}

		private void SaveCurrentTime()
		{
		}

		private void CalculateOfflineEmber()
		{
		}

		private void AddEmberToPlayer(int amount)
		{
		}

		public void TestForge()
		{
		}

		public void ShowPowerText(int power)
		{
		}
	}
}
